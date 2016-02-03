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
    public partial class Thannhan : Form
    {
        public static Boolean KTthannhan = false;
        public static string temp;
        public static Boolean flag;
        DataTable dt ;
        DataTable dtqh ;
        DataTable dttn ;
        public Thannhan()
        {
            InitializeComponent();
        }

        private void Thannhan_Load(object sender, EventArgs e)
        {
            KTthannhan = true;
            dt = Code.QLthannhan.lietkethannhan();
            dgvthannhan.DataSource = dt;
            clearbindingtext();
            bindingtext();
            dtqh = Code.QLthannhan.lietkequanhe();
            dttn = Code.QLthannhan.tablethannhan();
            Code.Khoitao.AddItemToCombobox(cbquanhe, dtqh, "tenqh");
            Code.Khoitao.KhoidongAutoTextbox(dt, txtthannhan, "hoten");

            lbtenqh.Hide();
            lbtn.Hide();
            lbPhai.Hide();
            lbmaqh.Hide();
        }

        private void rdnam_CheckedChanged(object sender, EventArgs e)
        {
            if (rdnam.Checked == true)
                rdnam.Checked = true;
            else
                rdnu.Checked = true;
        }

        private void btnthemthannhan_Click(object sender, EventArgs e)
        {
            try
            {
                if (Themthannhan.KTthemthannhan == false)
                {
                    MainForm f = (MainForm)this.MdiParent;
                    Themthannhan tn = new Themthannhan();
                    tn.MdiParent = f;
                    tn.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnxoathannhan_Click(object sender, EventArgs e)
        {
            try
            {
                string matn = lbtn.Text;
                if(matn=="")
                {
                    MessageBox.Show("Không có thân nhân để xóa");
                    return;
                }
                //Xoá trên Datagrid
                DataRow[] dr = dt.Select("MaTN='" + matn + "'");
                dr[0].Delete();
                //Xóa trên table thannhan để cập nhật dữ liệu
                DataRow[] dr2 = dttn.Select("matn='" + matn + "'");
                dr2[0].Delete();
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
                Code.QLthannhan.Luuthannhan(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            KTthannhan = false;
            this.Close();
        }

        private void Thannhan_FormClosing(object sender, FormClosingEventArgs e)
        {
            KTthannhan = false;
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            try
            {
                dt = Code.QLthannhan.lietkethannhan(txtthannhan.Text);
                dgvthannhan.DataSource = dt;     
                if (dt.Rows.Count > 0)
                {
                    clearbindingtext();
                    bindingtext();
                }
                else
                {
                    cleartextbox();
                    MessageBox.Show("Không có thông tin thân nhân cần tìm");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            dt.RejectChanges();
            dttn.RejectChanges();
        }

        private void lbqh_TextChanged(object sender, EventArgs e)
        {
            cbquanhe.Text = lbtenqh.Text;
        }

        private void bindingtext()
        {
            txtthannhan.DataBindings.Add("text", dt, "hoten");
            txtdiachi.DataBindings.Add("text", dt, "diachi");
            txtnguyenquan.DataBindings.Add("text", dt, "nguyenquan");
            txtngaysinh.DataBindings.Add("text", dt, "ngaysinh",true,DataSourceUpdateMode.OnPropertyChanged,null,"dd/MM/yyyy");
            txtnghenghiep.DataBindings.Add("text", dt, "nghenghiep");
            rtxtghichu.DataBindings.Add("text", dt, "chuthich");
            rdnam.DataBindings.Add("Checked", dt, "phai");
            lbtenqh.DataBindings.Add("text", dt, "tenqh");
            lbtn.DataBindings.Add("text", dt, "matn");
            lbmaqh.DataBindings.Add("text", dt, "maqh");
        }

        private void clearbindingtext()
        {
            txtthannhan.DataBindings.Clear();
            txtnghenghiep.DataBindings.Clear();
            txtngaysinh.DataBindings.Clear();
            txtdiachi.DataBindings.Clear();
            txtnguyenquan.DataBindings.Clear();
            rdnam.DataBindings.Clear();
            rtxtghichu.DataBindings.Clear();
            lbtenqh.DataBindings.Clear();
            lbtn.DataBindings.Clear();
            lbmaqh.DataBindings.Clear();
        }

        private void cleartextbox()
        {
            txtthannhan.Text = "";
            txtnguyenquan.Text = "";
            txtnghenghiep.Text = "";
            txtngaysinh.Text = "";
            txtdiachi.Text = "";
            cbquanhe.SelectedIndex = 0;
        }

        private void cbquanhe_SelectedValueChanged(object sender, EventArgs e)
        {
            int maqh = cbquanhe.SelectedIndex + 1;
            lbtenqh.Text = cbquanhe.Text;
            lbmaqh.Text = maqh.ToString() ;
        }

        private void Thannhan_Activated(object sender, EventArgs e)
        {
            if (flag == true)
            {
                flag = false;
                MessageBox.Show("Thêm thân nhân mới thành công");
                this.Thannhan_Load(null, null);
                int i;
                for (i = 0; i < dt.Rows.Count; i++)
                    if (temp == dt.Rows[i]["matn"].ToString())
                        break;
                if (i >= dt.Rows.Count)
                    return;
                dgvthannhan.Rows[i].Selected = true;
            }
        }

    }
}