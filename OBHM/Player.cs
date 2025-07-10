using Raylib_CsLo;
using System.Numerics;

namespace OBHM
{
        public class Player
        {
            public Vector2 position;
            public int PlayerSize;
            private float speed = 300f;
            private Color color = Raylib.SKYBLUE;
            public bool IsDead = false;

            public Player(float x, float y, int plsi)
            {
                position = new Vector2(x, y);
                PlayerSize = plsi;
            }

            public void Update(OBHMFILE.Whrite whrite)
            {
                float delta = Raylib.GetFrameTime();
            
                if (Raylib.IsKeyDown(KeyboardKey.KEY_W)) position.Y -= speed * delta;
                if (Raylib.IsKeyDown(KeyboardKey.KEY_S)) position.Y += speed * delta;
                if (Raylib.IsKeyDown(KeyboardKey.KEY_A)) position.X -= speed * delta;
                if (Raylib.IsKeyDown(KeyboardKey.KEY_D)) position.X += speed * delta;

                foreach (var e in whrite.Notes.Values)
                {
                    foreach (var j in e)
                    {
                        foreach (var k in j.bullets)
                        {
                            if (Raylib.CheckCollisionCircles(position, PlayerSize, k.position, k.Size) && k.IsAlive)
                            {
                                IsDead = true; 
                                break;
                            }
                        }
                        
                    }
                }

            if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT_SHIFT)) speed = 500f;
                else speed = 300f;
            }

            public void Draw()
            {
                Raylib.DrawRectangleV(position, new Vector2(PlayerSize, PlayerSize), color);
            }
        }
}
