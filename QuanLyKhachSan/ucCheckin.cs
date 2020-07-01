﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyKhachSan.BUS;
using QuanLyKhachSan.DTO;

namespace QuanLyKhachSan
{
    public partial class ucCheckin : UserControl
    {
        private bool only1searchattribute = true;
        private bool Is_AdvancedSearch = false;
        public ucCheckin()
        {
            InitializeComponent();
            LoadCheckin();
            LoadRatio();
            panel2.Visible = false;
        }

        #region Xử lí hàm

        void LoadCheckin()
        {
            dtgvList.DataSource=CheckinManagementBUS.Instance.LoadCheckinList();
        }

        void LoadRatio()
        {
            List<CustomerType> listRatio = CustomerTypeBUS.Instance.GetListType();
            textboxsearch4.DataSource = listRatio;
            textboxsearch4.DisplayMember = "ratio";
        }

        void AdvancedSearch(ref string insert)
        {
            if (checkbox1.Checked == true)
            {
                insert += " date_start = '" + textboxsearch1.Value.Date.ToString("d") + "'";
                only1searchattribute = false;
            }
            if (checkbox2.Checked == true)
            {
                if(only1searchattribute==false)
                {
                    insert += "and ";
                }
                insert +=" id_room = '" + textboxsearch2.Text + "'";
                only1searchattribute = false;
            }
            if (checkbox3.Checked == true)
            {
                if (only1searchattribute == false)
                {
                    insert += "and ";
                }
                insert +=" money_checkin = '" + textboxsearch3.Text + "'";
                only1searchattribute = false;
            }
            if (checkbox4.Checked == true)
            {
                if (only1searchattribute == false)
                {
                    insert += "and ";
                }
                insert += " type_ratioMAX = '" + textboxsearch4.Text + "'";
                only1searchattribute = false;
            }
            if (checkbox5.Checked == true)
            {
                if (only1searchattribute == false)
                {
                    insert += "and ";
                }
                insert +=" number_customer= '" + textboxsearch5.Text + "'";
                only1searchattribute = false;
            }
            if (checkbox6.Checked == true)
            {
                if (only1searchattribute == false)
                {
                    insert += "and ";
                }
                insert +=" status_checkin = '" + textboxsearch6.Text + "'";
                only1searchattribute = false;
            }
        }

        #endregion

        #region Chức năng quản lí phiếu thuê

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txbSearch.Text == "" && panel2.Visible == false)
            {
                MessageBox.Show("Vui lòng nhập mã phiếu");
                return;
            }
            only1searchattribute = true;
            string insert = "";
            if (checkbox1.Checked==true || checkbox2.Checked == true|| checkbox3.Checked ==true|| checkbox4.Checked == true||checkbox5.Checked == true || checkbox6.Checked == true )
                AdvancedSearch(ref insert);
            else
                insert = " id_checkin='" + txbSearch.Text + "'";
            dtgvList.DataSource = CheckinManagementBUS.Instance.SearchCheckin(insert);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadCheckin();
            checkbox1.Checked = false;
            checkbox2.Checked = false;
            checkbox3.Checked = false;
            checkbox4.Checked = false;
            checkbox5.Checked = false;
            checkbox6.Checked = false;
            textboxsearch1.Value = DateTime.Now;
            textboxsearch2.Text = "";
            textboxsearch3.Text = "";
            textboxsearch4.Text = "";
            textboxsearch5.Text = "";
            textboxsearch6.Text = "";
        }

        private void btnAdvancedSearch_Click(object sender, EventArgs e)
        {
            if (Is_AdvancedSearch == false)
            {
                panel2.Visible = true;
                Is_AdvancedSearch = true;
                return;
            }
            else
            {
                panel2.Visible = false;
                Is_AdvancedSearch = false;
                return;
            }
        }

        #endregion

        private void txbSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }     
    }
}
