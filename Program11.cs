using System;

namespace CSLight1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string wordCompletion = "exit";
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
            Console.Write("Сколько у вас RUB: ");
            float clientRub = Convert.ToSingle(Console.ReadLine());
            Console.Write("Сколько у вас EUR: ");
            float clientEur = Convert.ToSingle(Console.ReadLine());
            Console.Write("Сколько у вас USD: ");
            float clientUsd = Convert.ToSingle(Console.ReadLine());
            while (clientInputCompletion != wordCompletion)
            {
                Console.WriteLine("Для выхода введите - exit. Или нажмите Enter.");
                clientInputCompletion = Console.ReadLine();
                if (clientInputCompletion != "exit")
                {
                    Console.Write("Какую валюту вы хотите обменять (RUB, EUR, USD): ");
                    clientInput1 = Console.ReadLine();
                    Console.Write("В какую валюту хотите сделать обмен: ");
                    clientInput2 = Console.ReadLine();
                    switch (clientInput1)
                    {
                        case "USD":
                            switch (clientInput2)
                            {
                                case "RUB":
                                    Console.Write("Сколько меняете " + clientInput1 + ": ");
                                    countСonversionsCurrency = Convert.ToInt32(Console.ReadLine());
                                    clientUsd -= countСonversionsCurrency;
                                    clientRub += countСonversionsCurrency * rubToUsd;
                                    break;
                                case "EUR":
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
                        case "EUR":
                            switch (clientInput2)
                            {
                                case "RUB":
                                    Console.Write("Сколько меняете " + clientInput1 + ": ");
                                    countСonversionsCurrency = Convert.ToInt32(Console.ReadLine());
                                    clientEur -= countСonversionsCurrency;
                                    clientRub += countСonversionsCurrency * rubToEur;
                                    break;
                                case "USD":
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
                        case "RUB":
                            switch (clientInput2)
                            {
                                case "USD":
                                    Console.Write("Сколько меняете " + clientInput1 + ": ");
                                    countСonversionsCurrency = Convert.ToInt32(Console.ReadLine());
                                    clientRub -= countСonversionsCurrency;
                                    clientUsd += countСonversionsCurrency * usdToRub;
                                    break;
                                case "EUR":
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
                    Console.WriteLine("Баланс: " + clientRub + " Рублей; " +  clientEur + " Евро; " + clientUsd + " Долларов;");
                }
            }
        }
    }
}