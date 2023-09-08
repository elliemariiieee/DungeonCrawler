using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1DungeonCrawler
{
    internal class Player
    {
        string Name { get; set; }
        int Level { get; set; }
        int Lives { get; set; }

        public Player()
        {
            Name = "Player";
            Level = 1;
            Lives = 3;
        }

        public Player(string n, int le, int li)
        {
            Name = n;
            Level = le;
            Lives = li;
        }

        public string getName()
        {
            return Name;
        }

        public int getLives()
        {
            return Lives;
        }

        public int getLevels()
        {
            return Level;
        }
    }
}
