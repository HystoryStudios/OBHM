using OBHM.INPUT;
using OBHM.MAP;
using OBHM.RENDER;
using System.Numerics;

namespace OBHM.CORE
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
                        if (CheckCollision(k) && k.IsAlive) // Check Colisions  
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

        public bool CheckCollision(Bullet bullet)
        {
            float playerRadius = PlayerSize / 2f;
            float bulletRadius = bullet.Size / 2f;
            Vector2 centerPlayer = position + new Vector2(playerRadius);
            Vector2 centerBullet = bullet.position + new Vector2(bulletRadius);

            float distance = Vector2.Distance(centerPlayer, centerBullet);
            return distance < (playerRadius + bulletRadius);
        }
    }
}
