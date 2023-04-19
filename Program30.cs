using System;
using System.Collections.Generic;

namespace CSHomeWork1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("тромб", "прижизненный свёрток крови в просвете кровеносного сосуда");
            dictionary.Add("эритроциты", "клетки, функцией которых является перенос кислорода");
            dictionary.Add("лейкоциты", "основные компоненты иммунной системы, борющиеся с чужеродными агентами");
            string commandExit = "выход";
            string commandNotFound = "!!! В словаре нет такого слова.";
            string clientInput;
            Console.WriteLine("Введите слово для поиска в словаре.\nЧтобы выйти напишите - " + commandExit);

            do
            {
                clientInput = Console.ReadLine();

                if (dictionary.ContainsKey(clientInput.ToLower()))
                {
                    Console.WriteLine(dictionary[clientInput]);
                }
                else
                {
                    Console.WriteLine(commandNotFound);
                }
            }
            while (clientInput != commandExit);
        }
    }
}