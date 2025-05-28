namespace alimWk.mainPage
{
    partial class userPage
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
            this.srcInBtn = new System.Windows.Forms.Button();
            this.slctClass = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.slctWeekDay = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // srcInBtn
            // 
            this.srcInBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.srcInBtn.Location = new System.Drawing.Point(12, 289);
            this.srcInBtn.Name = "srcInBtn";
            this.srcInBtn.Size = new System.Drawing.Size(226, 50);
            this.srcInBtn.TabIndex = 10;
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
            this.slctClass.Location = new System.Drawing.Point(12, 245);
            this.slctClass.Name = "slctClass";
            this.slctClass.Size = new System.Drawing.Size(226, 29);
            this.slctClass.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.label3.Location = new System.Drawing.Point(12, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 8;
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
            this.slctWeekDay.Location = new System.Drawing.Point(12, 169);
            this.slctWeekDay.Name = "slctWeekDay";
            this.slctWeekDay.Size = new System.Drawing.Size(226, 29);
            this.slctWeekDay.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.label2.Location = new System.Drawing.Point(12, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "День недели";
            // 
            // flowLayout
            // 
            this.flowLayout.Location = new System.Drawing.Point(6, 21);
            this.flowLayout.Name = "flowLayout";
            this.flowLayout.Size = new System.Drawing.Size(510, 485);
            this.flowLayout.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flowLayout);
            this.groupBox1.Location = new System.Drawing.Point(244, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(522, 512);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Расписание на день недели";
            // 
            // userPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 545);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.srcInBtn);
            this.Controls.Add(this.slctClass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.slctWeekDay);
            this.Controls.Add(this.label2);
            this.Name = "userPage";
            this.Text = "Страница пользователя";
            this.Load += new System.EventHandler(this.userPage_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button srcInBtn;
        private System.Windows.Forms.ComboBox slctClass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox slctWeekDay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayout;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}