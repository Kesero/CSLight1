using System;
using System.Collections.Generic;
using System.Linq;

namespace CSHomeWork1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] line1 = { "1", "2", "3", "6", "5", "4" };
            string[] line2 = { "2", "3", "9", "8", "7" };
            List<string> summLines = new List<string>();
            PrintArray(line1);
            PrintArray(line2);
            MergeLines(summLines, line1);
            MergeLines(summLines, line2);
            PrintArray(summLines);
            Console.ReadKey();
        }

        static void MergeLines(List<string> summLines, string[] line)
        {
            for (int i = 0; i < line.Length; i++)
            {
                if (!summLines.Contains(line[i]))
                {
                    summLines.Add(line[i]);
                }
            }
        }

        static void PrintArray(string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

            Console.WriteLine();
        }

        static void PrintArray(List<string> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + " ");
            }

            Console.WriteLine();
        }
    }
}