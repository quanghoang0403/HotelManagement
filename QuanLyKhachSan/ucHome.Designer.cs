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
            this.label7 = new System.Windows.Forms.Label();
            this.flpHome = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddCheckin = new System.Windows.Forms.Button();
            this.btnAddBill = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(581, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(215, 51);
            this.label7.TabIndex = 10;
            this.label7.Text = "Trang chủ";
            // 
            // flpHome
            // 
            this.flpHome.Location = new System.Drawing.Point(99, 141);
            this.flpHome.Name = "flpHome";
            this.flpHome.Size = new System.Drawing.Size(1127, 520);
            this.flpHome.TabIndex = 11;
            // 
            // btnAddCheckin
            // 
            this.btnAddCheckin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnAddCheckin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCheckin.Location = new System.Drawing.Point(1315, 141);
            this.btnAddCheckin.Name = "btnAddCheckin";
            this.btnAddCheckin.Size = new System.Drawing.Size(176, 104);
            this.btnAddCheckin.TabIndex = 12;
            this.btnAddCheckin.Text = "Tạo phiếu thuê phòng ";
            this.btnAddCheckin.UseVisualStyleBackColor = false;
            this.btnAddCheckin.Click += new System.EventHandler(this.btnAddCheckin_Click);
            // 
            // btnAddBill
            // 
            this.btnAddBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAddBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBill.Location = new System.Drawing.Point(1315, 268);
            this.btnAddBill.Name = "btnAddBill";
            this.btnAddBill.Size = new System.Drawing.Size(176, 109);
            this.btnAddBill.TabIndex = 13;
            this.btnAddBill.Text = "Thanh toán hóa đơn";
            this.btnAddBill.UseVisualStyleBackColor = false;
            this.btnAddBill.Click += new System.EventHandler(this.btnAddBill_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRefresh.Location = new System.Drawing.Point(1315, 402);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(176, 103);
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
            this.Controls.Add(this.label7);
            this.Name = "ucHome";
            this.Size = new System.Drawing.Size(1616, 962);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.FlowLayoutPanel flpHome;
        private System.Windows.Forms.Button btnAddCheckin;
        private System.Windows.Forms.Button btnAddBill;
        private System.Windows.Forms.Button btnRefresh;
    }
}
