using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace LDTBXH
{
    public partial class Quanhe : Form
    {
        public Quanhe()
        {
            InitializeComponent();
        }
        SqlConnection cnn = null;
        SqlDataAdapter da = null;
        DataTable dt = null;

        private void Quanhe_Load(object sender, EventArgs e)
        {
            try
            {
                cnn = new SqlConnection(chuoiketnoi.chuoikn);
                da = new SqlDataAdapter("select * from quanhe", cnn);
                dt = new DataTable();
                new SqlCommandBuilder(da);
                cnn.Open();
                da.Fill(dt);
                cnn.Close();
                dataGridView1.DataSource = dt;
                lbqh.DataBindings.Add("text", dt, "maqh");
                lbqh.Hide();
                dataGridView1.Columns["maqh"].HeaderText = "Mã Quan Hệ";
                dataGridView1.Columns["tenqh"].HeaderText = "Tên Quan Hệ";
            }
            catch(Exception ee)
            {
                MessageBox.Show(ee.Message);
                cnn.Close();
            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtquanhe.Text.Trim() == "")
                {
                    MessageBox.Show("Bạn quên nhập tên quan hệ");
                    return;
                }

                try
                {
                    if (KTTonTai(txtquanhe.Text) == true)
                    {
                        MessageBox.Show("Quan hệ này đã tồn tại");
                        txtquanhe.Focus();
                        return;
                    }
                }
                catch (DeletedRowInaccessibleException)
                {
                    MessageBox.Show("Dữ liệu đã có sự thay đổi"+"\n"+"Làm ơn lưu lại hoặc hủy thao tác trước khi thêm mới");
                    return;
                }
                string maqh = "1";
                int i;
                for (i = 0; i < dt.Rows.Count; i++)
                {
                    if (maqh == dt.Rows[i]["maqh"].ToString())
                    {
                        int temp = i + 2;
                        maqh = temp.ToString();
                    }
                }
                if (i >= dt.Rows.Count)
                {
                    i++;
                    maqh = i.ToString() ;
                }

                DataRow dr = dt.NewRow();
                dr["maqh"] = maqh;
                dr["tenqh"] = txtquanhe.Text;
                dt.Rows.Add(dr);

                txtquanhe.Text = "";               
                txtquanhe.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            MainForm.KTquanhe = false;
            this.Close();

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
                cnn.Close();
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (lbqh.Text == "")
                    MessageBox.Show("Không có quan hệ để xóa");
                else
                {
                    DataRow[] dr = dt.Select("maqh='" + lbqh.Text + "'");
                    dr[0].Delete();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Huythaotac_Click(object sender, EventArgs e)
        {
            dt.RejectChanges();
        }
        
        private Boolean KTTonTai(string s)
        {
            for (int i = 0; i < dt.Rows.Count; i++)
                if (txtquanhe.Text == dt.Rows[i]["tenqh"].ToString())
                    return true;
            return false;
        }

        private void Quanhe_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm.KTquanhe = false;
        }
   
    }
}