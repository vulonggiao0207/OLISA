using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace LDTBXH
{
    public partial class Doipass : Form
    {
        public static Boolean KTdoipass = false;
        public static void Suapass(String a, String b)
        {
            try
            {         
                SqlConnection sqlconn = new SqlConnection(chuoiketnoi.chuoikn);
                string sql = "update admin set password= '" + a + "' where id='" + b + "'";
                SqlCommand cmd = new SqlCommand(sql, sqlconn);
                sqlconn.Open();
                cmd.ExecuteNonQuery();
                sqlconn.Close();
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }


        public Doipass()
        {
            InitializeComponent();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            KTdoipass = false;
            this.Close();
        }

        private void btndoi_Click(object sender, EventArgs e)
        {
            string tkhoan=txttkhoan.Text;
            string mkhau=txtmkhau.Text;
            string mkhmoi=txtmkmoi.Text;
            string nhaplai=txtnhaplai.Text;
            if (DangNhap.timkiem(tkhoan, mkhau))
            {
                if (mkhmoi == nhaplai)
                {
                    Suapass(mkhmoi, tkhoan);
                    lbdoipass.Text = "Thay đổi thành công";
                }
                else
                    lbdoipass.Text = "Yêu cầu xác nhận lại mật khẩu mới";
            }
            else
            {
                lbdoipass.Text = "Sai tên đăng nhập hoặc mật khẩu";
            }
        }

        private void txttkhoan_Validating(object sender, CancelEventArgs e)
        {
            Regex rg = new Regex("^[\\w,0-9]{0,20}$");
            if (rg.IsMatch(txttkhoan.Text) == false)
            {
                MessageBox.Show("Tài khoản không hợp lệ");
                e.Cancel = true;
            }
        }

        private void txtmkhau_Validating(object sender, CancelEventArgs e)
        {
            Regex rg = new Regex("^[\\S]{0,32}$");
            if (rg.IsMatch(txtmkhau.Text) == false)
            {
                MessageBox.Show("Mật khẩu không hợp lệ");
                e.Cancel = true;
            }
        }

        private void txtmkmoi_Validating(object sender, CancelEventArgs e)
        {
            Regex rg = new Regex("^[\\S]{0,32}$");
            if (rg.IsMatch(txtmkmoi.Text) == false)
            {
                MessageBox.Show("Mật khẩu mới không hợp lệ");
                e.Cancel = true;
            }
        }

        private void Doipass_Load(object sender, EventArgs e)
        {
            KTdoipass = true;
        }

        private void Doipass_FormClosing(object sender, FormClosingEventArgs e)
        {
            KTdoipass = false;
        }
    }
}