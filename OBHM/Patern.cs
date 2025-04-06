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
        private List<CircleBullet> bullets;
        private Vector2 PlayerPositon;
        private int PlayerSize;
        public PaternCircle(int x, int y, int number, int size, float speed, Color color, Vector2 PP, int PS) 
        { 
            bullets = new List<CircleBullet>();
            Position = new Vector2(x, y);
            this.number = number;
            this.Speed = speed;
            this.Size = size;
            this.color = color;
            PlayerPositon = PP;
            PlayerSize = PS;
            GeneratePatern();
        }
        private void GeneratePatern()
        {
            for (int i = 0; i < 360; i += number)
            {
                CircleBullet bl = new CircleBullet(Position.X, Position.Y, i, Speed, Size, color, PlayerPositon, PlayerSize);
                bullets.Add(bl);
            }
        }
        public void Update()
        {
            foreach (CircleBullet b in bullets)
            {
                b.Update();
            }
        }
        public void Draw()
        {
            foreach (CircleBullet b in bullets)
            {
                b.Draw();
            }
        }
    }
}
