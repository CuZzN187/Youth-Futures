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
            //calling update function with params
            update(ref numberTest);
            Console.WriteLine("New value: " + numberTest);
            Console.WriteLine();
            //calling linkedList function with no params
            linkedList();
            Console.ReadKey(); //<<<<<needed to pause the console so that pressing ENTER will close out console
        }

        public static void linkedList()
        {
            //.NET Libraries have alot of short cut functionality like linked lists, hashtables, etc...

            //this uses the .NET framework libraries to make a Linked List
            LinkedList<string> lista = new LinkedList<string>();

            //adding to your linked list
            lista.AddLast("Sabree");
            lista.AddFirst("Juan");
            lista.AddBefore(lista.First, "Robb");
            lista.AddAfter(lista.Last, "Bradley");
            lista.AddBefore(lista.First, "The 404");

            //simple foreach loop
            foreach (var val in lista)
            {
                Console.WriteLine(val);
            }
        }
    }
}
