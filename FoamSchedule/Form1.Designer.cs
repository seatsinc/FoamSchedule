﻿
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
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.nOverallEfficiency = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.nLineCycle = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.nMaxTools = new System.Windows.Forms.NumericUpDown();
            this.dgvShifts = new System.Windows.Forms.DataGridView();
            this.dtpShiftStart = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpShiftEnd = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbWeekdays = new System.Windows.Forms.ComboBox();
            this.btnAddShift = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbShiftId = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelShift = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weekdayName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.start = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.end = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.breakHours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nBreakHours = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbPartNum = new System.Windows.Forms.TextBox();
            this.nNumTools = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAddPart = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nOverallEfficiency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nLineCycle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nMaxTools)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShifts)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nBreakHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nNumTools)).BeginInit();
            this.groupBox4.SuspendLayout();
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
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 400);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Orders";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox4);
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Controls.Add(this.dataGridView1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(768, 400);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Parts";
            this.tabPage3.UseVisualStyleBackColor = true;
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
            this.dgvShifts.Size = new System.Drawing.Size(581, 388);
            this.dgvShifts.TabIndex = 0;
            // 
            // dtpShiftStart
            // 
            this.dtpShiftStart.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpShiftStart.Location = new System.Drawing.Point(41, 43);
            this.dtpShiftStart.Name = "dtpShiftStart";
            this.dtpShiftStart.ShowUpDown = true;
            this.dtpShiftStart.Size = new System.Drawing.Size(116, 20);
            this.dtpShiftStart.TabIndex = 2;
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
            // dtpShiftEnd
            // 
            this.dtpShiftEnd.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpShiftEnd.Location = new System.Drawing.Point(41, 69);
            this.dtpShiftEnd.Name = "dtpShiftEnd";
            this.dtpShiftEnd.ShowUpDown = true;
            this.dtpShiftEnd.Size = new System.Drawing.Size(116, 20);
            this.dtpShiftEnd.TabIndex = 4;
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
            this.groupBox1.Location = new System.Drawing.Point(593, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(169, 158);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Shift";
            // 
            // cbWeekdays
            // 
            this.cbWeekdays.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbWeekdays.FormattingEnabled = true;
            this.cbWeekdays.Location = new System.Drawing.Point(6, 19);
            this.cbWeekdays.Name = "cbWeekdays";
            this.cbWeekdays.Size = new System.Drawing.Size(151, 21);
            this.cbWeekdays.TabIndex = 7;
            // 
            // btnAddShift
            // 
            this.btnAddShift.BackColor = System.Drawing.Color.PaleGreen;
            this.btnAddShift.Location = new System.Drawing.Point(6, 121);
            this.btnAddShift.Name = "btnAddShift";
            this.btnAddShift.Size = new System.Drawing.Size(151, 23);
            this.btnAddShift.TabIndex = 8;
            this.btnAddShift.Text = "+";
            this.btnAddShift.UseVisualStyleBackColor = false;
            this.btnAddShift.Click += new System.EventHandler(this.btnAddShift_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDelShift);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cbShiftId);
            this.groupBox2.Location = new System.Drawing.Point(593, 170);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(169, 81);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Delete Shift";
            // 
            // cbShiftId
            // 
            this.cbShiftId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbShiftId.FormattingEnabled = true;
            this.cbShiftId.Location = new System.Drawing.Point(28, 19);
            this.cbShiftId.Name = "cbShiftId";
            this.cbShiftId.Size = new System.Drawing.Size(129, 21);
            this.cbShiftId.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Id";
            // 
            // btnDelShift
            // 
            this.btnDelShift.BackColor = System.Drawing.Color.Crimson;
            this.btnDelShift.Location = new System.Drawing.Point(9, 46);
            this.btnDelShift.Name = "btnDelShift";
            this.btnDelShift.Size = new System.Drawing.Size(148, 23);
            this.btnDelShift.TabIndex = 8;
            this.btnDelShift.Text = "x";
            this.btnDelShift.UseVisualStyleBackColor = false;
            this.btnDelShift.Click += new System.EventHandler(this.btnDelShift_Click);
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
            this.nBreakHours.Size = new System.Drawing.Size(79, 20);
            this.nBreakHours.TabIndex = 9;
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
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(543, 388);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnAddPart);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.nNumTools);
            this.groupBox3.Controls.Add(this.tbPartNum);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(555, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(207, 107);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Add Part";
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
            // tbPartNum
            // 
            this.tbPartNum.Location = new System.Drawing.Point(55, 19);
            this.tbPartNum.Name = "tbPartNum";
            this.tbPartNum.Size = new System.Drawing.Size(139, 20);
            this.tbPartNum.TabIndex = 1;
            // 
            // nNumTools
            // 
            this.nNumTools.Location = new System.Drawing.Point(55, 45);
            this.nNumTools.Name = "nNumTools";
            this.nNumTools.Size = new System.Drawing.Size(139, 20);
            this.nNumTools.TabIndex = 2;
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
            // btnAddPart
            // 
            this.btnAddPart.BackColor = System.Drawing.Color.PaleGreen;
            this.btnAddPart.Location = new System.Drawing.Point(9, 71);
            this.btnAddPart.Name = "btnAddPart";
            this.btnAddPart.Size = new System.Drawing.Size(185, 23);
            this.btnAddPart.TabIndex = 4;
            this.btnAddPart.Text = "+";
            this.btnAddPart.UseVisualStyleBackColor = false;
            this.btnAddPart.Click += new System.EventHandler(this.btnAddPart_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Controls.Add(this.comboBox1);
            this.groupBox4.Location = new System.Drawing.Point(555, 119);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(207, 82);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Delete Part";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(9, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(185, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Crimson;
            this.button2.Location = new System.Drawing.Point(9, 47);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(185, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "x";
            this.button2.UseVisualStyleBackColor = false;
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
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nOverallEfficiency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nLineCycle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nMaxTools)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShifts)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nBreakHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nNumTools)).EndInit();
            this.groupBox4.ResumeLayout(false);
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
        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

