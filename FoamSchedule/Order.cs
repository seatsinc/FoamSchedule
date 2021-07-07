using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoamSchedule
{
    public class Order
    {
        private string orderNum;
        private Part part;
        private int quantity;
        private DateTime dueDate;

        public Order(string on, Part p, int q, DateTime dd)
        {
            this.orderNum = on;
            this.part = p;
            this.quantity = q;
            this.dueDate = dd;
        }

        public string getOrderNum()
        {
            return this.orderNum;
        }

        public Part getPart()
        {
            return this.part;
        }

        public int getQuantity()
        {
            return this.quantity;
        }

        public DateTime getDueDate()
        {
            return this.dueDate;
        }

        public double getPriority(DateTime refDate)
        {
            double daysTill = (refDate - this.getDueDate()).TotalDays;

            double exp = 1.0;

            if (daysTill == 0.0)
            {
                exp = 0.0;
            }
            else if (daysTill < 0.0)
            {
                exp = -1.0;
            }

            return this.quantity / (Math.Pow(daysTill, exp) * 5.0);
        }
    }
}
