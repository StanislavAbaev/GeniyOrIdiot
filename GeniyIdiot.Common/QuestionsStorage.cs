using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace GeniyIdiot.Common
{

    public static class QuestionsStorage
    {
        static readonly string Path = "questions.json";
        /// <summary>
        /// Получает список вопросов из файла "questions.txt"
        /// Если файл существует, то парсит его и выводит вопрос
        /// Если не существует, то создает его и добавляет дефолтные вопросы
        /// </summary>
        /// <returns></returns>
        public static List<Question> GetQuestionList()
        {
            var questions = new List<Question>();

            if (!FileProvider.Exists(Path))
            {
                questions.Add(new Question("Сколько будет два плюс два умноженное на два?", 6));
                questions.Add(new Question("Бревно нужно распилить на 10 частей. Сколько надо сделать распилов?", 9));
                questions.Add(new Question("На двух руках 10 пальцев. Сколько пальцев на пяти руках?", 25));
                questions.Add(new Question("Укол делают каждые пол часа. Сколько времени нужно для 3 уколов?", 60));
                questions.Add(new Question("Пять свечей горело, две потухли. Сколько свечей осталось?", 2));
                questions.Add(new Question("Тестовый вопрос №1, правильный ответ: 1", 1));
                questions.Add(new Question("Тестовый вопрос №2, правильный ответ: 1", 1));
                questions.Add(new Question("Тестовый вопрос №3, правильный ответ: 1", 1));
                Save(questions);
                return questions;
            }
            var value = FileProvider.ReadFile(Path);
            var deserializedObjectList = JsonConvert.DeserializeObject<List<Question>>(value);
            return deserializedObjectList;
        }


        public static void AddQuestionToStorage()
        {
            string questionInput;
            while (true)
            {
                Console.WriteLine("Введите вопрос");
                questionInput = Console.ReadLine();
                if (String.IsNullOrWhiteSpace(questionInput))
                    Console.WriteLine("Введенный вопрос некореектен, пожалуйста, повторите попытку");
                else break;
            }
            Console.WriteLine("Введите ответ");
            string userAnswer = Console.ReadLine();
            var question = new Question(questionInput, User.GetAnswer());
            Append(question);
        }
        //потом проверить работоспособность этого метода
        public static void RemoveQuestion()
        {
            Console.WriteLine("Введите номер удаляемого вопроса");
            var questions = GetQuestionList();
            for (int i = 0; i < questions.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {questions[i].QuestionText}");
            }
            string userAnswer = Console.ReadLine();
            var removeQuestionNumber = User.GetAnswer();
            while (removeQuestionNumber < 1 || removeQuestionNumber > questions.Count)
            {
                Console.WriteLine("Введите число от 1 до " + questions.Count);
                removeQuestionNumber = User.GetAnswer();
            }
            var removeQuestion = questions[removeQuestionNumber - 1];
            questions.Remove(removeQuestion);
            Save(questions);
        }
        public static void Save(List<Question> questions)
        {
            var seralizedQuestions = JsonConvert.SerializeObject(questions, Formatting.Indented);
            FileProvider.RewriteData(seralizedQuestions, Path);
        }
        public static void Append(Question question)
        {
            var questionsList = GetQuestionList();
            questionsList.Add(question);
            Save(questionsList);
        }
    }
}