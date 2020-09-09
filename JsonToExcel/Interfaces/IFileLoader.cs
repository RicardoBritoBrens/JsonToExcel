using System.IO;

namespace JsonToExcel
{
    public interface IFileLoader
    {
        FileInfo LoadFileInfoJson(FileInfo fileInfo);

        FileInfo LoadJson(string filePath);
    }
}