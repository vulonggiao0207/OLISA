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
    public partial class TimDoiTuong : Form
    {
  //      bool flag = false;
        
        public static Boolean KTthemdt = false;
        SqlConnection cnn = null;
        SqlDataAdapter da = null;
        DataTable dt = null;
        public static string makh = "";
        public static string madt = "";
        public static string madut = "";
       
        DataTable dt1 = null;
        SqlDataAdapter da1 = null;
        
        public TimDoiTuong()
        {
            InitializeComponent();
        }

        private void TimDoiTuong_Load(object sender, EventArgs e)
        {
            lbtendt.Hide();
            lbmadut.Hide();
            lbmadt.Hide();
     //       flag = true;
            try
            {
                
                KTthemdt = true;
                cnn = new SqlConnection(chuoiketnoi.chuoikn);
                
                string sql = "select * from doituong";
                string sql1 = "select dienuutien.madut,tendut from dienuutien,chitietkh ";
                sql1 += "where dienuutien.madut=chitietkh.madut and chitietkh.makh=N'" + XemKeHoach.makh + "'group by tendut,dienuutien.madut";
                cnn.Open();
                //tạo table cho combobox diện ưu tiên
                da1= new SqlDataAdapter(sql1,cnn);
                dt1=new DataTable();
                //tạo table cho grid đối tượng
                da = new SqlDataAdapter(sql, cnn);
                dt = new DataTable();
                //fill dữ liệu vào grid va combobox
                da1.Fill(dt1);
                da.Fill(dt);
                
                lbmadt.DataBindings.Add("text", dt, "madt");
                lbtendt.DataBindings.Add("text", dt, "ten");
                txtdiachi.DataBindings.Add("text", dt, "diachi");
                txtnghenghiep.DataBindings.Add("text", dt, "nghenghiep");
                txtnguyenquan.DataBindings.Add("text", dt, "nguyenquan");
                txtsodienthoai.DataBindings.Add("text", dt, "sodt");
                txtngaysinh.DataBindings.Add("text", dt, "ngaysinh", true, DataSourceUpdateMode.Never, "Null", "dd-MM-yyyy");
                rdnam.DataBindings.Add("Checked", dt, "phai");
     
                cnn.Close();
               
                
                Code.Khoitao.AddItemToCombobox(cmbdienuutien, dt1, "TenDUT");     
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void rdnam_CheckedChanged(object sender, EventArgs e)
        {
            if (rdnam.Checked == false)
                rdnu.Checked = true;
        }      

        private void btnthoat_Click(object sender, EventArgs e)
        {
            KTthemdt = false;
            this.Close();
        }  

      
        private void btnthem_Click(object sender, EventArgs e)
        {
            try
            {                               
                XemKeHoach.ten_dienuutien = lbtendt.Text;
                XemKeHoach.ten_doituong = cmbdienuutien.SelectedItem.ToString();             
               
                //thêm doituong vào csdl
                madut = Code.XulyCay.layma(cmbdienuutien.SelectedItem.ToString(), "tendut", "dienuutien", "madut", cnn);
                madt = lbmadt.Text;          
                
                cnn.Open();
                string sql2 = "Insert into tiendo values";
                sql2 += "('" + XemKeHoach.makh + "','" + madt + "','" + madut + "',0)";
                SqlCommand cmd = new SqlCommand(sql2, cnn);
                cmd.ExecuteNonQuery();
                cnn.Close();
                MessageBox.Show("Thêm đối tượng thành công");

                //xóa dòng khỏi grid
                int row = dgvdoituong.CurrentRow.Index;
                dgvdoituong.Rows.RemoveAt(row);
                               
                XemKeHoach.flag = true;
                XemKeHoach.ActiveForm.Activate();
                KTthemdt = false;
            //    this.Close();
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
                cnn.Close();
            }
        }
     

        private void cmbdienuutien_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                lbmadut.Text = "";
                lbmadut.Text = Code.XulyCay.layma(cmbdienuutien.SelectedItem.ToString(), "tendut", "dienuutien", "madut", cnn);
                string sql = "select * from doituong,dtuutien,dienuutien ";
                sql += " where dienuutien.madut='"+lbmadut.Text+"' ";
                sql += "and doituong.madt=dtuutien.madt ";
                sql += "and dienuutien.madut=dtuutien.madut ";
                //vấn đề ở đây 
                sql += "and dtuutien.madt not in ";
                sql += "(select madt from tiendo where ";
                sql += "madut='"+lbmadut.Text+"'and makh='"+XemKeHoach.makh+"')";    
                   
               

                cnn.Open();
                da = new SqlDataAdapter(sql, cnn);
                dt = new DataTable();
                da.Fill(dt);
                dgvdoituong.DataSource = dt;
                cnn.Close();
                if (dt.Rows.Count > 0)
                {
                    lbtendt.DataBindings.Clear();
                    lbmadt.DataBindings.Clear();
                    txtdiachi.DataBindings.Clear();
                    txtnghenghiep.DataBindings.Clear();
                    txtnguyenquan.DataBindings.Clear();
                    txtsodienthoai.DataBindings.Clear();
                    txtngaysinh.DataBindings.Clear();
                    rdnam.DataBindings.Clear();


                    lbtendt.DataBindings.Add("text", dt, "ten");
                    lbmadt.DataBindings.Add("text", dt, "madt");
                    txtdiachi.DataBindings.Add("text", dt, "diachi");
                    txtnghenghiep.DataBindings.Add("text", dt, "nghenghiep");
                    txtnguyenquan.DataBindings.Add("text", dt, "nguyenquan");
                    txtsodienthoai.DataBindings.Add("text", dt, "sodt");
                    txtngaysinh.DataBindings.Add("text", dt, "ngaysinh", true, DataSourceUpdateMode.Never, "Null", "dd-MM-yyyy");
                    rdnam.DataBindings.Add("Checked", dt, "phai");
                }
                else
                {
                    lbmadt.Text = "";
                    txtdiachi.Text = "";
                    txtngaysinh.Text = "";
                    txtnghenghiep.Text = "";
                    txtsodienthoai.Text = "";
                    txtnguyenquan.Text = "";
                    MessageBox.Show("Không có đối tượng cần tìm");
                }
                for (int i = 0; i < 12; i++)
                    dgvdoituong.Columns[i].Visible = false;
                dgvdoituong.Columns["ten"].Visible = true;
                dgvdoituong.Columns["ten"].HeaderText = "Tên đối tượng";
                dgvdoituong.Columns["ten"].Width = 400;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                cnn.Close();
            }
        }

        private void TimDoiTuong_FormClosed(object sender, FormClosedEventArgs e)
        {

            KTthemdt = false;
        }

      

        
    
    }
}