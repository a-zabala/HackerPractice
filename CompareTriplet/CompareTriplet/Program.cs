using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace CompareTriplet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first triplet for Alice's scores");
            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();
            Console.WriteLine("Enter the second triplet for Bob's scores");
            List<int> b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();

            List<int> result = compareTriplets(a, b);
            Console.WriteLine("Alice had a {0} points and Bob had {1} points", result[0], result[1]);


            static List<int> compareTriplets(List<int> a, List<int> b)
            {
                int ascore = 0;
                int bscore = 0;
                for (int i=0; i<3; i++)
                {
                    if (a[i] > b[i]) ascore += 1;
                    if (a[i] < b[i]) bscore += 1;
                }
                List<int> result = new List<int> { ascore, bscore };
                return result;

            }

        }

    }
}
