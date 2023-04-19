using System;
using System.Collections.Generic;
using System.Web;

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
                $"\n{CommandShowAllDosier} - показать все досье +" +
                $"\n{commandExit} - выход");
                clientInput = Console.ReadLine();

                switch (clientInput) 
                {
                    case CommandAddDosier:
                        AddDosier(ref dossier);
                        break;

                    case CommandRemoveDosier:
                        RomoveDosier(ref dossier);
                        break;

                    case CommandShowAllDosier:
                        ShowAllDosier(dossier);
                        break;
                    default:
                        Console.WriteLine("Несуществуюшая команда.");
                        break;
                }
            }
            while (clientInput != commandExit);
        }

        static void AddDosier(ref Dictionary<string, string> dossier)
        {
            Console.Clear();
            Console.Write("Введите инициалы нового работника: ");
            string initialsOfWorker = Console.ReadLine();
            Console.Write("Введите должность нового работника: ");
            string postOfWorker = Console.ReadLine();
            dossier.Add(initialsOfWorker, postOfWorker);
        }

        static void RomoveDosier(ref Dictionary<string, string> dossier)
        {
            Console.Clear();
            Console.Write("Введите инициалы увольняемого работника: ");
            string initialsOfWorker = Console.ReadLine();
            dossier.Remove(initialsOfWorker);
        }

        static void ShowAllDosier(Dictionary<string, string> dossier)
        {
            Console.Clear();

            foreach (var worker in dossier)
            {
                Console.WriteLine(worker.Key + " - " + worker.Value);
            }

            Console.ReadKey();
        }
    }
}