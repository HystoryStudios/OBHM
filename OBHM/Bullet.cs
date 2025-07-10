using Raylib_CsLo;
using System.Numerics;


namespace OBHM
{
    public class Bullet
    {
        public Vector2 position;
        private float speed;
        private float angle;
        public int Size;
        private Color color;
        private string Type;
        private float Rotation = 1.0f;
        private float RotationSpeed = 100.0f;
        public bool IsAlive = false;
        
        public Bullet(float x, float y, float angleDegrees, float speed,int size, Color color, string type)
        {
            position = new Vector2(x, y);
            this.angle = angleDegrees * (float)Math.PI / 180f;
            this.speed = speed;
            this.color = color;
            Size = size;
            Type = type;
        }
        public Bullet(float x, float y, float angleDegrees, float speed, int size, Color color, string type, float rotationspeed)
        {
            position = new Vector2(x, y);
            this.angle = angleDegrees * (float)Math.PI / 180f;
            this.speed = speed;
            this.color = color;
            Size = size;
            Type = type;
            Rotation = rotationspeed;
        }

        public void Update(Vector2 PlayerPosition, int playersize)
        {
            IsAlive = true;
            float delta = Raylib.GetFrameTime();
            position.X += (float)Math.Cos(angle) * speed * delta;
            position.Y += (float)Math.Sin(angle) * speed * delta;
            if (Type == "square")
            {
                Rotation += RotationSpeed * delta;
            }
        }

        public void Draw()
        {
            if (Type == "circle")
            {
                Raylib.DrawCircleV(position, Size, color);
            }
            else if (Type == "square")
            {
                Raylib.DrawRectanglePro( new Rectangle(position.X, position.Y, Size, Size),new Vector2(Size / 2, Size / 2),Rotation,Raylib.RED);
            }
        }
        public bool IsOffScreen()
        {
            return position.X < -Size || position.X > Raylib.GetScreenWidth() + Size ||
                   position.Y < -Size || position.Y > Raylib.GetScreenHeight() + Size;
        }
    }
}
