using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace alimWk.mainPage
{
    public partial class userPage : Form
    {
        public userPage()
        {
            InitializeComponent();
        }

        private void userPage_Load(object sender, EventArgs e)
        {
            //teacherCount.Text = sqlClass.ints[0].ToString();
            //lessionCount.Text = sqlClass.ints[1].ToString();
        }

        private void srcInBtn_Click(object sender, EventArgs e)
        {
            string day = slctWeekDay.Text;
            string @class = slctClass.Text;

            sqlClass.dataSelectWhere(@class, day);

            for (int i = 0; i < sqlClass.work.Count; i++)
            {
                int counter = 1;
                Label Label = new Label
                {
                    Font = new Font("Microsoft Sans Serif", 12),
                    Width = 500,
                    Text = $"Урок №{counter + i} " + sqlClass.work[i],
                    Cursor = Cursors.Hand,
                    Tag = sqlClass.work[i]
                };
                Label Label1 = new Label
                {
                    Font = new Font("Microsoft Sans Serif", 12),
                    Width = 400,
                    Text = $"Преподаватель: " + sqlClass.senseis[i],
                    Cursor = Cursors.Hand,
                    Tag = sqlClass.work[i]
                };
                //Label.Click += Label_Click;

                flowLayout.Controls.Add(Label);
                flowLayout.Controls.Add(Label1);
            }
        }
    }
}
