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
    public partial class Taomoidienuutien : Form
    {
        public Taomoidienuutien()
        {
            InitializeComponent();
        }

        private void btmtaomoi_Click(object sender, EventArgs e)
        {
            try{
                string tb = "dienuutien";
                string cl = "madut";
                string sten = txttendut.Text;
                if (sten.Trim() == "" || sten.Length > 50)
                {
                    MessageBox.Show("Diện ưu tiên không hợp lệ");
                    txttendut.Focus();
                    return;
                }
                string id = sinhid.taoid(tb,cl, sten);    
     
                SqlConnection cnn = new SqlConnection(chuoiketnoi.chuoikn);
                string sql = "insert into Dienuutien(MaDUT,TenDUT) values";
                sql += "('" + id + "',N'" + sten + "')";
                cnn.Open();
                SqlCommand cmd= new SqlCommand(sql,cnn);
                cmd.ExecuteNonQuery();
                cnn.Close();
                txttendut.Text = "";
                txttendut.Focus();
                label2.Text = "Thêm diện ưu tiên thành công";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm.KTtaomoidienuutien = false;
        }

        private void txttendut_TextChanged(object sender, EventArgs e)
        {
            if (txttendut.Text.Length > 50)
                txttendut.ForeColor = Color.Red;
            else
                txttendut.ForeColor = Color.Black;
        }

        private void txttendut_Validating(object sender, CancelEventArgs e)
        {
            Regex rg = new Regex("^[\\w,\\s,//,-,(,)]{0,50}$");
            if (rg.IsMatch(txttendut.Text) == false)
            {
                MessageBox.Show("Diện ưu tiên không hợp lệ");
                e.Cancel = true;
            }
        }

        private void Taomoidienuutien_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm.KTtaomoidienuutien = false;
        }

    }
}