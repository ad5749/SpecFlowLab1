namespace ConsoleLogAnalyzerLab1
{
    public interface IFileManager
    {
        IFileUtility SetFileUtility { set; }
        bool IsValid(string fileName);
    }
}