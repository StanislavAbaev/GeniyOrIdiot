namespace GeniyIdiotWinFormsApp
{
    partial class SetUserNameForm
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
            appendButton = new Button();
            userNametextBox = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // appendButton
            // 
            appendButton.Location = new Point(139, 237);
            appendButton.Name = "appendButton";
            appendButton.Size = new Size(200, 46);
            appendButton.TabIndex = 0;
            appendButton.Text = "Подтвердить";
            appendButton.UseVisualStyleBackColor = true;
            appendButton.Click += appendButton_Click;
            // 
            // userNametextBox
            // 
            userNametextBox.Location = new Point(67, 148);
            userNametextBox.Name = "userNametextBox";
            userNametextBox.Size = new Size(345, 39);
            userNametextBox.TabIndex = 1;
            userNametextBox.Text = "Неизвестно";
            userNametextBox.TextChanged += userNametextBox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(83, 66);
            label1.Name = "label1";
            label1.Size = new Size(312, 32);
            label1.TabIndex = 2;
            label1.Text = "Введите имя пользователя";
            // 
            // SetUserNameForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 340);
            Controls.Add(label1);
            Controls.Add(userNametextBox);
            Controls.Add(appendButton);
            Name = "SetUserNameForm";
            Text = "Добавление пользователя";
            FormClosing += SetUserNameForm_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button appendButton;
        private TextBox userNametextBox;
        private Label label1;
    }
}