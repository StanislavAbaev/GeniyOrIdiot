using System;
using System.Collections.Generic;
using System.IO;

namespace GeniyIdiot.Common
{
    public static class FileProvider
    {
        /// <summary>
        /// Добавляет строку в определенный файл
        /// </summary>
        /// <param name="value">Строка, которую необходимо добавить</param>
        /// <param name="path">Путь к файлу</param>
        public static void AddData(string value, string path)
        {
            if (!Exists(path)) File.Create(path).Close();
            using (var sw = new StreamWriter(path, true))
                sw.WriteLine(value);
        }
        public static void RewriteData(string value, string path)
        {
            if (!Exists(path)) File.Create(path).Close();
            using (var sw = new StreamWriter(path, false))
                sw.WriteLine(value);
        }
        /// <summary>
        /// Прочитать файл
        /// </summary>
        /// <param name="path">Путь к файлу</param>
        /// <returns></returns>
        public static string ReadFile(string path)
        {
            if (!File.Exists(path)) File.Create(path).Close();
            var value = "";
            using (var sr = new StreamReader(path, true))
                value = sr.ReadToEnd();
            return value;
        }
        /// <summary>
        /// Очистить файл
        /// </summary>
        /// <param name="path">Путь к файлу</param>
        public static void Clear(string path)
        {
            File.WriteAllText(path, string.Empty);
        }
        /// <summary>
        /// Проверить, существует ли файл
        /// </summary>
        /// <param name="path">Путь к файлу</param>
        /// <returns></returns>
        public static bool Exists(string path)
        {
            return File.Exists(path);
        }
    }
}