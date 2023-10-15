using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace TestStub
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fileName = "Test.txt";//название файла,который ищем

            FileManager mgr = new FileManager();// экземляр класса  

            string returns = mgr.FindLogFile(fileName);

            Console.WriteLine($"Самое длинное слово: {returns}");

            Console.ReadKey();


        }
    }
}
