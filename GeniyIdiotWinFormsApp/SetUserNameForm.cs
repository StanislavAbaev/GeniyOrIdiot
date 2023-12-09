using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeniyIdiotWinFormsApp
{
    public partial class SetUserNameForm : Form
    {
        static ErrorProvider ep2 = new ErrorProvider();

        public SetUserNameForm()
        {
            InitializeComponent();
        }

        private void appendButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        public string GetUserName()
        {
            return userNametextBox.Text;
        }
        private void userNametextBox_TextChanged(object sender, EventArgs e)
        {
            ValidateInputString(userNametextBox, appendButton);
        }

        private static void ValidateInputString(TextBox text, Button button)
        {
            if (string.IsNullOrEmpty(text.Text) || Int32.TryParse(text.Text, out int name))
            {
                ep2.SetError(text, "Ваше имя не должно быть пустым, либо содержать только цифры");
                button.Enabled = false;
            }
            else
            {
                ep2.Dispose();
                button.Enabled = true;
            }

        }

        private void SetUserNameForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("После закрытия этого окна начнется игра, " +
                "время ответа на вопрос - 10 сек.");
        }
    }
}
