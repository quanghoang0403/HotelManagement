namespace QuanLyKhachSan
{
    partial class ucCheckin
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label5 = new System.Windows.Forms.Label();
            this.dtgvList = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textboxsearch4 = new System.Windows.Forms.ComboBox();
            this.textboxsearch1 = new System.Windows.Forms.DateTimePicker();
            this.checkbox6 = new System.Windows.Forms.CheckBox();
            this.checkbox5 = new System.Windows.Forms.CheckBox();
            this.checkbox4 = new System.Windows.Forms.CheckBox();
            this.checkbox3 = new System.Windows.Forms.CheckBox();
            this.checkbox2 = new System.Windows.Forms.CheckBox();
            this.checkbox1 = new System.Windows.Forms.CheckBox();
            this.textboxsearch6 = new System.Windows.Forms.ComboBox();
            this.textboxsearch5 = new System.Windows.Forms.TextBox();
            this.textboxsearch3 = new System.Windows.Forms.TextBox();
            this.textboxsearch2 = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnAdvancedSearch = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txbSearch = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.id_checkin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date_start = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_room = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Money_checkin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type_ratioMAX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number_customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status_checkin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvList)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(345, 51);
            this.label5.TabIndex = 11;
            this.label5.Text = "Danh sách phiếu";
            // 
            // dtgvList
            // 
            this.dtgvList.AllowUserToAddRows = false;
            this.dtgvList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_checkin,
            this.Date_start,
            this.Id_room,
            this.Money_checkin,
            this.Type_ratioMAX,
            this.Number_customer,
            this.Status_checkin});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvList.Location = new System.Drawing.Point(33, 98);
            this.dtgvList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgvList.Name = "dtgvList";
            this.dtgvList.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvList.RowHeadersVisible = false;
            this.dtgvList.RowHeadersWidth = 51;
            this.dtgvList.RowTemplate.Height = 24;
            this.dtgvList.Size = new System.Drawing.Size(1452, 783);
            this.dtgvList.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.dtgvList);
            this.panel3.Location = new System.Drawing.Point(37, 2);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1488, 900);
            this.panel3.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textboxsearch4);
            this.panel2.Controls.Add(this.textboxsearch1);
            this.panel2.Controls.Add(this.checkbox6);
            this.panel2.Controls.Add(this.checkbox5);
            this.panel2.Controls.Add(this.checkbox4);
            this.panel2.Controls.Add(this.checkbox3);
            this.panel2.Controls.Add(this.checkbox2);
            this.panel2.Controls.Add(this.checkbox1);
            this.panel2.Controls.Add(this.textboxsearch6);
            this.panel2.Controls.Add(this.textboxsearch5);
            this.panel2.Controls.Add(this.textboxsearch3);
            this.panel2.Controls.Add(this.textboxsearch2);
            this.panel2.Location = new System.Drawing.Point(1035, 101);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(449, 322);
            this.panel2.TabIndex = 15;
            // 
            // textboxsearch4
            // 
            this.textboxsearch4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxsearch4.FormattingEnabled = true;
            this.textboxsearch4.Items.AddRange(new object[] {
            "1",
            "1.5"});
            this.textboxsearch4.Location = new System.Drawing.Point(9, 114);
            this.textboxsearch4.Margin = new System.Windows.Forms.Padding(4);
            this.textboxsearch4.Name = "textboxsearch4";
            this.textboxsearch4.Size = new System.Drawing.Size(143, 33);
            this.textboxsearch4.TabIndex = 28;
            // 
            // textboxsearch1
            // 
            this.textboxsearch1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxsearch1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.textboxsearch1.Location = new System.Drawing.Point(9, 46);
            this.textboxsearch1.Margin = new System.Windows.Forms.Padding(4);
            this.textboxsearch1.Name = "textboxsearch1";
            this.textboxsearch1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textboxsearch1.ShowUpDown = true;
            this.textboxsearch1.Size = new System.Drawing.Size(143, 26);
            this.textboxsearch1.TabIndex = 27;
            // 
            // checkbox6
            // 
            this.checkbox6.AutoSize = true;
            this.checkbox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkbox6.Location = new System.Drawing.Point(9, 235);
            this.checkbox6.Margin = new System.Windows.Forms.Padding(4);
            this.checkbox6.Name = "checkbox6";
            this.checkbox6.Size = new System.Drawing.Size(101, 33);
            this.checkbox6.TabIndex = 26;
            this.checkbox6.Text = "Status";
            this.checkbox6.UseVisualStyleBackColor = true;
            // 
            // checkbox5
            // 
            this.checkbox5.AutoSize = true;
            this.checkbox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkbox5.Location = new System.Drawing.Point(9, 154);
            this.checkbox5.Margin = new System.Windows.Forms.Padding(4);
            this.checkbox5.Name = "checkbox5";
            this.checkbox5.Size = new System.Drawing.Size(200, 33);
            this.checkbox5.TabIndex = 25;
            this.checkbox5.Text = "Số lượng khách";
            this.checkbox5.UseVisualStyleBackColor = true;
            // 
            // checkbox4
            // 
            this.checkbox4.AutoSize = true;
            this.checkbox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkbox4.Location = new System.Drawing.Point(9, 80);
            this.checkbox4.Margin = new System.Windows.Forms.Padding(4);
            this.checkbox4.Name = "checkbox4";
            this.checkbox4.Size = new System.Drawing.Size(167, 33);
            this.checkbox4.TabIndex = 24;
            this.checkbox4.Text = "Tỉ lệ phụ thu";
            this.checkbox4.UseVisualStyleBackColor = true;
            // 
            // checkbox3
            // 
            this.checkbox3.AutoSize = true;
            this.checkbox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkbox3.Location = new System.Drawing.Point(220, 80);
            this.checkbox3.Margin = new System.Windows.Forms.Padding(4);
            this.checkbox3.Name = "checkbox3";
            this.checkbox3.Size = new System.Drawing.Size(143, 33);
            this.checkbox3.TabIndex = 23;
            this.checkbox3.Text = "Tổng tiền ";
            this.checkbox3.UseVisualStyleBackColor = true;
            // 
            // checkbox2
            // 
            this.checkbox2.AutoSize = true;
            this.checkbox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkbox2.Location = new System.Drawing.Point(220, 4);
            this.checkbox2.Margin = new System.Windows.Forms.Padding(4);
            this.checkbox2.Name = "checkbox2";
            this.checkbox2.Size = new System.Drawing.Size(132, 33);
            this.checkbox2.TabIndex = 22;
            this.checkbox2.Text = "ID phòng";
            this.checkbox2.UseVisualStyleBackColor = true;
            // 
            // checkbox1
            // 
            this.checkbox1.AutoSize = true;
            this.checkbox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkbox1.Location = new System.Drawing.Point(9, 4);
            this.checkbox1.Margin = new System.Windows.Forms.Padding(4);
            this.checkbox1.Name = "checkbox1";
            this.checkbox1.Size = new System.Drawing.Size(143, 33);
            this.checkbox1.TabIndex = 21;
            this.checkbox1.Text = "Ngày thuê";
            this.checkbox1.UseVisualStyleBackColor = true;
            // 
            // textboxsearch6
            // 
            this.textboxsearch6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxsearch6.FormattingEnabled = true;
            this.textboxsearch6.Items.AddRange(new object[] {
            "DONE",
            "USING"});
            this.textboxsearch6.Location = new System.Drawing.Point(9, 277);
            this.textboxsearch6.Margin = new System.Windows.Forms.Padding(4);
            this.textboxsearch6.Name = "textboxsearch6";
            this.textboxsearch6.Size = new System.Drawing.Size(208, 33);
            this.textboxsearch6.TabIndex = 20;
            // 
            // textboxsearch5
            // 
            this.textboxsearch5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxsearch5.Location = new System.Drawing.Point(9, 196);
            this.textboxsearch5.Margin = new System.Windows.Forms.Padding(4);
            this.textboxsearch5.Name = "textboxsearch5";
            this.textboxsearch5.Size = new System.Drawing.Size(208, 30);
            this.textboxsearch5.TabIndex = 12;
            // 
            // textboxsearch3
            // 
            this.textboxsearch3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxsearch3.Location = new System.Drawing.Point(220, 114);
            this.textboxsearch3.Margin = new System.Windows.Forms.Padding(4);
            this.textboxsearch3.Name = "textboxsearch3";
            this.textboxsearch3.Size = new System.Drawing.Size(201, 30);
            this.textboxsearch3.TabIndex = 7;
            // 
            // textboxsearch2
            // 
            this.textboxsearch2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxsearch2.Location = new System.Drawing.Point(220, 41);
            this.textboxsearch2.Margin = new System.Windows.Forms.Padding(4);
            this.textboxsearch2.Name = "textboxsearch2";
            this.textboxsearch2.Size = new System.Drawing.Size(144, 30);
            this.textboxsearch2.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnAdvancedSearch);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.txbSearch);
            this.panel5.Controls.Add(this.btnRefresh);
            this.panel5.Controls.Add(this.btnSearch);
            this.panel5.Location = new System.Drawing.Point(545, 48);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(708, 49);
            this.panel5.TabIndex = 12;
            // 
            // btnAdvancedSearch
            // 
            this.btnAdvancedSearch.BackColor = System.Drawing.Color.DarkGray;
            this.btnAdvancedSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdvancedSearch.ForeColor = System.Drawing.Color.Black;
            this.btnAdvancedSearch.Location = new System.Drawing.Point(573, 4);
            this.btnAdvancedSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdvancedSearch.Name = "btnAdvancedSearch";
            this.btnAdvancedSearch.Size = new System.Drawing.Size(125, 43);
            this.btnAdvancedSearch.TabIndex = 16;
            this.btnAdvancedSearch.Text = "Nâng cao ↓";
            this.btnAdvancedSearch.UseVisualStyleBackColor = false;
            this.btnAdvancedSearch.Click += new System.EventHandler(this.btnAdvancedSearch_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 7);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 29);
            this.label6.TabIndex = 14;
            this.label6.Text = "ID Phiếu thuê:";
            // 
            // txbSearch
            // 
            this.txbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSearch.Location = new System.Drawing.Point(200, 7);
            this.txbSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.Size = new System.Drawing.Size(188, 30);
            this.txbSearch.TabIndex = 2;
            this.txbSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbSearch_KeyPress);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(101)))), ((int)(((byte)(132)))));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(489, 4);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(76, 43);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(101)))), ((int)(((byte)(132)))));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(408, 4);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(76, 43);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(39, 20);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1553, 926);
            this.panel1.TabIndex = 13;
            // 
            // id_checkin
            // 
            this.id_checkin.DataPropertyName = "Id_checkin";
            this.id_checkin.HeaderText = "ID phiếu thuê";
            this.id_checkin.MinimumWidth = 6;
            this.id_checkin.Name = "id_checkin";
            this.id_checkin.ReadOnly = true;
            this.id_checkin.Width = 160;
            // 
            // Date_start
            // 
            this.Date_start.DataPropertyName = "Date_start";
            this.Date_start.HeaderText = "Ngày thuê";
            this.Date_start.MinimumWidth = 6;
            this.Date_start.Name = "Date_start";
            this.Date_start.ReadOnly = true;
            this.Date_start.Width = 125;
            // 
            // Id_room
            // 
            this.Id_room.DataPropertyName = "Id_room";
            this.Id_room.HeaderText = "ID phòng";
            this.Id_room.MinimumWidth = 6;
            this.Id_room.Name = "Id_room";
            this.Id_room.ReadOnly = true;
            this.Id_room.Width = 125;
            // 
            // Money_checkin
            // 
            this.Money_checkin.DataPropertyName = "Money_checkin";
            this.Money_checkin.HeaderText = "Tổng tiền";
            this.Money_checkin.MinimumWidth = 6;
            this.Money_checkin.Name = "Money_checkin";
            this.Money_checkin.ReadOnly = true;
            this.Money_checkin.Width = 175;
            // 
            // Type_ratioMAX
            // 
            this.Type_ratioMAX.DataPropertyName = "Type_ratioMAX";
            this.Type_ratioMAX.HeaderText = "Tỉ lệ phụ thu";
            this.Type_ratioMAX.MinimumWidth = 6;
            this.Type_ratioMAX.Name = "Type_ratioMAX";
            this.Type_ratioMAX.ReadOnly = true;
            this.Type_ratioMAX.Width = 175;
            // 
            // Number_customer
            // 
            this.Number_customer.DataPropertyName = "Number_customer";
            this.Number_customer.HeaderText = "Số lượng khách";
            this.Number_customer.MinimumWidth = 6;
            this.Number_customer.Name = "Number_customer";
            this.Number_customer.ReadOnly = true;
            this.Number_customer.Width = 175;
            // 
            // Status_checkin
            // 
            this.Status_checkin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Status_checkin.DataPropertyName = "Status_checkin";
            this.Status_checkin.HeaderText = "Status";
            this.Status_checkin.MinimumWidth = 6;
            this.Status_checkin.Name = "Status_checkin";
            this.Status_checkin.ReadOnly = true;
            // 
            // ucCheckin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ucCheckin";
            this.Size = new System.Drawing.Size(1616, 962);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvList)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dtgvList;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txbSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox checkbox6;
        private System.Windows.Forms.CheckBox checkbox5;
        private System.Windows.Forms.CheckBox checkbox4;
        private System.Windows.Forms.CheckBox checkbox3;
        private System.Windows.Forms.CheckBox checkbox2;
        private System.Windows.Forms.CheckBox checkbox1;
        private System.Windows.Forms.ComboBox textboxsearch6;
        private System.Windows.Forms.TextBox textboxsearch5;
        private System.Windows.Forms.TextBox textboxsearch3;
        private System.Windows.Forms.TextBox textboxsearch2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAdvancedSearch;
        private System.Windows.Forms.DateTimePicker textboxsearch1;
        private System.Windows.Forms.ComboBox textboxsearch4;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_checkin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date_start;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_room;
        private System.Windows.Forms.DataGridViewTextBoxColumn Money_checkin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type_ratioMAX;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number_customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status_checkin;
    }
}
