﻿namespace QuanLyKhachSan
{
    partial class ucBill
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.checkbox3 = new System.Windows.Forms.CheckBox();
            this.checkbox2 = new System.Windows.Forms.CheckBox();
            this.checkbox1 = new System.Windows.Forms.CheckBox();
            this.textboxsearch3 = new System.Windows.Forms.TextBox();
            this.textboxsearch1 = new System.Windows.Forms.TextBox();
            this.textboxsearch2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtgvListBill = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnAdvancedSearch = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txbSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.id_bill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bill_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bill_address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_money = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListBill)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(39, 20);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1548, 926);
            this.panel1.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.dtgvListBill);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Location = new System.Drawing.Point(37, 2);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1485, 897);
            this.panel3.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.checkbox3);
            this.panel2.Controls.Add(this.checkbox2);
            this.panel2.Controls.Add(this.checkbox1);
            this.panel2.Controls.Add(this.textboxsearch3);
            this.panel2.Controls.Add(this.textboxsearch1);
            this.panel2.Controls.Add(this.textboxsearch2);
            this.panel2.Location = new System.Drawing.Point(1116, 87);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(365, 260);
            this.panel2.TabIndex = 12;
            // 
            // checkbox3
            // 
            this.checkbox3.AutoSize = true;
            this.checkbox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkbox3.Location = new System.Drawing.Point(9, 167);
            this.checkbox3.Margin = new System.Windows.Forms.Padding(4);
            this.checkbox3.Name = "checkbox3";
            this.checkbox3.Size = new System.Drawing.Size(137, 33);
            this.checkbox3.TabIndex = 23;
            this.checkbox3.Text = "Tổng tiền";
            this.checkbox3.UseVisualStyleBackColor = true;
            // 
            // checkbox2
            // 
            this.checkbox2.AutoSize = true;
            this.checkbox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkbox2.Location = new System.Drawing.Point(9, 85);
            this.checkbox2.Margin = new System.Windows.Forms.Padding(4);
            this.checkbox2.Name = "checkbox2";
            this.checkbox2.Size = new System.Drawing.Size(108, 33);
            this.checkbox2.TabIndex = 22;
            this.checkbox2.Text = "Địa chỉ";
            this.checkbox2.UseVisualStyleBackColor = true;
            // 
            // checkbox1
            // 
            this.checkbox1.AutoSize = true;
            this.checkbox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkbox1.Location = new System.Drawing.Point(9, 4);
            this.checkbox1.Margin = new System.Windows.Forms.Padding(4);
            this.checkbox1.Name = "checkbox1";
            this.checkbox1.Size = new System.Drawing.Size(206, 33);
            this.checkbox1.TabIndex = 21;
            this.checkbox1.Text = "Tên khách hàng";
            this.checkbox1.UseVisualStyleBackColor = true;
            // 
            // textboxsearch3
            // 
            this.textboxsearch3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxsearch3.Location = new System.Drawing.Point(8, 209);
            this.textboxsearch3.Margin = new System.Windows.Forms.Padding(4);
            this.textboxsearch3.Name = "textboxsearch3";
            this.textboxsearch3.Size = new System.Drawing.Size(340, 30);
            this.textboxsearch3.TabIndex = 7;
            // 
            // textboxsearch1
            // 
            this.textboxsearch1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxsearch1.Location = new System.Drawing.Point(8, 46);
            this.textboxsearch1.Margin = new System.Windows.Forms.Padding(4);
            this.textboxsearch1.Name = "textboxsearch1";
            this.textboxsearch1.Size = new System.Drawing.Size(340, 30);
            this.textboxsearch1.TabIndex = 4;
            // 
            // textboxsearch2
            // 
            this.textboxsearch2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxsearch2.Location = new System.Drawing.Point(8, 128);
            this.textboxsearch2.Margin = new System.Windows.Forms.Padding(4);
            this.textboxsearch2.Name = "textboxsearch2";
            this.textboxsearch2.Size = new System.Drawing.Size(340, 30);
            this.textboxsearch2.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(394, 51);
            this.label5.TabIndex = 11;
            this.label5.Text = "Danh sách hóa đơn";
            // 
            // dtgvListBill
            // 
            this.dtgvListBill.AllowUserToAddRows = false;
            this.dtgvListBill.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvListBill.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvListBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvListBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_bill,
            this.Bill_name,
            this.Bill_address,
            this.Total_money});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvListBill.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvListBill.Location = new System.Drawing.Point(16, 86);
            this.dtgvListBill.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgvListBill.Name = "dtgvListBill";
            this.dtgvListBill.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvListBill.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvListBill.RowHeadersVisible = false;
            this.dtgvListBill.RowHeadersWidth = 51;
            this.dtgvListBill.RowTemplate.Height = 24;
            this.dtgvListBill.Size = new System.Drawing.Size(1467, 779);
            this.dtgvListBill.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnAdvancedSearch);
            this.panel5.Controls.Add(this.btnRefresh);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.txbSearch);
            this.panel5.Controls.Add(this.btnSearch);
            this.panel5.Location = new System.Drawing.Point(660, 32);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(612, 49);
            this.panel5.TabIndex = 6;
            // 
            // btnAdvancedSearch
            // 
            this.btnAdvancedSearch.BackColor = System.Drawing.Color.DarkGray;
            this.btnAdvancedSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdvancedSearch.ForeColor = System.Drawing.Color.Black;
            this.btnAdvancedSearch.Location = new System.Drawing.Point(456, 5);
            this.btnAdvancedSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdvancedSearch.Name = "btnAdvancedSearch";
            this.btnAdvancedSearch.Size = new System.Drawing.Size(125, 43);
            this.btnAdvancedSearch.TabIndex = 14;
            this.btnAdvancedSearch.Text = "Nâng cao ↓";
            this.btnAdvancedSearch.UseVisualStyleBackColor = false;
            this.btnAdvancedSearch.Click += new System.EventHandler(this.btnAdvancedSearch_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(101)))), ((int)(((byte)(132)))));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(375, 5);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(76, 43);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 10);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 29);
            this.label3.TabIndex = 13;
            this.label3.Text = "ID Bill:";
            // 
            // txbSearch
            // 
            this.txbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSearch.Location = new System.Drawing.Point(103, 9);
            this.txbSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.Size = new System.Drawing.Size(175, 29);
            this.txbSearch.TabIndex = 2;
            this.txbSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbSearch_KeyPress);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(101)))), ((int)(((byte)(132)))));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(293, 5);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(76, 43);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // id_bill
            // 
            this.id_bill.DataPropertyName = "id_bill";
            this.id_bill.HeaderText = "ID Hóa đơn";
            this.id_bill.MinimumWidth = 6;
            this.id_bill.Name = "id_bill";
            this.id_bill.ReadOnly = true;
            this.id_bill.Width = 250;
            // 
            // Bill_name
            // 
            this.Bill_name.DataPropertyName = "Bill_name";
            this.Bill_name.HeaderText = "Tên khách hàng";
            this.Bill_name.MinimumWidth = 6;
            this.Bill_name.Name = "Bill_name";
            this.Bill_name.ReadOnly = true;
            this.Bill_name.Width = 250;
            // 
            // Bill_address
            // 
            this.Bill_address.DataPropertyName = "Bill_address";
            this.Bill_address.HeaderText = "Địa chỉ";
            this.Bill_address.MinimumWidth = 6;
            this.Bill_address.Name = "Bill_address";
            this.Bill_address.ReadOnly = true;
            this.Bill_address.Width = 250;
            // 
            // Total_money
            // 
            this.Total_money.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Total_money.DataPropertyName = "Total_money";
            this.Total_money.HeaderText = "Tổng tiền";
            this.Total_money.MinimumWidth = 6;
            this.Total_money.Name = "Total_money";
            this.Total_money.ReadOnly = true;
            // 
            // ucBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ucBill";
            this.Size = new System.Drawing.Size(1616, 962);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListBill)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dtgvListBill;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txbSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnAdvancedSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textboxsearch3;
        private System.Windows.Forms.TextBox textboxsearch1;
        private System.Windows.Forms.TextBox textboxsearch2;
        private System.Windows.Forms.CheckBox checkbox3;
        private System.Windows.Forms.CheckBox checkbox2;
        private System.Windows.Forms.CheckBox checkbox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_bill;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bill_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bill_address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_money;
    }
}
