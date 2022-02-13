using System;

namespace Bakery.Logic
{
    public class Bread
    {
        public static int costOfBread(int loafCount)
        {   
           int totalCost = 0;
           for (int loaves = 0; loaves <= loafCount; loaves++)
           if (loaves%3 == 1)
           {
               totalCost += 5;
           }
           else if (loaves%3 == 2)
           {
               totalCost +=5;
           }
           else if (loaves%3 == 0)
           {
               totalCost +=0;
           }
           return totalCost;
        }
    }
    public class Pastry
    {
        public static int costOfPastry(int pastryCount)
        {
            return pastryCount * 2;
        }
    }
}