using System;
using System.Collections.Generic;

namespace CSLight1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string wordToExit = "exit";
            string clientInputCompletion = "";
            string clientInput1 = "";
            string clientInput2 = "";
            int countСonversionsCurrency;
            float rubToUsd = 75.0f;
            float usdToRub = 0.0133f;
            float rubToEur = 80.0f;
            float eurToRub = 0.0125f;
            float usdToEur = 0.9375f;
            float eurToUsd = 1.0666f;
            const string nameCurrencyUSD = "USD";
            const string nameCurrencyEUR = "EUR";
            const string nameCurrencyRUB = "RUB";
            Console.Write("Сколько у вас RUB: ");
            float clientRub = Convert.ToSingle(Console.ReadLine());
            Console.Write("Сколько у вас EUR: ");
            float clientEur = Convert.ToSingle(Console.ReadLine());
            Console.Write("Сколько у вас USD: ");
            float clientUsd = Convert.ToSingle(Console.ReadLine());

            while (clientInputCompletion != wordToExit)
            {
                Console.WriteLine("Для выхода введите - exit. Или нажмите Enter.");
                clientInputCompletion = Console.ReadLine();

                if (clientInputCompletion != wordToExit)
                {
                    Console.Write("Какую валюту вы хотите обменять (RUB, EUR, USD): ");
                    clientInput1 = Console.ReadLine();
                    Console.Write("В какую валюту хотите сделать обмен: ");
                    clientInput2 = Console.ReadLine();

                    switch (clientInput1)
                    {
                        case nameCurrencyUSD:

                            switch (clientInput2)
                            {
                                case nameCurrencyRUB:
                                    Console.Write("Сколько меняете " + clientInput1 + ": ");
                                    countСonversionsCurrency = Convert.ToInt32(Console.ReadLine());
                                    clientUsd -= countСonversionsCurrency;
                                    clientRub += countСonversionsCurrency * rubToUsd;
                                    break;
                                case nameCurrencyEUR:
                                    Console.Write("Сколько меняете " + clientInput1 + ": ");
                                    countСonversionsCurrency = Convert.ToInt32(Console.ReadLine());
                                    clientUsd -= countСonversionsCurrency;
                                    clientEur += countСonversionsCurrency * eurToUsd;
                                    break;
                                default:
                                    Console.WriteLine("Мы не можем конвертировать в эту валюту! У нас такой нет!");
                                    break;
                            }

                            break;
                        case nameCurrencyEUR:

                            switch (clientInput2)
                            {
                                case nameCurrencyRUB:
                                    Console.Write("Сколько меняете " + clientInput1 + ": ");
                                    countСonversionsCurrency = Convert.ToInt32(Console.ReadLine());
                                    clientEur -= countСonversionsCurrency;
                                    clientRub += countСonversionsCurrency * rubToEur;
                                    break;
                                case nameCurrencyUSD:
                                    Console.Write("Сколько меняете " + clientInput1 + ": ");
                                    countСonversionsCurrency = Convert.ToInt32(Console.ReadLine());
                                    clientEur -= countСonversionsCurrency;
                                    clientUsd += countСonversionsCurrency * usdToEur;
                                    break;
                                default:
                                    Console.WriteLine("Мы не можем конвертировать в эту валюту! У нас такой нет!");
                                    break;
                            }

                            break;
                        case nameCurrencyRUB:

                            switch (clientInput2)
                            {
                                case nameCurrencyUSD:
                                    Console.Write("Сколько меняете " + clientInput1 + ": ");
                                    countСonversionsCurrency = Convert.ToInt32(Console.ReadLine());
                                    clientRub -= countСonversionsCurrency;
                                    clientUsd += countСonversionsCurrency * usdToRub;
                                    break;
                                case nameCurrencyEUR:
                                    Console.Write("Сколько меняете " + clientInput1 + ": ");
                                    countСonversionsCurrency = Convert.ToInt32(Console.ReadLine());
                                    clientRub -= countСonversionsCurrency;
                                    clientEur += countСonversionsCurrency * eurToRub;
                                    break;
                                default:
                                    Console.WriteLine("Мы не можем конвертировать в эту валюту! У нас такой нет!");
                                    break;
                            }

                            break;
                        default:
                            Console.WriteLine("Мы не можем конвертировать эту валюту! У нас такой нет!");
                            break;
                    }

                    Console.WriteLine("Баланс: " + clientRub + " Рублей; " + clientEur + " Евро; " + clientUsd + " Долларов;");
                }
            }
        }
    }
}