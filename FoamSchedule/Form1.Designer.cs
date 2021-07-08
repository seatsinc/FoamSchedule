
namespace FoamSchedule
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnDeleteOrder = new System.Windows.Forms.Button();
            this.cbOrderNum = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.dtpDueDate = new System.Windows.Forms.DateTimePicker();
            this.nQuantity = new System.Windows.Forms.NumericUpDown();
            this.cbPartN = new System.Windows.Forms.ComboBox();
            this.tbOrderNum = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.orderNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partNumOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnDeletePart = new System.Windows.Forms.Button();
            this.cbPartNum = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnAddPart = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.nNumTools = new System.Windows.Forms.NumericUpDown();
            this.tbPartNum = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvParts = new System.Windows.Forms.DataGridView();
            this.partNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numTools = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDelShift = new System.Windows.Forms.Button();
            this.cbShiftId = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nBreakHours = new System.Windows.Forms.NumericUpDown();
            this.btnAddShift = new System.Windows.Forms.Button();
            this.cbWeekdays = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpShiftStart = new System.Windows.Forms.DateTimePicker();
            this.dtpShiftEnd = new System.Windows.Forms.DateTimePicker();
            this.dgvShifts = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weekdayName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.start = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.end = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.breakHours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.nOverallEfficiency = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.nLineCycle = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.nMaxTools = new System.Windows.Forms.NumericUpDown();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nNumTools)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParts)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nBreakHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShifts)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nOverallEfficiency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nLineCycle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nMaxTools)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 400);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Foam Schedule";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox6);
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Controls.Add(this.dgvOrders);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 400);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Orders";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnDeleteOrder);
            this.groupBox6.Controls.Add(this.cbOrderNum);
            this.groupBox6.Location = new System.Drawing.Point(578, 172);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(184, 81);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Delete Order";
            // 
            // btnDeleteOrder
            // 
            this.btnDeleteOrder.BackColor = System.Drawing.Color.LightCoral;
            this.btnDeleteOrder.Location = new System.Drawing.Point(6, 46);
            this.btnDeleteOrder.Name = "btnDeleteOrder";
            this.btnDeleteOrder.Size = new System.Drawing.Size(172, 23);
            this.btnDeleteOrder.TabIndex = 7;
            this.btnDeleteOrder.Text = "Delete Order";
            this.btnDeleteOrder.UseVisualStyleBackColor = false;
            this.btnDeleteOrder.Click += new System.EventHandler(this.btnDeleteOrder_Click);
            // 
            // cbOrderNum
            // 
            this.cbOrderNum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOrderNum.FormattingEnabled = true;
            this.cbOrderNum.Location = new System.Drawing.Point(6, 19);
            this.cbOrderNum.Name = "cbOrderNum";
            this.cbOrderNum.Size = new System.Drawing.Size(172, 21);
            this.cbOrderNum.TabIndex = 3;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnAddOrder);
            this.groupBox5.Controls.Add(this.dtpDueDate);
            this.groupBox5.Controls.Add(this.nQuantity);
            this.groupBox5.Controls.Add(this.cbPartN);
            this.groupBox5.Controls.Add(this.tbOrderNum);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Location = new System.Drawing.Point(578, 6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(184, 160);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.BackColor = System.Drawing.Color.PaleGreen;
            this.btnAddOrder.Location = new System.Drawing.Point(6, 124);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(172, 23);
            this.btnAddOrder.TabIndex = 6;
            this.btnAddOrder.Text = "Add Order";
            this.btnAddOrder.UseVisualStyleBackColor = false;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // dtpDueDate
            // 
            this.dtpDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDueDate.Location = new System.Drawing.Point(55, 98);
            this.dtpDueDate.Name = "dtpDueDate";
            this.dtpDueDate.Size = new System.Drawing.Size(123, 20);
            this.dtpDueDate.TabIndex = 5;
            // 
            // nQuantity
            // 
            this.nQuantity.Location = new System.Drawing.Point(55, 72);
            this.nQuantity.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nQuantity.Name = "nQuantity";
            this.nQuantity.Size = new System.Drawing.Size(123, 20);
            this.nQuantity.TabIndex = 4;
            this.nQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbPartN
            // 
            this.cbPartN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPartN.FormattingEnabled = true;
            this.cbPartN.Location = new System.Drawing.Point(55, 45);
            this.cbPartN.Name = "cbPartN";
            this.cbPartN.Size = new System.Drawing.Size(123, 21);
            this.cbPartN.TabIndex = 2;
            // 
            // tbOrderNum
            // 
            this.tbOrderNum.Location = new System.Drawing.Point(55, 19);
            this.tbOrderNum.Name = "tbOrderNum";
            this.tbOrderNum.Size = new System.Drawing.Size(123, 20);
            this.tbOrderNum.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 98);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(30, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "Date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Quantity";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Part #";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Order #";
            // 
            // dgvOrders
            // 
            this.dgvOrders.AllowUserToAddRows = false;
            this.dgvOrders.AllowUserToDeleteRows = false;
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderNum,
            this.partNumOrder,
            this.quantity,
            this.dueDate});
            this.dgvOrders.Location = new System.Drawing.Point(6, 6);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.ReadOnly = true;
            this.dgvOrders.Size = new System.Drawing.Size(566, 388);
            this.dgvOrders.TabIndex = 0;
            // 
            // orderNum
            // 
            this.orderNum.HeaderText = "Order #";
            this.orderNum.Name = "orderNum";
            this.orderNum.ReadOnly = true;
            // 
            // partNumOrder
            // 
            this.partNumOrder.HeaderText = "Part #";
            this.partNumOrder.Name = "partNumOrder";
            this.partNumOrder.ReadOnly = true;
            // 
            // quantity
            // 
            this.quantity.HeaderText = "Quantity";
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            // 
            // dueDate
            // 
            this.dueDate.HeaderText = "Due Date";
            this.dueDate.Name = "dueDate";
            this.dueDate.ReadOnly = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox4);
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Controls.Add(this.dgvParts);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(768, 400);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Parts";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnDeletePart);
            this.groupBox4.Controls.Add(this.cbPartNum);
            this.groupBox4.Location = new System.Drawing.Point(578, 119);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(184, 82);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            // 
            // btnDeletePart
            // 
            this.btnDeletePart.BackColor = System.Drawing.Color.LightCoral;
            this.btnDeletePart.Location = new System.Drawing.Point(9, 47);
            this.btnDeletePart.Name = "btnDeletePart";
            this.btnDeletePart.Size = new System.Drawing.Size(169, 23);
            this.btnDeletePart.TabIndex = 1;
            this.btnDeletePart.Text = "Delete Part";
            this.btnDeletePart.UseVisualStyleBackColor = false;
            this.btnDeletePart.Click += new System.EventHandler(this.btnDeletePart_Click);
            // 
            // cbPartNum
            // 
            this.cbPartNum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPartNum.FormattingEnabled = true;
            this.cbPartNum.Location = new System.Drawing.Point(9, 19);
            this.cbPartNum.Name = "cbPartNum";
            this.cbPartNum.Size = new System.Drawing.Size(169, 21);
            this.cbPartNum.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnAddPart);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.nNumTools);
            this.groupBox3.Controls.Add(this.tbPartNum);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(578, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(184, 107);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            // 
            // btnAddPart
            // 
            this.btnAddPart.BackColor = System.Drawing.Color.PaleGreen;
            this.btnAddPart.Location = new System.Drawing.Point(9, 71);
            this.btnAddPart.Name = "btnAddPart";
            this.btnAddPart.Size = new System.Drawing.Size(169, 23);
            this.btnAddPart.TabIndex = 4;
            this.btnAddPart.Text = "Add Part";
            this.btnAddPart.UseVisualStyleBackColor = false;
            this.btnAddPart.Click += new System.EventHandler(this.btnAddPart_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "# Tools";
            // 
            // nNumTools
            // 
            this.nNumTools.Location = new System.Drawing.Point(55, 45);
            this.nNumTools.Name = "nNumTools";
            this.nNumTools.Size = new System.Drawing.Size(123, 20);
            this.nNumTools.TabIndex = 2;
            // 
            // tbPartNum
            // 
            this.tbPartNum.Location = new System.Drawing.Point(55, 19);
            this.tbPartNum.Name = "tbPartNum";
            this.tbPartNum.Size = new System.Drawing.Size(123, 20);
            this.tbPartNum.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Part #";
            // 
            // dgvParts
            // 
            this.dgvParts.AllowUserToAddRows = false;
            this.dgvParts.AllowUserToDeleteRows = false;
            this.dgvParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.partNum,
            this.numTools});
            this.dgvParts.Location = new System.Drawing.Point(6, 6);
            this.dgvParts.Name = "dgvParts";
            this.dgvParts.ReadOnly = true;
            this.dgvParts.Size = new System.Drawing.Size(566, 388);
            this.dgvParts.TabIndex = 0;
            // 
            // partNum
            // 
            this.partNum.HeaderText = "Part #";
            this.partNum.Name = "partNum";
            this.partNum.ReadOnly = true;
            // 
            // numTools
            // 
            this.numTools.HeaderText = "# Tools";
            this.numTools.Name = "numTools";
            this.numTools.ReadOnly = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.groupBox2);
            this.tabPage4.Controls.Add(this.groupBox1);
            this.tabPage4.Controls.Add(this.dgvShifts);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(768, 400);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Shifts";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDelShift);
            this.groupBox2.Controls.Add(this.cbShiftId);
            this.groupBox2.Location = new System.Drawing.Point(578, 170);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(184, 81);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // btnDelShift
            // 
            this.btnDelShift.BackColor = System.Drawing.Color.LightCoral;
            this.btnDelShift.Location = new System.Drawing.Point(6, 46);
            this.btnDelShift.Name = "btnDelShift";
            this.btnDelShift.Size = new System.Drawing.Size(172, 23);
            this.btnDelShift.TabIndex = 8;
            this.btnDelShift.Text = "Delete Shift";
            this.btnDelShift.UseVisualStyleBackColor = false;
            this.btnDelShift.Click += new System.EventHandler(this.btnDelShift_Click);
            // 
            // cbShiftId
            // 
            this.cbShiftId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbShiftId.FormattingEnabled = true;
            this.cbShiftId.Location = new System.Drawing.Point(6, 19);
            this.cbShiftId.Name = "cbShiftId";
            this.cbShiftId.Size = new System.Drawing.Size(172, 21);
            this.cbShiftId.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.nBreakHours);
            this.groupBox1.Controls.Add(this.btnAddShift);
            this.groupBox1.Controls.Add(this.cbWeekdays);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtpShiftStart);
            this.groupBox1.Controls.Add(this.dtpShiftEnd);
            this.groupBox1.Location = new System.Drawing.Point(578, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(184, 158);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Break Hours";
            // 
            // nBreakHours
            // 
            this.nBreakHours.DecimalPlaces = 2;
            this.nBreakHours.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nBreakHours.Location = new System.Drawing.Point(78, 95);
            this.nBreakHours.Name = "nBreakHours";
            this.nBreakHours.Size = new System.Drawing.Size(100, 20);
            this.nBreakHours.TabIndex = 9;
            // 
            // btnAddShift
            // 
            this.btnAddShift.BackColor = System.Drawing.Color.PaleGreen;
            this.btnAddShift.Location = new System.Drawing.Point(6, 121);
            this.btnAddShift.Name = "btnAddShift";
            this.btnAddShift.Size = new System.Drawing.Size(172, 23);
            this.btnAddShift.TabIndex = 8;
            this.btnAddShift.Text = "Add Shift";
            this.btnAddShift.UseVisualStyleBackColor = false;
            this.btnAddShift.Click += new System.EventHandler(this.btnAddShift_Click);
            // 
            // cbWeekdays
            // 
            this.cbWeekdays.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbWeekdays.FormattingEnabled = true;
            this.cbWeekdays.Location = new System.Drawing.Point(6, 19);
            this.cbWeekdays.Name = "cbWeekdays";
            this.cbWeekdays.Size = new System.Drawing.Size(172, 21);
            this.cbWeekdays.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Start";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "End";
            // 
            // dtpShiftStart
            // 
            this.dtpShiftStart.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpShiftStart.Location = new System.Drawing.Point(41, 43);
            this.dtpShiftStart.Name = "dtpShiftStart";
            this.dtpShiftStart.ShowUpDown = true;
            this.dtpShiftStart.Size = new System.Drawing.Size(137, 20);
            this.dtpShiftStart.TabIndex = 2;
            // 
            // dtpShiftEnd
            // 
            this.dtpShiftEnd.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpShiftEnd.Location = new System.Drawing.Point(41, 69);
            this.dtpShiftEnd.Name = "dtpShiftEnd";
            this.dtpShiftEnd.ShowUpDown = true;
            this.dtpShiftEnd.Size = new System.Drawing.Size(137, 20);
            this.dtpShiftEnd.TabIndex = 4;
            // 
            // dgvShifts
            // 
            this.dgvShifts.AllowUserToAddRows = false;
            this.dgvShifts.AllowUserToDeleteRows = false;
            this.dgvShifts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShifts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.weekdayName,
            this.start,
            this.end,
            this.breakHours});
            this.dgvShifts.Location = new System.Drawing.Point(6, 6);
            this.dgvShifts.Name = "dgvShifts";
            this.dgvShifts.ReadOnly = true;
            this.dgvShifts.Size = new System.Drawing.Size(566, 388);
            this.dgvShifts.TabIndex = 0;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // weekdayName
            // 
            this.weekdayName.HeaderText = "WEEKDAY";
            this.weekdayName.Name = "weekdayName";
            this.weekdayName.ReadOnly = true;
            // 
            // start
            // 
            this.start.HeaderText = "START";
            this.start.Name = "start";
            this.start.ReadOnly = true;
            // 
            // end
            // 
            this.end.HeaderText = "END";
            this.end.Name = "end";
            this.end.ReadOnly = true;
            // 
            // breakHours
            // 
            this.breakHours.HeaderText = "BREAK HOURS";
            this.breakHours.Name = "breakHours";
            this.breakHours.ReadOnly = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.label12);
            this.tabPage5.Controls.Add(this.nOverallEfficiency);
            this.tabPage5.Controls.Add(this.label11);
            this.tabPage5.Controls.Add(this.nLineCycle);
            this.tabPage5.Controls.Add(this.label10);
            this.tabPage5.Controls.Add(this.nMaxTools);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(768, 400);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Constants";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 70);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(106, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "Overall Efficiency (%)";
            // 
            // nOverallEfficiency
            // 
            this.nOverallEfficiency.Location = new System.Drawing.Point(127, 68);
            this.nOverallEfficiency.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nOverallEfficiency.Name = "nOverallEfficiency";
            this.nOverallEfficiency.Size = new System.Drawing.Size(120, 20);
            this.nOverallEfficiency.TabIndex = 10;
            this.nOverallEfficiency.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nOverallEfficiency.ValueChanged += new System.EventHandler(this.nOverallEfficiency_ValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 44);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "Line Cycle (sec)";
            // 
            // nLineCycle
            // 
            this.nLineCycle.Location = new System.Drawing.Point(127, 42);
            this.nLineCycle.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nLineCycle.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nLineCycle.Name = "nLineCycle";
            this.nLineCycle.Size = new System.Drawing.Size(120, 20);
            this.nLineCycle.TabIndex = 8;
            this.nLineCycle.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nLineCycle.ValueChanged += new System.EventHandler(this.nLineCycle_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "Max Tools";
            // 
            // nMaxTools
            // 
            this.nMaxTools.Location = new System.Drawing.Point(128, 16);
            this.nMaxTools.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nMaxTools.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nMaxTools.Name = "nMaxTools";
            this.nMaxTools.Size = new System.Drawing.Size(120, 20);
            this.nMaxTools.TabIndex = 6;
            this.nMaxTools.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nMaxTools.ValueChanged += new System.EventHandler(this.nMaxTools_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nNumTools)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParts)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nBreakHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShifts)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nOverallEfficiency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nLineCycle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nMaxTools)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown nOverallEfficiency;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown nLineCycle;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown nMaxTools;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbWeekdays;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpShiftStart;
        private System.Windows.Forms.DateTimePicker dtpShiftEnd;
        private System.Windows.Forms.DataGridView dgvShifts;
        private System.Windows.Forms.Button btnAddShift;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDelShift;
        private System.Windows.Forms.ComboBox cbShiftId;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn weekdayName;
        private System.Windows.Forms.DataGridViewTextBoxColumn start;
        private System.Windows.Forms.DataGridViewTextBoxColumn end;
        private System.Windows.Forms.DataGridViewTextBoxColumn breakHours;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nBreakHours;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnAddPart;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nNumTools;
        private System.Windows.Forms.TextBox tbPartNum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvParts;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnDeletePart;
        private System.Windows.Forms.ComboBox cbPartNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn partNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn numTools;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnDeleteOrder;
        private System.Windows.Forms.ComboBox cbOrderNum;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.DateTimePicker dtpDueDate;
        private System.Windows.Forms.NumericUpDown nQuantity;
        private System.Windows.Forms.ComboBox cbPartN;
        private System.Windows.Forms.TextBox tbOrderNum;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn partNumOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn dueDate;
    }
}

