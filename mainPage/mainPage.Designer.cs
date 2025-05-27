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
            this.vodilaCount = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.teacherCount = new System.Windows.Forms.Label();
            this.reisLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.srcInBtn = new System.Windows.Forms.Button();
            this.slctWeekDay = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGrid1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // srcBtn
            // 
            this.srcBtn.Font = new System.Drawing.Font("Cambria", 10.8F);
            this.srcBtn.Location = new System.Drawing.Point(885, 499);
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
            this.srcBox.Location = new System.Drawing.Point(12, 33);
            this.srcBox.Multiline = true;
            this.srcBox.Name = "srcBox";
            this.srcBox.Size = new System.Drawing.Size(863, 38);
            this.srcBox.TabIndex = 10;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Cambria", 10.8F);
            this.lblInfo.Location = new System.Drawing.Point(14, 9);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(171, 21);
            this.lblInfo.TabIndex = 9;
            this.lblInfo.Text = "Поиск по названию";
            // 
            // dltBtn
            // 
            this.dltBtn.Font = new System.Drawing.Font("Cambria", 10.8F);
            this.dltBtn.Location = new System.Drawing.Point(450, 499);
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
            this.addBtn.Location = new System.Drawing.Point(12, 499);
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
            this.dataGrid.Location = new System.Drawing.Point(12, 77);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.RowHeadersVisible = false;
            this.dataGrid.RowHeadersWidth = 51;
            this.dataGrid.RowTemplate.Height = 24;
            this.dataGrid.Size = new System.Drawing.Size(1052, 416);
            this.dataGrid.TabIndex = 6;
            // 
            // slctTable
            // 
            this.slctTable.Font = new System.Drawing.Font("Cambria", 16.2F);
            this.slctTable.FormattingEnabled = true;
            this.slctTable.Items.AddRange(new object[] {
            "Пользователи",
            "Водители",
            "Машины",
            "Маршруты",
            "Расписание"});
            this.slctTable.Location = new System.Drawing.Point(885, 31);
            this.slctTable.Name = "slctTable";
            this.slctTable.Size = new System.Drawing.Size(173, 40);
            this.slctTable.TabIndex = 12;
            this.slctTable.SelectedIndexChanged += new System.EventHandler(this.slctTable_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 10.8F);
            this.label1.Location = new System.Drawing.Point(881, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 21);
            this.label1.TabIndex = 13;
            this.label1.Text = "Все таблицы";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.vodilaCount);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.teacherCount);
            this.panel1.Controls.Add(this.reisLabel);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.srcInBtn);
            this.panel1.Controls.Add(this.slctWeekDay);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dataGrid1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1062, 561);
            this.panel1.TabIndex = 14;
            this.panel1.Visible = false;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // vodilaCount
            // 
            this.vodilaCount.AutoSize = true;
            this.vodilaCount.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vodilaCount.Location = new System.Drawing.Point(349, 525);
            this.vodilaCount.Name = "vodilaCount";
            this.vodilaCount.Size = new System.Drawing.Size(21, 21);
            this.vodilaCount.TabIndex = 12;
            this.vodilaCount.Text = "#";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(195, 525);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 21);
            this.label5.TabIndex = 11;
            this.label5.Text = "Всего водителей\r\n";
            // 
            // teacherCount
            // 
            this.teacherCount.AutoSize = true;
            this.teacherCount.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teacherCount.Location = new System.Drawing.Point(137, 525);
            this.teacherCount.Name = "teacherCount";
            this.teacherCount.Size = new System.Drawing.Size(21, 21);
            this.teacherCount.TabIndex = 10;
            this.teacherCount.Text = "#";
            this.teacherCount.Click += new System.EventHandler(this.teacherCount_Click);
            // 
            // reisLabel
            // 
            this.reisLabel.AutoSize = true;
            this.reisLabel.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reisLabel.Location = new System.Drawing.Point(14, 525);
            this.reisLabel.Name = "reisLabel";
            this.reisLabel.Size = new System.Drawing.Size(117, 21);
            this.reisLabel.TabIndex = 7;
            this.reisLabel.Text = "Всего рейсов";
            this.reisLabel.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(14, 493);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Общая статистика";
            // 
            // srcInBtn
            // 
            this.srcInBtn.Font = new System.Drawing.Font("Cambria", 10.8F);
            this.srcInBtn.Location = new System.Drawing.Point(246, 9);
            this.srcInBtn.Name = "srcInBtn";
            this.srcInBtn.Size = new System.Drawing.Size(226, 50);
            this.srcInBtn.TabIndex = 5;
            this.srcInBtn.Text = "Найти";
            this.srcInBtn.UseVisualStyleBackColor = true;
            this.srcInBtn.Click += new System.EventHandler(this.srcInBtn_Click);
            // 
            // slctWeekDay
            // 
            this.slctWeekDay.Font = new System.Drawing.Font("Cambria", 10.8F);
            this.slctWeekDay.FormattingEnabled = true;
            this.slctWeekDay.Location = new System.Drawing.Point(14, 31);
            this.slctWeekDay.Name = "slctWeekDay";
            this.slctWeekDay.Size = new System.Drawing.Size(226, 29);
            this.slctWeekDay.TabIndex = 2;
            this.slctWeekDay.SelectedIndexChanged += new System.EventHandler(this.slctWeekDay_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(10, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Маршрут";
            // 
            // dataGrid1
            // 
            this.dataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid1.Location = new System.Drawing.Point(14, 66);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.RowHeadersVisible = false;
            this.dataGrid1.RowHeadersWidth = 51;
            this.dataGrid1.RowTemplate.Height = 24;
            this.dataGrid1.Size = new System.Drawing.Size(1038, 424);
            this.dataGrid1.TabIndex = 0;
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
        private System.Windows.Forms.ComboBox slctWeekDay;
        private System.Windows.Forms.Label reisLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label teacherCount;
        private System.Windows.Forms.Label vodilaCount;
        private System.Windows.Forms.Label label5;
    }
}