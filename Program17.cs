using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CSHomeWork1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String row = Console.ReadLine();
            int depth = 0;
            int maxDepth = 0;
            bool isCorrectParenthesisExpression = true;

            foreach (var symbol in row)
            {
                if (symbol == '(')
                {
                    depth++;
                }
                else
                {
                    depth--;
                }

                if (depth < 0)
                {
                    isCorrectParenthesisExpression = false;
                    break;
                }

                if (depth > maxDepth)
                {
                    maxDepth = depth;
                }
            }

            if (isCorrectParenthesisExpression && depth == 0)
            {
                Console.WriteLine("Верное скобочное выражение");
                Console.WriteLine("Глубина: " + maxDepth);
            }
            else
            {
                Console.WriteLine("Неверное скобочное выражение");
            }

            Console.ReadKey();
        }
    }
}