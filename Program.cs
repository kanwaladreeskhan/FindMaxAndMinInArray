using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaxInArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5];
           
            Console.WriteLine("Enter the Elements:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Element {0}:", (i + 1));
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            int max = array[0]; int min = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                  }
            }
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            Console.WriteLine("{0} is Greatest number in given array!", max);
            Console.WriteLine("{0} is Smallest number in given array!", min);
        }
    }
}
