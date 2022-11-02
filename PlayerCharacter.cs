using Raylib_cs;
using System.Numerics;
using static Raylib_cs.Raylib;
using static Raylib_cs.Color;
using static Raylib_cs.PixelFormat;

class Player : MovementObjects
{
    public float xValue;
    public float yValue;
    MovementObjects Movement = new MovementObjects();
    public Player()
{

     xValue = 400;
     yValue = 460;
     Movement.MovementSpeed = 4;
     
     
}


// Loads in the mosely texture and returns it to the functions
    public Texture2D playerImage() 
    {
        Image image = LoadImage("img/broMosely.png");
        ImageResize(ref image, 50, 50);
        // var playerSpeed = 50;
        Texture2D texture = LoadTextureFromImage(image);
        UnloadImage(image);
        return texture;
    }

// Takes the loaded texture and moves around the x and y values according to the arrow keys pressed. 
// Only allows you to move to certain values so you are kept in a box.
    public void PlayerCharacter(Texture2D texture)
    {
                
                if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT) && xValue != 780) {
                    xValue = Movement.MovePositive(xValue);
                }
                if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT) && xValue != 0) {
                    xValue = Movement.MoveNegative(xValue);
                }

                if (Raylib.IsKeyDown(KeyboardKey.KEY_UP)&& yValue != 420) {
                    yValue = Movement.MoveNegative(yValue);
                }

                if (Raylib.IsKeyDown(KeyboardKey.KEY_DOWN) && yValue !=460) {
                    yValue = Movement.MovePositive(yValue);
                }
                int NewX = (int) xValue;
                int NewY = (int) yValue;
                DrawTexture(texture, NewX, NewY, WHITE);
                
                // Raylib.DrawRectangleRec(PlayerRectangle, Color.RED);`
    }
}


