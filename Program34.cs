using System;
using System.Collections.Generic;

namespace CSHomeWork1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] line1 = { "1", "2", "3", "6", "5", "4" };
            string[] line2 = { "2", "3", "9", "8", "7" };
            List<string> summLines = SummarizeLines(line1, line2);
            printArray(line1);
            printArray(line2);
            printArray(summLines);
            Console.ReadKey();
        }

        static List<string> SummarizeLines(string[] line1, string[] line2)
        {
            List<string> summLines = new List<string>();
            summLines.AddRange(line1);
            bool haveSame;

            for (int i = 0; i < line2.Length; i++)
            {
                haveSame = false;

                for (int j = 0; j < line1.Length; j++)
                {
                    if (line2[i] == line1[j])
                    {
                        haveSame = true;
                    }
                }

                if (!haveSame)
                {
                    summLines.Add(line2[i]);
                }
            }

            return summLines;
        }

        static void printArray(string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

            Console.WriteLine();
        }

        static void printArray(List<string> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + " ");
            }

            Console.WriteLine();
        }
    }
}