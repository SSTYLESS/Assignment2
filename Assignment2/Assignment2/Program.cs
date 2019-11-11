using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, n, count = 0;
            int[] freq = new int[100];
            Console.WriteLine("Enter the Maximum length of the Array");

            n = Convert.ToInt32(Console.ReadLine());

            string[] a = new string[n];

            for (i = 0; i < n; i++)
            {
                a[i] = Console.ReadLine();
                freq[i] = -1;
            }
            for (i = 0; i < n; i++)
            {
                count = 1;
                for (j = i + 1; j < n; j++)
                {
                    if (a[i] == a[j])
                    {
                        count++;
                        freq[j] = 0;
                    }
                }
                if (freq[i] != 0)
                {
                    freq[i] = count;
                }
            }
            for (i = 0; i < n; i++)
            {
                if (freq[i] != 0)
                {
                    Console.WriteLine("the number {0} frequency is={1}", a[i], freq[i]);
                }
            }
            Console.ReadLine();
        }
    }
}