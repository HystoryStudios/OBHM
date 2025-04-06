using Raylib_CsLo;
using System.Numerics;


namespace OBHM
{
    public class CircleBullet
    {
        private Vector2 position;
        private float speed;
        private float angle;
        private int size;
        private Color color;
        private Vector2 PlayerPosition;
        private int PlayerSize;
        
        public CircleBullet(float x, float y, float angleDegrees, float speed,int size, Color color, Vector2 playerposition, int playersize)
        {
            position = new Vector2(x, y);
            this.angle = angleDegrees * (float)Math.PI / 180f;
            this.speed = speed;
            this.color = color;
            this.size = size;
            PlayerSize = playersize;
            PlayerPosition = playerposition;
        }

        public void Update()
        {
            float delta = Raylib.GetFrameTime();
            position.X += (float)Math.Cos(angle) * speed * delta;
            position.Y += (float)Math.Sin(angle) * speed * delta;
            if (Raylib.CheckCollisionCircles(position, size, PlayerPosition, PlayerSize))
            {
                Raylib.CloseWindow();
            }
        }

        public void Draw()
        {
            Raylib.DrawCircleV(position, size, color);
        }
    }
}
