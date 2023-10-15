using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace TestStub
{
    public class FileManager
    {
        public string FindLogFile(string fileName)
        {
            //FileDataObject obj = new FileDataObject(); //класс поиска по файловой системе
            TestDataObject obj = new TestDataObject(); // заглушка,для тестирования

            List<string> files = obj.GetFiles();

            foreach (var file in files)
            {
                if (file.Contains(fileName))  //поиск названия файла 
                {
                    string filePath = $"C:\\Users\\Gratix\\Downloads\\{fileName}";

                    string[] words = File.ReadAllText(filePath)
                        .Split(new char[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);

                    string longestWord = words.OrderByDescending(w => w.Length).FirstOrDefault();

                    return longestWord;
                }
            }

            return "Слов или файла не найдено";
        }
    }
}