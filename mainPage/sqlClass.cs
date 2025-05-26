using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace alimWk.mainPage
{
    internal class sqlClass
    {
        static MySqlConnection conn;
        static MySqlCommand cmd;
        static MySqlDataReader reader;
        static MySqlDataAdapter adapter;

        public static List<int> ints = new List<int>();
        public static List<string> names = new List<string>();
        public static DataTable loadData(string query)
        {
            try
            {
                using (conn = new MySqlConnection(autorizeClass.getConnStr()))
                {
                    cmd = new MySqlCommand(query, conn);
                    adapter = new MySqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    return dataTable;
                    //MessageBox.Show($"Rows returned: {dataTable.Rows.Count}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.HResult.ToString());
                return null;
            }
        }
        public static bool insertData(string tableToLoad, DataTable table)
        {
            var dataSet = new DataSet();

            table.TableName = tableToLoad;
            dataSet.Tables.Add(table);

            using (var conn = new MySqlConnection(autorizeClass.getConnStr()))
            {
                try
                {
                    adapter = new MySqlDataAdapter();
                    adapter.SelectCommand = new MySqlCommand($"SELECT * FROM {tableToLoad}", conn);
                    var builder = new MySqlCommandBuilder(adapter);

                    adapter.InsertCommand = builder.GetInsertCommand();
                    adapter.Update(dataSet, tableToLoad);
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.HResult.ToString());
                    return false;
                }
            }
        }
        public static bool deleteData(int id, string tableToLoad)
        {
            using (conn = new MySqlConnection(autorizeClass.getConnStr()))
            {
                string query = $"DELETE FROM {tableToLoad} WHERE id = {id}";
                cmd = new MySqlCommand(query, conn);
                try
                {
                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка: {ex.Message}");
                }
            }
            return true;
        }
        public static void countSelect(string table, string countOf)
        {
            using (MySqlConnection conn = new MySqlConnection(autorizeClass.getConnStr()))
            {
                try
                {
                    conn.Open();
                    string query = $"SELECT COUNT({countOf}) FROM {table}";
                    //MessageBox.Show(query);
                    using (cmd = new MySqlCommand(query, conn))
                    using (reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ints.Add(Convert.ToInt32(reader[$"COUNT({countOf})"]));
                        }
                        //MessageBox.Show($"{string.Join(",", ints)}");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.HResult.ToString());
                }
            }
        }
        public static void dataSelect(string table, string nessesaryData)
        {
            using (MySqlConnection conn = new MySqlConnection(autorizeClass.getConnStr()))
            {
                try
                {
                    conn.Open();
                    string query = $"SELECT {nessesaryData} FROM {table}";
                    //MessageBox.Show(query);
                    using (cmd = new MySqlCommand(query, conn))
                    using (reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            names.Add((reader[$"{nessesaryData}"]).ToString());
                        }
                        //MessageBox.Show($"{string.Join(",", names)}");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.HResult.ToString());
                }
            }
        }
    }
}
