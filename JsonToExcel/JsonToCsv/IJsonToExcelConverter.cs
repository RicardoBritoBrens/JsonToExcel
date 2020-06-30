using System.IO;

namespace JsonToExcel
{
    public interface IJsonToExcelConverter
    {
        FileInfo LoadFileInfoJson(FileInfo filePath);

        FileInfo LoadJson(string filePath);

        (string Path, FileInfo) ConvertJsonToExcel();
    }
}