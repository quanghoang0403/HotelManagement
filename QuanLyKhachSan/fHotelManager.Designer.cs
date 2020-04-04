namespace QuanLyKhachSan
{
    partial class fHotelManager
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.itHome = new System.Windows.Forms.ToolStripMenuItem();
            this.itRoom = new System.Windows.Forms.ToolStripMenuItem();
            this.itBill = new System.Windows.Forms.ToolStripMenuItem();
            this.itCheckin = new System.Windows.Forms.ToolStripMenuItem();
            this.itRevenue = new System.Windows.Forms.ToolStripMenuItem();
            this.itAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.itQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.ucHome2 = new QuanLyKhachSan.ucHome();
            this.ucAccount1 = new QuanLyKhachSan.ucAccount();
            this.ucRevenue1 = new QuanLyKhachSan.ucRevenue();
            this.ucCheckin1 = new QuanLyKhachSan.ucCheckin();
            this.ucRoom1 = new QuanLyKhachSan.ucRoom();
            this.ucBill1 = new QuanLyKhachSan.ucBill();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itHome,
            this.itRoom,
            this.itBill,
            this.itCheckin,
            this.itRevenue,
            this.itAccount,
            this.itQuit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(318, 1052);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // itHome
            // 
            this.itHome.Name = "itHome";
            this.itHome.Size = new System.Drawing.Size(305, 49);
            this.itHome.Text = "Trang chủ";
            this.itHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.itHome.Click += new System.EventHandler(this.itHome_Click);
            // 
            // itRoom
            // 
            this.itRoom.Name = "itRoom";
            this.itRoom.Size = new System.Drawing.Size(305, 49);
            this.itRoom.Text = "Phòng";
            this.itRoom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.itRoom.Click += new System.EventHandler(this.itRoom_Click);
            // 
            // itBill
            // 
            this.itBill.Name = "itBill";
            this.itBill.Size = new System.Drawing.Size(305, 49);
            this.itBill.Text = "Hóa đơn";
            this.itBill.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.itBill.Click += new System.EventHandler(this.itBill_Click);
            // 
            // itCheckin
            // 
            this.itCheckin.Name = "itCheckin";
            this.itCheckin.Size = new System.Drawing.Size(305, 49);
            this.itCheckin.Text = "Phiếu thuê phòng";
            this.itCheckin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.itCheckin.Click += new System.EventHandler(this.itCheckin_Click);
            // 
            // itRevenue
            // 
            this.itRevenue.Name = "itRevenue";
            this.itRevenue.Size = new System.Drawing.Size(305, 49);
            this.itRevenue.Text = "Doanh thu";
            this.itRevenue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.itRevenue.Click += new System.EventHandler(this.itRevenue_Click);
            // 
            // itAccount
            // 
            this.itAccount.BackColor = System.Drawing.Color.Transparent;
            this.itAccount.ForeColor = System.Drawing.Color.Black;
            this.itAccount.Name = "itAccount";
            this.itAccount.Size = new System.Drawing.Size(305, 49);
            this.itAccount.Text = "Thiết lập tài khoản ";
            this.itAccount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.itAccount.Click += new System.EventHandler(this.itAccount_Click);
            // 
            // itQuit
            // 
            this.itQuit.ForeColor = System.Drawing.Color.Maroon;
            this.itQuit.Name = "itQuit";
            this.itQuit.Size = new System.Drawing.Size(305, 49);
            this.itQuit.Text = "Thoát";
            this.itQuit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.itQuit.Click += new System.EventHandler(this.itLogout_Click);
            // 
            // ucHome2
            // 
            this.ucHome2.Location = new System.Drawing.Point(350, 35);
            this.ucHome2.Name = "ucHome2";
            this.ucHome2.Size = new System.Drawing.Size(1521, 1001);
            this.ucHome2.TabIndex = 13;
            // 
            // ucAccount1
            // 
            this.ucAccount1.Location = new System.Drawing.Point(362, 27);
            this.ucAccount1.Name = "ucAccount1";
            this.ucAccount1.Size = new System.Drawing.Size(1533, 1001);
            this.ucAccount1.TabIndex = 12;
            // 
            // ucRevenue1
            // 
            this.ucRevenue1.Location = new System.Drawing.Point(362, 27);
            this.ucRevenue1.Name = "ucRevenue1";
            this.ucRevenue1.Size = new System.Drawing.Size(1533, 1001);
            this.ucRevenue1.TabIndex = 9;
            // 
            // ucCheckin1
            // 
            this.ucCheckin1.Location = new System.Drawing.Point(362, 27);
            this.ucCheckin1.Name = "ucCheckin1";
            this.ucCheckin1.Size = new System.Drawing.Size(1533, 1001);
            this.ucCheckin1.TabIndex = 4;
            // 
            // ucRoom1
            // 
            this.ucRoom1.Location = new System.Drawing.Point(362, 27);
            this.ucRoom1.Name = "ucRoom1";
            this.ucRoom1.Size = new System.Drawing.Size(1533, 1001);
            this.ucRoom1.TabIndex = 3;
            // 
            // ucBill1
            // 
            this.ucBill1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ucBill1.Location = new System.Drawing.Point(362, 27);
            this.ucBill1.Name = "ucBill1";
            this.ucBill1.Size = new System.Drawing.Size(1533, 1001);
            this.ucBill1.TabIndex = 2;
            // 
            // fHotelManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1922, 1052);
            this.Controls.Add(this.ucHome2);
            this.Controls.Add(this.ucAccount1);
            this.Controls.Add(this.ucRevenue1);
            this.Controls.Add(this.ucCheckin1);
            this.Controls.Add(this.ucRoom1);
            this.Controls.Add(this.ucBill1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "fHotelManager";
            this.Text = "Phần mềm quản lý khách sạn";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fHotelManager_FormClosed);
            this.Load += new System.EventHandler(this.fHotelManager_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem itHome;
        private System.Windows.Forms.ToolStripMenuItem itRoom;
        private System.Windows.Forms.ToolStripMenuItem itBill;
        private System.Windows.Forms.ToolStripMenuItem itCheckin;
        private System.Windows.Forms.ToolStripMenuItem itRevenue;
        private System.Windows.Forms.ToolStripMenuItem itAccount;
        private System.Windows.Forms.ToolStripMenuItem itQuit;
        private ucBill ucBill1;
        private ucRoom ucRoom1;
        private ucCheckin ucCheckin1;
        private ucRevenue ucRevenue1;
        private ucAccount ucAccount1;
        private ucHome ucHome2;
    }
}