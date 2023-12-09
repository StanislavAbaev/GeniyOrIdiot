namespace GeniyIdiotWinFormsApp
{
    partial class UserResults
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
            dataGridView1 = new DataGridView();
            userNameColumn = new DataGridViewTextBoxColumn();
            countOfRightAnswersColumn = new DataGridViewTextBoxColumn();
            diagnosisColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { userNameColumn, countOfRightAnswersColumn, diagnosisColumn });
            dataGridView1.Location = new Point(6, 10);
            dataGridView1.Margin = new Padding(2, 1, 2, 1);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.RowTemplate.Height = 41;
            dataGridView1.Size = new Size(1036, 420);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // userNameColumn
            // 
            userNameColumn.HeaderText = "Фио";
            userNameColumn.MinimumWidth = 10;
            userNameColumn.Name = "userNameColumn";
            userNameColumn.Width = 300;
            // 
            // countOfRightAnswersColumn
            // 
            countOfRightAnswersColumn.HeaderText = "Кол-во правильных ответов";
            countOfRightAnswersColumn.MinimumWidth = 100;
            countOfRightAnswersColumn.Name = "countOfRightAnswersColumn";
            countOfRightAnswersColumn.Width = 400;
            // 
            // diagnosisColumn
            // 
            diagnosisColumn.HeaderText = "Диагноз";
            diagnosisColumn.MinimumWidth = 10;
            diagnosisColumn.Name = "diagnosisColumn";
            diagnosisColumn.Width = 250;
            // 
            // UserResults
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1045, 434);
            Controls.Add(dataGridView1);
            Margin = new Padding(2, 1, 2, 1);
            Name = "UserResults";
            Text = "Результаты";
            Load += UserResults_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn userNameColumn;
        private DataGridViewTextBoxColumn countOfRightAnswersColumn;
        private DataGridViewTextBoxColumn diagnosisColumn;
    }
}