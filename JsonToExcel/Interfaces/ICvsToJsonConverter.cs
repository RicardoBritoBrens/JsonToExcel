using System.IO;

namespace JsonToExcel
{
    public interface ICvsToJsonConverter
    {
        void ConvertCsvToJson(FileInfo inputFile);
    }
}