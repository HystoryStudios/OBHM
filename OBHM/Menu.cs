using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBHM
{
    public class Menu
    {
        public int ID;
        public Dictionary<int, string> Window = new Dictionary<int, string>();

        public Menu()
        {
            Window.Add(1, "play");
        }

        public void GetMenu()
        {
            string input = Console.ReadLine();

            foreach (var key in Window)
            {
                if (key.Value == input)
                {
                    Manager(key.Key);
                }
            }
        }

        

        public void Manager(int id)
        {
            switch (id)
            {
                case 1:
                    Console.Write("What level you wanna play ? (filepath .OBHML): ");
                    string levelpath = Console.ReadLine();
                    Console.Write("What music you wanna play ? (filepath .mp3, .waw, .ogg etc...): ");
                    string musicpath = Console.ReadLine();
                    OBHMFILE.Read read = new OBHMFILE.Read(levelpath);
                    OBHMFILE.Whrite whrite = new OBHMFILE.Whrite(read.ReadFile());

                    Game.playlevel(whrite, new Player(100, 100, 10), musicpath);
                    break;
            }
        }
    }
}
