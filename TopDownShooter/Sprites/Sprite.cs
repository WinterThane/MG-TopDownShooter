using TopDownShooter.Global;

namespace TopDownShooter.Sprites
{
    public class Sprite
    {
        protected readonly Texture2D _texture;
        protected readonly Vector2 _origin;
        public Vector2 Position { get; set; }
        public int Speed { get; set; }
        public float Rotation { get; set; }

        public Sprite(Texture2D texture, Vector2 position)
        {
            _texture = texture;
            Position = position;
            Speed = 300;
            _origin = new(texture.Width / 2f, texture.Height / 2f);
        }

        public virtual void Draw()
        {
            Globals.SpriteBatch.Draw(_texture, Position, null, Color.White, Rotation, _origin, 0.5f, SpriteEffects.None, 0);
        }
    }
}
