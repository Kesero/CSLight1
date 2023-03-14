using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLight1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string CommandToSetName = "setname";
            const string CommandToSetAge = "setage";
            const string CommandToSetPassword = "setpassword";
            const string CommandToViewProfile = "profile";
            const string CommandToHelp = "help";

            string commandToExit = "esc";
            string clientInput = "";
            string clientName = "";
            string clientAge = "";
            string clientPassword = "";

            while (clientInput != commandToExit)
            {
                Console.WriteLine("Список команд - *help*.");
                clientInput = Console.ReadLine();

                if (clientInput != commandToExit)
                {
                    switch (clientInput)
                    {
                        case CommandToHelp:
                            Console.WriteLine();
                            Console.WriteLine("----- Доступные команды -----");
                            Console.WriteLine(commandToExit + " - Выход");
                            Console.WriteLine(CommandToSetName + " - установить своё имя");
                            Console.WriteLine(CommandToSetAge + " - установить свой возраст");
                            Console.WriteLine(CommandToSetPassword + " - установить новый пароль");
                            Console.WriteLine(CommandToViewProfile + " - просмотреть свой профиль");
                            Console.WriteLine("----- Доступные команды -----");
                            Console.WriteLine();
                            break;

                        case CommandToSetName:
                            Console.Write("Выше имя: ");
                            clientName = Console.ReadLine();
                            break;

                        case CommandToSetAge:
                            Console.Write("Ваш возраст: ");
                            clientAge = Console.ReadLine();
                            break;

                        case CommandToSetPassword:
                            Console.Write("Ваш новый пароль: ");
                            clientPassword = Console.ReadLine();
                            break;

                        case CommandToViewProfile:
                            if ((clientName != "") && (clientAge != "") && (clientPassword != ""))
                            {
                                Console.Write("Введите пароль: ");
                                string inputPassword = Console.ReadLine();

                                if (inputPassword == clientPassword)
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("----- Ваш профиль -----");
                                    Console.WriteLine("Имя: " + clientName);
                                    Console.WriteLine("Возраст: " + clientAge);
                                    Console.WriteLine("Актуальный пароль: " + clientPassword);
                                    Console.WriteLine("----- Ваш профиль -----");
                                    Console.WriteLine();
                                }
                                else
                                {
                                    Console.WriteLine("Неверный пароль!");
                                }
                            }
                            else
                            {
                                if (clientName == "")
                                {
                                    Console.WriteLine("Для просмотра профиля вам нужно ввести своё имя *setname*.");
                                }

                                if (clientAge == "")
                                {
                                    Console.WriteLine("Для просмотра профиля вам нужно ввести свой возраст *setage*.");
                                }

                                if (clientPassword == "")
                                {
                                    Console.WriteLine("Для просмотра профиля вам нужно ввести свой новый пароль *setpassword*.");
                                }
                            }

                            break;

                        default:
                            Console.WriteLine("Несуществующая команда.");
                            break;
                    }
                }
            }
        }
    }
}