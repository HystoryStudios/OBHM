using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            Window.Add(2, "add");
        }

        public void GetMenu()
        {
            Console.WriteLine("Welcome to OBHM ! tap 'play' to play a level");
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
                    OBHMFILE.Whrite whrite = new OBHMFILE.Whrite(read.ReadFile(), read.Path);

                    Game.playlevel(whrite.Notes,whrite.LevelPath, 100, 100, 10, musicpath);
                    break;
                case 2:
                    Console.Write("What level you wanna add ? (filepath .OBHML): ");
                    string levelpathsource = Console.ReadLine();
                    Console.Write("What music you wanna add ? (filepath .mp3, .waw, .ogg etc...): ");
                    string musicpathsource = Console.ReadLine();
                    string destinationFolder = "Program Files/Hystory_Studios/Content";
                    Directory.CreateDirectory(destinationFolder);
                    Directory.CreateDirectory(destinationFolder + "/Musics");
                    Directory.CreateDirectory(destinationFolder + "/Levels");

                    string levelfileName = Path.GetFileName(levelpathsource);
                    string leveldestinationPath = Path.Combine(destinationFolder, levelfileName);

                    string musicfileName = Path.GetFileName(levelpathsource);
                    string musicdestinationPath = Path.Combine(destinationFolder, musicfileName);

                    File.Copy(levelpathsource, leveldestinationPath, true);
                    File.Copy(musicpathsource, musicdestinationPath, true);
                    break;
            }
        }
    }
}
