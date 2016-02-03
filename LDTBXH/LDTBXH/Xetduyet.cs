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
    public partial class Xetduyet : Form
    {
        public static Boolean KTxetduyet = false;
        DataTable dt = null;
        DataTable dtdkut = null;
        public Xetduyet()
        {
            InitializeComponent();
        }

        private void Xetduyet_Load(object sender, EventArgs e)
        {
            try
            {
                KTxetduyet = true;
                dt = Code.QlDienuutien.LietkeXetDuyetDUT(DoiTuongUuTien.madt);
                dgvdienuutien.DataSource = dt;
                txttendoituong.Text = DoiTuongUuTien.tendt;
                Addbinding();
                Code.Khoitao.KhoidongAutoTextbox(dt, txtdienuutien, "tendut");

                lbdut.Hide();
                dgvdienuutien.Columns["Madut"].Visible = false;
                dgvdienuutien.Columns["tendut"].HeaderText = "Tên Diện Ưu Tiên";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            KTxetduyet = false;
            this.Close();
        }

        private void Xetduyet_FormClosing(object sender, FormClosingEventArgs e)
        {
            KTxetduyet = false;
        }

        private void btntim_Click(object sender, EventArgs e)
        {
            dt = Code.QlDienuutien.Timkiemdut(txtdienuutien.Text);
            dgvdienuutien.DataSource = dt;
            if (dt.Rows.Count <= 0)
                MessageBox.Show("Không có thông tin diện ưu tiên cần tìm");
            else
            {
                Clearbinding();
                Addbinding();
            }
        }

        private void lbdut_TextChanged(object sender, EventArgs e)
        {
            dtdkut = Code.QlDienuutien.Lietkedieukienut(lbdut.Text);
            cklbdieukien.Items.Clear();
            for (int i = 0; i < dtdkut.Rows.Count; i++)
                cklbdieukien.Items.Add(dtdkut.Rows[i]["madkut"].ToString());         
            rtxtnoidung.Text = "";
            btnxetduyet.Enabled = false;
        }

        private void cklbdieukien_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cklbdieukien.SelectedIndex;
            rtxtnoidung.Text = dtdkut.Rows[index]["dieukien"].ToString();
        }

        private void cklbdieukien_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            int index = cklbdieukien.SelectedIndex;
            if (cklbdieukien.GetItemChecked(index) == false && cklbdieukien.CheckedItems.Count == cklbdieukien.Items.Count - 1)
                btnxetduyet.Enabled = true;
            else
                btnxetduyet.Enabled = false;
        }

        private void btnxetduyet_Click(object sender, EventArgs e)
        {
            try
            {
                if (Code.Qldoituong.Themdoituonguutien(DoiTuongUuTien.madt, lbdut.Text) > 0)
                {
                    MessageBox.Show("Xét duyệt thành công");
                    dt = Code.QlDienuutien.LietkeXetDuyetDUT(DoiTuongUuTien.madt);
                    dgvdienuutien.DataSource = dt;
                    Clearbinding();
                    Addbinding();
                }
                else
                    MessageBox.Show("Xét duyệt không thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Clearbinding()
        {
            txtdienuutien.DataBindings.Clear();
            lbdut.DataBindings.Clear();
        }

        private void Addbinding()
        {
            txtdienuutien.DataBindings.Add("text", dt, "tendut");
            lbdut.DataBindings.Add("text", dt, "madut");          
        }
        

    }
}