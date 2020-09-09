using System.IO;

namespace JsonToExcel
{
    public interface IJsonToCvsConverter
    {
        void ConvertJsonToCvs(FileInfo inputFile);
    }
}