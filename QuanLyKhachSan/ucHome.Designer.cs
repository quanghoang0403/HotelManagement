namespace QuanLyKhachSan
{
    partial class ucHome
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
            this.flpHome = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddCheckin = new System.Windows.Forms.Button();
            this.btnAddBill = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flpHome
            // 
            this.flpHome.Location = new System.Drawing.Point(99, 110);
            this.flpHome.Name = "flpHome";
            this.flpHome.Size = new System.Drawing.Size(1044, 600);
            this.flpHome.TabIndex = 11;
            // 
            // btnAddCheckin
            // 
            this.btnAddCheckin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(101)))), ((int)(((byte)(132)))));
            this.btnAddCheckin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCheckin.ForeColor = System.Drawing.Color.White;
            this.btnAddCheckin.Location = new System.Drawing.Point(1210, 165);
            this.btnAddCheckin.Name = "btnAddCheckin";
            this.btnAddCheckin.Size = new System.Drawing.Size(250, 104);
            this.btnAddCheckin.TabIndex = 12;
            this.btnAddCheckin.Text = "Tạo phiếu thuê phòng ";
            this.btnAddCheckin.UseVisualStyleBackColor = false;
            this.btnAddCheckin.Click += new System.EventHandler(this.btnAddCheckin_Click);
            // 
            // btnAddBill
            // 
            this.btnAddBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(101)))), ((int)(((byte)(132)))));
            this.btnAddBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBill.ForeColor = System.Drawing.Color.White;
            this.btnAddBill.Location = new System.Drawing.Point(1210, 354);
            this.btnAddBill.Name = "btnAddBill";
            this.btnAddBill.Size = new System.Drawing.Size(250, 109);
            this.btnAddBill.TabIndex = 13;
            this.btnAddBill.Text = "Thanh toán hóa đơn";
            this.btnAddBill.UseVisualStyleBackColor = false;
            this.btnAddBill.Click += new System.EventHandler(this.btnAddBill_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(101)))), ((int)(((byte)(132)))));
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(1210, 558);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(250, 103);
            this.btnRefresh.TabIndex = 14;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // ucHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnAddBill);
            this.Controls.Add(this.btnAddCheckin);
            this.Controls.Add(this.flpHome);
            this.Name = "ucHome";
            this.Size = new System.Drawing.Size(1504, 801);
            this.Load += new System.EventHandler(this.UcHome_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flpHome;
        private System.Windows.Forms.Button btnAddCheckin;
        private System.Windows.Forms.Button btnAddBill;
        private System.Windows.Forms.Button btnRefresh;
    }
}
