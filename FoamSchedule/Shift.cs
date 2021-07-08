using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoamSchedule
{
    public class Shift
    {
        private string name;

        public Shift(string n)
        {
            this.name = n;
        }

        public string getName()
        {
            return this.name;
        }


    }
}
