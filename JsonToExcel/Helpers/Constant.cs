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