using OBHM.OBHMFILE;
using Raylib_CsLo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OBHM
{
    public class Game
    {
        public static void playlevel(Dictionary<double, List<Patern>> notes, string levelPath, float startX, float startY, int playerSize, string Musicpath)
        {
            int screen = Raylib.GetCurrentMonitor();

            Raylib.InitWindow(1000, 1000, "OBHM");
            Raylib.InitAudioDevice();
            Raylib.HideCursor();
            Raylib.SetTargetFPS(Raylib.GetMonitorRefreshRate(screen));

            Whrite write = new Whrite(notes, levelPath);
            Player player = new Player(startX, startY, playerSize);

            write.LunchMusic(Musicpath);
            while (!Raylib.WindowShouldClose())
            {
                Raylib.DrawText(write.CurrentTime.ToString(), 100, 100, 10, Raylib.WHITE);
                player.Update(write);
                write.Update(player.position, player.PlayerSize);
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Raylib.BLACK);
                player.Draw();
                write.Draw();
                Raylib.EndDrawing();

                if (player.IsDead)
                {
                    break;
                }
            }

            Console.Clear();
            Raylib.CloseAudioDevice();
            write.Unload();
            Raylib.CloseWindow();
            Console.WriteLine("GAME OVER");
            Console.WriteLine("Tap 'R' or 'r' to retry the level");

            char input = Console.ReadKey().KeyChar;
            Console.WriteLine();

            if (input == 'R' || input == 'r')
            {
                playlevel(notes, levelPath, startX, startY, playerSize, Musicpath);
            }
            else
            {
                Menu menu = new Menu();
                menu.GetMenu();
            }
        }
    }
}
