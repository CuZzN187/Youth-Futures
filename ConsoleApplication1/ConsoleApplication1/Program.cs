using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        public static void update(ref int num)
        {
            num = 1;
        }
        static void Main(string[] args)
        {
            // Parsing
            string sNumber = "1";
            int number;
            Int32.TryParse(sNumber, out number);// Reference
            Console.WriteLine("Number: " + number);

            // Arrays
            int[] numbers = {1,2,3,4,5};// single
            int[,] mNumbers = { {1,2,3}, {4,5,6}};// multi

            // Foreach
            foreach(int x in numbers)
            {
                Console.WriteLine("Number from array: " + x);
            }

            // Pass by ref
            int numberTest = 500;
            update(ref numberTest);
            Console.WriteLine("New value: " + numberTest);
            Console.ReadKey();
        }
    }
}
