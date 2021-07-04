using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleLogAnalyzerLab1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;

namespace ConsoleLogAnalyzerLab1.Tests
{
    [TestClass()]
    public class LogAnalyzerTests
    {
        [TestMethod()]
        public void IsValidLogFileNameTest()
        {
            //Arrange
            Mock<IFileUtility> fileUtility = new Mock<IFileUtility>();
            string fileName = "20210703.log";
            fileUtility.Setup(c => c.CheckFileExists(fileName))
                .Returns(true);
            IFileManager target = new FileManager();
            target.SetFileUtility = fileUtility.Object;
            bool expected = true;
            bool actual;
            

            //Act
            actual = target.IsValid(fileName);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}