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
            this.label5.Location = new System.Drawing.Point(18, 32);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(275, 39);
            this.label5.TabIndex = 11;
            this.label5.Text = "Danh sách phiếu";
            // 
            // dtgvList
            // 
            this.dtgvList.AllowUserToAddRows = false;
            this.dtgvList.AllowUserToDeleteRows = false;
            this.dtgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvList.Location = new System.Drawing.Point(25, 80);
            this.dtgvList.Margin = new System.Windows.Forms.Padding(2);
            this.dtgvList.Name = "dtgvList";
            this.dtgvList.ReadOnly = true;
            this.dtgvList.RowHeadersWidth = 51;
            this.dtgvList.RowTemplate.Height = 24;
            this.dtgvList.Size = new System.Drawing.Size(1089, 636);
            this.dtgvList.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.dtgvList);
            this.panel3.Location = new System.Drawing.Point(28, 2);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1116, 731);
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
            this.panel2.Location = new System.Drawing.Point(776, 82);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(337, 262);
            this.panel2.TabIndex = 15;
            // 
            // textboxsearch4
            // 
            this.textboxsearch4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxsearch4.FormattingEnabled = true;
            this.textboxsearch4.Items.AddRange(new object[] {
            "1",
            "1.5"});
            this.textboxsearch4.Location = new System.Drawing.Point(7, 93);
            this.textboxsearch4.Name = "textboxsearch4";
            this.textboxsearch4.Size = new System.Drawing.Size(108, 28);
            this.textboxsearch4.TabIndex = 28;
            // 
            // textboxsearch1
            // 
            this.textboxsearch1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxsearch1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.textboxsearch1.Location = new System.Drawing.Point(7, 37);
            this.textboxsearch1.Name = "textboxsearch1";
            this.textboxsearch1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textboxsearch1.ShowUpDown = true;
            this.textboxsearch1.Size = new System.Drawing.Size(108, 22);
            this.textboxsearch1.TabIndex = 27;
            // 
            // checkbox6
            // 
            this.checkbox6.AutoSize = true;
            this.checkbox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkbox6.Location = new System.Drawing.Point(7, 191);
            this.checkbox6.Name = "checkbox6";
            this.checkbox6.Size = new System.Drawing.Size(152, 28);
            this.checkbox6.TabIndex = 26;
            this.checkbox6.Text = "status_checkin";
            this.checkbox6.UseVisualStyleBackColor = true;
            // 
            // checkbox5
            // 
            this.checkbox5.AutoSize = true;
            this.checkbox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkbox5.Location = new System.Drawing.Point(7, 125);
            this.checkbox5.Name = "checkbox5";
            this.checkbox5.Size = new System.Drawing.Size(183, 28);
            this.checkbox5.TabIndex = 25;
            this.checkbox5.Text = "number_customer";
            this.checkbox5.UseVisualStyleBackColor = true;
            // 
            // checkbox4
            // 
            this.checkbox4.AutoSize = true;
            this.checkbox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkbox4.Location = new System.Drawing.Point(7, 65);
            this.checkbox4.Name = "checkbox4";
            this.checkbox4.Size = new System.Drawing.Size(152, 28);
            this.checkbox4.TabIndex = 24;
            this.checkbox4.Text = "type_ratioMAX";
            this.checkbox4.UseVisualStyleBackColor = true;
            // 
            // checkbox3
            // 
            this.checkbox3.AutoSize = true;
            this.checkbox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkbox3.Location = new System.Drawing.Point(165, 65);
            this.checkbox3.Name = "checkbox3";
            this.checkbox3.Size = new System.Drawing.Size(163, 28);
            this.checkbox3.TabIndex = 23;
            this.checkbox3.Text = "money_checkin";
            this.checkbox3.UseVisualStyleBackColor = true;
            // 
            // checkbox2
            // 
            this.checkbox2.AutoSize = true;
            this.checkbox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkbox2.Location = new System.Drawing.Point(165, 3);
            this.checkbox2.Name = "checkbox2";
            this.checkbox2.Size = new System.Drawing.Size(98, 28);
            this.checkbox2.TabIndex = 22;
            this.checkbox2.Text = "id_room";
            this.checkbox2.UseVisualStyleBackColor = true;
            // 
            // checkbox1
            // 
            this.checkbox1.AutoSize = true;
            this.checkbox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkbox1.Location = new System.Drawing.Point(7, 3);
            this.checkbox1.Name = "checkbox1";
            this.checkbox1.Size = new System.Drawing.Size(108, 28);
            this.checkbox1.TabIndex = 21;
            this.checkbox1.Text = "date_start";
            this.checkbox1.UseVisualStyleBackColor = true;
            // 
            // textboxsearch6
            // 
            this.textboxsearch6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxsearch6.FormattingEnabled = true;
            this.textboxsearch6.Items.AddRange(new object[] {
            "DONE",
            "USING"});
            this.textboxsearch6.Location = new System.Drawing.Point(7, 225);
            this.textboxsearch6.Name = "textboxsearch6";
            this.textboxsearch6.Size = new System.Drawing.Size(157, 28);
            this.textboxsearch6.TabIndex = 20;
            // 
            // textboxsearch5
            // 
            this.textboxsearch5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxsearch5.Location = new System.Drawing.Point(7, 159);
            this.textboxsearch5.Name = "textboxsearch5";
            this.textboxsearch5.Size = new System.Drawing.Size(157, 26);
            this.textboxsearch5.TabIndex = 12;
            // 
            // textboxsearch3
            // 
            this.textboxsearch3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxsearch3.Location = new System.Drawing.Point(165, 93);
            this.textboxsearch3.Name = "textboxsearch3";
            this.textboxsearch3.Size = new System.Drawing.Size(152, 26);
            this.textboxsearch3.TabIndex = 7;
            // 
            // textboxsearch2
            // 
            this.textboxsearch2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxsearch2.Location = new System.Drawing.Point(165, 33);
            this.textboxsearch2.Name = "textboxsearch2";
            this.textboxsearch2.Size = new System.Drawing.Size(109, 26);
            this.textboxsearch2.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnAdvancedSearch);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.txbSearch);
            this.panel5.Controls.Add(this.btnRefresh);
            this.panel5.Controls.Add(this.btnSearch);
            this.panel5.Location = new System.Drawing.Point(409, 39);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(531, 40);
            this.panel5.TabIndex = 12;
            // 
            // btnAdvancedSearch
            // 
            this.btnAdvancedSearch.BackColor = System.Drawing.Color.DarkGray;
            this.btnAdvancedSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdvancedSearch.ForeColor = System.Drawing.Color.Black;
            this.btnAdvancedSearch.Location = new System.Drawing.Point(430, 3);
            this.btnAdvancedSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdvancedSearch.Name = "btnAdvancedSearch";
            this.btnAdvancedSearch.Size = new System.Drawing.Size(94, 35);
            this.btnAdvancedSearch.TabIndex = 16;
            this.btnAdvancedSearch.Text = "Nâng cao ↓";
            this.btnAdvancedSearch.UseVisualStyleBackColor = false;
            this.btnAdvancedSearch.Click += new System.EventHandler(this.btnAdvancedSearch_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 24);
            this.label6.TabIndex = 14;
            this.label6.Text = "ID Phiếu thuê:";
            // 
            // txbSearch
            // 
            this.txbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSearch.Location = new System.Drawing.Point(150, 6);
            this.txbSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.Size = new System.Drawing.Size(142, 26);
            this.txbSearch.TabIndex = 2;
            this.txbSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbSearch_KeyPress);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(101)))), ((int)(((byte)(132)))));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(367, 3);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(57, 35);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(101)))), ((int)(((byte)(132)))));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(306, 3);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(57, 35);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(29, 16);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1165, 752);
            this.panel1.TabIndex = 13;
            // 
            // ucCheckin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ucCheckin";
            this.Size = new System.Drawing.Size(1212, 782);
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
    }
}
