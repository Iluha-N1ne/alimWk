namespace alimWk.mainPage
{
    partial class mainPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.srcBtn = new System.Windows.Forms.Button();
            this.srcBox = new System.Windows.Forms.TextBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.dltBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.slctTable = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.srcInBtn = new System.Windows.Forms.Button();
            this.slctClass = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.slctWeekDay = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGrid1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lessionCount = new System.Windows.Forms.Label();
            this.teacherCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // srcBtn
            // 
            this.srcBtn.Font = new System.Drawing.Font("Cambria", 10.8F);
            this.srcBtn.Location = new System.Drawing.Point(885, 227);
            this.srcBtn.Name = "srcBtn";
            this.srcBtn.Size = new System.Drawing.Size(179, 65);
            this.srcBtn.TabIndex = 11;
            this.srcBtn.Text = "Искать";
            this.srcBtn.UseVisualStyleBackColor = true;
            this.srcBtn.Click += new System.EventHandler(this.srcBtn_Click);
            // 
            // srcBox
            // 
            this.srcBox.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.srcBox.Location = new System.Drawing.Point(885, 183);
            this.srcBox.Multiline = true;
            this.srcBox.Name = "srcBox";
            this.srcBox.Size = new System.Drawing.Size(179, 38);
            this.srcBox.TabIndex = 10;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Cambria", 10.8F);
            this.lblInfo.Location = new System.Drawing.Point(887, 159);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(171, 21);
            this.lblInfo.TabIndex = 9;
            this.lblInfo.Text = "Поиск по названию";
            // 
            // dltBtn
            // 
            this.dltBtn.Font = new System.Drawing.Font("Cambria", 10.8F);
            this.dltBtn.Location = new System.Drawing.Point(885, 86);
            this.dltBtn.Name = "dltBtn";
            this.dltBtn.Size = new System.Drawing.Size(179, 65);
            this.dltBtn.TabIndex = 8;
            this.dltBtn.Text = "Удалить";
            this.dltBtn.UseVisualStyleBackColor = true;
            this.dltBtn.Click += new System.EventHandler(this.dltBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Font = new System.Drawing.Font("Cambria", 10.8F);
            this.addBtn.Location = new System.Drawing.Point(885, 15);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(179, 65);
            this.addBtn.TabIndex = 7;
            this.addBtn.Text = "Закрепить";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(12, 12);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.RowHeadersVisible = false;
            this.dataGrid.RowHeadersWidth = 51;
            this.dataGrid.RowTemplate.Height = 24;
            this.dataGrid.Size = new System.Drawing.Size(863, 552);
            this.dataGrid.TabIndex = 6;
            // 
            // slctTable
            // 
            this.slctTable.Font = new System.Drawing.Font("Cambria", 16.2F);
            this.slctTable.FormattingEnabled = true;
            this.slctTable.Items.AddRange(new object[] {
            "Пользователи",
            "Предмет",
            "Преподаватели",
            "Расписание"});
            this.slctTable.Location = new System.Drawing.Point(891, 347);
            this.slctTable.Name = "slctTable";
            this.slctTable.Size = new System.Drawing.Size(173, 40);
            this.slctTable.TabIndex = 12;
            this.slctTable.SelectedIndexChanged += new System.EventHandler(this.slctTable_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 10.8F);
            this.label1.Location = new System.Drawing.Point(887, 323);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 21);
            this.label1.TabIndex = 13;
            this.label1.Text = "Все таблицы";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.teacherCount);
            this.panel1.Controls.Add(this.lessionCount);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.srcInBtn);
            this.panel1.Controls.Add(this.slctClass);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.slctWeekDay);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dataGrid1);
            this.panel1.Location = new System.Drawing.Point(12, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1062, 561);
            this.panel1.TabIndex = 14;
            this.panel1.Visible = false;
            // 
            // srcInBtn
            // 
            this.srcInBtn.Font = new System.Drawing.Font("Cambria", 10.8F);
            this.srcInBtn.Location = new System.Drawing.Point(820, 168);
            this.srcInBtn.Name = "srcInBtn";
            this.srcInBtn.Size = new System.Drawing.Size(226, 50);
            this.srcInBtn.TabIndex = 5;
            this.srcInBtn.Text = "Найти";
            this.srcInBtn.UseVisualStyleBackColor = true;
            this.srcInBtn.Click += new System.EventHandler(this.srcInBtn_Click);
            // 
            // slctClass
            // 
            this.slctClass.Font = new System.Drawing.Font("Cambria", 10.8F);
            this.slctClass.FormattingEnabled = true;
            this.slctClass.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11"});
            this.slctClass.Location = new System.Drawing.Point(820, 124);
            this.slctClass.Name = "slctClass";
            this.slctClass.Size = new System.Drawing.Size(226, 29);
            this.slctClass.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(820, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Класс";
            // 
            // slctWeekDay
            // 
            this.slctWeekDay.Font = new System.Drawing.Font("Cambria", 10.8F);
            this.slctWeekDay.FormattingEnabled = true;
            this.slctWeekDay.Items.AddRange(new object[] {
            "Понедельник",
            "Вторник",
            "Среда",
            "Четверг",
            "Пятница",
            "Суббота",
            "Воскресенье"});
            this.slctWeekDay.Location = new System.Drawing.Point(820, 48);
            this.slctWeekDay.Name = "slctWeekDay";
            this.slctWeekDay.Size = new System.Drawing.Size(226, 29);
            this.slctWeekDay.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(820, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "День недели";
            // 
            // dataGrid1
            // 
            this.dataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid1.Location = new System.Drawing.Point(14, 12);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.RowHeadersVisible = false;
            this.dataGrid1.RowHeadersWidth = 51;
            this.dataGrid1.RowTemplate.Height = 24;
            this.dataGrid1.Size = new System.Drawing.Size(800, 536);
            this.dataGrid1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(849, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Общая статистика";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(816, 309);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(194, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "Всего преподавателей";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(816, 341);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 21);
            this.label6.TabIndex = 8;
            this.label6.Text = "Всего занятий";
            // 
            // lessionCount
            // 
            this.lessionCount.AutoSize = true;
            this.lessionCount.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lessionCount.Location = new System.Drawing.Point(1032, 341);
            this.lessionCount.Name = "lessionCount";
            this.lessionCount.Size = new System.Drawing.Size(21, 21);
            this.lessionCount.TabIndex = 9;
            this.lessionCount.Text = "#";
            // 
            // teacherCount
            // 
            this.teacherCount.AutoSize = true;
            this.teacherCount.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teacherCount.Location = new System.Drawing.Point(1032, 309);
            this.teacherCount.Name = "teacherCount";
            this.teacherCount.Size = new System.Drawing.Size(21, 21);
            this.teacherCount.TabIndex = 10;
            this.teacherCount.Text = "#";
            // 
            // mainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 576);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.slctTable);
            this.Controls.Add(this.srcBtn);
            this.Controls.Add(this.srcBox);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.dltBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.dataGrid);
            this.Name = "mainPage";
            this.Text = "Страница расписания";
            this.Load += new System.EventHandler(this.mainPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button srcBtn;
        private System.Windows.Forms.TextBox srcBox;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button dltBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.ComboBox slctTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGrid1;
        private System.Windows.Forms.Button srcInBtn;
        private System.Windows.Forms.ComboBox slctClass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox slctWeekDay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label teacherCount;
        private System.Windows.Forms.Label lessionCount;
        private System.Windows.Forms.Label label6;
    }
}