using System.Collections.Generic;

namespace TestStub
{
    internal class TestDataObject
    {
        public List<string> GetFiles()
        {
            List<string> list = new List<string>();
            list.Add("main.log");
            list.Add("Test.txt");
            list.Add("file2.log");
            list.Add("file3.exe");

            return list;
        }

    }
}