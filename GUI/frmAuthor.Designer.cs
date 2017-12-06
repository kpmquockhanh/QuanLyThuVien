namespace GUI
{
    partial class frmAuthor
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
            this.dgvAuthor = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gb1 = new System.Windows.Forms.GroupBox();
            this.btnE = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnR = new System.Windows.Forms.Button();
            this.btnD = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnA = new System.Windows.Forms.Button();
            this.cbPub = new System.Windows.Forms.ComboBox();
            this.cbAuthor = new System.Windows.Forms.ComboBox();
            this.cbCate = new System.Windows.Forms.ComboBox();
            this.dpPubDate = new System.Windows.Forms.DateTimePicker();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAuthorName = new System.Windows.Forms.TextBox();
            this.txtQuanity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAuthorID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuthor)).BeginInit();
            this.gb1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAuthor
            // 
            this.dgvAuthor.AllowUserToAddRows = false;
            this.dgvAuthor.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Tan;
            this.dgvAuthor.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAuthor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAuthor.BackgroundColor = System.Drawing.Color.White;
            this.dgvAuthor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAuthor.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvAuthor.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAuthor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAuthor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAuthor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvAuthor.GridColor = System.Drawing.Color.White;
            this.dgvAuthor.Location = new System.Drawing.Point(10, 368);
            this.dgvAuthor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvAuthor.MultiSelect = false;
            this.dgvAuthor.Name = "dgvAuthor";
            this.dgvAuthor.ReadOnly = true;
            this.dgvAuthor.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvAuthor.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Tan;
            this.dgvAuthor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAuthor.ShowCellToolTips = false;
            this.dgvAuthor.ShowEditingIcon = false;
            this.dgvAuthor.Size = new System.Drawing.Size(777, 239);
            this.dgvAuthor.TabIndex = 1;
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
            this.gb1.Controls.Add(this.btnE);
            this.gb1.Controls.Add(this.btnSearch);
            this.gb1.Controls.Add(this.btnR);
            this.gb1.Controls.Add(this.btnD);
            this.gb1.Controls.Add(this.btnEdit);
            this.gb1.Controls.Add(this.btnA);
            this.gb1.Controls.Add(this.cbPub);
            this.gb1.Controls.Add(this.cbAuthor);
            this.gb1.Controls.Add(this.cbCate);
            this.gb1.Controls.Add(this.dpPubDate);
            this.gb1.Controls.Add(this.txtPrice);
            this.gb1.Controls.Add(this.label8);
            this.gb1.Controls.Add(this.label4);
            this.gb1.Controls.Add(this.label7);
            this.gb1.Controls.Add(this.label3);
            this.gb1.Controls.Add(this.label6);
            this.gb1.Controls.Add(this.txtAuthorName);
            this.gb1.Controls.Add(this.txtQuanity);
            this.gb1.Controls.Add(this.label2);
            this.gb1.Controls.Add(this.label5);
            this.gb1.Controls.Add(this.txtAuthorID);
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
            this.gb1.Text = "Thông tin sách";
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
            this.btnE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnE.Location = new System.Drawing.Point(640, 188);
            this.btnE.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnE.Name = "btnE";
            this.btnE.Size = new System.Drawing.Size(98, 56);
            this.btnE.TabIndex = 22;
            this.btnE.Text = "Thoát";
            this.btnE.UseVisualStyleBackColor = false;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnSearch.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(237)))), ((int)(((byte)(144)))));
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(237)))), ((int)(((byte)(144)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSearch.Location = new System.Drawing.Point(533, 188);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(98, 56);
            this.btnSearch.TabIndex = 22;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // btnR
            // 
            this.btnR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btnR.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnR.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(237)))), ((int)(((byte)(144)))));
            this.btnR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(237)))), ((int)(((byte)(144)))));
            this.btnR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnR.Location = new System.Drawing.Point(429, 188);
            this.btnR.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnR.Name = "btnR";
            this.btnR.Size = new System.Drawing.Size(98, 56);
            this.btnR.TabIndex = 23;
            this.btnR.Text = "Reset";
            this.btnR.UseVisualStyleBackColor = false;
            // 
            // btnD
            // 
            this.btnD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btnD.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnD.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnD.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(237)))), ((int)(((byte)(144)))));
            this.btnD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(237)))), ((int)(((byte)(144)))));
            this.btnD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
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
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnEdit.Location = new System.Drawing.Point(221, 188);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(98, 56);
            this.btnEdit.TabIndex = 25;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnA
            // 
            this.btnA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btnA.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnA.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnA.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(237)))), ((int)(((byte)(144)))));
            this.btnA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(237)))), ((int)(((byte)(144)))));
            this.btnA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnA.Location = new System.Drawing.Point(117, 188);
            this.btnA.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(98, 56);
            this.btnA.TabIndex = 26;
            this.btnA.Text = "Thêm";
            this.btnA.UseVisualStyleBackColor = false;
            // 
            // cbPub
            // 
            this.cbPub.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPub.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbPub.FormattingEnabled = true;
            this.cbPub.Location = new System.Drawing.Point(438, 128);
            this.cbPub.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbPub.MaxDropDownItems = 10;
            this.cbPub.Name = "cbPub";
            this.cbPub.Size = new System.Drawing.Size(300, 28);
            this.cbPub.TabIndex = 21;
            // 
            // cbAuthor
            // 
            this.cbAuthor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbAuthor.FormattingEnabled = true;
            this.cbAuthor.Location = new System.Drawing.Point(438, 98);
            this.cbAuthor.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbAuthor.MaxDropDownItems = 10;
            this.cbAuthor.Name = "cbAuthor";
            this.cbAuthor.Size = new System.Drawing.Size(300, 28);
            this.cbAuthor.TabIndex = 21;
            // 
            // cbCate
            // 
            this.cbCate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbCate.FormattingEnabled = true;
            this.cbCate.Location = new System.Drawing.Point(438, 68);
            this.cbCate.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbCate.MaxDropDownItems = 10;
            this.cbCate.Name = "cbCate";
            this.cbCate.Size = new System.Drawing.Size(300, 28);
            this.cbCate.Sorted = true;
            this.cbCate.TabIndex = 21;
            // 
            // dpPubDate
            // 
            this.dpPubDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Strikeout);
            this.dpPubDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dpPubDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpPubDate.Location = new System.Drawing.Point(74, 98);
            this.dpPubDate.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dpPubDate.Name = "dpPubDate";
            this.dpPubDate.Size = new System.Drawing.Size(143, 26);
            this.dpPubDate.TabIndex = 20;
            // 
            // txtPrice
            // 
            this.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPrice.Location = new System.Drawing.Point(74, 128);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(278, 26);
            this.txtPrice.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(367, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 20);
            this.label8.TabIndex = 5;
            this.label8.Text = "Publisher:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(29, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Price:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(380, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Author:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(8, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "PubDate:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(368, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Category:";
            // 
            // txtAuthorName
            // 
            this.txtAuthorName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAuthorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtAuthorName.Location = new System.Drawing.Point(74, 68);
            this.txtAuthorName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAuthorName.Name = "txtAuthorName";
            this.txtAuthorName.Size = new System.Drawing.Size(278, 26);
            this.txtAuthorName.TabIndex = 17;
            // 
            // txtQuanity
            // 
            this.txtQuanity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQuanity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtQuanity.Location = new System.Drawing.Point(438, 38);
            this.txtQuanity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtQuanity.Name = "txtQuanity";
            this.txtQuanity.Size = new System.Drawing.Size(299, 26);
            this.txtQuanity.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(24, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(375, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Quanity:";
            // 
            // txtAuthorID
            // 
            this.txtAuthorID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAuthorID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtAuthorID.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtAuthorID.Location = new System.Drawing.Point(74, 38);
            this.txtAuthorID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAuthorID.Name = "txtAuthorID";
            this.txtAuthorID.Size = new System.Drawing.Size(278, 26);
            this.txtAuthorID.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(43, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "ID:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label9.Location = new System.Drawing.Point(273, 19);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(282, 54);
            this.label9.TabIndex = 12;
            this.label9.Text = "Quản lí sách";
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Tan;
            this.button2.Location = new System.Drawing.Point(731, 11);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(25, 25);
            this.button2.TabIndex = 14;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Tan;
            this.button1.Location = new System.Drawing.Point(762, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 25);
            this.button1.TabIndex = 15;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Tan;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2, 615);
            this.panel2.TabIndex = 16;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Tan;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(795, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(4, 615);
            this.panel3.TabIndex = 17;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Tan;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(2, 618);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(793, 2);
            this.panel4.TabIndex = 18;
            // 
            // frmAuthor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnE;
            this.ClientSize = new System.Drawing.Size(799, 620);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.gb1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvAuthor);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmAuthor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBook";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuthor)).EndInit();
            this.gb1.ResumeLayout(false);
            this.gb1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvAuthor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gb1;
        private System.Windows.Forms.DateTimePicker dpPubDate;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAuthorName;
        private System.Windows.Forms.TextBox txtQuanity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAuthorID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnE;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnR;
        private System.Windows.Forms.Button btnD;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.ComboBox cbPub;
        private System.Windows.Forms.ComboBox cbAuthor;
        private System.Windows.Forms.ComboBox cbCate;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}