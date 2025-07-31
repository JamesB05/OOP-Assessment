using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assessment
{
    //Sets up dungeon layout, linking multiple rooms to eachother
    public class Map
    {

        //the room where the player starts their adventure
        public Rooms StartingRoom { get; private set; }

        //constructor calls mapbuild to create structure when map is instantiated
        public Map()
        {
            MapBuild();
        }

        //builds the connected rooms, adds items and monsters to the rooms and sets starting point as the entrance
        private void MapBuild()
        {
            //creates unique rooms and pairs it with their descriptions
            Rooms Entrance = new Rooms("Entry Hall", "You feel cold air all around you. The decrepid stone walls fill you with unease.");
            Rooms TortureChamber = new Rooms("Torture Chamber", "The smell of dried blood and decay infests your nostrils. You can hear the disembodied whispers of the adventurers before");
            Rooms TreasureRoom = new Rooms("Treasure Room", "The room is filled with gems and jewels, the sparkling lights are almost blinding");
            Rooms Armoury = new Rooms("Armoury", "Armour and rusty weapons lay bare on the ground, you think about the fate of the previous owners.");
            Rooms ThroneRoom = new Rooms("Throne Room", "You see a gigantic throne before you and feel a powerful presence closing in.");

            //links rooms by defining exits for each room
            Entrance.AddExit("north", Armoury);
            Armoury.AddExit("south", Entrance);
            Armoury.AddExit("west", TortureChamber);
            TortureChamber.AddExit("east", Armoury);
            TortureChamber.AddExit("west", TreasureRoom);
            TreasureRoom.AddExit("east", TortureChamber);
            TortureChamber.AddExit("up", ThroneRoom);
            ThroneRoom.AddExit("down", TortureChamber);

            //adds speicified items to their corresponding rooms
            Armoury.Items.Add(new Weapons("Sharp Sword", 10));
            TortureChamber.Items.Add(new Potions("Healing Elixir", 20));
            TreasureRoom.Items.Add(new Weapons("Royal Scepter", 35));

            //adds monsters to speicifc rooms
            TortureChamber.Monsters.Add(new Orc());
            ThroneRoom.Monsters.Add(new Beholder());

            //sets players starting point as the entrance
            StartingRoom = Entrance;

        }
    }
}
