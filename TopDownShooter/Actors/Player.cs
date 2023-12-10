using System;
using TopDownShooter.Global;
using TopDownShooter.Projectiles;
using TopDownShooter.Sprites;

namespace TopDownShooter.Actors
{
    public class Player : Sprite
    {
        public Player(Texture2D texture, Vector2 position) : base(texture, position)
        {

        }

        private void Fire()
        {
            ProjectileData data = new()
            {
                Position = Position,
                Speed = 600,
                Rotation = Rotation,
                LifeTime = 2f
            };

            ProjectileManager.AddProjectile(data);
        }
        
        public void Update()
        {
            if (InputManager.Direction != Vector2.Zero)
            {
                var dir = Vector2.Normalize(InputManager.Direction);
                Position += dir * Speed * Globals.TotalSeconds;
            }

            var toMouse = InputManager.MousePosition - Position;
            Rotation = (float)Math.Atan2(toMouse.Y, toMouse.X);

            if (InputManager.MouseClicked)
            {
                Fire();
            }
        }
    }
}
