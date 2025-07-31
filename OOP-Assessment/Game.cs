using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assessment
{
    //The game class handles the main game loop, player input and game state
    public class Game
    {
        private Player player; // player character
        private Rooms currentRoom; //current room player is in
        private Map map; //dungeon map
        private Statistics stats; //tracks gameplay stats

        //initialises map and statistics
        public Game()
        {
            map = new Map();
            stats = new Statistics();
        }

        private bool isPlayerAlive = true; //controls main game loop

        //starts the game, manages player interaction
        public void Start()
        {
            Console.WriteLine("Welcome brave adventurer, please tell me your name: ");
            string name = Console.ReadLine();
            player = new Player(name); //creates a new player with inputs given by user
            currentRoom = map.StartingRoom;

            Console.WriteLine($"\nGreetings, {name}! Your quest awaits...\n");

            //Main game loop, checks player is still alive and runs until player dies
            while (isPlayerAlive)
            {
                currentRoom.Describe(); //shows room details
                Console.WriteLine("\n what would you like to do? > ");
                string input = Console.ReadLine().ToLower();
                HandleCommand(input); //processes player inputs
            }

            //game over message outputted when player dies, waits for key press from player before closing game
            Console.WriteLine("\nGame over. press any key to exit...");
            Console.ReadKey();
        }

        //interprets and handles player inputs
        private void HandleCommand(string input)
        {
            string[] parts = input.Split(' ');
            string command = parts[0];

            switch (command)
            {
                case "go":
                    if (parts.Length > 1)
                    {
                        Move(parts[1]); //moves player in given direction
                    }
                    else Console.WriteLine("Go where?");
                    break;

                case "inventory":
                    player.inventory.ListItems(); //displays player inventory items
                    break;

                case "attack":
                    if (currentRoom.Monsters.Count > 0)
                    {
                        var monster = currentRoom.Monsters.First();
                        player.Attack(monster); //player attacks first monster in room
                        if (monster.Health <= 0)
                        {
                            currentRoom.Monsters.Remove(monster); //removes defeated monster from room
                            stats.MonstersDefeated++; //updates player stats
                        }
                    }
                    else Console.WriteLine("Theres nothing dangerous here");
                    break;

                case "pickup":
                    if (currentRoom.Items.Count > 0)
                    {
                        var items = currentRoom.Items.First();
                        player.inventory.AddItems(items); //adds first item in room to player inventory
                        currentRoom.Items.Remove(items); //Removes item from room
                    }
                    else Console.WriteLine("There is nothing to pickup");
                    break;

                case "use":
                    if (parts.Length > 1)
                        player.UseItem(string.Join(" ", parts.Skip(1))); //uses specified item from inventory
                    else
                        Console.WriteLine("Use what?");
                    break;

                case "stats":
                    stats.ShowStats(); //displays current game stats
                    break;

                case "help":
                    Console.WriteLine("Need some help? No worries heres some commands: go [direction], attack; pickup; use [item],inventory, stats, help, quit");
                    break;

                case "quit":
                    Console.WriteLine("Thanks for playing. Until next time, brave one");
                    Environment.Exit(0); //Quits game immediately
                    break;

                default:
                    Console.WriteLine("Unknown command. Type 'help' for commands");
                    break;

            }
        }

        //moves player character to specified adjacent room if it exists
        private void Move(string direction)
        {
            var nextRoom = currentRoom.GetExit(direction);
            if (nextRoom != null)
            {
                currentRoom = nextRoom;
                if (currentRoom.Monsters.Count > 0)
                {
                    foreach (var monster in currentRoom.Monsters) //if there are monsters in the room the player enters, they will attack the player
                    {
                        Console.WriteLine($"{monster.Name} looks aggresive!");

                        monster.Attack(player); 

                        //if player health drops to zero, the game loop ends
                        if (player.Health <= 0)
                        {
                            Console.WriteLine("You have been slain by the Monster!");
                            Console.WriteLine("if you wish to retry please quit and restart");
                            isPlayerAlive = false; //stops main game loop
                            return;
                        }
                    }
                }
                stats.RoomsVisited++; //rooms visited counter
            }
            else
            {
                Console.WriteLine("You shall not pass! (Please choose another way)"); //informs player there is no room in the direction specified
            }
        }
    }
}
