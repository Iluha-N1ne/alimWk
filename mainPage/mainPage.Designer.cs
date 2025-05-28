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
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // srcBtn
            // 
            this.srcBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.srcBtn.Location = new System.Drawing.Point(885, 5);
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
            this.srcBox.Location = new System.Drawing.Point(12, 29);
            this.srcBox.Multiline = true;
            this.srcBox.Name = "srcBox";
            this.srcBox.Size = new System.Drawing.Size(863, 38);
            this.srcBox.TabIndex = 10;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.lblInfo.Location = new System.Drawing.Point(9, 10);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(135, 16);
            this.lblInfo.TabIndex = 9;
            this.lblInfo.Text = "Поиск по названию";
            // 
            // dltBtn
            // 
            this.dltBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.dltBtn.Location = new System.Drawing.Point(885, 500);
            this.dltBtn.Name = "dltBtn";
            this.dltBtn.Size = new System.Drawing.Size(179, 65);
            this.dltBtn.TabIndex = 8;
            this.dltBtn.Text = "Удалить";
            this.dltBtn.UseVisualStyleBackColor = true;
            this.dltBtn.Click += new System.EventHandler(this.dltBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.addBtn.Location = new System.Drawing.Point(885, 429);
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
            this.dataGrid.Location = new System.Drawing.Point(12, 73);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.RowHeadersVisible = false;
            this.dataGrid.RowHeadersWidth = 51;
            this.dataGrid.RowTemplate.Height = 24;
            this.dataGrid.Size = new System.Drawing.Size(863, 491);
            this.dataGrid.TabIndex = 6;
            // 
            // slctTable
            // 
            this.slctTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.slctTable.FormattingEnabled = true;
            this.slctTable.Items.AddRange(new object[] {
            "Пользователи",
            "Предмет",
            "Преподаватели",
            "Расписание"});
            this.slctTable.Location = new System.Drawing.Point(885, 103);
            this.slctTable.Name = "slctTable";
            this.slctTable.Size = new System.Drawing.Size(173, 39);
            this.slctTable.TabIndex = 12;
            this.slctTable.SelectedIndexChanged += new System.EventHandler(this.slctTable_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.label1.Location = new System.Drawing.Point(881, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Все таблицы";
            // 
            // mainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 576);
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
    }
}