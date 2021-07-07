using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoamSchedule
{
    public partial class Form1 : Form
    {
        private List<Shift> shifts = new List<Shift>();
        private List<Part> parts = new List<Part>();
        private List<Order> orders = new List<Order>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.refreshConstants();
            this.refreshShifts();
            this.refreshParts();
            this.refreshOrders();
            this.initWeekdays();
            
        }

        private void refreshConstants()
        {
            DatabaseHandler dh = new DatabaseHandler("database.db");

            DataTable dt = dh.executeQuery("select VALUE from CONSTANTS where NAME=\"MAX_TOOLS\"");
            this.nMaxTools.Value = Convert.ToInt32(dt.Rows[0]["VALUE"].ToString());

            dt = dh.executeQuery("select VALUE from CONSTANTS where NAME=\"LINE_CYCLE\"");
            this.nLineCycle.Value = Convert.ToInt32(dt.Rows[0]["VALUE"].ToString());

            dt = dh.executeQuery("select VALUE from CONSTANTS where NAME=\"OVERALL_EFFICIENCY\"");
            this.nOverallEfficiency.Value = Convert.ToInt32(dt.Rows[0]["VALUE"].ToString());
        }

        private void nMaxTools_ValueChanged(object sender, EventArgs e)
        {
            DatabaseHandler dh = new DatabaseHandler("database.db");

            dh.executeNonQuery($"update CONSTANTS set VALUE={this.nMaxTools.Value} where NAME=\"MAX_TOOLS\"");
        }

        private void nLineCycle_ValueChanged(object sender, EventArgs e)
        {
            DatabaseHandler dh = new DatabaseHandler("database.db");

            dh.executeNonQuery($"update CONSTANTS set VALUE={this.nLineCycle.Value} where NAME=\"LINE_CYCLE\"");
        }

        private void nOverallEfficiency_ValueChanged(object sender, EventArgs e)
        {
            DatabaseHandler dh = new DatabaseHandler("database.db");

            dh.executeNonQuery($"update CONSTANTS set VALUE={this.nOverallEfficiency.Value} where NAME=\"OVERALL_EFFICIENCY\"");
        }

        private void initWeekdays()
        {
            DatabaseHandler dh = new DatabaseHandler("database.db");

            DataTable dt = dh.executeQuery("select NAME from WEEKDAYS");
            
            foreach (DataRow dr in dt.Rows)
            {
                this.cbWeekdays.Items.Add(dr["NAME"].ToString());
            }

            this.cbWeekdays.SelectedIndex = 0;
        }



        private void btnAddShift_Click(object sender, EventArgs e)
        {
            DatabaseHandler dh = new DatabaseHandler("database.db");

            dh.executeNonQuery($"insert into SHIFTS (WEEKDAY_NAME, START, END, BREAK_HOURS) VALUES (\"{this.cbWeekdays.SelectedItem}\", \"{this.dtpShiftStart.Value.ToShortTimeString()}\", \"{this.dtpShiftEnd.Value.ToShortTimeString()}\", \"{this.nBreakHours.Value}\")");

            this.refreshShifts();
        }

        private void populateShifts()
        {

            this.dgvShifts.Rows.Clear();

            for (int i = 0; i < this.shifts.Count; ++i)
            {
                Shift s = this.shifts[i];

                this.dgvShifts.Rows.Add();

                this.dgvShifts["id", i].Value = s.getId();
                this.dgvShifts["weekdayName", i].Value = s.getWeekdayName();
                this.dgvShifts["start", i].Value = s.getStart().ToShortTimeString();
                this.dgvShifts["end", i].Value = s.getEnd().ToShortTimeString();
                this.dgvShifts["breakHours", i].Value = s.getBreakHours();

            }
        }

        private void refreshShifts()
        {
            this.cbShiftId.Items.Clear();
            this.shifts.Clear();

            DatabaseHandler dh = new DatabaseHandler("database.db");

            DataTable dt = dh.executeQuery("select * from SHIFTS");

            foreach (DataRow dr in dt.Rows)
            {
                this.cbShiftId.Items.Add(dr["ID"].ToString());

                this.shifts.Add(new Shift(
                    Convert.ToInt32(dr["ID"].ToString()),
                    dr["WEEKDAY_NAME"].ToString(),
                    DateTime.Parse(dr["START"].ToString()),
                    DateTime.Parse(dr["END"].ToString()),
                    Convert.ToDouble(dr["BREAK_HOURS"].ToString())
                    ));
            }

            this.populateShifts();

            if (this.cbShiftId.Items.Count > 0)
                this.cbShiftId.SelectedIndex = 0;
        }

        private void btnDelShift_Click(object sender, EventArgs e)
        {
            if (this.shifts.Count == 0)
                return;

            DatabaseHandler dh = new DatabaseHandler("database.db");

            dh.executeNonQuery($"delete from SHIFTS where ID={this.cbShiftId.SelectedItem}");

            this.refreshShifts();
        }

        private void btnAddPart_Click(object sender, EventArgs e)
        {
            DatabaseHandler dh = new DatabaseHandler("database.db");

            try
            {
                dh.executeNonQuery($"insert into PARTS (PART_NUM, NUM_TOOLS) VALUES (\"{this.tbPartNum.Text}\", {this.nNumTools.Value})");
            }
            catch (SQLiteException exc)
            {
                MessageBox.Show("Part already exists!");
            }

            this.refreshParts();
        }

        private void refreshParts()
        {
            this.cbPartNum.Items.Clear();
            this.parts.Clear();

            DatabaseHandler dh = new DatabaseHandler("database.db");

            DataTable dt = dh.executeQuery("select * from PARTS");

            foreach (DataRow dr in dt.Rows)
            {
                string partNum = dr["PART_NUM"].ToString();

                this.cbPartNum.Items.Add(partNum);
                this.cbPartN.Items.Add(partNum);

                this.parts.Add(new Part(
                    partNum,
                    Convert.ToInt32(dr["NUM_TOOLS"].ToString())
                    ));
            }

            this.populateParts();

            if (this.cbPartNum.Items.Count > 0)
                this.cbPartNum.SelectedIndex = 0;

            if (this.cbPartN.Items.Count > 0)
                this.cbPartN.SelectedIndex = 0;

        }

        private void populateParts()
        {
            this.dgvParts.Rows.Clear();

            for (int i = 0; i < this.parts.Count; ++i)
            {
                Part p = this.parts[i];

                this.dgvParts.Rows.Add();

                this.dgvParts["partNum", i].Value = p.getPartNum();
                this.dgvParts["numTools", i].Value = p.getNumTools();

            }
        }

        private void btnDeletePart_Click(object sender, EventArgs e)
        {
            if (this.parts.Count == 0)
                return;

            DatabaseHandler dh = new DatabaseHandler("database.db");

            dh.executeNonQuery($"delete from PARTS where PART_NUM={this.cbPartNum.SelectedItem}");

            this.refreshParts();
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            DatabaseHandler dh = new DatabaseHandler("database.db");

            dh.executeNonQuery($"insert into ORDERS (ORDER_NUM, PART_NUM, QUANTITY, DATE) VALUES (\"{this.tbOrderNum.Text}\", \"{this.cbPartN.SelectedItem}\", {this.nQuantity.Value}, \"{this.dtpDueDate.Value.ToShortDateString()}\")");

            this.refreshOrders();
        }

        private void populateOrders()
        {
            this.dgvOrders.Rows.Clear();

            for (int i = 0; i < this.orders.Count; ++i)
            {
                Order o = this.orders[i];

                this.dgvOrders.Rows.Add();

                this.dgvOrders["orderNum", i].Value = o.getOrderNum();
                this.dgvOrders["partNumOrder", i].Value = o.getPartNum();
                this.dgvOrders["quantity", i].Value = o.getQuantity();
                this.dgvOrders["dueDate", i].Value = o.getDueDate().ToShortDateString();

            }
        }

        private void refreshOrders()
        {
            this.cbOrderNum.Items.Clear();
            this.orders.Clear();

            DatabaseHandler dh = new DatabaseHandler("database.db");

            DataTable dt = dh.executeQuery("select * from ORDERS");

            foreach (DataRow dr in dt.Rows)
            {
                this.cbOrderNum.Items.Add(dr["ORDER_NUM"].ToString());

                this.orders.Add(new Order(
                    dr["ORDER_NUM"].ToString(),
                    dr["PART_NUM"].ToString(),
                    Convert.ToInt32(dr["QUANTITY"].ToString()),
                    DateTime.Parse(dr["DATE"].ToString())
                    ));
            }

            this.populateOrders();

            if (this.cbOrderNum.Items.Count > 0)
                this.cbOrderNum.SelectedIndex = 0;
        }

        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {
            if (this.orders.Count == 0)
                return;

            DatabaseHandler dh = new DatabaseHandler("database.db");

            dh.executeNonQuery($"delete from ORDERS where ORDER_NUM=\"{this.cbOrderNum.SelectedItem}\"");

            this.refreshOrders();
        }
    }
}
