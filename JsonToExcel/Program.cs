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
            string inputFilePath = "/Users/mac/Downloads/PlantillaDeSincronizacionDeDatosNinos.csv";

            var converter = new ChoJSONConverter();

            Console.Title = $"Json to CSV, version {Project.GetSoftwareVersion()}";

            Console.WriteLine("\n\n\n");

            if (Clipboard.ContainsText(TextDataFormat.Text) && Clipboard.GetText(TextDataFormat.Text).Contains(".json"))
            {
                var clipboardText = Clipboard.GetText(TextDataFormat.Text);

                Console.WriteLine($"¿ Are you trying to convert {clipboardText} to csv ? \n y = yes \n n = no \n\n");

                var selectedOption = Console.ReadLine();

                if (selectedOption.Equals("y"))
                {
                    inputFilePath = clipboardText;
                    converter.ConvertJsonToCsv(new FileInfo(inputFilePath));
                }
                else if (selectedOption.Equals("n"))
                {
                    Console.WriteLine("Please give me the full file path of the json you want to convert to csv");
                    inputFilePath = Console.ReadLine();
                    converter.ConvertJsonToCsv(new FileInfo(inputFilePath));
                    return;
                }

                Console.WriteLine("Please give me the full file path of the json you want to convert to csv");
            }
            else if ((Clipboard.ContainsText(TextDataFormat.Text) && Clipboard.GetText(TextDataFormat.Text).Contains(".csv"))
                    || (Clipboard.ContainsText(TextDataFormat.Text) && Clipboard.GetText(TextDataFormat.Text).Contains(".xlsx")))
            {
                var clipboardText = Clipboard.GetText(TextDataFormat.Text);

                Console.WriteLine($"¿ Are you trying to convert {clipboardText} to json ? \n y = yes \n n = no \n\n");

                var selectedOption = Console.ReadLine();

                if (selectedOption.Equals("y"))
                {
                    inputFilePath = clipboardText;
                    converter.ConvertCsvToJson(new FileInfo(inputFilePath));
                }
                else if (selectedOption.Equals("n"))
                {
                    Console.WriteLine("Please give me the full file path of the json you want to convert to json");
                    inputFilePath = Console.ReadLine();
                    converter.ConvertCsvToJson(new FileInfo(inputFilePath));
                    return;
                }

                Console.WriteLine("Please give me the full file path of the json you want to convert to csv");
            }

            Console.WriteLine("Please give me the full file path of the json you want to convert to csv");
            inputFilePath = Console.ReadLine();
            converter.ConvertJsonToCsv(new FileInfo("/Users/mac/Downloads/PlantillaDeSincronizacionDeDatosNinos.csv"));
            return;
        }
    }
}