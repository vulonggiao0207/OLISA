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
    public partial class Themdieukienut : Form
    {
        public static Boolean KTthemdkut=false;

        public Themdieukienut()
        {
            InitializeComponent();
        }

        private void Themdieukienut_Load(object sender, EventArgs e)
        {
            KTthemdkut = true;
            lbdienuutien.Text = DienUuTien.tendut;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            KTthemdkut = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string madkut = sinhid.taoid("dieukienut", "madkut", lbdienuutien.Text);
                if(Code.QlDienuutien.Themdieukien(DienUuTien.madut,madkut,rtxtnoidung.Text)>0)
                    MessageBox.Show("Thêm điều kiện thành công");
                rtxtnoidung.Text = "";
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

   /*     private void txtdieukien_Validating(object sender, CancelEventArgs e)
        {
            Regex rg = new Regex("^[\\w,\\s,%]*$");
            if (rg.IsMatch(txtdieukien.Text) == false)
            {
                MessageBox.Show("Điều kiện ưu tiên không hợp lệ");
                e.Cancel = true;
            }
        }*/

        private void Themdieukienut_FormClosing(object sender, FormClosingEventArgs e)
        {
            KTthemdkut = false;
        }

        
    }
}