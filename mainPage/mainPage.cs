using Mysqlx.Crud;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace alimWk.mainPage
{
    public partial class mainPage : Form
    {
        public mainPage()
        {
            InitializeComponent();
        }
        string tableToLoad;
        string queryToInsert = $@"SELECT Расписание.id, Предмет.Название AS Предмет, Преподаватели.Фамилия AS ФамилияПреподавателя, Класс, 'Время начала', 'Время конца', День 
                FROM Расписание 
                LEFT JOIN Предмет ON id_Предмета = Предмет.id 
                LEFT JOIN Преподаватели ON id_Преподавателя = Преподаватели.id";

        Dictionary<string, string> columnForSearch = new Dictionary<string, string>
                {
                    { "Пользователи", "Логин"},
                    { "Предмет","Название" },
                    { "Преподаватели","Фамилия" },
                    { "Расписание","Класс" }
                };

        DataTable table;
        private void mainPage_Load(object sender, EventArgs e)
        {
            if(Form1.userData.panelSwitch == "")
            {
                tableToLoad = "Расписание";
                string queryToInsert = $@"SELECT * FROM {tableToLoad}";
                insertInDataGrid(queryToInsert);

            }
            else
            {
                panel1.Show();
                tableToLoad = "Расписание";

                sqlClass.countSelect("Преподаватели", "id");
                sqlClass.countSelect("Расписание", "id");

                teacherCount.Text = sqlClass.ints[0].ToString();
                lessionCount.Text = sqlClass.ints[1].ToString();

                insertInDataGrid(queryToInsert);
            }
        }

        private void slctTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            tableToLoad = slctTable.Text;

            string queryToInsert = $@"SELECT * FROM {tableToLoad}";

            columnForSearch.TryGetValue(tableToLoad, out string column);

            lblInfo.Text = $"Поиск по {column}";
            insertInDataGrid(queryToInsert);
        }
        public void insertInDataGrid(string query)
        {
            table = sqlClass.loadData(query);

            dataGrid.DataSource = table;
            dataGrid.AutoGenerateColumns = true;

            if(Form1.userData.panelSwitch != "")
            {
                dataGrid1.DataSource = table;
                dataGrid1.AutoGenerateColumns = true;
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            bool succesInsert = sqlClass.insertData(tableToLoad, table);
            if (succesInsert)
            {
                string queryToInsert = $@"SELECT * FROM {tableToLoad}";
                insertInDataGrid(queryToInsert);
            }
        }

        private void dltBtn_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dataGrid.Rows[dataGrid.CurrentRow.Index].Cells["id"].Value.ToString());
            bool succesDelete = sqlClass.deleteData(id, tableToLoad);
            if (succesDelete)
            {
                string queryToInsert = $@"SELECT * FROM {tableToLoad}";
                insertInDataGrid(queryToInsert);
            }
        }

        private void srcBtn_Click(object sender, EventArgs e)
        {
            string textForSearch = srcBox.Text;
            if (textForSearch.Length > 0)
            {   
                columnForSearch.TryGetValue(slctTable.Text, out string column);
                string searchString = $"SELECT * FROM {tableToLoad} WHERE {column} LIKE '{srcBox.Text}%'";
                insertInDataGrid(searchString);
            }
            else
            {
                string queryToInsert = $@"SELECT * FROM {tableToLoad}";
                insertInDataGrid(queryToInsert);
            }
        }

        private void srcInBtn_Click(object sender, EventArgs e)
        {
            if (slctClass.Text != "" || slctWeekDay.Text != "")
            {
                
                insertInDataGrid($"{queryToInsert} WHERE Класс = '{slctClass.Text}' and День = '{slctWeekDay.Text}'");
            }
            else
            {
                string queryToInsert = $@"SELECT * FROM {tableToLoad}";
                insertInDataGrid(queryToInsert);
            }
        }
    }
}
