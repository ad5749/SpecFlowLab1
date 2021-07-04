using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleLogAnalyzerLab1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleLogAnalyzerLab1Tests.Fake;

namespace ConsoleLogAnalyzerLab1.Tests
{
    [TestClass()]
    public class LogAnalyzerTests
    {
        [TestMethod()]
        public void IsValidLogFileNameTest()
        {
            //Arrange
            LogAnalyzer target = new LogAnalyzer();
            bool expected = true;
            bool actual;
            string fileName = "20210703.log";

            //Act
            actual = target.IsValidLogFileName(fileName);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Test_IsValidLogFileName_Stub()
        {
            //Arrange
            IFileManager target = new FileManager();
            target.SetFileUtility = new FakeFileUtility();
            bool expected = true;
            bool actual;
            string fileName = "20210703.log";

            //Act
            actual = target.IsValid(fileName);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
