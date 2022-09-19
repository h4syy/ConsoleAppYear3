using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppYear3
{
    internal class Class1
    {
        public void Addition()
        {
            Console.WriteLine("Enter Number 1: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number 2: ");
            int number2 = Convert.ToInt32(Console.ReadLine());
            var sum = number1 + number2;
            Console.WriteLine("The sum of the two numbers is :" + sum);
        }
        public void Subtraction()
        {
            Console.WriteLine("Enter Number 1: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number 2: ");
            int number2 = Convert.ToInt32(Console.ReadLine());
            var diff = number1 - number2;
            Console.WriteLine("The difference of the two numbers is :" + diff);
        }
        public void Multiplication()
        {
            Console.WriteLine("Enter Number 1: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number 2: ");
            int number2 = Convert.ToInt32(Console.ReadLine());
            var product = number1 * number2;
            Console.WriteLine("The product of the two numbers is :" + product);
        }
        public void Division()
        {
            Console.WriteLine("Enter Number 1: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number 2: ");
            int number2 = Convert.ToInt32(Console.ReadLine());
            var quotient = number1 + number2;
            Console.WriteLine("The quotient of the two numbers is :" + quotient);
        }
        public void StringInterpolation()
        {
            Console.WriteLine("Enter First Name:  ");
            string? word1 = Console.ReadLine();
            Console.WriteLine("Enter Last Name: ");
            string? word2 = Console.ReadLine();
            Console.WriteLine($"My name is {word1} {word2}.");
        }

    }
}
