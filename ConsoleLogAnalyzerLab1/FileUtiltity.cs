using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLogAnalyzerLab1
{
    public class FileUtiltity : IFileUtility
    {
        public IFileUtility SetFileUtility { private get; set; }

        public bool CheckFileExists(string fileName)
        {
            return File.Exists(fileName);
        }
    }
}
