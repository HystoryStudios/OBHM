using Raylib_CsLo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace OBHM
{
    public class PaternCircle
    {
        private int number;
        private Vector2 Position;
        private float Speed;
        private int Size;
        private Color color;
        private List<Bullet> bullets;
        public PaternCircle(int x, int y, int number, int size, float speed, Color color) 
        { 
            bullets = new List<Bullet>();
            Position = new Vector2(x, y);
            this.number = number;
            this.Speed = speed;
            this.Size = size;
            this.color = color;
            GeneratePatern();
        }
        private void GeneratePatern()
        {
            for (int i = 0; i < 360; i += number)
            {
                Bullet bl = new Bullet(Position.X, Position.Y, i, Speed, Size, color);
                bullets.Add(bl);
            }
        }
        public void Update()
        {
            foreach (Bullet b in bullets)
            {
                b.Update();
            }
        }
        public void Draw()
        {
            foreach (Bullet b in bullets)
            {
                b.Draw();
            }
        }
    }
}
