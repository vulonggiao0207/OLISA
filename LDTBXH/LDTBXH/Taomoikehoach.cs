using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace LDTBXH
{
    public partial class Taomoikehoach : Form
    {
        Boolean flag1 = false;
        Boolean flag2 = false;
        public Taomoikehoach()
        {
            InitializeComponent();
        }

        private void Taomoikehoach_Load(object sender, EventArgs e)
        {
            Code.Xulyngaysinh.khoitaocomboboxkh(cbthangtk, cbnamtk);
            Code.Xulyngaysinh.khoitaocomboboxkh(cbthangkt, cbnamkt);

            cbnamtk.SelectedIndex = 0;
            flag1 = true;
            cbthangtk.SelectedIndex = 0;
            cbngaytk.SelectedIndex = 0;

            cbnamkt.SelectedIndex = 0;
            flag2 = true;
            cbthangkt.SelectedIndex = 0;
            cbngaykt.SelectedIndex = 0;
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm.KTtaomoikehoach = false;
        }

        private void Taomoikehoach_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm.KTtaomoikehoach = false;
        }

        private void btntaomoi_Click(object sender, EventArgs e)
        {
            try
            {
                string sten =txttenkehoach.Text;
                string socv = txtsocv.Text;
                if (sten.Trim() == "")
                {
                    MessageBox.Show("Yêu cầu nhập tên kế hoạch");
                    txttenkehoach.Focus();
                    return;
                }
                string sngaytrienkhai = Code.Xulyngaysinh.layngaysinh(cbngaytk,cbthangtk,cbnamtk);
                string sngayketthuc = Code.Xulyngaysinh.layngaysinh(cbngaykt, cbthangkt, cbnamkt);
                
                DateTime d1;
                DateTime d2;
                DateTime homnay=DateTime.Now.Date;
                
                try
                {
                   d1 = DateTime.Parse(sngaytrienkhai);
                   d2 = DateTime.Parse(sngayketthuc);   
                }
                catch (FormatException)
                {
                    MessageBox.Show("Ngày triển khai hoặc ngày kết thúc không hợp lệ");
                    return;
                }

                if (d1 >= homnay)
                {
                    TimeSpan tp = d2 - d1;
                    if (tp.Days <= 0)
                    {
                        MessageBox.Show("Ngày kết thúc phải lớn hơn ngày triển khai");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Ngày triển khai không hợp lệ");
                    return;
                }


                string id = sinhid.taoid("kehoach","makh",sten);
                int stongchi = 0;
                if (Code.QLKehoach.themkehoach(id, txttenkehoach.Text,socv, sngaytrienkhai, sngayketthuc, stongchi) > 0)
                {
                    MessageBox.Show("Thêm kế hoạch thành công");
                    txttenkehoach.Text = "";
                    txttenkehoach.Focus();
                }
                else
                    MessageBox.Show("Thêm kế hoạch không thành công");                    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbnamtk_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (flag1 == true)
                {
                    int namtk = Convert.ToInt32(cbnamtk.SelectedItem.ToString());
                    int thangtk = Convert.ToInt32(cbthangtk.SelectedItem.ToString());
                    Code.Xulyngaysinh.Xulyngay(thangtk, namtk, cbngaytk);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbthangtk_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                int namtk = Convert.ToInt32(cbnamtk.SelectedItem.ToString());
                int thangtk = Convert.ToInt32(cbthangtk.SelectedItem.ToString());
                Code.Xulyngaysinh.Xulyngay(thangtk, namtk, cbngaytk);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbnamkt_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (flag2 == true)
                {
                    int namkt = Convert.ToInt32(cbnamkt.SelectedItem.ToString());
                    int thangkt = Convert.ToInt32(cbthangkt.SelectedItem.ToString());
                    Code.Xulyngaysinh.Xulyngay(thangkt, namkt, cbngaykt);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbthangkt_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                int namkt = Convert.ToInt32(cbnamkt.SelectedItem.ToString());
                int thangkt = Convert.ToInt32(cbthangkt.SelectedItem.ToString());
                Code.Xulyngaysinh.Xulyngay(thangkt, namkt, cbngaykt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       private void txttenkehoach_Validating(object sender, CancelEventArgs e)
        {
            Regex rg = new Regex("^[\\w,\\s,//,-,(,)]{0,50}$");
            if (rg.IsMatch(txttenkehoach.Text) == false)
            {
                MessageBox.Show("tên kế hoạch không hợp lệ");
                e.Cancel = true;
            }
        }

    }
}