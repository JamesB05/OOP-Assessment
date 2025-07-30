using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assessment
{
    public class Map
    {
        public Rooms StartingRoom { get; private set; }

        public Map()
        {
            MapBuild();
        }

        private void MapBuild()
        {
            Rooms Entrance = new Rooms("Entry Hall", "You feel cold air all around you. The decrepid stone walls fill you with unease.");
            Rooms TortureChamber = new Rooms("Torture Chamber", "The smell of dried blood and decay infests your nostrils. You can hear the disembodied whispers of the adventurers before");
            Rooms TreasureRoom = new Rooms("Treasure Room", "The room is filled with gems and jewels, the sparkling lights are almost blinding");
            Rooms Armoury = new Rooms("Armoury", "Armour and rusty weapons lay bare on the ground, you think about the fate of the previous owners.");
            Rooms ThroneRoom = new Rooms("Throne Room", "You see a gigantic throne before you and feel a powerful presence closing in.");

            Entrance.AddExit("north", Armoury);
            Armoury.AddExit("south", Entrance);
            Armoury.AddExit("west", TortureChamber);
            TortureChamber.AddExit("east", Armoury);
            TortureChamber.AddExit("west", TreasureRoom);
            TreasureRoom.AddExit("east", TortureChamber);
            TortureChamber.AddExit("up", ThroneRoom);
            ThroneRoom.AddExit("down", TortureChamber);

            Armoury.Items.Add(new Weapons("Sharp Sword", 10));
            TortureChamber.Items.Add(new Potions("Healing Elixir", 20));
            TreasureRoom.Items.Add(new Weapons("Royal Scythe", 20));


            TortureChamber.Monsters.Add(new Orc());
            ThroneRoom.Monsters.Add(new Beholder());

            StartingRoom = Entrance;

        }
    }
}
