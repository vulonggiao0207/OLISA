using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LDTBXH
{
    public partial class Themcongvan : Form
    {
        public static Boolean KTthemcv = false;
        public Themcongvan()
        {
            InitializeComponent();
        }

        private void Themcongvan_Load(object sender, EventArgs e)
        {
            KTthemcv = true;
            txtkehoach.Text = KeHoach.tenkh;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            KTthemcv = false;
            this.Close();
        }

        private void Themcongvan_FormClosing(object sender, FormClosingEventArgs e)
        {
            KTthemcv = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txttencv.Text.Trim() == "")
            {
                MessageBox.Show("Yêu càu nhập tiêu đề công văn");
                return;
            }
            string macv=sinhid.taoid("congvan","macv",txttencv.Text);
            if (Code.QLKehoach.themcongvan(KeHoach.makh, macv, txttencv.Text, rtxtnoidungcv.Text) > 0)
            {
                KeHoach.flag = true;
                KeHoach.temp = macv;
                KeHoach.ActiveForm.Activate();
                this.Close();
            }
            else
            {
                MessageBox.Show("Thêm công văn thất bại");
            }
        }
    }
}