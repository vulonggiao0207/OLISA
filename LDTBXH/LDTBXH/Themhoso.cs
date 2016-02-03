using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace LDTBXH
{
    public partial class Themhoso : Form
    {
        public static Boolean KTThemhoso = false;
        public Themhoso()
        {
            InitializeComponent();
        }

        private void Themhoso_Load(object sender, EventArgs e)
        {
            KTThemhoso = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            KTThemhoso = false;
            this.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txttenhoso.Text = "";
            rtxtnoidung.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txttenhoso.Text.Trim() == "")
            {
                MessageBox.Show("Yêu cầu nhập tên hồ sơ");
                return;
            }
            string magt = sinhid.taoid("giayto", "magt", txttenhoso.Text);
            if (Code.QLHoso.Themhoso(magt,DoiTuongUuTien.madt,txttenhoso.Text,rtxtnoidung.Text)
                > 0)
            {
                HoSo.temp = magt;
                HoSo.flag = true;
                HoSo.ActiveForm.Activate();
                this.Close();
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

        private void Themhoso_FormClosing(object sender, FormClosingEventArgs e)
        {
            KTThemhoso = false;
        }

        
    }
}