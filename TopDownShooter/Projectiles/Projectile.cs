using System;
using TopDownShooter.Global;
using TopDownShooter.Sprites;

namespace TopDownShooter.Projectiles
{
    public class Projectile : Sprite
    {
        public Vector2 Direction { get; set; }
        public float LifeTime { get; set; }

        public Projectile(Texture2D texture, ProjectileData data) : base(texture, data.Position)
        {
            Speed = data.Speed;
            Rotation = data.Rotation;
            Direction = new((float)Math.Cos(Rotation), (float)Math.Sin(Rotation));
            LifeTime = data.LifeTime;
        }

        public void Update()
        {
            Position += Direction * Speed * Globals.TotalSeconds;
            LifeTime -= Globals.TotalSeconds;
        }
    }
}
