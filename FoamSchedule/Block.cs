using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoamSchedule
{
    public class Block
    {
        private string weekday;
        private int id;
        private DateTime startTime, endTime;
        private double breakHours;
        private Shift shift;

        public Block(string wd, int i, DateTime st, DateTime et, double bh, Shift s)
        {
            this.weekday = wd;
            this.id = i;
            this.startTime = st;
            this.endTime = et;
            this.breakHours = bh;
            this.shift = s;
        }

        public string getWeekday()
        {
            return this.weekday;
        }

        public int getId()
        {
            return this.id;
        }

        public DateTime getStartTime()
        {
            return this.startTime;
        }

        public DateTime getEndTime()
        {
            return this.endTime;
        }

        public double getBreakHours()
        {
            return this.breakHours;
        }

        public Shift getShift()
        {
            return this.shift;
        }
    }
}
