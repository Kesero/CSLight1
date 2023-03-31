using System;

namespace CSHomeWork1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string CommandAddDossier = "add";
            const string CommandShowAllDossiers = "show";
            const string CommandRemoveDossier = "remove";
            const string CommandSearchSurname = "search";

            string[] workersInitials = new string[0];
            string[] workersPosts = new string[0];
            string commandExit = "exit";
            string clientInput = "";
            char symbolSeparation = ' ';

            while (clientInput != commandExit)
            {
                Console.WriteLine($"\n------- Commands -------" +
                $"\n{CommandAddDossier} - добавить досье" +
                $"\n{CommandShowAllDossiers} - показать список досье" +
                $"\n{CommandRemoveDossier} - удалить досье" +
                $"\n{CommandSearchSurname} - поиск досье по фамилии" +
                $"\n{commandExit} - выход\n");
                clientInput = Console.ReadLine();

                switch (clientInput)
                {
                    case CommandAddDossier:
                        AddDossier(ref workersInitials, ref workersPosts);
                        break;
                    case CommandShowAllDossiers:
                        ShowAllDossiers(workersInitials, workersPosts);
                        break;
                    case CommandRemoveDossier:
                        RemoveDossier(ref workersInitials, ref workersPosts);
                        break;
                    case CommandSearchSurname:
                        SearchSurname(symbolSeparation, workersInitials, workersPosts);
                        break;
                    default:
                        CheckCommandToExit(clientInput, commandExit);
                        break;
                }
            }
        }

        static void AddDossier(ref string[] workersInitials, ref string[] workersPosts)
        {
            Console.Clear();
            workersInitials = resizeArray(workersInitials, 1);
            workersPosts = resizeArray(workersPosts, 1);

            Console.Write("Введите ФИО нового работника: ");
            string workerInitial = Console.ReadLine();
            Console.Write("Введите Должность нового работника: ");
            string workerPost = Console.ReadLine();
            workersInitials[workersInitials.Length - 1] = workerInitial;
            workersPosts[workersPosts.Length - 1] = workerPost;
        }

        static void RemoveDossier(ref string[] workersInitials, ref string[] workersPosts)
        {
            Console.Clear();
            Console.Write("Номер удаляемого досье: ");
            int numberOfDeletDosier = Convert.ToInt32(Console.ReadLine());

            if (numberOfDeletDosier >= 0 && numberOfDeletDosier < workersInitials.Length)
            {
                workersInitials = resizeArray(workersInitials, -1, numberOfDeletDosier);
                workersPosts = resizeArray(workersPosts, -1, numberOfDeletDosier);
            }
            else
            {
                Console.WriteLine("Досье с таким номером нету...");
            }
        }

        static void ShowAllDossiers(string[] workersInitials, string[] workersPosts)
        {
            Console.Clear();

            for (int i = 0; i < workersInitials.Length; i++)
            {
                Console.WriteLine(i + " | " + workersInitials[i] + " - " + workersPosts[i]);
            }
        }

        static void SearchSurname(char symbolSeparation, string[] workersInitials, string[] workersPosts)
        {
            Console.Clear();
            Console.Write("Введите фамилию для поиска: ");
            string searchSurname = Console.ReadLine();
            bool haveInputSurname = false;

            for (int i = 0; i < workersInitials.Length; i++)
            {
                string[] workerInitialArray = workersInitials[i].Split(symbolSeparation);

                if (workerInitialArray[0] == searchSurname)
                {
                    Console.WriteLine(i + " | " + workersInitials[i] + " - " + workersPosts[i]);
                    haveInputSurname = true;
                }
            }

            if (haveInputSurname == false)
            {
                Console.WriteLine("Работника с такой фамилии нету!");
            }
        }

        static void CheckCommandToExit(string anyCommand, string commandExit)
        {
            if (anyCommand != commandExit)
            {
                Console.WriteLine("Несуществующая команда...");
            }
        }

        static string[] resizeArray(string[] originalArray, int countNewIndexes, int numberRemoveIndex = -1)
        {
            string[] tempArray = new string[originalArray.Length + countNewIndexes];

            if (numberRemoveIndex == -1)
            {
                for (int i = 0; i < originalArray.Length; i++)
                {
                    tempArray[i] = originalArray[i];
                }
            }
            else
            {
                for (int i = 0; i < numberRemoveIndex; i++)
                {
                    tempArray[i] = originalArray[i];
                }

                for (int i = numberRemoveIndex; i < tempArray.Length; i++)
                {
                    tempArray[i] = originalArray[i + 1];
                }
            }

            return tempArray;
        }
    }
}