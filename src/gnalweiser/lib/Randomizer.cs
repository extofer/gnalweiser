using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace gnalweiser.lib
{
   public static class Randomizer
    {
       public static int GetRandom(int min, int max)
       {
           Random random = new Random();
           int y = random.Next(min, max);

           while (!TxtLogger.IsAvailable(y))
           {
               y= random.Next(min, max);
           }

           return y;
       }
       
    }
}
