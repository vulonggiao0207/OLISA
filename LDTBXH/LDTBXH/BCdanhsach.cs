using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;

namespace LDTBXH
{
    public partial class BCdanhsach : Form
    {
        public BCdanhsach()
        {
            InitializeComponent();
        }
        SqlConnection cnn = null;
        SqlDataAdapter da = null;
        DataTable dt = null;
        private void BCdanhsach_Load(object sender, EventArgs e)
        {
            MainForm.KTbaocaods = true;
            lbmakh.Hide();
            string sql = "select *from kehoach";
            cnn = new SqlConnection(chuoiketnoi.chuoikn);
            da = new SqlDataAdapter(sql, cnn);
            dt = new DataTable();
            cnn.Open();
            da.Fill(dt);
            Code.Khoitao.KhoidongAutoTextbox(dt, txttenkh, "tenkh");
            cnn.Close();
            binding();
            dataGridView1.DataSource = dt;
            
        }
        private void binding()
        {
            lbmakh.DataBindings.Add("Text", dt, "makh");
            txttenkh.DataBindings.Add("Text", dt, "tenkh");
        }
        private void clearbinding()
        {
            lbmakh.DataBindings.Clear();
            txttenkh.DataBindings.Clear();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "select * from kehoach where tenkh like N'%" + txttenkh.Text + "%'";
                da = new SqlDataAdapter(sql, cnn);
                dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                if (dt.Rows.Count > 0)
                {
                    clearbinding();
                    binding();
                }
                else
                {
                    clearbinding();
                    MessageBox.Show("Không có kế hoạch cần tìm");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                cnn.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(chuoiketnoi.chuoikn);
            string sql = "select * from tiendo,chitietkh,kehoach where tiendo.makh='" + lbmakh.Text + "'";
            sql += " and tiendo.madut=chitietkh.madut ";
            sql += "and tiendo.makh=chitietkh.makh ";
            

            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            DataSet ds = new DataSet();
            da.Fill(ds, "tiendo");

            Reportds rp = new Reportds();
            rp.SetDataSource(ds);
          //  rp.SetDatabaseLogon("sa", "sa");
            crystalReportViewer1.ReportSource = rp;
        }

        private void BCdanhsach_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm.KTbaocaods = false;
        }

    }
}