using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge_Waterways__Pair_Programming
{
    class Rivers
    {
        //Declare fields
       private string name;
        private int currentDepth;
        private int pollutionLevel;

        //Declare properties
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int CurrentDepth
        {
            get { return this.currentDepth; }
            set { this.currentDepth = value; }
        }

        public int PollutionLevel
        {
            get { return this.pollutionLevel; }
            set { this.pollutionLevel = value; }
        }

        public Rivers()
        {
            //Default constructor
        }

        public Rivers(string name, int currentDepth, int pollutionLevel)
        {
            this.name = name;
            this.currentDepth = currentDepth;
            this.pollutionLevel = pollutionLevel;
        }


        public void Clean()
        {
            PollutionLevel = PollutionLevel - 10;
            Console.WriteLine("The new depth is {0}.", PollutionLevel);
        }

        public void Drain()
        {
            CurrentDepth = CurrentDepth - 10;
            Console.WriteLine("The new depth is {0}.", CurrentDepth);
        }



        public void CheckStatus()
        {
            Random r = new Random();

            CurrentDepth = r.Next(0, 70);
            PollutionLevel = r.Next(0, 20);

            if (CurrentDepth >= 30)
            {
                Console.WriteLine("The current depth is {0}. The river is getting full.", CurrentDepth);

            }

            if (PollutionLevel >= 10)
            {
                Console.WriteLine("The Current pollution level is {0}. The river is getting dirty.", PollutionLevel);
            }
        }
    }
}
