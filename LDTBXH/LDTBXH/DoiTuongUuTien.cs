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
    public partial class DoiTuongUuTien : Form
    {
        public bool flag = false;
        public bool flag2 = false;
        public static string madt;
        public static string madut;
        public static string tendt;
        DataTable dt = null;
        SqlDataAdapter da = null;
        DataTable dtDienUT = null;
        DataTable dttiendo = null;
        public DoiTuongUuTien()
        {
            InitializeComponent();
        }

        private void btnthannhan_Click(object sender, EventArgs e)
        {
            if (Themthannhan.KTthemthannhan == false)
            {
                if (lbmadt.Text == "")
                {
                    MessageBox.Show("Bạn chưa chọn đối tượng của thân nhân");
                }
                else
                {
                    madt = lbmadt.Text;
                    MainForm f = (MainForm)this.MdiParent;
                    Thannhan tn = new Thannhan();
                    tn.MdiParent = f;
                    tn.Show();
                }
            }
        }

        private void btnhoso_Click(object sender, EventArgs e)
        {
            if (HoSo.KThoso == false)
            {
                if (lbmadt.Text == "")
                {
                    MessageBox.Show("Bạn chưa chọn đối tượng của hồ sơ");
                }
                else
                {
                    madt = lbmadt.Text;
                    MainForm f = (MainForm)this.MdiParent;
                    HoSo hs = new HoSo();
                    hs.MdiParent = f;
                    hs.Show();
                }
            }
        }

        private void btnxetduyet_Click(object sender, EventArgs e)
        {
            if (Xetduyet.KTxetduyet == false)
            {
                if (lbmadt.Text == "")
                    MessageBox.Show("Bạn chưa chọn đối tượng cần xét duyệt");
                else
                {
                    madt = lbmadt.Text;
                    tendt = txthoten.Text;
                    MainForm f = (MainForm)this.MdiParent;
                    Xetduyet xd = new Xetduyet();
                    xd.MdiParent = f;
                    xd.Show();
                }
            }
        }

        private void DoiTuongUuTien_Load(object sender, EventArgs e)
        {
            try
            {
                dttiendo = Code.QLKehoach.Lietketiendo();
                dt = Code.Qldoituong.Lietkedoituong();
                dgvdoituong.DataSource = dt;
                Code.Khoitao.KhoidongAutoTextbox(dt, txthoten, "Ten");
                
                Code.Xulyngaysinh.khoitaocombobox(cbthang, cbnam);
                bindingtextbox();

                cbnam.SelectedIndex = 0;
                flag = true;
                cbthang.SelectedIndex = 0;
                cbngay.SelectedIndex = 0;

                lbngaysinh.Hide();
                lbmadt.Hide();
                dgvdoituong.Columns["madt"].HeaderText = "Mã Đối Tượng";
                dgvdoituong.Columns["ten"].HeaderText = "Tên Đối Tượng";
                dgvdoituong.Columns["phai"].HeaderText = "Phái";
                dgvdoituong.Columns["ngaysinh"].HeaderText = "Ngày Sinh";
                dgvdoituong.Columns["diachi"].HeaderText = "Địa Chỉ";
                dgvdoituong.Columns["nguyenquan"].HeaderText = "Nguyên Quán";
                dgvdoituong.Columns["nghenghiep"].HeaderText = "Nghề Nghiệp";
                dgvdoituong.Columns["sodt"].HeaderText = "Số Điện Thoại";

                flag2 = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lbmadt_TextChanged(object sender, EventArgs e)
        {
            dtDienUT = Code.QlDienuutien.Lietkedienut(lbmadt.Text);
            dgvdienuutien.DataSource = dtDienUT;
            dgvdienuutien.Columns["madut"].Visible = false;
            dgvdienuutien.Columns["tendut"].HeaderText = "Tên Diện Ưu Tiên";
        }

        private void cbnam_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (flag == true)
                {
                    int nam = Convert.ToInt32(cbnam.SelectedItem.ToString());
                    int thang = Convert.ToInt32(cbthang.SelectedItem.ToString());
                    Code.Xulyngaysinh.Xulyngay(thang, nam, cbngay);
                    if (flag2 == true)
                    {
                        lbngaysinh.Text = Code.Xulyngaysinh.layngaysinh(cbthang, cbngay, cbnam);

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbthang_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                int nam = Convert.ToInt32(cbnam.SelectedItem.ToString());
                int thang = Convert.ToInt32(cbthang.SelectedItem.ToString());
                Code.Xulyngaysinh.Xulyngay(thang, nam, cbngay);
                if (flag2 == true)
                {
                    lbngaysinh.Text = Code.Xulyngaysinh.layngaysinh(cbthang, cbngay, cbnam);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbngay_SelectedValueChanged(object sender, EventArgs e)
        {
            if (flag2 == true)
            {
                lbngaysinh.Text = Code.Xulyngaysinh.layngaysinh(cbthang, cbngay, cbnam);
            }
        }

        private void lbngaysinh_TextChanged(object sender, EventArgs e)
        {
            //cbngay.Text = Code.Xulyngaysinh.layngay(lbngaysinh.Text);
            //cbthang.Text = Code.Xulyngaysinh.laythang(lbngaysinh.Text);
            //cbnam.Text = Code.Xulyngaysinh.laynam(lbngaysinh.Text);
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                string madt = lbmadt.Text;
                if (madt == "")
                {
                    MessageBox.Show("Không có đối tượng để xóa");
                    return;
                }
                DataRow[] dr = dt.Select("madt='" + madt + "'");
                DataRow[] drtiendo=dttiendo.Select("madt='"+madt+"'");
                //Xóa trên table tiendo
                for (int i = 0; i < drtiendo.Length; i++)
                    drtiendo[i].Delete();
                //Xóa trên table doituong
                dr[0].Delete();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            dttiendo.RejectChanges();
            dt.RejectChanges();
            dtDienUT.RejectChanges();
        }


        private void btntim_Click(object sender, EventArgs e)
        {
            try
            {
                dt = Code.Qldoituong.Lietkedoituong(txthoten.Text);
                dgvdoituong.DataSource = dt;
                if (dt.Rows.Count > 0)
                {
                    ClearBinding();
                    bindingtextbox();
                }
                else
                {
                    ClearTextbox();
                    MessageBox.Show("Không có thông tin đối tượng cần tìm");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            MainForm.KTdoituong = false;
            this.Close();
        }

        private void DoiTuongUuTien_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm.KTdoituong = false;
        }

        private void bindingtextbox()
        {
            txthoten.DataBindings.Add("text", dt, "ten");
            txtdiachi.DataBindings.Add("text", dt, "diachi");
            txtnghenghiep.DataBindings.Add("text", dt, "nghenghiep");
            txtnguyenquan.DataBindings.Add("text", dt, "nguyenquan");
            txtsodienthoai.DataBindings.Add("text", dt, "sodt");
            txthokhau.DataBindings.Add("text",dt,"hokhau");
            lbngaysinh.DataBindings.Add("text", dt, "ngaysinh", true, DataSourceUpdateMode.OnValidation, null, "MM/dd/yyyy");
            rdnam.DataBindings.Add("Checked", dt, "phai");
            lbmadt.DataBindings.Add("text", dt, "madt");
            
        }

        private void ClearBinding()
        {
            txthoten.DataBindings.Clear();
            txtdiachi.DataBindings.Clear();
            txtnghenghiep.DataBindings.Clear();
            txtnguyenquan.DataBindings.Clear();
            txtsodienthoai.DataBindings.Clear();
            txthokhau.DataBindings.Clear();
            rdnam.DataBindings.Clear();
            lbmadt.DataBindings.Clear();
            lbngaysinh.DataBindings.Clear();
        }

        private void ClearTextbox()
        {
            txthoten.Text = "";
            txtdiachi.Text = "";
            txtnghenghiep.Text = "";
            txtsodienthoai.Text = "";
            txtnguyenquan.Text = "";
        }

        

        private void btnluu_Click(object sender, EventArgs e)
        {
            Code.QLKehoach.Luutiendo(dttiendo);
            Code.Qldoituong.Luudoituong(da,dt);
        }

        private void rdnam_CheckedChanged(object sender, EventArgs e)
        {
            if (rdnam.Checked == true)
                rdnam.Checked = true;
            else
                rdnu.Checked = true;
        }

        private void txthoten_Validating(object sender, CancelEventArgs e)
        {
            Regex rg = new Regex("^[\\w,\\s]{0,30}$");
            if (rg.IsMatch(txthoten.Text) == false)
            {
                MessageBox.Show("Họ tên không hợp lệ");
                e.Cancel = true;
            }
        }

        private void txtnghenghiep_Validating(object sender, CancelEventArgs e)
        {
            Regex rg = new Regex("^[\\w,\\s]{0,30}$");
            if (rg.IsMatch(txtnghenghiep.Text) == false)
            {
                MessageBox.Show("Nghề nghiệp không hợp lệ");
                e.Cancel = true;
            }
        }

        private void txtnguyenquan_Validating(object sender, CancelEventArgs e)
        {
            Regex rg = new Regex("^[\\w,\\s]{0,30}$");
            if (rg.IsMatch(txtnguyenquan.Text) == false)
            {
                MessageBox.Show("Nguyên quán không hợp lệ");
                e.Cancel = true;
            }
        }

        private void txtsodienthoai_Validating(object sender, CancelEventArgs e)
        {
            Regex rg = new Regex("^[0-9]{0,20}$");
            if (rg.IsMatch(txtsodienthoai.Text) == false)
            {
                MessageBox.Show("Số diện thoại không hợp lệ");
                e.Cancel = true;
            }
        }

        

       

    }
}