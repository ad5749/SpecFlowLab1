using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleLogAnalyzerLab1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;

namespace ConsoleLogAnalyzerLab1.Tests
{
    [TestClass()]
    public class LogAnalyzerTests
    {
        [TestMethod()]
        public void IsValidLogFileNameTest()
        {
            Process p = new Process();
            string fileName = Path.Combine(@"D:\Projects\MSTest\Demo1\ConsoleLogAnalyzerLab1\bin\Debug",
                "ConsoleLogAnalyzerLab1.exe");
            string arguments = "20210703.log";
            p.StartInfo = new ProcessStartInfo(fileName, arguments)
            {
                UseShellExecute = false,
                RedirectStandardInput = true,
                RedirectStandardOutput = true
            };

            p.Start();

            string result = p.StandardOutput.ReadToEnd();

            bool expected = true;
            bool actual = result.IndexOf("isValid=True") >= 0;
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}