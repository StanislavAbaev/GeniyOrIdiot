using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using Newtonsoft.Json;

namespace GeniyIdiot.Common
{

    public class UsersResultsStorage
    {
        public readonly static string Path = "results.json";

        public static void PrintResults()
        {
            Console.WriteLine("{0,-20}{1,-30}{2}", "ФИО", "Правильных ответов", "Диагноз");
            for (var i = 0; i < 60; i++) Console.Write("=");
            Console.WriteLine();
            foreach (var user in GetAll())
            Console.WriteLine("{0,-29}{1,-22}{2}", user.Name, user.CountOfRightAnswers, user.Diagnosis);
        }
        public static List<User> GetAll()
        {
            if (!FileProvider.Exists(Path)) return new List<User>();

            var allResults = FileProvider.ReadFile(Path);
            var userResults = JsonConvert.DeserializeObject<List<User>>(allResults);

            return userResults;
        }

        public static void Save (List<User> users)
        {
            var jsonString = JsonConvert.SerializeObject(users, Formatting.Indented);
            FileProvider.RewriteData(jsonString, Path);
        }
        public static void Append(User user)
        {
            var userResults = GetAll();
            userResults.Add(user);
            Save(userResults);
        }
    }
}