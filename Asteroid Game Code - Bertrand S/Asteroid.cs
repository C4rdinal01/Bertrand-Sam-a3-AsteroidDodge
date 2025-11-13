using Raylib_cs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MohawkGame2D
{
    public class Asteroid
    {
        Texture2D texture2;
        Vector2 asteroidSize;
        Vector2 asteroidPosition = new Vector2(Random.Float(10.0f, 410.0f), -10.0f);

        Vector2 collision2;

        int asteroids = 1000;

        public void Setup()
        {
            texture2 = Graphics.LoadTexture("Textures/asteroid_icon.png");

            asteroidSize = new Vector2(texture2.Height, texture2.Width);
        }

        public void Update()
        {
            if (asteroids > 0)
            {
                DrawAsteroid();
                asteroids--;
            }
        }

        public void DrawAsteroid()
        {
            Graphics.Rotation = 0.0f;
            Graphics.Scale = 0.15f;
            Graphics.Draw(texture2, asteroidPosition);
        }
    }
}
