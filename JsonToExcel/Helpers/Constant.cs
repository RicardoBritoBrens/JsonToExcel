using ServiceStack.Html;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonToExcel.Helpers
{
    public static class Constant
    {
        private static string Output => nameof(Output);
        private static string JsonExtension => ".json";
        private static string CsvExtension => ".Csv";

        public static string JsonOutputFile => $"{Output}.{JsonExtension}";
        public static string CsvOutputFile => $"{Output}.{CsvExtension}";
    }
}