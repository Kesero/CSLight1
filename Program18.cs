using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CSHomeWork1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string commandSpell1 = "spawn";
            const string commandSpell2 = "attack";
            const string commandSpell3 = "health";
            const string commandSpell4 = "buff";

            Random random = new Random();
            int maxPlayerHealth = 1000;
            int playerHealth = maxPlayerHealth;
            int playerDamage;
            int spiritDamage = 100;
            int bossHealth = 4000;
            int bossDamage;
            int minBossDamage = 50;
            int maxBossDamage = 150;
            string playerInput;
            int countSpirit = 0;
            int coefDamageMultiplier = 1;
            bool havePlayerVulnerability = false;
            int countHealthRestored = 300;
            int maxNumberOfRandomBool = 2;
            Console.WriteLine("----- Заклинания -----");
            Console.WriteLine(commandSpell1 + " - призвать духа");
            Console.WriteLine(commandSpell2 + " - атака духами");
            Console.WriteLine(commandSpell3 + " - лечиться (+" + countHealthRestored + "hp)");
            Console.WriteLine(commandSpell4 + " - увеличить урон");
            Console.WriteLine();

            while (playerHealth > 0 && bossHealth > 0)
            {
                playerInput = Console.ReadLine();

                switch (playerInput)
                {
                    case commandSpell1:
                        playerHealth -= spiritDamage;
                        countSpirit++;
                        Console.WriteLine("Вы призвали духа, сейчас духов: " + countSpirit);
                        Console.WriteLine("  -" + spiritDamage + " вашего здоровья");
                        break;

                    case commandSpell2:
                        if (countSpirit > 0)
                        {
                            playerDamage = spiritDamage * countSpirit * coefDamageMultiplier;
                            bossHealth -= playerDamage;
                            Console.WriteLine("  -" + playerDamage + " по Боссу");
                        }
                        else
                        {
                            Console.WriteLine("У вас нет атакующих духов!");
                        }
                        break;

                    case commandSpell3:
                        Console.WriteLine("Вы подлечились.");
                        if (playerHealth >= maxPlayerHealth - countHealthRestored)
                        {
                            playerHealth = maxPlayerHealth;

                        }
                        else
                        {
                            playerHealth += countHealthRestored;
                        }
                        break;

                    case commandSpell4:
                        coefDamageMultiplier++;
                        havePlayerVulnerability = true;
                        Console.WriteLine("Весь урон с вашей стороны увеличен.");
                        Console.WriteLine("Но вы уязвимы, есть шанс на этом ходу получить критический удар и потерять бонус!");
                        break;

                    default:
                        Console.WriteLine("Такого заклинания нету!");
                        break;
                }

                bool canBossCriticalDamageMake = Convert.ToBoolean(random.Next(maxNumberOfRandomBool));
                bossDamage = random.Next(minBossDamage, maxBossDamage) +
                    Convert.ToInt32(havePlayerVulnerability) * Convert.ToInt32(canBossCriticalDamageMake) * maxBossDamage;
                playerHealth -= bossDamage;

                if (havePlayerVulnerability && canBossCriticalDamageMake)
                {
                    Console.WriteLine("Босс нанёс тяжёлый удар и сбил вас с ног!");
                    havePlayerVulnerability = false;
                }

                Console.WriteLine("  -" + bossDamage + " по Вам");
                Console.WriteLine();
                Console.WriteLine("Boss Hp: " + bossHealth);
                Console.WriteLine("Player Hp: " + playerHealth);
                Console.WriteLine();
            }

            if (playerHealth <= 0 && bossHealth <= 0)
            {
                Console.WriteLine("Ничья!");
            }
            else if (playerHealth > 0)
            {
                Console.WriteLine("Вы выиграли!");
            }
            else
            {
                Console.WriteLine("Вы проиграли!");
            }

            Console.ReadKey();
        }
    }
}