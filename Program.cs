using System;

namespace CSLight1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите ваше игровое имя: ");
            string playerName = Console.ReadLine();
            Console.Write("Введите возраст персонажа: ");
            byte playerAge = Convert.ToByte(Console.ReadLine());
            Console.Write("Введите рост персонажа: ");
            ushort playerHeight = Convert.ToUInt16(Console.ReadLine());
            Console.Write("Введите стартовое кол-во монет персонажа ");
            int playerCountCoins = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите знак рассовой пренадлежности (первая буква называния расы)");
            char playerRace = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("...Информация о созданном персонаже... ");
            Console.WriteLine("Имя: " + playerName);
            Console.WriteLine("Возраст: " + playerAge);
            Console.WriteLine("Рост: " + playerHeight);
            Console.WriteLine("Знак рассы: " + playerRace);
            Console.WriteLine();
            Console.WriteLine("Баланс: " + playerCountCoins);
            Console.WriteLine("^^^Информация о созданном персонаже^^^");
            Console.WriteLine();
            Console.WriteLine("Вам потребуется стартовый набор материалов, купите их!");
            int productScrapСount = 100;
            float productScrapPrice = 5.6f;
            Console.Write("Сколько хотите купить металлолома: ");
            int playerCountScrap = Convert.ToInt32(Console.ReadLine());
            bool havePlayerEnoughCoins = (playerCountScrap * productScrapPrice) <= playerCountCoins;
            int havePlayerEnoughCoinsInt = Convert.ToInt32(havePlayerEnoughCoins);
            playerCountScrap *= havePlayerEnoughCoinsInt;
            playerCountCoins -= Convert.ToInt32(havePlayerEnoughCoinsInt * playerCountScrap * productScrapPrice);
            productScrapСount -= havePlayerEnoughCoinsInt * playerCountScrap;
            Console.WriteLine("В магазине осталось: " + productScrapСount);
            Console.WriteLine($"Кол-во металлолома у вас: {playerCountScrap}  Баланс: {playerCountCoins}");
            Console.ReadKey();
        }
    }
}
