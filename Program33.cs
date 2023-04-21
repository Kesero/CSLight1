using System;
using System.Collections.Generic;

namespace CSHomeWork1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string CommandAddDosier = "add";
            const string CommandRemoveDosier = "remove";
            const string CommandShowAllDosier = "show";

            Dictionary<string, string> dossier = new Dictionary<string, string>();
            string commandExit = "exit";
            string clientInput;

            do
            {
                Console.Clear();
                Console.WriteLine($"{CommandAddDosier} - добавить досье" +
                $"\n{CommandRemoveDosier} - удалить досье" +
                $"\n{CommandShowAllDosier} - показать все досье" +
                $"\n{commandExit} - выход");
                clientInput = Console.ReadLine();

                switch (clientInput)
                {
                    case CommandAddDosier:
                        AddDossier(dossier);
                        break;

                    case CommandRemoveDosier:
                        RemoveDossier(dossier);
                        break;

                    case CommandShowAllDosier:
                        ShowAllDossier(dossier);
                        break;

                    default:
                        Console.WriteLine("Несуществуюшая команда.");
                        break;
                }
            }
            while (clientInput != commandExit);
        }

        static void AddDossier(Dictionary<string, string> dossier)
        {
            Console.Clear();
            Console.Write("Введите инициалы нового работника: ");
            string initialsOfWorker = Console.ReadLine();

            if (dossier.ContainsKey(initialsOfWorker))
            {
                Console.WriteLine("Такие инициалы уже есть.");
                Console.ReadKey();
            }
            else
            {
                Console.Write("Введите должность нового работника: ");
                string postOfWorker = Console.ReadLine();
                dossier.Add(initialsOfWorker, postOfWorker);
            }
        }

        static void RemoveDossier(Dictionary<string, string> dossier)
        {
            Console.Clear();
            Console.Write("Введите инициалы увольняемого работника: ");
            string initialsOfWorker = Console.ReadLine();

            if (dossier.ContainsKey(initialsOfWorker))
            {
                dossier.Remove(initialsOfWorker);
            }
            else
            {
                Console.WriteLine("Таких инициалов нет.");
                Console.ReadKey();
            }
        }

        static void ShowAllDossier(Dictionary<string, string> dossier)
        {
            Console.Clear();

            foreach (KeyValuePair<string, string> worker in dossier)
            {
                Console.WriteLine(worker.Key + " - " + worker.Value);
            }

            Console.ReadKey();
        }
    }
}