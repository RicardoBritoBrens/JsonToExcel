using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonToExcel.Helpers
{
    public static class ConsolePresentation
    {
        public static void ShowConvertingMessage()
        {
            Console.WriteLine("Converting...");
            Task.Delay(5000);

            Console.WriteLine("Converting...");
            Task.Delay(5000);

            Console.WriteLine("Converting...");
            Task.Delay(5000);
        }

        public static void ShowConsoleExceptionAndReadKey(Exception exception)
        {
            Console.WriteLine($"Error => {exception.Message}");
            Console.ReadKey();
        }

        public static void ShowConsoleEndMessageAndReadKey(string outputFileFullNamePath)
        {
            Console.WriteLine();
            Task.Delay(5000);

            Console.WriteLine();
            Task.Delay(5000);

            Console.WriteLine($"Done... check the path {outputFileFullNamePath}");
            Console.WriteLine("\n Press any key to close this window");

            Task.Delay(5000);
            Console.ReadKey();
        }
    }
}