using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Russian_Roullete
{
   public  class shootaway
    {
        public int Spinbullete;
        public int Fire = 2;
        public int Totalshots = 6;
        public int BulleteChange(int change)
        {
            if (change == 6)
            {
                change = 1;
            }
            else
            {
                change++;
            }
            return change;
        }
        public int Awaymiss()
        {
            int points = 0;
            if (Totalshots > 0 && Spinbullete == 1 && Fire == 2)
            {

                points = 10;


            }
            if (Totalshots > 0 && Spinbullete == 1 && Fire == 1)
            {

                points = 5;

            }

            else if (Totalshots > 0 && Spinbullete != 1)
            {
                points = 0;
                Totalshots = Totalshots - 1;
                Spinbullete = BulleteChange(Spinbullete);



            }
            return points;
        }
    }
}
