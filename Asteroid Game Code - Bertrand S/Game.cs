// Include the namespaces (code libraries) you need below.
using Raylib_cs;
using System;
using System.Dynamic;
using System.Net;
using System.Numerics;
using System.Security.Cryptography;

// The namespace your code is in.
namespace MohawkGame2D
{

    public class Game
    {
        Player ship;

        Vector2 gravity = new Vector2(0, 500);

        float[] starPositions;

        bool areStarsDrawn = false;
        int StarsCount = 0;

        Texture2D texture1;

        Vector2 playerPosition = new Vector2(Input.GetMouseX(), Input.GetMouseY());


        public void Setup()
        {
            Window.SetSize(400, 400);
            Window.SetTitle("Asteroid Dodge");

            // initialize all game objects!
            // ideally here we would have the Asteroids being given their coordinates, the score calculator resetting etc...

            texture1 = Graphics.LoadTexture("Textures/player_icon.png");

            ship = new Player();
            ship.Setup();

        }

        public void Update()
        {
            Window.ClearBackground(Color.Black);

            ship.Update();

            DrawStar(); // replace with Stars.cs
            DrawAsteroid(); // make a public class (Asteroids.cs)
            // ScoreCounter();
        }

        void DrawPlayerIcon()
        {

            Graphics.Rotation = 0.0f;
            Graphics.Scale = 1.0f;
            Graphics.LoadTexture("Textures/player_icon.png");
            Graphics.Draw(texture1, playerPosition);

        }

        public void DrawStar()
        {
            if (StarsCount <= 60)
            {
                Draw.FillColor = new Color("#FCFC12EE");
                Draw.Ellipse(Random.Float(0, 400), Random.Float(0, 400), 5, 5);

                StarsCount += 1;

                areStarsDrawn = false;
                return;

                // I want to add the random floats made here to the 'starPositions' array to keep their place
            }
            else if (StarsCount >= 60)
            {
                areStarsDrawn = true;
            }
        }

        void DrawAsteroid()
        {
            // Randomly draw an Asteroid (using the texture provided) along the X Axis above the screen
            // and have them fall at a moderate speed.
            // Once they fall from the bottom of the screen, SCORE++ and the asteroid will be respawned randomly along the X axis once again.

            // Asteroid should be roughly 20x20 pixels <-- for collision as well as the texture size

            Graphics.Rotation = 0.0f;
            Graphics.Scale = 1.0f;
            Graphics.LoadTexture("Textures/asteroid_icon.png");

        }
    }

}