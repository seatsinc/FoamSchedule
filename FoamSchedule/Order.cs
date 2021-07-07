using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoamSchedule
{
    public class Order
    {
        private string orderNum, partNum;
        private int quantity;
        private DateTime dueDate;

        public Order(string on, string pn, int q, DateTime dd)
        {
            this.orderNum = on;
            this.partNum = pn;
            this.quantity = q;
            this.dueDate = dd;
        }

        public string getOrderNum()
        {
            return this.orderNum;
        }

        public string getPartNum()
        {
            return this.partNum;
        }

        public int getQuantity()
        {
            return this.quantity;
        }

        public DateTime getDueDate()
        {
            return this.dueDate;
        }
    }
}
