namespace TopDownShooter.Projectiles
{
    public sealed class ProjectileData
    {
        public Vector2 Position { get; set; }
        public float Rotation { get; set; }
        public int Speed { get; set; }
        public float LifeTime { get; set; }
    }
}
