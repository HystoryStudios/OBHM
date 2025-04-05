using Raylib_CsLo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace OBHM
{
    public class Bullet
    {
        private Vector2 position;
        private float speed;
        private float angle;
        private int size;
        private Color color;

        public Bullet(float x, float y, float angleDegrees, float speed,int size, Color color)
        {
            position = new Vector2(x, y);
            this.angle = angleDegrees * (float)Math.PI / 180f;
            this.speed = speed;
            this.color = color;
            this.size = size;
        }

        public void Update()
        {
            float delta = Raylib.GetFrameTime();
            position.X += (float)Math.Cos(angle) * speed * delta;
            position.Y += (float)Math.Sin(angle) * speed * delta;
        }

        public void Draw()
        {
            Raylib.DrawCircleV(position, 5, color);
            Vector2 dir = new Vector2(
                (float)Math.Cos(angle) * 20,
                (float)Math.Sin(angle) * 20
            );
        }
    }
}
