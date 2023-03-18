using System;
using System.Collections.Generic;
using System.Linq;
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
            Random random = new Random();
            int maxPlayerHealth = 1000;
            int playerHealth = maxPlayerHealth;
            int playerDamage;
            int bossHealth = 4000;
            int bossDamage;
            string playerInput;
            int countSpirit = 0;
            int damageMultiplier = 1;
            bool havePlayerVulnerability = false;

            while (playerHealth > 0 && bossHealth > 0)
            {
                playerInput = Console.ReadLine();

                switch (playerInput)
                {
                    case "1":
                        playerHealth -= 100;
                        countSpirit++;
                        Console.WriteLine("Вы призвали духа, сейчас духов: " + countSpirit);
                        Console.WriteLine("  -100 вашего здоровья");
                        break;

                    case "2":
                        if (countSpirit > 0)
                        {
                            playerDamage = 100 * countSpirit * damageMultiplier;
                            bossHealth -= playerDamage;
                            Console.WriteLine("  -" + playerDamage + " по Боссу");
                        }
                        else
                        {
                            Console.WriteLine("У вас нет атакующих духов!");
                        }
                        break;

                    case "3":
                        Console.WriteLine("Вы подлечились.");
                        if (playerHealth >= maxPlayerHealth - 125)
                        {
                            playerHealth = maxPlayerHealth;

                        }
                        else
                        {
                            playerHealth += 125;
                        }
                        break;

                    case "4":
                        damageMultiplier++;
                        havePlayerVulnerability = true;
                        Console.WriteLine("Весь урон с вашей стороны увеличен на +100%");
                        Console.WriteLine("Но вы уязвимы, есть шанс на этом ходу получить критический удар и потерять бонус!");
                        break;

                    default:
                        break;
                }

                bool canBossCriticalDamageMake = Convert.ToBoolean(random.Next(2));
                bossDamage = random.Next(50, 150) + Convert.ToInt32(havePlayerVulnerability) * Convert.ToInt32(canBossCriticalDamageMake) * 150;
                playerHealth -= bossDamage;

                if (havePlayerVulnerability && canBossCriticalDamageMake)
                {
                    Console.WriteLine("Босс нанёс тяжёлый удар и сбил вас с ног!");
                    havePlayerVulnerability = false;
                }

                Console.WriteLine("  -" + bossDamage + " по Вам");
                Console.WriteLine("Boss Hp: " + bossHealth);
                Console.WriteLine("Player Hp: " + playerHealth);
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