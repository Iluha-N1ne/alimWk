using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace alimWk.mainPage
{
    internal class autorizeClass
    {
        private class sqlData
        {
            public string sqlGet = $"SELECT Логин, Пароль FROM Пользователи WHERE Логин = '@login' and Пароль = '@pass'";
        }

        static MySqlConnection conn;
        static MySqlCommand cmd;
        static MySqlDataReader reader;
        static MySqlDataAdapter adapter;
        public static string getConnStr()
        {
            return $"Server = 95.183.12.18; Port = 3306; Database=igorDB; user=igorDB; password=123;";
        }
        public static bool checkDB()
        {
            using (conn = new MySqlConnection(getConnStr()))
            {
                conn.Open();
                return conn.Ping();
            }
        }
        public bool getDataUser()
        {
            bool foundUser = false;
            using (conn = new MySqlConnection(getConnStr()))
                try
                {
                    conn.Open();
                    string sqlGet = $"SELECT Логин, Пароль FROM Пользователи WHERE Логин = '{Form1.userData.login}' and Пароль = '{Form1.userData.pass}'";
                    using (cmd = new MySqlCommand(sqlGet, conn))
                    {
                        using (reader = cmd.ExecuteReader())
                        {
                            foundUser = reader.HasRows;
                            //MessageBox.Show(foundUser.ToString());
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.HResult.ToString());
                }
            return foundUser;
        }
    }
}
