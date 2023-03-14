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
            const string CommandConversionCurrencyUSD = "USD";
            const string CommandConversionCurrencyEUR = "EUR";
            const string CommandConversionCurrencyRUB = "RUB";

            float rubToUsd = 75.0f;
            float usdToRub = 0.0133f;
            float rubToEur = 80.0f;
            float eurToRub = 0.0125f;
            float usdToEur = 0.9375f;
            float eurToUsd = 1.0666f;
            string wordToExit = "exit";
            string clientInputCompletion = "";
            string clientInput1 = "";
            string clientInput2 = "";
            int countСonversionsCurrency;
            Console.Write("Сколько у вас RUB: ");
            float clientRub = Convert.ToSingle(Console.ReadLine());
            Console.Write("Сколько у вас EUR: ");
            float clientEur = Convert.ToSingle(Console.ReadLine());
            Console.Write("Сколько у вас USD: ");
            float clientUsd = Convert.ToSingle(Console.ReadLine());

            while (clientInputCompletion != wordToExit)
            {
                Console.Write("Какую валюту вы хотите обменять (RUB, EUR, USD): ");
                clientInput1 = Console.ReadLine();
                Console.Write("В какую валюту хотите сделать обмен: ");
                clientInput2 = Console.ReadLine();

                switch (clientInput1)
                {
                    case CommandConversionCurrencyUSD:
                        switch (clientInput2)
                        {
                            case CommandConversionCurrencyRUB:
                                Console.Write("Сколько меняете " + clientInput1 + ": ");
                                countСonversionsCurrency = Convert.ToInt32(Console.ReadLine());

                                if (clientUsd <= countСonversionsCurrency)
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("!! Для данной конверции не хватает " +
                                        (countСonversionsCurrency - clientUsd) + " " + clientInput1);
                                }
                                else
                                {
                                    clientUsd -= countСonversionsCurrency;
                                    clientRub += countСonversionsCurrency * rubToUsd;
                                }

                                break;

                            case CommandConversionCurrencyEUR:
                                Console.Write("Сколько меняете " + clientInput1 + ": ");
                                countСonversionsCurrency = Convert.ToInt32(Console.ReadLine());

                                if (clientUsd <= countСonversionsCurrency)
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("!! Для данной конверции не хватает " +
                                        (countСonversionsCurrency - clientUsd) + " " + clientInput1);
                                }
                                else
                                {
                                    clientUsd -= countСonversionsCurrency;
                                    clientEur += countСonversionsCurrency * eurToUsd;
                                }

                                break;

                            default:
                                Console.WriteLine("Мы не можем конвертировать в эту валюту! У нас такой нет!");
                                break;
                        }

                        break;

                    case CommandConversionCurrencyEUR:
                        switch (clientInput2)
                        {
                            case CommandConversionCurrencyRUB:
                                Console.Write("Сколько меняете " + clientInput1 + ": ");
                                countСonversionsCurrency = Convert.ToInt32(Console.ReadLine());

                                if (clientEur <= countСonversionsCurrency)
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("!! Для данной конверции не хватает " +
                                        (countСonversionsCurrency - clientEur) + " " + clientInput1);
                                }
                                else
                                {
                                    clientEur -= countСonversionsCurrency;
                                    clientRub += countСonversionsCurrency * rubToEur;
                                }

                                break;

                            case CommandConversionCurrencyUSD:
                                Console.Write("Сколько меняете " + clientInput1 + ": ");
                                countСonversionsCurrency = Convert.ToInt32(Console.ReadLine());

                                if (clientEur <= countСonversionsCurrency)
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("!! Для данной конверции не хватает " +
                                        (countСonversionsCurrency - clientEur) + " " + clientInput1);
                                }
                                else
                                {
                                    clientEur -= countСonversionsCurrency;
                                    clientUsd += countСonversionsCurrency * usdToEur;
                                }

                                break;

                            default:
                                Console.WriteLine("Мы не можем конвертировать в эту валюту! У нас такой нет!");
                                break;
                        }

                        break;

                    case CommandConversionCurrencyRUB:
                        switch (clientInput2)
                        {
                            case CommandConversionCurrencyUSD:
                                Console.Write("Сколько меняете " + clientInput1 + ": ");
                                countСonversionsCurrency = Convert.ToInt32(Console.ReadLine());

                                if (clientRub <= countСonversionsCurrency)
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("!! Для данной конверции не хватает " +
                                        (countСonversionsCurrency - clientRub) + " " + clientInput1);
                                }
                                else
                                {
                                    clientRub -= countСonversionsCurrency;
                                    clientUsd += countСonversionsCurrency * usdToRub;
                                }

                                break;

                            case CommandConversionCurrencyEUR:
                                Console.Write("Сколько меняете " + clientInput1 + ": ");
                                countСonversionsCurrency = Convert.ToInt32(Console.ReadLine());

                                if (clientRub <= countСonversionsCurrency)
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("!! Для данной конверции не хватает " +
                                        (countСonversionsCurrency - clientRub) + " " + clientInput1);
                                }
                                else
                                {
                                    clientRub -= countСonversionsCurrency;
                                    clientEur += countСonversionsCurrency * eurToRub;
                                }

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

                Console.WriteLine();
                Console.WriteLine("Баланс: " + clientRub + " Рублей; " + clientEur + " Евро; " + clientUsd + " Долларов;");
                Console.WriteLine();
                Console.WriteLine("Для выхода введите - exit. Или нажмите Enter.");
                clientInputCompletion = Console.ReadLine();
            }
        }
    }
}
