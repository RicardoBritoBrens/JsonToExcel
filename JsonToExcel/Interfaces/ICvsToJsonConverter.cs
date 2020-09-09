using System.IO;

namespace JsonToExcel
{
    public interface ICvsToJsonConverter
    {
        void ConvertCvsToJson(FileInfo inputFile);
    }
}