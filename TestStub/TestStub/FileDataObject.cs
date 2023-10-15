using System.Collections.Generic;
using System.IO;

namespace TestStub
{
    internal class FileDataObject
    {
        public List<string> GetFiles()
        {
            string path = "C:\\Users\\Gratix\\Downloads"; //путь поиска файла

            List<string> list = new List<string>();
            DirectoryInfo d = new DirectoryInfo(path);
            FileInfo[] files = d.GetFiles();

            foreach (var file in files)//формирвоание листа из названий файлов с расширением
            {
                list.Add(file.Name);
            }

            return list;
        }

    }
}