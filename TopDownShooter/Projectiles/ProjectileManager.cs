using System.Collections.Generic;
using TopDownShooter.Global;

namespace TopDownShooter.Projectiles
{
    public static class ProjectileManager
    {
        private static Texture2D _texture;
        private static List<Projectile> ProjectilesList { get; } = new();

        public static void Init()
        {
            _texture = Globals.Content.Load<Texture2D>("bullet");
        }

        public static void AddProjectile(ProjectileData data)
        {
            ProjectilesList.Add(new(_texture, data));
        }

        public static void Update()
        {
            foreach (var projectile in ProjectilesList)
            {
                projectile.Update();
            }

            ProjectilesList.RemoveAll(p => p.LifeTime <= 0);
        }

        public static void Draw()
        {
            foreach (var projectile in ProjectilesList)
            {
                projectile.Draw();
            }
        }
    }
}
