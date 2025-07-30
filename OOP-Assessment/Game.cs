using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assessment
{
    public class Game
    {
        private Player player;
        private Rooms currentRoom;
        private Map map;
        private Statistics stats;

        public Game()
        {
            map = new Map();
            stats = new Statistics();
        }

        private bool isPlayerAlive = true;

        public void Start()
        {
            Console.WriteLine("Welcome brave adventurer, please tell me your name: ");
            string name = Console.ReadLine();
            player = new Player(name);
            currentRoom = map.StartingRoom;

            Console.WriteLine($"\nGreetings, {name}! Your quest awaits...\n");

            while (isPlayerAlive)
            {
                currentRoom.Describe();
                Console.WriteLine("\n what would you like to do? > ");
                string input = Console.ReadLine().ToLower();
                HandleCommand(input);
            }

            Console.WriteLine("\nGame over. press any key to exit...");
            Console.ReadKey();
        }

        private void HandleCommand(string input)
        {
            string[] parts = input.Split(' ');
            string command = parts[0];

            switch (command)
            {
                case "go":
                    if (parts.Length > 1)
                    {
                        Move(parts[1]);
                    }
                    else Console.WriteLine("Go where?");
                    break;

                case "inventory":
                    player.inventory.ListItems();
                    break;

                case "attack":
                    if (currentRoom.Monsters.Count > 0)
                    {
                        var monster = currentRoom.Monsters.First();
                        player.Attack(monster);
                        if (monster.Health <= 0)
                        {
                            currentRoom.Monsters.Remove(monster);
                            stats.MonstersDefeated++;
                        }
                    }
                    else Console.WriteLine("Theres nothing dangerous here");
                    break;

                case "pickup":
                    if (currentRoom.Items.Count > 0)
                    {
                        var items = currentRoom.Items.First();
                        player.inventory.AddItems(items);
                        currentRoom.Items.Remove(items);
                    }
                    else Console.WriteLine("There is nothing to pickup");
                    break;

                case "use":
                    if (parts.Length > 1)
                        player.UseItem(string.Join(" ", parts.Skip(1)));
                    else
                        Console.WriteLine("Use what?");
                    break;

                case "stats":
                    stats.ShowStats();
                    break;

                case "help":
                    Console.WriteLine("Need some help? No worries heres some commands: go [direction], attack; pickup; use [item],inventory, stats, help, quit");
                    break;

                case "quit":
                    Console.WriteLine("Thanks for playing. Until next time, brave one");
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Unknown command. Type 'help' for commands");
                    break;

            }
        }

        private void Move(string direction)
        {
            var nextRoom = currentRoom.GetExit(direction);
            if (nextRoom != null)
            {
                currentRoom = nextRoom;
                if (currentRoom.Monsters.Count > 0)
                {
                    foreach (var monster in currentRoom.Monsters)
                    {
                        Console.WriteLine($"{monster.Name} looks aggresive!");

                        monster.Attack(player);

                        if (player.Health <= 0)
                        {
                            Console.WriteLine("You have been slain by the Monster!");
                            Console.WriteLine("if you wish to retry please quit and restart");
                            isPlayerAlive = false;
                            return;
                        }
                    }
                }
                stats.RoomsVisited++;
            }
            else
            {
                Console.WriteLine("You shall not pass! (Please choose another way)");
            }
        }
    }
}
