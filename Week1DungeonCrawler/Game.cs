using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.ConsoleColor;

namespace Week1DungeonCrawler
{
    public class Game
    {
        string title = "Welcome To Candy Castle Run!";
        string objective = "You have three lives to pass three levels to make it through the Candy Castle. Each level asks one question that you must answer correctly to reach the nect level. If you answer incorrectly, "
        public void Start()
        {
            SetTextColor(Magenta);
            WriteLine(title);
            resetColor();

            WriteLine("What is your name?");
            string s = ReadLine();
            Player p = new Player(s, 1, 3);
            Write("Welcome ");
            SetTextColor(Cyan);
            Write(p.getName());
            resetColor();
            WriteLine("!");


        }

        public void SetTextColor(ConsoleColor c)
        {
            ForegroundColor = c;
        }

        public void resetColor()
        {
            ForegroundColor = White;
        }
    }
}
