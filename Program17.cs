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
            int countLeftBrackets = 0;
            int countRightBrackets = 0;
            bool isCorrectParenthesisExpression = false;
            int depth;
            int maxDepth = 0;

            if (row.Length > 2 && row[0] != ')' && row[row.Length - 1] != '(')
            {
                foreach (var symbol in row)
                {
                    if (symbol == '(')
                    {
                        countLeftBrackets++;
                    } 
                    else
                    {
                        countRightBrackets++;
                    }
                }

                if (countLeftBrackets == countRightBrackets)
                {
                    isCorrectParenthesisExpression |= true;
                }
            }

            if (isCorrectParenthesisExpression)
            {
                for (int i1 = 0; i1 < row.Length - 1; i1++)
                {
                    if (row[i1] == '(' && row[i1 + 1] == ')')
                    {
                        depth = 1;

                        for (int i2 = i1 + 2; i2 < row.Length; i2++)
                        {
                            if (row[i2] == '(')
                            {
                                depth--;
                            }
                            else
                            {
                                depth++;
                            }
                        }

                        if (depth > maxDepth)
                        {
                            maxDepth = depth;
                        }
                    }
                }

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