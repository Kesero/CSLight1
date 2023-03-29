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
                        if (clientInput != commandExit)
                        {
                            Console.WriteLine("Несуществующая команда...");
                        }
                        break;
                }
            }
        }

        static void AddDossier(ref string[] workersInitials, ref string[] workersPosts)
        {
            Console.Clear();
            string[] tempWorkersInitials = new string[workersInitials.Length + 1];
            string[] tempWorkersPosts = new string[workersPosts.Length + 1];

            for (int i = 0; i < workersInitials.Length; i++)
            {
                tempWorkersInitials[i] = workersInitials[i];
                tempWorkersPosts[i] = workersPosts[i];
            }

            Console.Write("Введите ФИО нового работника: ");
            string workerInitial = Console.ReadLine();
            Console.Write("Введите Должность нового работника: ");
            string workerPost = Console.ReadLine();
            tempWorkersInitials[tempWorkersInitials.Length - 1] = workerInitial;
            tempWorkersPosts[tempWorkersPosts.Length - 1] = workerPost;
            workersInitials = tempWorkersInitials;
            workersPosts = tempWorkersPosts;
        }

        static void ShowAllDossiers(string[] workersInitials, string[] workersPosts)
        {
            Console.Clear();

            for (int i = 0; i < workersInitials.Length; i++)
            {
                Console.WriteLine(i + " | " + workersInitials[i] + " - " + workersPosts[i]);
            }
        }

        static void RemoveDossier(ref string[] workersInitials, ref string[] workersPosts)
        {
            Console.Clear();
            string[] tempWorkersInitials = new string[workersInitials.Length - 1];
            string[] tempWorkersPosts = new string[workersPosts.Length - 1];
            Console.Write("Номер удаляемого досье: ");
            int numberOfDeletDosier = Convert.ToInt32(Console.ReadLine());

            if (numberOfDeletDosier > -1 && numberOfDeletDosier < workersInitials.Length)
            {
                for (int i = 0; i < workersInitials.Length; i++)
                {
                    if (i > numberOfDeletDosier)
                    {
                        workersInitials[i - 1] = workersInitials[i];
                        workersPosts[i - 1] = workersPosts[i];
                    }
                }

                for (int i = 0; i < tempWorkersInitials.Length; i++)
                {
                    tempWorkersInitials[i] = workersInitials[i];
                    tempWorkersPosts[i] = workersPosts[i];
                }

                workersInitials = tempWorkersInitials;
                workersPosts = tempWorkersPosts;
            }
            else
            {
                Console.WriteLine("Досье с таким номером нету...");
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

            if (!haveInputSurname)
            {
                Console.WriteLine("Работника с такой фамилии нету!");
            }
        }
    }
}