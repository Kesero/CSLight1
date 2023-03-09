using System;

namespace CSLight1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float cristallPrice = 5.6f;
            Console.WriteLine("Добро пожаловать в магазин покупки кристаллов!");
            Console.Write("Введите кол-во монет персонажа: ");
            float playerCountCoins = Convert.ToSingle(Console.ReadLine());
            Console.Write("Цена кристаллов: " + productCristallPrice + "/1шт. " + " Сколько кристаллов вы хотите купить: ");
            int playerCountCristall = Convert.ToInt32(Console.ReadLine());
            playerCountCoins -= playerCountCristall * productCristallPrice;
            Console.WriteLine($"Кол-во купленных кристаллов: {playerCountCristall}  Баланс: {playerCountCoins}");
            Console.ReadKey();
        }
    }
}
