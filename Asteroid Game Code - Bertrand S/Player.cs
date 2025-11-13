using Raylib_cs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MohawkGame2D
{
    public class Player
    {
        Texture2D texture1;
        Vector2 playerPosition = new Vector2(Input.GetMouseX(), Input.GetMouseY());

        public void Setup()
        {
            texture1 = Graphics.LoadTexture("Textures/player_icon.png");
        }

        public void Update()
        {
            DrawPlayer();
        }

        public void DrawPlayer()
        {
            Graphics.Rotation = 0.0f;
            Graphics.Scale = 0.15f;
            Graphics.Draw(texture1, playerPosition);
        }
    }
}