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
    public partial class Taomoidoituong : Form
    {
        Boolean flag = false;
        public Taomoidoituong()
        {
            InitializeComponent();
        }

        private void Taomoidoituong_Load(object sender, EventArgs e)
        {
            Code.Xulyngaysinh.khoitaocombobox(cbthang, cbnam);
            cbnam.SelectedIndex = 0;
            flag = true;
            cbthang.SelectedIndex = 0;
            cbngay.SelectedIndex = 0;
        }

        private void btntaomoi_Click(object sender, EventArgs e)
        {
            try
            {
                string ngaysinh = Code.Xulyngaysinh.layngaysinh(cbngay, cbthang, cbnam);
                if (txtten.Text.Trim() == "")
                {
                    MessageBox.Show("Bạn chưa nhập họ tên đối tượng");
                    return;
                }
                string madt = sinhid.taoid("doituong","madt",txtten.Text); 
                if (Code.Qldoituong.Themmoidoituong(madt, txtten.Text, (rdnam.Checked==true ? 1 : 0), ngaysinh, txtnguyenquan.Text, txtnghenghiep.Text, txthokhau.Text, txtdiachi.Text, txtsodt.Text)
                    > 0)
                {
                    MessageBox.Show("Thêm đối tượng thành công");
                    txtten.Text = "";
                    txtdiachi.Text = "";
                    txtsodt.Text = "";
                    txtnghenghiep.Text = "";
                    txtnguyenquan.Text = "";
                    txthokhau.Text = "";
                    txtten.Focus();
                }
                
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }         

        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm.KTtaomoidoituong = false;
        }

        private void Taomoidoituong_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm.KTtaomoidoituong = false;
        }

        private void txtten_Validating(object sender, CancelEventArgs e)
        {
            Regex rg = new Regex("^[\\w,\\s]{0,30}$");
            if (rg.IsMatch(txtten.Text) == false)
            {
                MessageBox.Show("Họ tên đối tượng không hợp lệ");
                e.Cancel = true;
            }
        }

        private void txtsodt_Validating(object sender, CancelEventArgs e)
        {
            Regex rg = new Regex("^[0-9]{0,20}$");
            if (rg.IsMatch(txtsodt.Text) == false)
            {
                MessageBox.Show("Số điện thoại không hợp lệ");
                e.Cancel = true;
            }
        }

        private void txtnghenghiep_Validating(object sender, CancelEventArgs e)
        {
            Regex rg = new Regex("^[\\w,\\s]{0,30}$");
            if (rg.IsMatch(txtnghenghiep.Text) == false)
            {
                MessageBox.Show("nghề nghiệp không hợp lệ");
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

        
        
    }
}