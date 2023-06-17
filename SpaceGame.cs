using DefaultNamespace;
using System.Collections.Generic;

namespace DefaultNamespace;


internal class SpaceGame
{
    private static void Main(string[] args)
    {
        Director director = new Director();
        director.startGame();
    }
}