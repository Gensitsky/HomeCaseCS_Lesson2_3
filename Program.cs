/*Написать программу, которая предлагает пользова-
телю ввести число и считает, сколько раз это число
встречается в массиве.*/
using System;

namespace HomeCaseCS_Lesson2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = 10, count = 0;
            Random rnd = new Random();
            int[] arr = new int[length];
            Console.WriteLine("Source array:");
            for (int i = 0; i < length; i++)
            {
                arr[i] = rnd.Next(10);
                Console.Write(arr[i] + " | ");
            }
            Console.Write("\n\nEnter an integer from the array: ");
            int num = Convert.ToInt32(Console.ReadLine());
            foreach (var item in arr)
            {
                if (item == num)
                {
                    count++;
                }
            }
            Console.WriteLine($"The desired number was encountered {count} times");
            Console.ReadKey();
        }
    }
}