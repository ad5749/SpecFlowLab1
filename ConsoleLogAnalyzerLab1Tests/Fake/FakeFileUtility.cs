using ConsoleLogAnalyzerLab1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLogAnalyzerLab1Tests.Fake
{
    public class FakeFileUtility : IFileUtility
    {
        public bool CheckFileExists(string fileName)
        {
            return true;
        }
    }
}
