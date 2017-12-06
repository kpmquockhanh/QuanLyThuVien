namespace GUI
{
    partial class frmBorrow
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvBorrow = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gb1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnE = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnR = new System.Windows.Forms.Button();
            this.btnD = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnA = new System.Windows.Forms.Button();
            this.txtQuanity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRID = new System.Windows.Forms.Label();
            this.a = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDeposit = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cbxBookID = new System.Windows.Forms.ComboBox();
            this.cbxStaffID = new System.Windows.Forms.ComboBox();
            this.cbxReadID = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrow)).BeginInit();
            this.gb1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBorrow
            // 
            this.dgvBorrow.AllowUserToAddRows = false;
            this.dgvBorrow.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Tan;
            this.dgvBorrow.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBorrow.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBorrow.BackgroundColor = System.Drawing.Color.White;
            this.dgvBorrow.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBorrow.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvBorrow.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto Condensed Light", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBorrow.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBorrow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBorrow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvBorrow.EnableHeadersVisualStyles = false;
            this.dgvBorrow.GridColor = System.Drawing.Color.White;
            this.dgvBorrow.Location = new System.Drawing.Point(10, 368);
            this.dgvBorrow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvBorrow.MultiSelect = false;
            this.dgvBorrow.Name = "dgvBorrow";
            this.dgvBorrow.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Roboto Condensed Light", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBorrow.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBorrow.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvBorrow.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.dgvBorrow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBorrow.ShowCellToolTips = false;
            this.dgvBorrow.ShowEditingIcon = false;
            this.dgvBorrow.Size = new System.Drawing.Size(777, 239);
            this.dgvBorrow.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Tan;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 5);
            this.panel1.TabIndex = 5;
            // 
            // gb1
            // 
            this.gb1.Controls.Add(this.cbxReadID);
            this.gb1.Controls.Add(this.cbxStaffID);
            this.gb1.Controls.Add(this.cbxBookID);
            this.gb1.Controls.Add(this.dateTimePicker2);
            this.gb1.Controls.Add(this.dateTimePicker1);
            this.gb1.Controls.Add(this.btnE);
            this.gb1.Controls.Add(this.btnSearch);
            this.gb1.Controls.Add(this.btnR);
            this.gb1.Controls.Add(this.btnD);
            this.gb1.Controls.Add(this.btnEdit);
            this.gb1.Controls.Add(this.btnA);
            this.gb1.Controls.Add(this.txtQuanity);
            this.gb1.Controls.Add(this.label4);
            this.gb1.Controls.Add(this.label3);
            this.gb1.Controls.Add(this.txtRID);
            this.gb1.Controls.Add(this.a);
            this.gb1.Controls.Add(this.label6);
            this.gb1.Controls.Add(this.txtDeposit);
            this.gb1.Controls.Add(this.label2);
            this.gb1.Controls.Add(this.label5);
            this.gb1.Controls.Add(this.txtID);
            this.gb1.Controls.Add(this.label1);
            this.gb1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gb1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.gb1.Location = new System.Drawing.Point(10, 79);
            this.gb1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gb1.Name = "gb1";
            this.gb1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gb1.Size = new System.Drawing.Size(777, 282);
            this.gb1.TabIndex = 6;
            this.gb1.TabStop = false;
            this.gb1.Text = "Thông tin người mượn";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CalendarFont = new System.Drawing.Font("Roboto Condensed Light", 12F);
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(105, 98);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(171, 24);
            this.dateTimePicker2.TabIndex = 27;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Roboto Condensed Light", 12F);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(104, 70);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(172, 24);
            this.dateTimePicker1.TabIndex = 27;
            // 
            // btnE
            // 
            this.btnE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btnE.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnE.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnE.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnE.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(237)))), ((int)(((byte)(144)))));
            this.btnE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(237)))), ((int)(((byte)(144)))));
            this.btnE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnE.Font = new System.Drawing.Font("Roboto Condensed Light", 15F);
            this.btnE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnE.Location = new System.Drawing.Point(640, 188);
            this.btnE.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnE.Name = "btnE";
            this.btnE.Size = new System.Drawing.Size(98, 56);
            this.btnE.TabIndex = 22;
            this.btnE.Text = "Thoát";
            this.btnE.UseVisualStyleBackColor = false;
            this.btnE.Click += new System.EventHandler(this.btnE_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnSearch.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(237)))), ((int)(((byte)(144)))));
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(237)))), ((int)(((byte)(144)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Roboto Condensed Light", 15F);
            this.btnSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnSearch.Location = new System.Drawing.Point(533, 188);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(98, 56);
            this.btnSearch.TabIndex = 22;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnR
            // 
            this.btnR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btnR.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnR.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(237)))), ((int)(((byte)(144)))));
            this.btnR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(237)))), ((int)(((byte)(144)))));
            this.btnR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnR.Font = new System.Drawing.Font("Roboto Condensed Light", 15F);
            this.btnR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnR.Location = new System.Drawing.Point(429, 188);
            this.btnR.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnR.Name = "btnR";
            this.btnR.Size = new System.Drawing.Size(98, 56);
            this.btnR.TabIndex = 23;
            this.btnR.Text = "Reset";
            this.btnR.UseVisualStyleBackColor = false;
            this.btnR.Click += new System.EventHandler(this.btnR_Click);
            // 
            // btnD
            // 
            this.btnD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btnD.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnD.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnD.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(237)))), ((int)(((byte)(144)))));
            this.btnD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(237)))), ((int)(((byte)(144)))));
            this.btnD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnD.Font = new System.Drawing.Font("Roboto Condensed Light", 15F);
            this.btnD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnD.Location = new System.Drawing.Point(325, 188);
            this.btnD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(98, 56);
            this.btnD.TabIndex = 24;
            this.btnD.Text = "Xóa";
            this.btnD.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnEdit.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(237)))), ((int)(((byte)(144)))));
            this.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(237)))), ((int)(((byte)(144)))));
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Roboto Condensed Light", 15F);
            this.btnEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnEdit.Location = new System.Drawing.Point(221, 188);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(98, 56);
            this.btnEdit.TabIndex = 25;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnA
            // 
            this.btnA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btnA.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnA.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnA.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(237)))), ((int)(((byte)(144)))));
            this.btnA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(237)))), ((int)(((byte)(144)))));
            this.btnA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnA.Font = new System.Drawing.Font("Roboto Condensed Light", 15F);
            this.btnA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnA.Location = new System.Drawing.Point(117, 188);
            this.btnA.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(98, 56);
            this.btnA.TabIndex = 26;
            this.btnA.Text = "Thêm";
            this.btnA.UseVisualStyleBackColor = false;
            // 
            // txtQuanity
            // 
            this.txtQuanity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQuanity.Font = new System.Drawing.Font("Roboto Condensed Light", 12F);
            this.txtQuanity.Location = new System.Drawing.Point(105, 128);
            this.txtQuanity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtQuanity.Name = "txtQuanity";
            this.txtQuanity.Size = new System.Drawing.Size(245, 27);
            this.txtQuanity.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto Condensed Light", 12F);
            this.label4.Location = new System.Drawing.Point(37, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Quanity:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto Condensed Light", 12F);
            this.label3.Location = new System.Drawing.Point(11, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Return date:";
            // 
            // txtRID
            // 
            this.txtRID.AutoSize = true;
            this.txtRID.Font = new System.Drawing.Font("Roboto Condensed Light", 12F);
            this.txtRID.Location = new System.Drawing.Point(361, 130);
            this.txtRID.Name = "txtRID";
            this.txtRID.Size = new System.Drawing.Size(73, 19);
            this.txtRID.TabIndex = 9;
            this.txtRID.Text = "Reader ID:";
            // 
            // a
            // 
            this.a.AutoSize = true;
            this.a.Font = new System.Drawing.Font("Roboto Condensed Light", 12F);
            this.a.Location = new System.Drawing.Point(374, 100);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(60, 19);
            this.a.TabIndex = 9;
            this.a.Text = "Staff ID:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto Condensed Light", 12F);
            this.label6.Location = new System.Drawing.Point(373, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 19);
            this.label6.TabIndex = 9;
            this.label6.Text = "Book ID:";
            // 
            // txtDeposit
            // 
            this.txtDeposit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDeposit.Font = new System.Drawing.Font("Roboto Condensed Light", 12F);
            this.txtDeposit.Location = new System.Drawing.Point(438, 38);
            this.txtDeposit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDeposit.Name = "txtDeposit";
            this.txtDeposit.Size = new System.Drawing.Size(299, 27);
            this.txtDeposit.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Condensed Light", 12F);
            this.label2.Location = new System.Drawing.Point(24, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "Take date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto Condensed Light", 12F);
            this.label5.Location = new System.Drawing.Point(375, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "Deposit:";
            // 
            // txtID
            // 
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtID.Font = new System.Drawing.Font("Roboto Condensed Light", 12F);
            this.txtID.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtID.Location = new System.Drawing.Point(105, 38);
            this.txtID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(245, 27);
            this.txtID.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Condensed Light", 12F);
            this.label1.Location = new System.Drawing.Point(72, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 19);
            this.label1.TabIndex = 12;
            this.label1.Text = "ID:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Roboto Condensed Light", 35F);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label9.Location = new System.Drawing.Point(207, 19);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(383, 57);
            this.label9.TabIndex = 12;
            this.label9.Text = "Quản lí người mượn";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Tan;
            this.button1.Location = new System.Drawing.Point(762, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 25);
            this.button1.TabIndex = 13;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Tan;
            this.button2.Location = new System.Drawing.Point(731, 11);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(25, 25);
            this.button2.TabIndex = 13;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // cbxBookID
            // 
            this.cbxBookID.FormattingEnabled = true;
            this.cbxBookID.Location = new System.Drawing.Point(441, 73);
            this.cbxBookID.Name = "cbxBookID";
            this.cbxBookID.Size = new System.Drawing.Size(121, 23);
            this.cbxBookID.TabIndex = 28;
            // 
            // cbxStaffID
            // 
            this.cbxStaffID.FormattingEnabled = true;
            this.cbxStaffID.Location = new System.Drawing.Point(441, 100);
            this.cbxStaffID.Name = "cbxStaffID";
            this.cbxStaffID.Size = new System.Drawing.Size(121, 23);
            this.cbxStaffID.TabIndex = 29;
            // 
            // cbxReadID
            // 
            this.cbxReadID.FormattingEnabled = true;
            this.cbxReadID.Location = new System.Drawing.Point(441, 126);
            this.cbxReadID.Name = "cbxReadID";
            this.cbxReadID.Size = new System.Drawing.Size(121, 23);
            this.cbxReadID.TabIndex = 29;
            // 
            // frmBorrow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(37)))), ((int)(((byte)(57)))));
            this.CancelButton = this.btnE;
            this.ClientSize = new System.Drawing.Size(799, 620);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.gb1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvBorrow);
            this.Font = new System.Drawing.Font("Roboto Condensed Light", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmBorrow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBook";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrow)).EndInit();
            this.gb1.ResumeLayout(false);
            this.gb1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvBorrow;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gb1;
        private System.Windows.Forms.TextBox txtQuanity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDeposit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnE;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnR;
        private System.Windows.Forms.Button btnD;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.Label txtRID;
        private System.Windows.Forms.Label a;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cbxReadID;
        private System.Windows.Forms.ComboBox cbxStaffID;
        private System.Windows.Forms.ComboBox cbxBookID;
    }
}