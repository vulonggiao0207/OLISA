using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LDTBXH
{
    public partial class DangNhap : Form
    {
        public static string tendangnhap = "";
        public DangNhap()
        {
            InitializeComponent();
            
        }
        public static bool timkiem(String a, String b)
        {
            bool timthay = false;
            a = a.Replace("'", "''");
            b = b.Replace("'", "''");
            a = a.Trim();
            b = b.Trim();
            SqlConnection sqlconn = new SqlConnection(chuoiketnoi.chuoikn);
            string sql = "SELECT id,password FROM Admin WHERE id='" + a + "' and password='" + b + "'";

            SqlCommand cmd = new SqlCommand(sql, sqlconn);
            sqlconn.Open();

            SqlDataReader read = cmd.ExecuteReader();
            if (read.Read()) // select co du lieu
                timthay = true;

            sqlconn.Close();
            return timthay;
        }  

        private void btndangnhap_Click(object sender, EventArgs e)
        {
            String tkhoan = txttaikhoan.Text;
            String matkhau = txtmatkhau.Text;
            
            if (timkiem(tkhoan, matkhau))
            {
                tendangnhap = tkhoan;
                this.Hide();
                MainForm f = new MainForm();
                f.Show();
            }
            else
                lbdangnhap.Text = "  Mật khẩu đăng nhập sai!";
        }

        private void btndoipass_Click(object sender, EventArgs e)
        {
            if (Doipass.KTdoipass == false)
            {
                Doipass dp = new Doipass();
                dp.Show();
            }
        }

     
    }
}