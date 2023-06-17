using Raylib_cs;

namespace DefaultNamespace;
public class Player //This class has all the atributes of the player
{
 //string color = "red";
 //int x = 5;
 //int y = 5;
 public float radius = 10;
 public int speed = 10;

    public int x1 = 400;
    public int y1 = 700;

 

    public void Left()//this method is to detect if the A key is bineg held down by the player, if so the palyer's icon should move left. 
    {
        if(x1>5){ //causes player to not go off screen
    if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT)||Raylib.IsKeyDown(KeyboardKey.KEY_A))
        {
         x1-=5;
        }
    }
    }

    public void Right()
    {
    if(x1<795){
    if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT)||Raylib.IsKeyDown(KeyboardKey.KEY_D))
        {
         x1+=5;
        }
    }



}
public void Up() {
   if(y1>5){
    if (Raylib.IsKeyDown(KeyboardKey.KEY_UP)||Raylib.IsKeyDown(KeyboardKey.KEY_W))
        {
         y1-=5;
        }
}}





public void Down() {
       if(y1<795){
    if (Raylib.IsKeyDown(KeyboardKey.KEY_DOWN)||Raylib.IsKeyDown(KeyboardKey.KEY_S))
        {
         y1+=5;
        }

}
}}