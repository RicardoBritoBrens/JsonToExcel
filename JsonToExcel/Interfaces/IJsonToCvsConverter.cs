using System.IO;

namespace JsonToExcel
{
    public interface IJsonToCvsConverter
    {
        void ConvertJsonToCsv(FileInfo inputFile);
    }
}