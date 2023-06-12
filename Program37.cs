using System;
using System.Collections.Generic;
using System.Web;

namespace CSHomeWork1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string CommandShowPlayerList = "show";
            const string CommandAddPlayer = "add";
            const string CommandRemovePlayer = "remove";
            const string CommandBanPlayer = "ban";

            string сommandExit = "exit";
            string clinetInput;

            do
            {
                Console.WriteLine("Команды\n" +
                    $"{CommandShowPlayerList} - вывести список игроков\n" +
                    $"{CommandAddPlayer} - добавить игрока\n" +
                    $"{CommandRemovePlayer} - удалить игрока\n" +
                    $"{CommandBanPlayer} - забанить игрока\n" +
                    $"{сommandExit} - выход");
                clinetInput = Console.ReadLine();

                switch (clinetInput)
                {
                    case CommandShowPlayerList:
                        PlayerList.ShowInfo();
                        break;

                    case CommandAddPlayer:
                        PlayerList.AddPlayer();
                        break;

                    case CommandRemovePlayer:
                        PlayerList.RemovePlayer();
                        break;

                    case CommandBanPlayer:
                        PlayerList.Ban();
                        break;
                }

                Console.Clear();
            }
            while (clinetInput != сommandExit);
        }
    }

    class Player
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public bool IsBanned { get; private set; }
        public int Score { get; private set; }

        public Player(int id, string name)
        {
            Id = id;
            Name = name;
            IsBanned = false;
            Score = 0;
        }

        public void ShowInfo()
        {
            string status = "-";

            if (IsBanned)
            {
                status = "Banned";
            }

            Console.WriteLine($"Id: {Id}  Ник: {Name}  Статус: {status}  Счёт: {Score}");
        }

        public void Ban()
        {
            IsBanned = true;
        }
    }

    class PlayerList
    {
        private static List<Player> Players = new List<Player>();

        public static void AddPlayer()
        {
            Console.Clear();
            Console.Write("Введите id игрока: ");

            if (!int.TryParse(Console.ReadLine(), out int id))
            {
                Console.WriteLine("Неверно введено id нового игрока!");
                Console.Write(" Нажмите любую кнопку...");
                Console.ReadKey();
                return;
            }
            
            if (IsPlayer(id))
            {
                Console.WriteLine("Игрок с таким id уже есть!");
                Console.Write(" Нажмите любую кнопку...");
                Console.ReadKey();
                return;
            }

            Console.Write("Введите ник игрока: ");
            string name = Console.ReadLine();
            Player player = new Player(id, name);
            Players.Add(player);
        }

        public static void RemovePlayer()
        {
            Console.Clear();
            Console.Write("Введите id игрока: ");

            if (!int.TryParse(Console.ReadLine(), out int id))
            {
                Console.WriteLine("Неверно введено id игрока!");
                Console.Write(" Нажмите любую кнопку...");
                Console.ReadKey();
                return;
            }

            if (IsPlayer(id))
            {
                Player player = GetPlayer(id);
                Players.Remove(player);
                return;
            }

            Console.WriteLine("Такого игрока нету!");
            Console.Write(" Нажмите любую кнопку...");
            Console.ReadKey();
        }

        public static bool IsPlayer(int id)
        {
            foreach (Player player in Players)
            {
                if (player.Id == id) return true;
            }

            return false;
        }

        public static Player GetPlayer(int id)
        {
            foreach (Player player in Players)
            {
                if (player.Id == id) return player;
            }

            return null;
        }

        public static void ShowInfo()
        {
            Console.Clear();

            foreach (Player player in Players)
            {
                player.ShowInfo();
            }

            Console.Write(" Нажмите любую кнопку...");
            Console.ReadKey();
        }

        public static void Ban()
        {
            Console.Clear();
            Console.Write("Введите id игрока: ");

            if (!int.TryParse(Console.ReadLine(), out int id))
            {
                Console.WriteLine("Неверно введено id игрока!");
                Console.Write(" Нажмите любую кнопку...");
                Console.ReadKey();
                return;
            }

            if (IsPlayer(id))
            {
                Player player = GetPlayer(id);
                player.Ban();
            }
        }
    }
}