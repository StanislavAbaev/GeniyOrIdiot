using GeniyIdiot.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeniyIdiotWinFormsApp
{
    public partial class DeleteQuestion : Form
    {
        static List<Question> _questions = QuestionsStorage.GetQuestionList();
        public DeleteQuestion()
        {
            InitializeComponent();
        }

        private void DeleteQuestion_Load(object sender, EventArgs e)
        {
            LoadQuestions(dataGridView1);
            var questions = QuestionsStorage.GetQuestionList();
            for (int i = 0; i < questions.Count; i++)
            {
                dataGridView1.Rows.Add(i + 1, questions[i].QuestionText);
            }
            button1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var question = _questions[Convert.ToInt32(textBox1.Text)-1];
            _questions.Remove(question);
            QuestionsStorage.Save(_questions);
            MessageBox.Show("Вопрос успешно удален!");
            Close();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            bool isNumber = InputValidator.ValidateIntInput(textBox1.Text);
            if (isNumber && Int32.Parse(textBox1.Text) - 1 >= 0 && Int32.Parse(textBox1.Text) - 1 <= _questions.Count)
            {
                button1.Enabled = true;
            }
            else button1.Enabled = false;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var deletedQuestionText = dataGridView1.CurrentRow.Cells[1].Value.ToString();

            RemoveQuestion(deletedQuestionText);
            dataGridView1.Rows.Clear();

            LoadQuestions(dataGridView1);
        }

        static void LoadQuestions(DataGridView dataGridView)
        {
            dataGridView.Rows.Clear();
            _questions = QuestionsStorage.GetQuestionList();
            for (int i = 0; i < _questions.Count; i++)
            {
                dataGridView.Rows.Add(i + 1, _questions[i].QuestionText);
            }
        }

        /// <summary>
        /// Удаляет вопрос из списка по переданному тексту
        /// </summary>
        /// <param name="dataGridView">таблица, которая будет обновлена</param>
        /// <param name="deleteQuestionText">текст удаляемого вопроса</param>

        static void RemoveQuestion(string deletedQuestionText)
        {
            foreach (var question in _questions)
            {
                if (question.QuestionText == deletedQuestionText)
                {
                    _questions.Remove(question);
                    break;
                }
            }
            QuestionsStorage.Save(_questions);
            MessageBox.Show("Вопрос успешно удален");
        }
    }
}
