using Raylib_CsLo;
using System.Numerics;

namespace OBHM.RENDER
{
    public class Raylib_Render : IRender
    {
        // socuper de bind les couleurs
        public string Name => "Raylib";
        public void Init(int width, int height)
        {
            Raylib.InitWindow(width, height, "OBHM");
        }
        public void DrawCircle(Vector2 position, float size, Color color)
        {
            Raylib.DrawCircleV(position, size, Raylib.RED);
        }
        public void DrawRectangle(Vector2 position, Vector2 size, float rotation, Color color)
        {
            Raylib.DrawRectanglePro(new Rectangle(position.X, position.Y, size.X, size.Y), position, rotation, Raylib.RED);
        }
        public void DrawSquare(Vector2 position, float size, float rotation, Color color)
        {
            Raylib.DrawRectanglePro(new Rectangle(position.X, position.Y, size, size), position, rotation, Raylib.RED);
        }
        public int GetScreenWidth()
        {
            return Raylib.GetScreenWidth();
        }
        public int GetScreenHeight()
        {
            return Raylib.GetScreenHeight();
        }
    }
}
