using System;
using System.Collections.Generic;

namespace CSLight1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string commandToExit = "esc";
            const string commandToSetName = "setname";
            const string commandToSetAge = "setage";
            const string commandToSetPassword = "setpassword";
            const string commandToViewProfile = "profile";
            const string commandToHelp = "help";
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
                        case commandToHelp:
                            Console.WriteLine();
                            Console.WriteLine("----- Доступные команды -----");
                            Console.WriteLine(commandToExit + " - Выход");
                            Console.WriteLine(commandToSetName + " - установить своё имя");
                            Console.WriteLine(commandToSetAge + " - установить свой возраст");
                            Console.WriteLine(commandToSetPassword + " - установить новый пароль");
                            Console.WriteLine(commandToViewProfile + " - просмотреть свой профиль");
                            Console.WriteLine("----- Доступные команды -----");
                            Console.WriteLine();
                            break;
                        case commandToSetName:
                            Console.Write("Выше имя: ");
                            clientName = Console.ReadLine();
                            break;
                        case commandToSetAge:
                            Console.Write("Ваш возраст: ");
                            clientAge = Console.ReadLine();
                            break;
                        case commandToSetPassword:
                            Console.Write("Ваш новый пароль: ");
                            clientPassword = Console.ReadLine();
                            break;
                        case commandToViewProfile:

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