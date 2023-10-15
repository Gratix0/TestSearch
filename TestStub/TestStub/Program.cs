using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestStub
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fileName = "_MG_2122.CR2";//название файла,который ищем

            FileManager mgr = new FileManager();// экземляр класса  

            if (mgr.FindLogFile(fileName))//если вернул метод true
            {
                Console.WriteLine("Файл {0} найден!", fileName);
            }
            else
            {
                Console.WriteLine("Файл {0} не найден!", fileName);
            }

            Console.ReadKey();


        }
    }
}
