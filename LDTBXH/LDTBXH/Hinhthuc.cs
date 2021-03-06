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
    public partial class Hinhthuc : Form
    {
        public Hinhthuc()
        {
            InitializeComponent();
        }
        SqlConnection cnn = null;
        SqlDataAdapter da = null;
        DataTable dt = null;
        private void Hinhthuc_Load(object sender, EventArgs e)
        {
            try
            {
                cnn = new SqlConnection(chuoiketnoi.chuoikn);
                da = new SqlDataAdapter("select * from hinhthuc", cnn);
                dt = new DataTable();
                new SqlCommandBuilder(da);
                cnn.Open();
                da.Fill(dt);
                cnn.Close();
                dataGridView1.DataSource = dt;
                lbht.DataBindings.Add("text", dt, "maht");
                lbht.Hide();
                dataGridView1.Columns["maht"].HeaderText = "Mã Hình Thức";
                dataGridView1.Columns["tenht"].HeaderText = "Tên Hình Thức";
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
                cnn.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txthinhthuc.Text.Trim() == "")
                {
                    MessageBox.Show("Bạn quên nhập tên hình thức");
                    return;
                }

                try
                {
                    if (KTTonTai(txthinhthuc.Text) == true)
                    {
                        MessageBox.Show("Hình thức này đã tồn tại");
                        txthinhthuc.Focus();
                        return;
                    }
                }
                catch (DeletedRowInaccessibleException)
                {
                    MessageBox.Show("Dữ liệu đã có sự thay đổi" + "\n" + "Làm ơn lưu lại hoặc hủy thao tác trước khi thêm mới");
                    return;
                }

                string maht = "1";
                int i;
                for (i = 0; i < dt.Rows.Count; i++)
                {
                    if (maht == dt.Rows[i]["maht"].ToString())
                    {
                        int temp = i + 2;
                        maht = temp.ToString();
                    }
                }
                if (i >= dt.Rows.Count)
                {
                    i++;
                    maht = i.ToString();
                }

                DataRow dr = dt.NewRow();
                dr["maht"] = maht;
                dr["tenht"]=txthinhthuc.Text;
                dt.Rows.Add(dr);
                txthinhthuc.Text = "";
                txthinhthuc.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
        {
            MainForm.KThinhthuc = false;
            this.Close();

        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (lbht.Text == "")
                    MessageBox.Show("Không có hình thức để xóa");
                else
                {
                    DataRow[] dr = dt.Select("maht='" + lbht.Text + "'");
                    dr[0].Delete();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnHuythaotac_Click(object sender, EventArgs e)
        {
            dt.RejectChanges();
        }

        private Boolean KTTonTai(string s)
        {
            for (int i = 0; i < dt.Rows.Count; i++)
                if (txthinhthuc.Text == dt.Rows[i]["tenht"].ToString())
                    return true;
            return false;
        }

        private void Hinhthuc_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm.KThinhthuc = false;
        }
    }
}