﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7Arrays
{
    class Program
    {
        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);

            //foreach (int i in arr)
            //{
            //    Console.WriteLine(i);
            //}

            for (int i = arr.Length - 1; i >= 0; i--)       
            {
                Console.Write(arr[i]+" ");
            }

            Console.ReadKey();
        }
    }
}
