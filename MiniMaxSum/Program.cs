using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

namespace MiniMaxSum
{
    class Result
    {

        /*
         * Complete the 'miniMaxSum' function below.
         *
         * The function accepts INTEGER_ARRAY arr as parameter.
         */

        public static void miniMaxSum(List<long> arr)
        {
            var minSum = arr.OrderBy( n => n).Take(4).Sum();
            var maxSum = arr.OrderByDescending(n => n).Take(4).Sum();

            Console.WriteLine($"{minSum} {maxSum}");
        }

        class Program
        {
            static void Main(string[] args)
            {
                List<long> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt64(arrTemp)).ToList();

                Result.miniMaxSum(arr);
            }
        }

    }
}
