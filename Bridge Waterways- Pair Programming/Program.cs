using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge_Waterways__Pair_Programming
{
    class Program
    {
        static void Main(string[] args)
         {
            Rivers Cuyahoga = new Rivers();
            Cuyahoga.Name = "Cuyahoga";
            Console.WriteLine("Would you like to check the status of the {0} river?", Cuyahoga.Name);
            string statusResponse = Console.ReadLine().ToLower();

            if (statusResponse == "yes")
            {
                Cuyahoga.CheckStatus();
                Console.WriteLine("Would you like to drain the river?");
                string drainResponse = Console.ReadLine().ToLower();
                Console.WriteLine("Would you like to clean the river?");
                string cleanResponse = Console.ReadLine().ToLower();

                if (drainResponse == "yes")
                {
                    Cuyahoga.Drain();
                }
            }
        }
    }
}
