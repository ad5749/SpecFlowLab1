using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLogAnalyzerLab1
{
    public class FileManager : IFileManager
    {
        public IFileUtility SetFileUtility { private get; set; }

        public bool IsValid(string fileName)
        {
            if (SetFileUtility.CheckFileExists(fileName)
                && fileName.EndsWith(".LOG", StringComparison.CurrentCultureIgnoreCase))
            {
                return true;
            }
            return false;
        }

        
    }
}
