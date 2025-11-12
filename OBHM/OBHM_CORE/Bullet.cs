using OBHM.RENDER;
using System.Numerics;


namespace OBHM.CORE
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
            position.X += (float)Math.Cos(angle) * speed;
            position.Y += (float)Math.Sin(angle) * speed;
            if (Type == "square")
            {
                Rotation += RotationSpeed;
            }
        }

        public void Draw(IRender render)
        {
            if (Type == "circle")
            {
                render.DrawCircle(position, Size, color);
            }
            else if (Type == "square")
            {
                render.DrawSquare(position, Size,Rotation,color);
            }
        }
        public bool IsOffScreen(IRender render)
        {
            return position.X < -Size || position.X > render.GetScreenWidth() + Size ||
                   position.Y < -Size || position.Y > render.GetScreenHeight() + Size;
        }
    }
}
