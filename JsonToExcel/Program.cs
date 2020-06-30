using JsonToExcel.JsonToCsv;
using System;
using System.IO;
using System.Windows.Forms;

namespace JsonToExcel
{
    internal class Program
    {
        [STAThread]
        private static void Main(string[] args)
        {
            string inputFilePath;
            string outputFilePath;

            ChoJSONConverter converter = new ChoJSONConverter();

            Console.Title = $"Json to CSV, version {CommonUtilities.GetSoftwareVersion()}";

            Console.WriteLine("\n\n\n");

            if (Clipboard.ContainsText(TextDataFormat.Text) && Clipboard.GetText(TextDataFormat.Text).Contains(".json"))
            {
                string clipboardText = Clipboard.GetText(TextDataFormat.Text);

                Console.WriteLine($"¿ Are you triying to convert {clipboardText} to csv ? \n y = yes \n n = no \n\n");

                var selectedOption = Console.ReadLine();

                if (selectedOption.Equals("y"))
                {
                    inputFilePath = clipboardText;
                    converter.ConvertJsonToExcel(new FileInfo(inputFilePath));
                }
                else if (selectedOption.Equals("n"))
                {
                    Console.WriteLine("Please give me the full file path of the json you want to convert to csv");
                    inputFilePath = Console.ReadLine();
                    converter.ConvertJsonToExcel(new FileInfo(inputFilePath));
                    return;
                }

                Console.WriteLine("Please give me the full file path of the json you want to convert to csv");
            }
            else if ((Clipboard.ContainsText(TextDataFormat.Text) && Clipboard.GetText(TextDataFormat.Text).Contains(".csv"))
                   || (Clipboard.ContainsText(TextDataFormat.Text) && Clipboard.GetText(TextDataFormat.Text).Contains(".xlsx")))
            {
            }
            Console.WriteLine("Please give me the full file path of the json you want to convert to csv");
            inputFilePath = Console.ReadLine();
            converter.ConvertJsonToExcel(new FileInfo(inputFilePath));
            return;
        }
    }
}