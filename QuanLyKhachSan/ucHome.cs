﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyKhachSan.DTO;
using QuanLyKhachSan.BUS;

namespace QuanLyKhachSan
{
    public partial class ucHome : UserControl
    {
        public ucHome()
        {
            InitializeComponent();
            LoadHome(); 
        }

        void LoadHome()
        {
            List<Home> RoomList = HomeBUS.Instance.LoadRoomList();

            foreach (Home item in RoomList)
            {
                Button btn = new Button() { Width = HomeBUS.RoomWidth, Height = HomeBUS.RoomHeight };
                btn.Text = item.ID + Environment.NewLine + item.Status;
                btn.Tag = item;
                btn.Click += btn_Click;
                btn.Tag = item;
                switch (item.Status)
                {
                    case "EMPTY":
                        btn.BackColor = Color.SandyBrown;
                        break;
                    default:
                        btn.BackColor = Color.LightCoral;
                        break;
                }
                flpHome.Controls.Add(btn);

            }
        }

        void btn_Click(object sender, EventArgs e)
        {
            string roomID = ((sender as Button).Tag as Home).ID;
            string roomStatus = ((sender as Button).Tag as Home).Status;
            if (roomStatus == "EMPTY")
            {
                fCheckin f = new fCheckin
                {
                    Tag = roomID
                };
                f.ShowDialog();
            }
            else
            {
                fBill f = new fBill();
                f.ShowDialog();
            }
        }

        private void btnAddCheckin_Click(object sender, EventArgs e)
        {
            fCheckin f = new fCheckin();
            f.ShowDialog();
        }

        private void btnAddBill_Click(object sender, EventArgs e)
        {
            fBill f = new fBill();
            f.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            flpHome.Controls.Clear();
            LoadHome();
        }

        private void UcHome_Load(object sender, EventArgs e)
        {

        }
    }
}
