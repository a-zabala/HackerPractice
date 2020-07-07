using System;
using System.Threading;
namespace HackerrankPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of elements in the array");
            int elements = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the list of numbers with a space between each element");
            string listElements = Console.ReadLine();
            string[] stringArray = listElements.Split(" ");
            int sum = simpleArraySum(stringArray, elements);
            Console.WriteLine("The sum of all elements in the array is " + sum);
            Console.ReadLine();
        }
        static int simpleArraySum(string[] ar, int elements)
        {
            int sum = 0;
            for (int i = 0; i < elements; i++)
            {
                //Console.WriteLine(stringArray[i]);
                sum += Convert.ToInt32(ar[i]);
            }
            return sum;
        }
    }
}
