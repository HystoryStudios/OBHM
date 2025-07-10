using OBHM.OBHMFILE;
using Raylib_CsLo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBHM
{
    public class Game
    {
        public static void playlevel(Whrite write, Player player, string Musicpath)
        {
            int screen = Raylib.GetCurrentMonitor();
            Raylib.InitWindow(1000, 1000, "OBHM");
            Raylib.InitAudioDevice();
            Raylib.HideCursor();
            Raylib.SetTargetFPS(Raylib.GetMonitorRefreshRate(screen));

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
                    Console.WriteLine("GAME OVER");
                    Menu menu1 = new Menu();
                }
            }

            Raylib.CloseWindow();

            Menu menu = new Menu();    
        }
    }
}
