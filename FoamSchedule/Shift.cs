using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoamSchedule
{
    public class Shift
    {
        private int id;
        private string weekdayName;
        private DateTime start, end;
        private double breakHours;

        public Shift(int i, string wd, DateTime s, DateTime e, double bh)
        {
            this.id = i;
            this.weekdayName = wd;
            this.start = s;
            this.end = e;
            this.breakHours = bh;
        }

        public int getId()
        {
            return this.id;
        }

        public string getWeekdayName()
        {
            return this.weekdayName;
        }

        public DateTime getStart()
        {
            return this.start;
        }

        public DateTime getEnd()
        {
            return this.end;
        }

        public double getBreakHours()
        {
            return this.breakHours;
        }


    }
}
