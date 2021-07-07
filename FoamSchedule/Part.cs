using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoamSchedule
{
    public class Part
    {
        private string partNum;
        private int numTools;

        public Part(string pn, int nt)
        {
            this.partNum = pn;
            this.numTools = nt;
        }

        public string getPartNum()
        {
            return this.partNum;
        }

        public int getNumTools()
        {
            return this.numTools;
        }
    }
}
