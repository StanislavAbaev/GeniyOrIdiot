namespace GeniyIdiotWinFormsApp
{
    partial class DeleteQuestion
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
            button1 = new Button();
            dataGridView1 = new DataGridView();
            numberOfQuestion = new DataGridViewTextBoxColumn();
            questionText = new DataGridViewTextBoxColumn();
            textBox1 = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(251, 350);
            button1.Margin = new Padding(2, 1, 2, 1);
            button1.Name = "button1";
            button1.Size = new Size(135, 22);
            button1.TabIndex = 0;
            button1.Text = "Удалить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { numberOfQuestion, questionText });
            dataGridView1.Location = new Point(11, 16);
            dataGridView1.Margin = new Padding(2, 1, 2, 1);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.RowTemplate.Height = 41;
            dataGridView1.Size = new Size(637, 251);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // numberOfQuestion
            // 
            numberOfQuestion.HeaderText = "#";
            numberOfQuestion.MinimumWidth = 10;
            numberOfQuestion.Name = "numberOfQuestion";
            numberOfQuestion.ReadOnly = true;
            numberOfQuestion.Width = 50;
            // 
            // questionText
            // 
            questionText.HeaderText = "Текст вопроса";
            questionText.MinimumWidth = 10;
            questionText.Name = "questionText";
            questionText.ReadOnly = true;
            questionText.Width = 1000;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(11, 310);
            textBox1.Margin = new Padding(2, 1, 2, 1);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 283);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(583, 15);
            label1.TabIndex = 3;
            label1.Text = "Введите номер вопроса, который хотите удалить, либо дважды нажмите на него левой кнопкой мышки";
            // 
            // DeleteQuestion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(680, 382);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Margin = new Padding(2, 1, 2, 1);
            Name = "DeleteQuestion";
            Text = "DeleteQuestion";
            Load += DeleteQuestion_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn numberOfQuestion;
        private DataGridViewTextBoxColumn questionText;
        private TextBox textBox1;
        private Label label1;
    }
}