using OBHM;
using Raylib_CsLo;
using System.Reflection.Emit;
int screen = Raylib.GetCurrentMonitor();
Raylib.InitWindow(Raylib.GetMonitorWidth(screen), Raylib.GetMonitorHeight(screen), "OBHM");
Raylib.HideCursor();
Raylib.ToggleFullscreen();
Raylib.SetTargetFPS(1000);

Player player = new Player(500, 500);

PaternCircle generator = new PaternCircle(Raylib.GetMonitorWidth(screen) / 2, Raylib.GetMonitorHeight(screen) / 2, 10, 10, 200f, Raylib.RED);
PaternCircle generatorl = new PaternCircle(800, 400, 10, 10, 200f, Raylib.RED);
PaternCircle generatorr = new PaternCircle(0, 400, 10, 10, 200f, Raylib.RED);


while (!Raylib.WindowShouldClose())
{
    player.Update();
    generator.Update();
    generatorl.Update();
    generatorr.Update();
    Raylib.BeginDrawing();
    Raylib.ClearBackground(Raylib.BLACK);
    player.Draw();
    generator.Draw();
    generatorl.Draw();
    generatorr.Draw();
    Raylib.EndDrawing();
}

Raylib.CloseWindow();