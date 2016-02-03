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
    public partial class DienUuTien : Form
    {   
        DataTable dtdut = null;   
        DataTable dtdk = null;
        DataTable dttiendo = null;
        SqlDataAdapter dadut = null;
        SqlDataAdapter dadk = null;
        public static string madut;
        public static string tendut;
        public static string temp;
        public static Boolean flag;

        public DienUuTien()
        {
            InitializeComponent();
        }

        private void DienUuTien_Load(object sender, EventArgs e)
        {
            try
            {
                dtdut = Code.QlDienuutien.Lietkedienut();
                dttiendo = Code.QLKehoach.Lietketiendo();
                dgvdienuutien.DataSource = dtdut;
                ClearbindingDUT();
                AddbindingDUT();
                Code.Khoitao.KhoidongAutoTextbox(dtdut, txttendienuutien, "tendut");
                lbdut.Hide();
                lbdieukien.Hide();
                dgvdienuutien.Columns["madut"].HeaderText = "Mã Diện Ưu Tiên";
                dgvdienuutien.Columns["tendut"].HeaderText = "Tên Diện Ưu Tiên";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            MainForm.KTdienuutien = false;
            this.Close();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                string madut = lbdut.Text;
                if(madut=="")
                {
                    MessageBox.Show("Không có diện ưu tiên để xóa");
                    return;
                }
                DataRow[] dr = dtdut.Select("madut='" + madut + "'");
                DataRow[] drtiendo=dttiendo.Select("madut='"+madut+"'");
                //Xóa trên table tiendo
                for (int i = 0; i < drtiendo.Length; i++)
                    drtiendo[i].Delete();
                //Xóa trên table dienuutien
                dr[0].Delete();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
        private void btntim_Click(object sender, EventArgs e)
        {
            try
            {
                ClearbindingDUT();
                dtdut = Code.QlDienuutien.Timkiemdut(txttendienuutien.Text);
                dgvdienuutien.DataSource = dtdut;
                AddbindingDUT();
                if (dtdut.Rows.Count <= 0)
                    MessageBox.Show("Không có thông tin diện ưu tiên cần tìm");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DienUuTien_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm.KTdienuutien = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            dttiendo.RejectChanges();
            dtdut.RejectChanges();
            dtdk.RejectChanges();
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            try
            {
                Code.QLKehoach.Luutiendo(dttiendo);
                Code.QlDienuutien.Luudienut(dadut, dtdut);
                Code.QlDienuutien.Luudieukien(dadk, dtdk);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lbdut_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dtdk = Code.QlDienuutien.Lietkedieukienut(lbdut.Text);
                if (dtdk.Rows.Count <= 0)
                    lbdieukien.Text = "";
                Code.Khoitao.bindinglistbox(dtdk, lstdieukienuutien, "madkut", "madkut");
                lbdieukien.DataBindings.Clear();
                rtxtnoidungdk.DataBindings.Clear();

                lbdieukien.DataBindings.Add("text", dtdk, "madkut");
                rtxtnoidungdk.DataBindings.Add("text", dtdk, "dieukien");
                if (dtdk.Rows.Count <= 0)
                    rtxtnoidungdk.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnthemdieukienuutien_Click(object sender, EventArgs e)
        {
            try
            {
                madut = lbdut.Text;
                tendut = txttendienuutien.Text;
                if (madut == "")
                {
                    MessageBox.Show("Bạn chưa chọn diện ưu tiên");
                    return;
                }
                if (Themdieukienut.KTthemdkut == false)
                {
                    MainForm f = (MainForm)this.MdiParent;
                    Themdieukienut fdk = new Themdieukienut();
                    fdk.MdiParent = f;
                    fdk.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnxoadieukienuutien_Click(object sender, EventArgs e)
        {
            try
            {
                if (lbdieukien.Text == "")
                {
                    MessageBox.Show("Không có điều kiện ưu tiên để xóa");
                    return;
                }
                DataRow[] dr = dtdk.Select("madkut='" + lbdieukien.Text + "'");
                dr[0].Delete();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ClearbindingDUT()
        {
            lbdut.DataBindings.Clear();
            txttendienuutien.DataBindings.Clear();
        }

        private void AddbindingDUT()
        {
            lbdut.DataBindings.Add("text", dtdut, "madut");
            txttendienuutien.DataBindings.Add("text", dtdut, "tendut");
        }

        private void DienUuTien_Activated(object sender, EventArgs e)
        {
            if (flag == true)
            {
                flag = false;
                MessageBox.Show("Thêm điều kiện ưu tiên thành công");
                dtdk = Code.QlDienuutien.Lietkedieukienut(madut);
                Code.Khoitao.bindinglistbox(dtdk, lstdieukienuutien, "madkut", "madkut");
                lbdieukien.DataBindings.Clear();
                rtxtnoidungdk.DataBindings.Clear();

                lbdieukien.DataBindings.Add("text", dtdk, "madkut");
                rtxtnoidungdk.DataBindings.Add("text", dtdk, "dieukien");

                int i;
                for (i = 0; i < dtdk.Rows.Count; i++)
                    if (temp.Trim() == dtdk.Rows[i]["madkut"].ToString())
                        break;
                if (i >= dtdk.Rows.Count)
                    return;
                lstdieukienuutien.SetSelected(i, true);
            }
        }


    }
}