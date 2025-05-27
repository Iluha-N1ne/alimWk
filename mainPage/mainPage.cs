using System;
using System.Collections.Generic;
using System.Data;
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
        string queryToInsert = $@"SELECT Расписание.id AS Номер, ВремяПрибытия, ВремяОтправления, Водители.Фамилия AS ФамилияВодителя, Машины.Название AS НазваниеМашины, Машины.Марка AS МаркаМашины, Маршруты.Название AS НазваниеМаршрута
                FROM Расписание 
                LEFT JOIN Водители ON Водитель_id = Водители.id 
                LEFT JOIN Машины ON Машина_id = Машины.id
                LEFT JOIN Маршруты ON Маршрут_id = Маршруты.id";

        Dictionary<string, string> columnForSearch = new Dictionary<string, string>
                {
                    { "Пользователи", "Логин"},
                    { "Водители","Фамилия" },
                    { "Машины","Название" },
                    { "Маршруты","Название" },
                    { "Расписание","ВремяПрибытия" }
                };

        DataTable table;
        private void mainPage_Load(object sender, EventArgs e)
        {
            if (Form1.userData.panelSwitch == "")
            {
                tableToLoad = "Расписание";
                string queryToInsert = $@"SELECT * FROM {tableToLoad}";
                insertInDataGrid(queryToInsert);

            }
            else
            {
                panel1.Show();
                tableToLoad = "Расписание";

                sqlClass.countSelect("Расписание", "id");
                sqlClass.dataSelect("Маршруты", "Название");

                teacherCount.Text = string.Concat(sqlClass.ints);

                sqlClass.ints.Clear();

                sqlClass.countSelect("Водители", "id");

                vodilaCount.Text = string.Concat(sqlClass.ints);

                for (int i = 0; sqlClass.names.Count != i; i++)
                {
                    slctWeekDay.Items.Add(sqlClass.names[i]);
                }

                sqlClass.names.Clear();
                sqlClass.ints.Clear();

                sqlClass.dataSelect("Маршруты", "id");

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

            if (Form1.userData.panelSwitch != "")
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
            //MessageBox.Show(slctWeekDay.SelectedIndex.ToString());
            if (slctWeekDay.Text != "")
            {
                List<int> ints = sqlClass.names.ConvertAll(int.Parse);
                //MessageBox.Show(string.Concat(ints));

                insertInDataGrid($"{queryToInsert} WHERE Маршрут_id = {ints[(int)slctTable.SelectedIndex + 1]}");
            }
            else
            {
                insertInDataGrid(queryToInsert);
            }
        }

        private void teacherCount_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void slctWeekDay_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
