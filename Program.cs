using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfMessages;
            string userInput;

            Console.WriteLine("Введите сообщение");
            userInput = Console.ReadLine();
            Console.WriteLine("Введите количество повторов");
            numberOfMessages = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < numberOfMessages; i++)
            {
                Console.WriteLine(userInput);
            }
        }
    }
}