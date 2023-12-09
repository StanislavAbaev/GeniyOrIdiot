namespace GeniyIdiotWinFormsApp
{
    partial class GameAppForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            nextButton = new Button();
            questionNumberLabel = new Label();
            questionTextLabel = new Label();
            userAnswerTextBox = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            restartGameMenuItem = new ToolStripMenuItem();
            showResultsMenuItem = new ToolStripMenuItem();
            addQuestionToolStripMenuItem = new ToolStripMenuItem();
            deleteQuestionToolStripMenuItem = new ToolStripMenuItem();
            endTestingToolStripMenuItem = new ToolStripMenuItem();
            timer1 = new System.Windows.Forms.Timer(components);
            secondsRemainingLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // nextButton
            // 
            nextButton.Enabled = false;
            nextButton.Location = new Point(103, 178);
            nextButton.Margin = new Padding(2, 1, 2, 1);
            nextButton.Name = "nextButton";
            nextButton.Size = new Size(81, 22);
            nextButton.TabIndex = 0;
            nextButton.Text = "Далее";
            nextButton.UseVisualStyleBackColor = true;
            nextButton.Click += nextButton_Click;
            // 
            // questionNumberLabel
            // 
            questionNumberLabel.AutoSize = true;
            questionNumberLabel.Location = new Point(11, 50);
            questionNumberLabel.Margin = new Padding(2, 0, 2, 0);
            questionNumberLabel.Name = "questionNumberLabel";
            questionNumberLabel.Size = new Size(67, 15);
            questionNumberLabel.TabIndex = 1;
            questionNumberLabel.Text = "Вопрос№1";
            // 
            // questionTextLabel
            // 
            questionTextLabel.Location = new Point(36, 102);
            questionTextLabel.Margin = new Padding(2, 0, 2, 0);
            questionTextLabel.Name = "questionTextLabel";
            questionTextLabel.Size = new Size(215, 44);
            questionTextLabel.TabIndex = 2;
            questionTextLabel.Text = "Текст вопроса";
            // 
            // userAnswerTextBox
            // 
            userAnswerTextBox.Location = new Point(36, 147);
            userAnswerTextBox.Margin = new Padding(2, 1, 2, 1);
            userAnswerTextBox.Name = "userAnswerTextBox";
            userAnswerTextBox.Size = new Size(215, 23);
            userAnswerTextBox.TabIndex = 3;
            userAnswerTextBox.TextChanged += userAnswerTextBox_TextChanged;
            // 
            // errorProvider1
            // 
            errorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider1.ContainerControl = this;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(3, 1, 0, 1);
            menuStrip1.Size = new Size(288, 24);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { restartGameMenuItem, showResultsMenuItem, addQuestionToolStripMenuItem, deleteQuestionToolStripMenuItem, endTestingToolStripMenuItem });
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(53, 22);
            menuToolStripMenuItem.Text = "Меню";
            // 
            // restartGameMenuItem
            // 
            restartGameMenuItem.Name = "restartGameMenuItem";
            restartGameMenuItem.Size = new Size(213, 22);
            restartGameMenuItem.Text = "Перезапустить игру";
            restartGameMenuItem.Click += toolStripMenuItem1_Click;
            // 
            // showResultsMenuItem
            // 
            showResultsMenuItem.Name = "showResultsMenuItem";
            showResultsMenuItem.Size = new Size(213, 22);
            showResultsMenuItem.Text = "Показать результаты";
            showResultsMenuItem.Click += showResultsMenuItem_Click;
            // 
            // addQuestionToolStripMenuItem
            // 
            addQuestionToolStripMenuItem.Name = "addQuestionToolStripMenuItem";
            addQuestionToolStripMenuItem.Size = new Size(213, 22);
            addQuestionToolStripMenuItem.Text = "Добавить вопрос";
            addQuestionToolStripMenuItem.Click += addQuestionToolStripMenuItem_Click;
            // 
            // deleteQuestionToolStripMenuItem
            // 
            deleteQuestionToolStripMenuItem.Name = "deleteQuestionToolStripMenuItem";
            deleteQuestionToolStripMenuItem.Size = new Size(213, 22);
            deleteQuestionToolStripMenuItem.Text = "Удалить вопрос";
            deleteQuestionToolStripMenuItem.Click += deleteQuestionToolStripMenuItem_Click;
            // 
            // endTestingToolStripMenuItem
            // 
            endTestingToolStripMenuItem.Name = "endTestingToolStripMenuItem";
            endTestingToolStripMenuItem.Size = new Size(213, 22);
            endTestingToolStripMenuItem.Text = "Завершить тестирование";
            endTestingToolStripMenuItem.Click += endTestingToolStripMenuItem_Click;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // secondsRemainingLabel
            // 
            secondsRemainingLabel.AutoSize = true;
            secondsRemainingLabel.Location = new Point(141, 50);
            secondsRemainingLabel.Margin = new Padding(2, 0, 2, 0);
            secondsRemainingLabel.Name = "secondsRemainingLabel";
            secondsRemainingLabel.Size = new Size(110, 15);
            secondsRemainingLabel.TabIndex = 5;
            secondsRemainingLabel.Text = "Осталось времени";
            // 
            // GameAppForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(288, 225);
            Controls.Add(secondsRemainingLabel);
            Controls.Add(userAnswerTextBox);
            Controls.Add(questionTextLabel);
            Controls.Add(questionNumberLabel);
            Controls.Add(nextButton);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(2, 1, 2, 1);
            Name = "GameAppForm";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button nextButton;
        private Label questionNumberLabel;
        private Label questionTextLabel;
        private TextBox userAnswerTextBox;
        private ErrorProvider errorProvider1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem restartGameMenuItem;
        private ToolStripMenuItem showResultsMenuItem;
        private ToolStripMenuItem addQuestionToolStripMenuItem;
        private ToolStripMenuItem deleteQuestionToolStripMenuItem;
        private ToolStripMenuItem endTestingToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private Label secondsRemainingLabel;
    }
}