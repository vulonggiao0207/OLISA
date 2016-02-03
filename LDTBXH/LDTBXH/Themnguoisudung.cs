using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace LDTBXH
{
    public partial class Themnguoisudung : Form
    {
        SqlConnection cnn = null;
        SqlDataAdapter da = null;
        DataTable dt = null;
        public Themnguoisudung()
        {
            InitializeComponent();
        }

        private void Themnguoisudung_Load(object sender, EventArgs e)
        {
            try
            {
                
                string sql = "select * from admin";
                cnn = new SqlConnection(chuoiketnoi.chuoikn);
                da = new SqlDataAdapter(sql, cnn);
                new SqlCommandBuilder(da);
                dt = new DataTable();
                cnn.Open();
                da.Fill(dt);
                cnn.Close();
                dgvadmin.DataSource = dt;
                lbtaikhoan.DataBindings.Add("text", dt, "id");
                lbtaikhoan.Hide();
                dgvadmin.Columns["password"].Visible = false;
                dgvadmin.Columns["admin"].HeaderText="Toàn quyền";
                dgvadmin.Columns["doituong"].HeaderText = "Cập nhật đối tượng";
                dgvadmin.Columns["dienuutien"].HeaderText = "cập nhật diện ưu tiên";
                dgvadmin.Columns["kehoach"].HeaderText = "Cập nhật kế hoạch";
                dgvadmin.Columns["tiendo"].HeaderText = "Cập nhật tiến độ";
                dgvadmin.Columns["id"].HeaderText = "Tài khoản";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            MainForm.KTthemngdung = false;
            this.Close();
        }

        private void Themnguoisudung_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm.KTthemngdung = false;
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            try
            {
                cnn.Open();
                da.Update(dt);
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (lbtaikhoan.Text == "")
                    MessageBox.Show("Không có tài khoản để xóa");
                else
                {
                    DataRow[] dr = dt.Select("id='" + lbtaikhoan.Text + "'");
                    dr[0].Delete();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txttaikhoan.Text.Trim() == "" || txtmatkhau.Text.Trim() == "")
                {
                    MessageBox.Show("Bạn quên nhập ID hoặc Password");
                    return;
                }
                if (KTTonTai(txttaikhoan.Text) == true)
                {
                    MessageBox.Show("Tài khoản này đã tồn tại");
                    txttaikhoan.Focus();
                    return;
                }
                if (txtmatkhau.Text != txtmatkhaunhaplai.Text)
                {
                    MessageBox.Show("Yêu cầu xác nhận lại mật khẩu");
                    return;
                }
                //string sql = "insert into admin(ID,Password)";
                //sql+="values('"+txttaikhoan.Text+"','"+txtmatkhau.Text+"')";
                //SqlCommand cmd = new SqlCommand("admin", cnn);
                //cmd.CommandText = sql;
                //cnn.Open();
                //cmd.ExecuteNonQuery();
                //dt = new DataTable();
                //da.Fill(dt);
                //cnn.Close();
                //dgvadmin.DataSource = dt;
                DataRow dr = dt.NewRow();
                dr["id"] = txttaikhoan.Text;
                dr["password"] = txtmatkhau.Text;
                dt.Rows.Add(dr);

                txttaikhoan.Text = "";
                txtmatkhau.Text = "";
                txtmatkhaunhaplai.Text = "";
                txttaikhoan.Focus();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private Boolean KTTonTai(string s)
        {
            //bool flag = false; // default khong ton tai user tennd
            //string sql = "SELECT 1 From admin where id='" + s + "'";
            //SqlCommand cmd = new SqlCommand(sql, cnn);
            //cnn.Open();
            //object obj = cmd.ExecuteScalar();
            //cnn.Close();
            //if (obj != null)
            //{
            //    flag = true;
            //}
            //return flag;
            for (int i = 0; i < dt.Rows.Count; i++)
                if (txttaikhoan.Text == dt.Rows[i]["id"].ToString())
                    return true;
            return false;
        }

        private void txttaikhoan_Validating(object sender, CancelEventArgs e)
        {
            Regex rg = new Regex("^\\w{0,20}$");
            if (rg.IsMatch(txttaikhoan.Text) == false)
            {
                MessageBox.Show("ID nhập vào không hợp lệ");
                e.Cancel = true;
            }
        }

        private void txttaikhoan_TextChanged(object sender, EventArgs e)
        {
            if (txttaikhoan.Text.Length > 20)
                txttaikhoan.ForeColor = Color.Red;
            else
                txttaikhoan.ForeColor = Color.Black;
        }

        private void txtmatkhau_Validating(object sender, CancelEventArgs e)
        {
            Regex rg = new Regex("^\\S{0,32}$");
            if (rg.IsMatch(txtmatkhau.Text) == false)
            {
                MessageBox.Show("Mật khẩu không hợp lệ");
                e.Cancel = true;
            }
        }

        private void txtmatkhau_TextChanged(object sender, EventArgs e)
        {
            if (txtmatkhau.Text.Length > 32)
                txtmatkhau.ForeColor = Color.Red;
            else
                txtmatkhau.ForeColor = Color.Black;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            dt.RejectChanges();
        }

        
       
    }
}