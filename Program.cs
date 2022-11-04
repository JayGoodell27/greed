﻿using Raylib_cs;
using System.Numerics;
using static Raylib_cs.Raylib;

namespace Greed
{
     class Program : MovementObjects
    {
        public Program()
        {
        }
        public static void Main()
        {
            //sets things up.
            Player Player = new Player();
            TrashObject TrashObject = new TrashObject();
            TreasureObject TreasureObject = new TreasureObject();
            var ScreenHeight = 520;
            var ScreenWidth = 800;
            Raylib.InitWindow(ScreenWidth, ScreenHeight, "Greed");
            Raylib.InitAudioDevice();
            Raylib.SetTargetFPS(60);
            int score = 0;

           


            while (!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.WHITE);
                // Raylib.DrawText($"Collect the circles and avoid the squares!        Your score is {score}", 12, 12, 18, Color.BLACK);
                Raylib.DrawText($"xvalue{Player.CircleCenter.X} yvalue{Player.CircleCenter.Y}", 50, 50, 18, Color.GREEN);
                //These two lines add mosleys texture into the game, and then moves it around with the arrowkeys.
                var TextureReturn = Player.playerImage();
                Player.PlayerCharacter(TextureReturn);

                 
                TrashObject.DisplayFallingBlocksFull();

                TreasureObject.DisplayFallingBlocksFull();

                Raylib.EndDrawing();
            }
            Raylib.CloseAudioDevice();
            Raylib.CloseWindow();
        }
    }
}

//character
/*public class Character {
    public void Player() {
            var posHeight = 1500;
            var posWidth = 1000;
            var shipPosition = new Vector2(posHeight, posWidth);
            var player = new Rectangle(100, 100, 50, 50);
            var playerSpeed = 50;
                if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT)) {
                    shipPosition.X += playerSpeed;
                }

                if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT)) {
                    shipPosition.X -= playerSpeed;
                }

                if (Raylib.IsKeyDown(KeyboardKey.KEY_UP)) {
                    shipPosition.Y -= playerSpeed;
                }

                if (Raylib.IsKeyDown(KeyboardKey.KEY_DOWN)) {
                    shipPosition.Y  += playerSpeed;
                }
    }
}
    */