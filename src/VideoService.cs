namespace DefaultNamespace;
using Raylib_cs;
using static Raylib_cs.Raylib;
using static Raylib_cs.Color;
using System;
using System.Collections.Generic;
public class VideoService
{
    
    private int offset = 15;
    public void startGame()
    {
       
    }
    public void draw(List<Artifact> objectsToDraw)
    {
        Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.BLACK);

            for (int i = 0; i < objectsToDraw.Count; i ++) {
                drawArtifact(objectsToDraw[i].x1, objectsToDraw[i].y1, objectsToDraw[i].radius1, objectsToDraw[i].artifactName);
            }

            Raylib.EndDrawing();
        
    }
    public void drawPlayer(Player player ) //ship
    {
        Raylib.DrawCircle(player.x1,player.y1,player.radius,Color.BLACK);
        DrawTexture(Director.rocketTexture, player.x1-offset, player.y1-offset, WHITE);
    }

    public void drawArtifact(int x, int y, float radius, char artifactType) // draws an artifact
    {
        if (artifactType == 'b') {
            Raylib.DrawCircle(x,y,radius,Color.BLACK);
            DrawTexture(Director.bombTexture, x-offset, y-offset, Color.WHITE);
            
        }
        else if (artifactType == 'g') { //gem
            Raylib.DrawCircle(x,y,radius,Color.BLACK);
            DrawTexture(Director.gemTexture, x-offset, y-offset, Color.WHITE);
        }
        else if (artifactType == 'r') {
            Raylib.DrawCircle(x,y,radius,Color.BLACK);
            DrawTexture(Director.rockTexture, x-offset, y-offset, Color.WHITE);
        }
    }

    public void displayScore() {
        DrawText("Score: " + ScoreManager.score.ToString(), 25, 25, 20, WHITE);
    }
}
