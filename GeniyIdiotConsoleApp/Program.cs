using System.Numerics;
using System.Text;
using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System.Threading;
using GeniyIdiot.Common;
using System.Timers;

namespace GeniyIdiot.Common

{
    class Program
    {
        public static User user;
        public static Game game;

        public static void Main()
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            var enc1251 = Encoding.GetEncoding(1251);
            System.Console.OutputEncoding = System.Text.Encoding.UTF8;
            System.Console.InputEncoding = enc1251;

            Console.WriteLine("Введите имя пользователя");
            user = new User(Console.ReadLine());
            game = new Game(user);

            while (!game.IsEnded())
            {
                if (!game.IsEnded())
                {
                    Console.WriteLine(game.GetQuestionNumber());
                    Console.WriteLine(game.GetNextQuestion().QuestionText);

                    game.AcceptAnswer(Convert.ToString(User.GetAnswer()));
                }

            }
            game.EndGame();
            Console.WriteLine("Количество правильных ответов: " + user.CountOfRightAnswers);
            Console.WriteLine($"{user.Name}, ваш диагноз: {user.Diagnosis}");

            if (User.IsConfirmed("Желаете ли вы посмотреть результаты тестирований?")) UsersResultsStorage.PrintResults();

            if (User.IsConfirmed("Желаете добавить вопрос?")) QuestionsStorage.AddQuestionToStorage();
            if (User.IsConfirmed("Желаете удалить вопрос")) QuestionsStorage.RemoveQuestion();

            if (User.IsConfirmed("Желаете ли вы пройти тест еще раз?")) game.RestartGame();

            UsersResultsStorage.Append(user);
        }
    }
}
