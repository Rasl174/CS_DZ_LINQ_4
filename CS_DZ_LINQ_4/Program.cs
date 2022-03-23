using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_DZ_LINQ_4
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isWork = true;

            List<Player> players = new List<Player> { new Player("Player46272394", 2, 3), new Player("Амбал99", 45, 76), new Player("Жук_Иван", 89, 89), new Player("Игрок№1", 5, 8),
            new Player("Курюха", 51, 68), new Player("Mozzy", 61, 74), new Player("Furia", 14, 84), new Player("Donate_Maker", 5, 99), new Player("Power_Ranger", 56, 41),
            new Player("Альберт_Иванович_2000", 4, 10) };

            while (isWork)
            {
                Console.WriteLine("Для вывода топ 3 игроков по уровню введите 1 или уровень");
                Console.WriteLine("Для вывода топ 3 игроков по силе введите 2 или сила");
                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                    case "уровень":
                        SortiredLevel(players);
                        break;
                    case "2":
                    case "сила":
                        SortiredStrength(players);
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Ошибка не верно введен запрос! Повторите попытку");
                        Console.ReadKey();
                        break;
                }
            }
        }

        static void SortiredLevel(List<Player> players)
        {
            Console.Clear();

            var sortiredLevelPlayers = players.OrderByDescending(player => player.Level).Take(3).ToList();

            ShowSortiredPlayers(sortiredLevelPlayers);
        }

        static void SortiredStrength(List<Player> players)
        {
            Console.Clear();

            var sortiredStrengthPlayers = players.OrderByDescending(player => player.Strength).Take(3).ToList();

            ShowSortiredPlayers(sortiredStrengthPlayers);
        }

        static void ShowSortiredPlayers(List<Player> players)
        {
            foreach (var player in players)
            {
                Console.WriteLine(player.Name + " " + player.Level + " " + player.Strength);
            }
            Console.ReadKey();
            Console.Clear();
        }
    }

    class Player
    {
        public string Name { get; private set; }

        public int Level { get; private set; }
        
        public int Strength { get; private set; } 

        public Player(string name, int level, int strength)
        {
            Name = name;
            Level = level;
            Strength = strength;
        }
    }
}
