using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class fHotelManager : Form
    {
        private bool Accessibility=true;
        public fHotelManager()
        {
            InitializeComponent();
            ucHome1.Visible = false;
            ucAccount1.Visible = false;
            ucBill1.Visible = false;
            ucCheckin1.Visible = false;
            ucRevenue1.Visible = false;
            ucRoom1.Visible = false;
        }
        public bool Permission_to_access
        {
            get { return Accessibility; }
            set { Accessibility = value; }
        }

        private void fHotelManager_Load(object sender, EventArgs e)
        {
            ucRoom1.Permission_to_access = Accessibility;
            ucAccount1.Permission_to_access = Accessibility;
            if (Accessibility == false)
            {
                panel1.Visible = false;
                button_doanhthu.Visible = false;
            }
            ucHome1.Visible = true;
        }

        private void itLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        private void fHotelManager_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }



        private void Button_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        private void Button_thugon_Click(object sender, EventArgs e)
        {
            if (panel_left.Width == 350)
            {
                panel_left.Width = 77;
            }
            else
            {
                panel_left.Width = 350;
            }
        }

        private void Button_phong_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            label_tieude.Text = btn.Text;
            foreach (Control item in panel_Menu.Controls)
                item.BackColor = panel_Menu.BackColor;
            btn.BackColor = Color.Orange;

            ucAccount1.Visible = false;
            ucBill1.Visible = false;
            ucCheckin1.Visible = false;
            ucRevenue1.Visible = false;
            ucRoom1.Visible = true;
            ucHome1.Visible = false;
        }

        private void Button_trangchu_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            label_tieude.Text = btn.Text;
            foreach (Control item in panel_Menu.Controls)
                item.BackColor = panel_Menu.BackColor;
            btn.BackColor = Color.Orange;

            ucAccount1.Visible = false;
            ucBill1.Visible = false;
            ucCheckin1.Visible = false;
            ucRevenue1.Visible = false;
            ucRoom1.Visible = false;
            ucHome1.Visible = true;
        }

        private void Button_hoadon_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            label_tieude.Text = btn.Text;
            foreach (Control item in panel_Menu.Controls)
                item.BackColor = panel_Menu.BackColor;
            btn.BackColor = Color.Orange;

            ucAccount1.Visible = false;
            ucBill1.Visible = true;
            ucCheckin1.Visible = false;
            ucRevenue1.Visible = false;
            ucRoom1.Visible = false;
            ucHome1.Visible = false;
        }

        private void Button_phieuthue_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            label_tieude.Text = btn.Text;
            foreach (Control item in panel_Menu.Controls)
                item.BackColor = panel_Menu.BackColor;
            btn.BackColor = Color.Orange;

            ucAccount1.Visible = false;
            ucBill1.Visible = false;
            ucCheckin1.Visible = true;
            ucRevenue1.Visible = false;
            ucRoom1.Visible = false;
            ucHome1.Visible = false;
        }

        private void Button_doanhthu_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            label_tieude.Text = btn.Text;
            foreach (Control item in panel_Menu.Controls)
                item.BackColor = panel_Menu.BackColor;
            btn.BackColor = Color.Orange;

            ucAccount1.Visible = false;
            ucBill1.Visible = false;
            ucCheckin1.Visible = false;
            ucRevenue1.Visible = true;
            ucRoom1.Visible = false;
            ucHome1.Visible = false;
        }

        private void Button_thietlap_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            label_tieude.Text = btn.Text;
            foreach (Control item in panel_Menu.Controls)
                item.BackColor = panel_Menu.BackColor;
            btn.BackColor = Color.Orange;

            ucAccount1.Visible = true;
            ucBill1.Visible = false;
            ucCheckin1.Visible = false;
            ucRevenue1.Visible = false;
            ucRoom1.Visible = false;
            ucHome1.Visible = false;
        }

        private void Button_thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void UcHome2_Load(object sender, EventArgs e)
        {

        }

        private void Panel_top_Paint(object sender, PaintEventArgs e)
        {

        }
    }   
}
