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
    public partial class Themthannhan : Form
    {
        Boolean flag=false;
        DataTable dtqh;
        public static Boolean KTthemthannhan;
        public Themthannhan()
        {
            InitializeComponent();
        }

        private void Themthannhan_Load(object sender, EventArgs e)
        {
            try
            {
                KTthemthannhan = true;
                dtqh = Code.QLthannhan.lietkequanhe();
                Code.Khoitao.bindingcombobox(dtqh, cbquanhe, "tenqh", "maqh");
                Code.Xulyngaysinh.khoitaocombobox(cbthang, cbnam);

                cbnam.SelectedIndex = 0;
                flag = true;
                cbthang.SelectedIndex = 0;
                cbngay.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            KTthemthannhan = false;
            this.Close();
        }

        private void btnHuythaotac_Click(object sender, EventArgs e)
        {
            XoaTextbox();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txthoten.Text.Trim() == "")
                {
                    MessageBox.Show("Yêu cầu nhập họ tên thân nhân");
                    return;
                }
                string ngaysinh=Code.Xulyngaysinh.layngaysinh(cbngay,cbthang,cbnam);
                int phai = LaygiatriPhai.GetPhai(rdnam, rdnu);
                string matn = sinhid.taoid("thannhan", "matn", txthoten.Text);
                int maqh = Convert.ToInt32( cbquanhe.SelectedValue.ToString());
                if (Code.QLthannhan.Themthannhan(matn, DoiTuongUuTien.madt, maqh, txthoten.Text,
                    txtdiachi.Text, phai, ngaysinh, txtnguyenquan.Text, txtnghenghiep.Text, txtdiachi.Text)
                    > 0)
                {
                    Thannhan.temp = matn;
                    Thannhan.flag = true;
                    Thannhan.ActiveForm.Activate();
                    this.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txthoten_Validating(object sender, CancelEventArgs e)
        {
            Regex rg = new Regex("^[\\w,\\s]{0,30}$");
            if (rg.IsMatch(txthoten.Text) == false)
            {
                MessageBox.Show("Tên thân nhân không hợp lệ");
                e.Cancel = true;
            }
        }

        private void txtnghenghiep_Validating_1(object sender, CancelEventArgs e)
        {
            Regex rg = new Regex("^[\\w,\\s]{0,30}$");
            if (rg.IsMatch(txtnghenghiep.Text) == false)
            {
                MessageBox.Show("Nghề nghiệp không hợp lệ");
                e.Cancel = true;
            }
        }

        private void txtnguyenquan_Validating_1(object sender, CancelEventArgs e)
        {
            Regex rg = new Regex("^[\\w,\\s]{0,30}$");
            if (rg.IsMatch(txtnguyenquan.Text) == false)
            {
                MessageBox.Show("Nguyên quán không hợp lệ");
                e.Cancel = true;
            }
        }

        private void Themthannhan_FormClosing(object sender, FormClosingEventArgs e)
        {
            KTthemthannhan = false;
        }

        private void XoaTextbox()
        {
            txthoten.Text = "";
            txtdiachi.Text = "";
            txtnghenghiep.Text = "";
            txtnguyenquan.Text = "";
        }

    }
}