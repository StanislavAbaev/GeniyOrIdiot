using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeniyIdiot.Common
{
    public class Game
    {
        User user;
        public List<Question> questions = QuestionsStorage.GetQuestionList();
        Question currentQuestion;
        public int countOfQuestions = QuestionsStorage.GetQuestionList().Count;
        int questionNuber = 0;
        public Game(User user)
        {
            this.user = user;
        }

        public Question GetNextQuestion()
        {
            GameTimer.ResetSecondsRemaining();

            var random = new Random();
            var randomIndex = random.Next(0, questions.Count);
            currentQuestion = questions[randomIndex];
            questions.Remove(currentQuestion);
            return currentQuestion;
        }
        public void AcceptAnswer(string userAnswer)
        {
            if (InputValidator.ValidateIntInput(userAnswer) && Convert.ToUInt32(userAnswer) == currentQuestion.Answer)
                user.CountOfRightAnswers++;
        }
        public bool IsEnded()
        {
            return questions.Count == 0;
        }
        public bool isLastQuestion()
        {
            return questions.Count == 1;
        }
        public void RestartGame()
        {
            questions = QuestionsStorage.GetQuestionList();
            questionNuber = 0;
            user.CountOfRightAnswers = 0;
            user.Diagnosis = string.Empty;
        }
        public string GetQuestionNumber()
        {
            questionNuber++;
            return "Вопрос № " + questionNuber;
        }

        public void EndGame()
        {
            user.Diagnosis = user.GetDiagnosis(countOfQuestions);
            UsersResultsStorage.Append(user);
        }


    }
}
