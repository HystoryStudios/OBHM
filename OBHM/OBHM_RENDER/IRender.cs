using System.Numerics;

namespace OBHM.RENDER
{
    public interface IRender
    {
        string Name { get; }
        void Init(int width, int height);
        void DrawCircle(Vector2 position, float size, Color color);
        void DrawRectangle(Vector2 position, Vector2 size, float rotation, Color color);
        void DrawSquare(Vector2 position, float size, float rotation, Color color);
        int GetScreenWidth();
        int GetScreenHeight();
    }
}