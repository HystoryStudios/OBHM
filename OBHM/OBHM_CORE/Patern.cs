using OBHM.RENDER;
using System.Numerics;

namespace OBHM.CORE
{ 
    public class Patern
    {
        private int AngleStep;
        private Vector2 Position;
        private float Speed;
        private int Size;
        private Color color;
        public List<Bullet> bullets;
        private string Type;
        private float RotationSpeed;
        public Patern(int x, int y, int angleStep, int size, float speed, Color color, string type) 
        { 
            bullets = new List<Bullet>();
            Position = new Vector2(x, y);
            AngleStep = angleStep;
            this.Speed = speed;
            this.Size = size;
            this.color = color;
            Type = type;
            GeneratePatern();
        }
        public Patern(int x, int y, int angleStep, int size, float speed, Color color, string type, float rotationspeed)
        {
            bullets = new List<Bullet>();
            Position = new Vector2(x, y);
            AngleStep = angleStep;
            this.Speed = speed;
            this.Size = size;
            this.color = color;
            Type = type;
            RotationSpeed = rotationspeed;
            GeneratePatern();
        }
        private void GeneratePatern()
        {
            for (int i = 0; i < 360; i += AngleStep)
            {
                Bullet bl = new Bullet(Position.X, Position.Y, i, Speed, Size, color, Type, RotationSpeed);
                bullets.Add(bl);
            }
        }
        public void Update(Vector2 PlayerPosition, int playersize, IRender render)
        {
            List<Bullet> deadlist = new List<Bullet>();
            foreach (Bullet b in bullets)
            {
                b.Update(PlayerPosition, playersize);
                if (b.IsOffScreen(render))
                {
                    deadlist.Add(b);
                    continue;
                }
            }
            foreach (Bullet b in deadlist)
            {
                bullets.Remove(b);
            }
            deadlist.Clear();
        }
        public void Draw(IRender render)
        {
            foreach (Bullet b in bullets)
            {
                b.Draw(render);
            }
        }
    }
}
