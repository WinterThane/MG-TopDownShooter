using TopDownShooter.Actors;
using TopDownShooter.Projectiles;

namespace TopDownShooter.Global
{
    public class GameManager
    {
        private readonly Player _player;

        public GameManager()
        {
            ProjectileManager.Init();
            _player = new(Globals.Content.Load<Texture2D>("player"), new(100, 100));
        }

        public void Update()
        {
            InputManager.Update();   
            _player.Update();
            ProjectileManager.Update();
        }

        public void Draw()
        {
            ProjectileManager.Draw();
            _player.Draw();
        }
    }
}
