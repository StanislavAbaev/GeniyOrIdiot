using System;
namespace GeniyIdiot.Common
{
    public class User
    {
        public string Name;
        public int CountOfRightAnswers = 0;
        public string Diagnosis;
        public User(string name)
        {
            Name = name;
        }
        /// <summary>
        /// Функция возвразщает диагноз пользователя в виде строки. 
        /// </summary>
        /// <param name="countOfQuestions"></param>
        /// <returns>
        /// Если процент количества правильных ответов меньше 20% - идиот, 20-39% - кретин,
        /// 40-59% - дурак, 60-79% - нормальный, 80-99% - талант, 100% - гений. 
        /// </returns>
        public string GetDiagnosis(int countOfQuestions)
        {
            double percentageOfCorrectAnswers = (double)CountOfRightAnswers / (double)countOfQuestions; // счиаем процент правильных ответов
            if (percentageOfCorrectAnswers == 1) return "гений";
            else if (percentageOfCorrectAnswers >= 0.8) return "талант";
            else if (percentageOfCorrectAnswers >= 0.6) return "нормальный";
            else if (percentageOfCorrectAnswers >= 0.4) return "дурак";
            else if (percentageOfCorrectAnswers >= 0.2) return "кретин";
            else return "идиот";
        }
        /// <summary>
        /// Валидация ответа
        /// </summary>
        /// <returns></returns>

        public static int GetAnswer()
        {
            while (true)
            {
                var userAnswer = Console.ReadLine();
                if (int.TryParse(userAnswer, out int answer)) return answer;
                else Console.WriteLine("Введенный вами ответ некорректен! Пожалуйста, повторите попытку.");
            }
        }
        public static bool IsConfirmed(string questuion)
        {
            var userDecision = "";
            while (true)
            {
                Console.WriteLine(questuion);
                userDecision = Console.ReadLine().ToLower();

                if (userDecision == "да")
                {
                    return true;
                }
                else if (userDecision == "нет") return false;
                else Console.WriteLine("Введите да или нет");
            }
        }
    }
}