using OBHM.INPUT;
using System.Numerics;
using OBHM.MAP;
using OBHM.RENDER;

namespace OBHM
{
        public class Player
        {
            public Vector2 position;
            public int PlayerSize;
            public float PlayerRotation;
            public Color color = Color.LightBlue;
            private float speed = 300f;
            public bool IsDead = false;

            public Player(float x, float y, int plsi, float playerRotation)
            {
                position = new Vector2(x, y);
                PlayerSize = plsi;
                PlayerRotation = playerRotation;
            }

            public void Update(MAP.Write write, IKeyboard keyboard)
            {
                if (keyboard.IsKeyDown(Keys.W)) position.Y -= speed;
                if (keyboard.IsKeyDown(Keys.S)) position.Y += speed;
                if (keyboard.IsKeyDown(Keys.A)) position.X -= speed;
                if (keyboard.IsKeyDown(Keys.D)) position.X += speed;

                foreach (var e in write.Notes.Values)
                {
                    foreach (var j in e)
                    {
                        foreach (var k in j.bullets)
                        {
                            if (&& k.IsAlive) // Check Colisions
                            {
                                IsDead = true; 
                                break;
                            }
                        }
                    }
                }

            if (keyboard.IsKeyDown(Keys.Left_Shift)) speed = 500f;
                else speed = 300f;
            }

            public void Draw(IRender render)
            {
                render.DrawSquare(position, PlayerSize, PlayerRotation, color);
            }
        }
}
