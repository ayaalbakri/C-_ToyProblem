using System.Collections.Generic;
using System.Linq;

namespace ToyProblem
{
    public class PeopleInBus
    {
        public static int Number(List<int[]> peopleListInOut)
        {
            int numberOfPeople = 0;
            for (int i = 0; i < peopleListInOut.Count(); i++)
            {
                numberOfPeople += peopleListInOut[i][0] - peopleListInOut[i][1];
            }

            //best solution 
            //return peopleListInOut.Sum(Item => Item[0] - Item[1]);
            return numberOfPeople;
        }
    }
}
