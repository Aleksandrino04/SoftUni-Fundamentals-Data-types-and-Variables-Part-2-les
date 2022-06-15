using System;

namespace _09._Spice_Must_Flow
{
    class Program
    {
        static void Main(string[] args)
        {
            const int CONSUMED_BY_WORKERS = 26;
            const int MINIMUM_SPICES_TO_GATHER = 100;
            const int DAILY_DECREASE_OF_MINE_YIELD = 10;

            int startingYield = int.Parse(Console.ReadLine());
            int totalConsummed = 0;
            int countOfDays = 0;
            
            while (startingYield >= MINIMUM_SPICES_TO_GATHER)
            {
                totalConsummed += startingYield - CONSUMED_BY_WORKERS;
                startingYield -= DAILY_DECREASE_OF_MINE_YIELD;
                countOfDays++;
                if (startingYield < MINIMUM_SPICES_TO_GATHER)
                {
                    totalConsummed -= CONSUMED_BY_WORKERS;
                }
            }
            Console.WriteLine(countOfDays);
            Console.WriteLine(totalConsummed);


        }
    }
}
