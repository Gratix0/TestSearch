using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StubTest
{
    internal class FileManagerTests
    {
        [TestMethod]
        public void FindLogFile_NameFile_IsFound()
        {
            TestStub.FileManager fileManager = new TestStub.FileManager(); string expected = "dadada";

            string actual = fileManager.FindLogFile("Test.txt");

            Assert.AreEqual(expected, actual);
        }
    }
}
