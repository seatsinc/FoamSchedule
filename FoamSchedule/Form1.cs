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
        private List<Block> blocks = new List<Block>();
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
            this.refreshParts();
            this.refreshOrders();
            this.refreshShifts();
            this.refreshBlocks();
            this.initWeekdays();

        }

        private void refreshConstants()
        {
            DatabaseHandler dh = new DatabaseHandler("database.db");

            DataTable dt = dh.executeQuery("select VALUE from CONSTANTS where NAME='MAX_TOOLS'");
            this.nMaxTools.Value = Convert.ToInt32(dt.Rows[0]["VALUE"].ToString());

            dt = dh.executeQuery("select VALUE from CONSTANTS where NAME='LINE_CYCLE'");
            this.nLineCycle.Value = Convert.ToInt32(dt.Rows[0]["VALUE"].ToString());

            dt = dh.executeQuery("select VALUE from CONSTANTS where NAME='OVERALL_EFFICIENCY'");
            this.nOverallEfficiency.Value = Convert.ToInt32(dt.Rows[0]["VALUE"].ToString());
        }

        private void nMaxTools_ValueChanged(object sender, EventArgs e)
        {
            DatabaseHandler dh = new DatabaseHandler("database.db");

            dh.executeNonQuery($"update CONSTANTS set VALUE={this.nMaxTools.Value} where NAME='MAX_TOOLS'");
        }

        private void nLineCycle_ValueChanged(object sender, EventArgs e)
        {
            DatabaseHandler dh = new DatabaseHandler("database.db");

            dh.executeNonQuery($"update CONSTANTS set VALUE={this.nLineCycle.Value} where NAME='LINE_CYCLE'");
        }

        private void nOverallEfficiency_ValueChanged(object sender, EventArgs e)
        {
            DatabaseHandler dh = new DatabaseHandler("database.db");

            dh.executeNonQuery($"update CONSTANTS set VALUE={this.nOverallEfficiency.Value} where NAME='OVERALL_EFFICIENCY'");
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



        private void btnAddPart_Click(object sender, EventArgs e)
        {
            DatabaseHandler dh = new DatabaseHandler("database.db");

            try
            {
                dh.executeNonQuery($"insert into PARTS (PART_NUM, NUM_TOOLS) VALUES ('{this.tbPartNum.Text}', {this.nNumTools.Value})");
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

            if (this.parts.Count > 0)
            {
                this.cbPartNum.SelectedIndex = 0;
                this.cbPartN.SelectedIndex = 0;
            }


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

            dh.executeNonQuery($"delete from ORDERS where PART_NUM='{this.cbPartNum.SelectedItem}'");

            dh.executeNonQuery($"delete from PARTS where PART_NUM='{this.cbPartNum.SelectedItem}'");

            this.refreshParts();
            this.refreshOrders();
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            DatabaseHandler dh = new DatabaseHandler("database.db");

            dh.executeNonQuery($"insert into ORDERS (ORDER_NUM, PART_NUM, QUANTITY, DATE) VALUES ('{this.tbOrderNum.Text}', '{this.cbPartN.SelectedItem}', {this.nQuantity.Value}, '{this.dtpDueDate.Value.ToShortDateString()}')");

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
                this.dgvOrders["partNumOrder", i].Value = o.getPart().getPartNum();
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


                DatabaseHandler dh2 = new DatabaseHandler("database.db");
                DataTable dt2 = dh2.executeQuery($"select * from PARTS where PART_NUM='{dr["PART_NUM"]}'");

                DataRow dr2 = dt2.Rows[0];


                this.orders.Add(new Order(
                    dr["ORDER_NUM"].ToString(),
                    new Part(dr2["PART_NUM"].ToString(), Convert.ToInt32(dr2["NUM_TOOLS"].ToString())),
                    Convert.ToInt32(dr["QUANTITY"].ToString()),
                    DateTime.Parse(dr["DATE"].ToString())
                    ));
            }

            this.populateOrders();

            if (this.orders.Count > 0)
                this.cbOrderNum.SelectedIndex = 0;
        }

        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {
            if (this.orders.Count == 0)
                return;

            DatabaseHandler dh = new DatabaseHandler("database.db");

            dh.executeNonQuery($"delete from ORDERS where ORDER_NUM='{this.cbOrderNum.SelectedItem}'");

            this.refreshOrders();
        }

        private void btnAddShift_Click(object sender, EventArgs e)
        {
            DatabaseHandler dh = new DatabaseHandler("database.db");

            dh.executeNonQuery($"insert into SHIFTS (NAME) VALUES ('{this.tbShift.Text}')");

            this.refreshShifts();

        }

        private void btnDeleteShift_Click(object sender, EventArgs e)
        {
            DatabaseHandler dh = new DatabaseHandler("database.db");

            dh.executeNonQuery($"delete from BLOCKS where SHIFT='{this.cbShift.SelectedItem}'");
            dh.executeNonQuery($"delete from SHIFTS where NAME='{this.cbShift.SelectedItem}'");

            this.refreshShifts();
            this.refreshBlocks();
        }

        private void refreshShifts()
        {

            this.shifts.Clear();

            DatabaseHandler dh = new DatabaseHandler("database.db");

            DataTable dt = dh.executeQuery("select * from SHIFTS");

            foreach (DataRow dr in dt.Rows)
            {
                this.shifts.Add(new Shift(dr["NAME"].ToString()));
            }

            this.populateShifts();
        }

        private void populateShifts()
        {
            this.cbShift.Items.Clear();
            this.dgvShifts.Rows.Clear();
            this.cbShifts.Items.Clear();

            for (int i = 0; i < this.shifts.Count; ++i)
            {
                Shift s = this.shifts[i];

                this.dgvShifts.Rows.Add();
                this.dgvShifts["shift", i].Value = s.getName();

                this.cbShift.Items.Add(s.getName());
                this.cbShifts.Items.Add(s.getName());
            }

            if (this.shifts.Count > 0)
            {
                this.cbShift.SelectedIndex = 0;
                this.cbShifts.SelectedIndex = 0;
            }

        }

        private void refreshBlocks()
        {
            this.blocks.Clear();

            DatabaseHandler dbh = new DatabaseHandler("database.db");

            DataTable dt = dbh.executeQuery("select * from BLOCKS");

            foreach (DataRow dr in dt.Rows)
            {
                this.blocks.Add(new Block(
                    dr["WEEKDAY_NAME"].ToString(),
                    Convert.ToInt32(dr["ID"].ToString()),
                    Convert.ToDateTime(dr["START"].ToString()),
                    Convert.ToDateTime(dr["END"].ToString()),
                    Convert.ToDouble(dr["BREAK_HOURS"].ToString()),
                    new Shift(dr["SHIFT"].ToString())
                ));
            }

            this.populateBlocks();
        }

        private void populateBlocks()
        {
            this.cbBlockId.Items.Clear();
            this.dgvBlocks.Rows.Clear();

            for (int i = 0; i < this.blocks.Count; ++i)
            {
                Block b = this.blocks[i];

                this.dgvBlocks.Rows.Add();

                this.cbBlockId.Items.Add(b.getId());

                this.dgvBlocks["id", i].Value = b.getId();
                this.dgvBlocks["shiftName", i].Value = b.getShift().getName();
                this.dgvBlocks["weekdayName", i].Value = b.getWeekday();
                this.dgvBlocks["start", i].Value = b.getStartTime().ToShortTimeString();
                this.dgvBlocks["end", i].Value = b.getEndTime().ToShortTimeString();
                this.dgvBlocks["breakHours", i].Value = b.getBreakHours();

            }

            if (this.cbBlockId.Items.Count > 0)
            {
                this.cbBlockId.SelectedIndex = 0;
            }
        }

        private void btnAddBlock_Click(object sender, EventArgs e)
        {
            DatabaseHandler dbh = new DatabaseHandler("database.db");

            dbh.executeNonQuery($"insert into BLOCKS (SHIFT, WEEKDAY_NAME, START, END, BREAK_HOURS) VALUES ('{this.cbShifts.SelectedItem}', '{this.cbWeekdays.SelectedItem}', '{this.dtpShiftStart.Value.ToShortTimeString()}', '{this.dtpShiftEnd.Value.ToShortTimeString()}', {this.nBreakHours.Value})");

            this.refreshBlocks();
        }

        private void btnDeleteBlock_Click(object sender, EventArgs e)
        {
            DatabaseHandler dbh = new DatabaseHandler("database.db");

            dbh.executeNonQuery($"delete from BLOCKS where ID={this.cbBlockId.SelectedItem}");

            this.refreshBlocks();
        }
    }
}
