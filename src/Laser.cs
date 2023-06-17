using System;
using Raylib_cs;
using System.Numerics;

namespace DefaultNamespace
{
    public class Laser
    {
        private Vector2 position;
        private float speed;
        private Color color;
        private bool active;

        public Laser(Vector2 startPosition, float laserSpeed, Color laserColor)
        {
            position = startPosition;
            speed = laserSpeed;
            color = laserColor;
            active = true;
        }

        public bool Active => active;

        public void Update()
        {
            position.Y -= speed;

            if (position.Y < 0)
                active = false;
        }

        public void Draw()
        {
            Raylib.DrawRectangle((int)position.X, (int)position.Y, 2, 8, color);
        }

        public Rectangle GetCollisionRectangle()
        {
            return new Rectangle(position.X, position.Y, 2, 8);
        }
    }
}
