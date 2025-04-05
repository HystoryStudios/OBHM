using Raylib_CsLo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace OBHM
{
        public class Player
        {
            private Vector2 position;
            private float speed = 300f;
            private Color color = Raylib.SKYBLUE;

            public Player(float x, float y)
            {
                position = new Vector2(x, y);
            }

            public void Update()
            {
                float delta = Raylib.GetFrameTime();

                if (Raylib.IsKeyDown(KeyboardKey.KEY_W)) position.Y -= speed * delta;
                if (Raylib.IsKeyDown(KeyboardKey.KEY_S)) position.Y += speed * delta;
                if (Raylib.IsKeyDown(KeyboardKey.KEY_A)) position.X -= speed * delta;
                if (Raylib.IsKeyDown(KeyboardKey.KEY_D)) position.X += speed * delta;

                if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT_SHIFT)) speed = 500f;
                else speed = 300f;
            }

            public void Draw()
            {
                Raylib.DrawRectangleV(position, new Vector2(5, 5), color);
            }
        }
}
