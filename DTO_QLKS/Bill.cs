using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DTO
{
    public class Bill
{
    public Bill(int id_bill,string bill_name,string bill_address,string total_money, int id_checkin, int date_number, float surchage_price)
    {
        this.Id_bill = id_bill;
        this.Bill_address = bill_address;
        this.Bill_name = bill_name;
        this.Total_money = total_money;
        this.Surchage_ratio = surchage_ratio;
        this.Id_checkin = id_checkin;
        this.Date_number = date_number;
    }

    public Bill(DataRow row)
    {
        this.Id_bill = Convert.ToInt32(row["id_bill"].ToString());
        this.Bill_name = row["bill_name"].ToString();
        this.Bill_address = row["bill_address"].ToString();
        this.Total_money = row["total_money"].ToString();
        this.Id_checkin = (int)Convert.ToInt32(row["id_checkin"].ToString());
        this.date_number = (int)Convert.ToInt32(row["date_number"].ToString());
        this.Surchage_ratio = (float)Convert.ToDouble(row["surchage_ratio"].ToString());
    }

    private int id_bill;
    private string bill_name;
    private string bill_address;
    private string total_money;
    private int id_checkin;
    private int date_number;
    private float surchage_ratio;

    public int Id_bill
    {
        get { return id_bill; }
        set { id_bill = value; }
    }

    public string Bill_name
    {
        get { return bill_name; }
        set { bill_name = value; }
    }
    public string Bill_address
    {
        get { return bill_address; }
        set { bill_address = value; }
    }

    public string Total_money
    {
        get { return total_money; }
        set { total_money = value; }
    }
    public int Id_checkin
    {
        get { return id_checkin; }
        set { id_checkin = value; }
    }
    public int Date_number
    {
        get { return date_number; }
        set { date_number = value; }
    }
    public float Surchage_ratio
    {
        get { return surchage_ratio; }
        set { surchage_ratio = value; }
    }
}
}
