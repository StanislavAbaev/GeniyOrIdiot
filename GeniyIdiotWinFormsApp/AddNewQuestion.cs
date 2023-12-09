using GeniyIdiot.Common;
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
    public partial class AddNewQuestion : Form
    {
        public AddNewQuestion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var list = QuestionsStorage.GetQuestionList();
            var question = new Question(textBox1.Text, Convert.ToInt32(textBox2.Text));
            list.Add(question);

            QuestionsStorage.Append(question);
            MessageBox.Show("Вопрос успешно добавлен");
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            CheckInputQuestion();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            CheckInputQuestion();
        }
        void CheckInputQuestion()
        {
            if (InputValidator.ValidateStringInput(textBox1.Text) &&
                (InputValidator.ValidateIntInput(textBox2.Text))) button1.Enabled = true;
            else button1.Enabled = false;
        }

    }
}
