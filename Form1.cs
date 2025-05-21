using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace alimWk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public class userData
        {
            public static string login;
            public static string pass;
            public static string panelSwitch;
        }
        bool connSuccess = mainPage.autorizeClass.checkDB();
        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            panel1.Show();
        }

        private void auBtn_Click(object sender, EventArgs e)
        {
            char[] falseChars = {' ', ',' , '.'};

            if (connSuccess)
            {
                userData.login = loginBox.Text.ToLower().Trim(falseChars);
                userData.pass = passBox.Text.ToLower().Trim(falseChars);

                mainPage.autorizeClass @class = new mainPage.autorizeClass();
                mainPage.mainPage transfer = new mainPage.mainPage();

                bool checkUserInDatabase = @class.getDataUser();

                if (checkUserInDatabase)
                {
                    userData.panelSwitch = "";
                    transfer.Show();
                }
                else
                {
                    MessageBox.Show("Пользователь не найден");
                }
            }
            else
            {
                MessageBox.Show("Соединение с БД не установленно");
            }
        }

        private void checkBtn_Click(object sender, EventArgs e)
        {
            if (connSuccess)
            {
                mainPage.mainPage transfer = new mainPage.mainPage();
                transfer.Show();
            }
            else
            {
                MessageBox.Show("Соединение с БД не установленно");
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            panel1.Hide();
        }
    }
}
