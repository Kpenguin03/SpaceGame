using System;
using System.Collections.Generic;
namespace DefaultNamespace;

public static class ScoreManager
{
   public static int score = 0;
   public static void scoreUp(){
   score = score + 100; 
   }
   
   public static void scoreDown(){
   score = score - 100; 
   }

   public static void scoreResset(){
   score = 0; 
   }

   public static void scoreHalf(){
   score = score/2; 
   }
}