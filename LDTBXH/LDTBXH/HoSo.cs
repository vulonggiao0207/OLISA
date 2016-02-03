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
    public partial class HoSo : Form
    {
        public static Boolean KThoso = false;
        DataTable dt = null;
        public static string temp;
        public static Boolean flag=false;
        public HoSo()
        {
            InitializeComponent();
        }

        private void HoSo_Load(object sender, EventArgs e)
        {
            try
            {
                KThoso = true;
                dt = Code.QLHoso.Lietkehoso();
                dgvhoso.DataSource = dt;
                ClearBinding();
                Bindingtextbox();
                for (int i = 0; i < dt.Rows.Count; i++)
                    txttenhoso.AutoCompleteCustomSource.Add(dt.Rows[i]["tengt"].ToString());
                lbhs.Hide();
                dgvhoso.Columns["magt"].Visible = false;
                dgvhoso.Columns["madt"].Visible = false;
                dgvhoso.Columns["tengt"].HeaderText = "Tên Hồ Sơ";
                dgvhoso.Columns["noidungGT"].HeaderText = "Nội Dung Hồ Sơ";
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
                if(lbhs.Text=="")
                {
                    MessageBox.Show("Không có hồ sơ để xóa");
                    return;
                }
                DataRow[] dr = dt.Select("magt='" + lbhs.Text + "'");
                dr[0].Delete();
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
                if (Themhoso.KTThemhoso == false)
                {
                    MainForm f = (MainForm)this.MdiParent;
                    Themhoso hs = new Themhoso();
                    hs.MdiParent = f;
                    hs.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            try
            {
                if (Code.QLHoso.Luuhoso(txttenhoso.Text, rtxtnoidung.Text, lbhs.Text) > 0)
                {
                    dgvhoso.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            KThoso = false;
            this.Close();
        }

        private void HoSo_FormClosing(object sender, FormClosingEventArgs e)
        {
            KThoso = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            dt.RejectChanges();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            try
            {
                dt = Code.QLHoso.Lietkehoso(txttenhoso.Text);
                dgvhoso.DataSource = dt;
                if (dt.Rows.Count > 0)
                {
                    ClearBinding();
                    Bindingtextbox();
                }
                else
                {
                    ClearTextbox();
                    MessageBox.Show("Không có thông tin hồ sơ cần tìm");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void txttenhoso_Validating(object sender, CancelEventArgs e)
        {
            Regex rg = new Regex("^[\\w,\\s]{0,30}$");
            if (rg.IsMatch(txttenhoso.Text) == false)
            {
                MessageBox.Show("Tên hồ sơ không hợp lệ");
                e.Cancel = true;
            }
        }

        private void txttenhoso_TextChanged(object sender, EventArgs e)
        {
            if (txttenhoso.Text.Length > 30)
                txttenhoso.ForeColor = Color.Red;
            else
                txttenhoso.ForeColor = Color.Black;
        }

        private void Bindingtextbox()
        {
            txttenhoso.DataBindings.Add("text", dt, "tengt");
            rtxtnoidung.DataBindings.Add("text", dt, "noidunggt");
            lbhs.DataBindings.Add("text", dt, "magt");
        }
        private void ClearBinding()
        {
            txttenhoso.DataBindings.Clear();
            rtxtnoidung.DataBindings.Clear();
            lbhs.DataBindings.Clear();
        }
        private void ClearTextbox()
        {
            txttenhoso.Text = "";
            rtxtnoidung.Text = "";
        }

        private void HoSo_Activated(object sender, EventArgs e)
        {
            if (flag == true)
            {
                flag = false;
                MessageBox.Show("Thêm hồ sơ mới thành công");
                this.HoSo_Load(null, null);
                int i;
                for (i = 0; i < dt.Rows.Count; i++)
                    if (temp==dt.Rows[i]["magt"].ToString())
                        break;
                if (i >= dt.Rows.Count)
                    return;
                dgvhoso.Rows[i].Selected = true;
            }
        }
    }
}