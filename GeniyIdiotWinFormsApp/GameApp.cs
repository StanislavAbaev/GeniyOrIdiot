using GeniyIdiot.Common;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace GeniyIdiotWinFormsApp
{
    public partial class GameAppForm : Form
    {
        User user = new User("Неизвестно");
        Game game;
        public GameAppForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var f2 = new SetUserNameForm();
            f2.ShowDialog();
            user.Name = f2.GetUserName();
            game = new Game(user);
            ShowNextQuestion();
            nextButton.Enabled = false;
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            game.AcceptAnswer(userAnswerTextBox.Text);
            if (!game.IsEnded()) ShowNextQuestion();
            else EndGame();
        }

        private void userAnswerTextBox_TextChanged(object sender, EventArgs e)
        {
            if (InputValidator.ValidateIntInput(userAnswerTextBox.Text))
            {
                nextButton.Enabled = true;
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(userAnswerTextBox, "Ответ должен содержать только цифры " +
                    "и не должен быть пустым!");
                nextButton.Enabled = false;
            }
        }


        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            game.RestartGame();
            MessageBox.Show("Игра перезапущена");
            ShowNextQuestion();
        }

        private void showResultsMenuItem_Click(object sender, EventArgs e)
        {
            var form3 = new UserResults();
            form3.ShowDialog();
        }

        private void addQuestionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var addQuestionForm = new AddNewQuestion();
            addQuestionForm.ShowDialog();
        }

        private void deleteQuestionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var deleteQuestionForm = new DeleteQuestion();
            deleteQuestionForm.ShowDialog();
        }

        private void endTestingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var mb = MessageBox.Show("Вы действительно хотите завершить тестирование?", "Завершение тестирования", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (mb == DialogResult.Yes) Close();
        }
        private void ShowNextQuestion()
        {
            timer1.Enabled = true;

            var que = game.GetNextQuestion();
            questionTextLabel.Text = que.QuestionText;
            questionNumberLabel.Text = game.GetQuestionNumber();

            userAnswerTextBox.Clear();
            userAnswerTextBox.Enabled = true;
            errorProvider1.Clear();
        }

        private void EndGame()
        {
            userAnswerTextBox.Enabled = false;
            timer1.Enabled = false;
            game.EndGame();
            nextButton.Enabled = false;
            MessageBox.Show(user.Diagnosis);
            return;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            GameTimer.StartTimer(null);
            var secondsRemaining = GameTimer.ReturnSecondsRemaining();
            if (secondsRemaining == 0 && !game.IsEnded()) ShowNextQuestion();
            if (secondsRemaining == 0 && game.IsEnded()) EndGame();
            secondsRemainingLabel.Text = "Осталось времени: " + secondsRemaining + " сек.";
        }

    }
}