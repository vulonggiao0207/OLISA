using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Common;

namespace LDTBXH
{
    public partial class XemKeHoach : Form
    {
        //biến active form
      //  private string makh_temp = "";
        public static bool flag;
   
        public static string makh = "";
        public static string ten_doituong = "";
        public static string ten_dienuutien = "";
        SqlConnection cnn = null;

        //doi tuong
        SqlDataAdapter da = null;
        DataTable dtb = null;    
 
        //ke hoach
        SqlDataAdapter dakehoach = null;
        DataTable dtkehoach = null; 

        //tạo table để load cây
        DataTable dtbDUT = null;
        DataTable dtbDT = null;

        //tạo table các đối tượng
        DataTable dttien = null;
        SqlDataAdapter datien = null;

        //thong ke tien
        int conlai;
        int chitra;

        //xoa
        DataTable tbxoa = null;
        public XemKeHoach()
        {
            InitializeComponent();
        }
        private void btnthemdoituong_Click(object sender, EventArgs e)
        {
            makh = lbkehoach.Text;
            if (TimDoiTuong.KTthemdt == false)
            {                
                MainForm f = (MainForm)this.MdiParent;
                TimDoiTuong tdt = new TimDoiTuong();
                tdt.MdiParent = f;
                tdt.Show();
            }
        }
        private void XemKeHoach_Load(object sender, EventArgs e)
        {
            
            lbketthuc.Hide();
            lbtrienkhai.Hide();
            try
            {
                               
                string sqlkehoach = "select *from kehoach";
                cnn = new SqlConnection(chuoiketnoi.chuoikn);
                dakehoach = new SqlDataAdapter(sqlkehoach, cnn);         
                dtkehoach = new DataTable();
                cnn.Open();  
                dakehoach.Fill(dtkehoach);
                Code.Khoitao.KhoidongAutoTextbox(dtkehoach, txtkehoach, "tenkh");
                cnn.Close();

                ClearbindingKH();
                ClearTxtKH();
                AddbindingKH();
                dgvkehoach.DataSource = dtkehoach;
                for (int i = 0; i < 6; i++)
                {
                    dgvkehoach.Columns[i].Visible = false;
                }
                dgvkehoach.Columns["tenkh"].Visible = true;
                dgvkehoach.Columns["tenkh"].Width = 550;
                dgvkehoach.Columns["tenkh"].HeaderText = "Tên kế hoạch";
                
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
        private void btnThoat_Click(object sender, EventArgs e)
        {
            MainForm.KTxemkehoach = false;
            this.Close();
        }
        private void XemKeHoach_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm.KTxemkehoach = false;
        }
        private void btntim_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "select * from kehoach where tenkh like N'%" +txtkehoach.Text+ "%'";
                dakehoach = new SqlDataAdapter(sql, cnn);
                dtkehoach = new DataTable();
                dakehoach.Fill(dtkehoach);
                dgvkehoach.DataSource = dtkehoach;

                if (dtkehoach.Rows.Count > 0)
                {
                   ClearbindingKH();
                   AddbindingKH();
                }
                else
                {
                    ClearTxtDT();
                    ClearTxtKH();
                    MessageBox.Show("Không có kế hoạch cần tìm");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                cnn.Close();
            }
        }
        private void lbkehoach_TextChanged(object sender, EventArgs e)
        {
            try
            {

                tree_dsdoituong.Nodes.Clear();

                //kết nối đến csdl
                cnn.Open();
                //lấy dữ liệu vào 2 table
                dtbDUT = new DataTable();
                dtbDT = new DataTable();
                dtbDUT = Code.XulyCay.Table("select chitietkh.MaDUT,TenDUT from DienUuTien,chitietkh where dienuutien.MaDUT=chitietkh.MaDUT and MaKH= '" + lbkehoach.Text + "'group by chitietkh.madut, DienUuTien.TenDUT", cnn);

                // tạo biến tính tổng cho đối tượng
                int hoanthanh = 0;
                int tongso = 0;

                //gọi hàm lấy tổng số dt và số đt hoành thành
                hoanthanh = Code.XulyCay.Loadcay(dtbDUT, dtbDT, tree_dsdoituong, cnn, lbkehoach.Text, hoanthanh);
                tongso = Code.XulyCay.thongkeDT(tree_dsdoituong, tongso);


                string sqltien = "select *  from tiendo,chitietkh where tiendo.makh='" + lbkehoach.Text + "'";
                sqltien += "and tiendo.madut=chitietkh.madut ";
                sqltien += "and tiendo.makh=chitietkh.makh";
                dttien = new DataTable();
                datien = new SqlDataAdapter(sqltien, cnn);
                datien.Fill(dttien);

                //tạo biến thống kê tiền            
              

                //Gọi hàm lấy số tiền đã chi và số tiền còn lại            
                 conlai = Code.XulyCay.laysotien(dttien, "False");
                 chitra = Code.XulyCay.laysotien(dttien, "True");

                cnn.Close();
                ClearbindingDT();
                ClearTxtDT();

                //gán dữ liệu chi tiết kế hoạch
                if (lbkehoach.Text != "")
                {
                    // AddbindingDT();                    

                    if (lbtrienkhai.Text != "" && lbketthuc.Text != "")
                    {
                        DateTime d1 = DateTime.Parse(lbtrienkhai.Text);
                        DateTime d2 = DateTime.Parse(lbketthuc.Text);
                        TimeSpan d = d2 - d1;
                        txtthoihan.Text = d.Days.ToString();
                    }
                    //gán tổng số đối tượng và đối tượng hoàn thành lên textbox
                    txtdoituong.Text = tongso.ToString();
                    txthoanthanh.Text = hoanthanh.ToString();
                    txtconlai.Text = (tongso - hoanthanh).ToString();

                    //gán số tiền còn lại
                    txt_conlai.Text = conlai.ToString();
                    txtkinhphi.Text = (chitra + conlai).ToString();

                }
                else
                {
                    txtthoihan.Text = "";
                }
                //tạo mới datatable xóa
                tbxoa = new DataTable("data_delete");
                tbxoa.Columns.Add("MaKH", typeof(string));
                tbxoa.Columns.Add("MaDT", typeof(string));
                tbxoa.Columns.Add("MaDUT", typeof(string));
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                cnn.Close();
            }
        }
        private void btnxoadoituong_Click(object sender, EventArgs e)
        {
     //       makh_temp = "";
       //     makh_temp = txtkehoach.Text;
         //   cnn=new SqlConnection(chuoiketnoi.chuoikn);
            try
            {
                Code.XulyCay.update_table(tbxoa, tree_dsdoituong, lbkehoach.Text, cnn);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
         
            makh = lbkehoach.Text;
           
            try
            {   
                        
                cnn.Open();  
                //Thêm các đối tượng vào database               
                Code.XulyCay.Update_database(Code.XulyCay.update_table(dtb,tree_dsdoituong, lbkehoach.Text,da, cnn),cnn);
                //Xóa các đối tượng trong database
                Code.XulyCay.Delete_database(tbxoa, cnn);

                //tinh tong so tien
                conlai = Code.XulyCay.laysotien(dttien, "False");
                chitra = Code.XulyCay.laysotien(dttien, "True");                
                Code.XulyCay.capnhatsotien(makh, cnn, (conlai+chitra).ToString());                 
                cnn.Close();                
                          
                this.XemKeHoach_Load(null, null);
                cnn.Open();
                
                
                cnn.Close();
                this.XemKeHoach_Load(null, null);
              //  dgvkehoach.Rows[0].Selected = false;
                int i;
                for (i = 0; i < dtkehoach.Rows.Count; i++)
                    if (makh == dtkehoach.Rows[i]["makh"].ToString())
                        break;
                if (i >= dtkehoach.Rows.Count)
                    return;
          //      dgvkehoach.Rows[0].Selected = false;
          //      dgvkehoach.Rows[i].Selected = true;  
            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                cnn.Close();
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            dtkehoach.RejectChanges();
  //         dtdoituong.RejectChanges();
        }
        private void lbphai_TextChanged(object sender, EventArgs e)
        {
            if (lbphai.Text == "True")
                rdnam.Checked = true;
            else
                rdnu.Checked = false;

        }
        private void ClearbindingDT()
        {
            txtdiachi.DataBindings.Clear();
            txtnghenghiep.DataBindings.Clear();
            txtnguyenquan.DataBindings.Clear();
            txtsodienthoai.DataBindings.Clear();
            txtngaysinh.DataBindings.Clear();
            rdnam.DataBindings.Clear();
            lbdoituong.DataBindings.Clear();
            
        }
        private void ClearTxtDT()
        {
            txtdiachi.Text = "";
            txtngaysinh.Text = "";
            txtdoituong.Text = "";
            txtnghenghiep.Text = "";
            txtnguyenquan.Text = "";
            txtsodienthoai.Text = "";
           
        }        
        private void AddbindingDT(string madt)
        {
                     
                string sqlkehoach = "select * from doituong where madt='"+madt+"'";
                cnn = new SqlConnection(chuoiketnoi.chuoikn);
                da = new SqlDataAdapter(sqlkehoach, cnn);          
                dtb = new DataTable();
                cnn.Open();  
                da.Fill(dtb);
                cnn.Close();
                txtdiachi.DataBindings.Add("text",dtb,"diachi");
                txtnghenghiep.DataBindings.Add("text",dtb,"nghenghiep");
                txtnguyenquan.DataBindings.Add("text",dtb,"nguyenquan");
                txtsodienthoai.DataBindings.Add("text",dtb,"sodt");
         
                txtngaysinh.DataBindings.Add("text", dtb, "ngaysinh", true, DataSourceUpdateMode.Never, "Null", "dd-MM-yyyy");
        
                rdnam.DataBindings.Add("Checked", dtb, "phai");
          
               
        }        
        private void ClearbindingKH()
        {
            txtkehoach.DataBindings.Clear();
            txttu.DataBindings.Clear();
            txtden.DataBindings.Clear();
            lbtrienkhai.DataBindings.Clear();
            lbketthuc.DataBindings.Clear();
      //      txtkinhphi.DataBindings.Clear();
            lbkehoach.DataBindings.Clear();
      //      txtconlai.DataBindings.Clear();
        }
        private void ClearTxtKH()
        {
            txttu.Text = "";
            txtden.Text = "";
     //       txtkinhphi.Text = "";
            txthoanthanh.Text = "";
            txtdoituong.Text = "";
            txtthoihan.Text = "";
            txt_conlai.Text = "";
            lbkehoach.Text = "";
        }
        private void AddbindingKH()
        {
           
            txtkehoach.DataBindings.Add("Text", dtkehoach, "tenkh",true);
     //       txtkinhphi.DataBindings.Add("text", dtkehoach, "tongchi");
            lbketthuc.DataBindings.Add("Text", dtkehoach, "ngayketthuc");
            lbtrienkhai.DataBindings.Add("Text", dtkehoach, "ngaytrienkhai");
            txttu.DataBindings.Add("text", dtkehoach, "ngaytrienkhai", true, DataSourceUpdateMode.Never, null, "dd/MM/yyyy");
            txtden.DataBindings.Add("text", dtkehoach, "ngayketthuc", true, DataSourceUpdateMode.Never, null, "dd/MM/yyyy");
            lbkehoach.DataBindings.Add("text", dtkehoach, "makh");
        
          //  string thoihan=
                
        }    
        private void tree_dsdoituong_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            //Node cha
            if (e.Node.Parent == null)
            {
                if (e.Node.Checked == true)
                {
                    for (int i = 0; i < e.Node.Nodes.Count; i++)
                        e.Node.Nodes[i].Checked = true;

                }
            }
            //Node con
            if (e.Node.Parent != null)
            {
                if (e.Node.Checked == false)
                {
                    e.Node.Parent.Checked = false;
                }
                if (e.Node.Checked == true)
                {
                    for (int i = 0; i < e.Node.Parent.Nodes.Count; i++)
                    {
                        if (e.Node.Parent.Nodes[i].Checked == false)
                        {
                            e.Node.Parent.Checked = false;
                            break;
                        }
                        else
                            e.Node.Parent.Checked = true;
                    }
                }
                ClearbindingDT();
                cnn = new SqlConnection(chuoiketnoi.chuoikn);
                AddbindingDT(Code.XulyCay.layma(e.Node.Text,"ten","doituong","madt",cnn));
            }
        }
        private void XemKeHoach_Activated(object sender, EventArgs e)
        {
            if (flag == true)
            {        
                flag = false;
                this.XemKeHoach_Load(null, null);
                int i;
                for (i = 0; i < dtkehoach.Rows.Count; i++)
                    if (makh== dtkehoach.Rows[i]["makh"].ToString())
                        break;
                if (i >= dtkehoach.Rows.Count)
                    return;
         //        dgvkehoach.Rows[0].Selected = false;
          //       dgvkehoach.Rows[i].Selected = true;          
            }
        }

        private void btnbaocao_Click(object sender, EventArgs e)
        {
            if (MainForm.KTbaocaods == false)
            {
                MainForm f = (MainForm)this.MdiParent;
                BCdanhsach bc = new BCdanhsach();
                bc.MdiParent = f;
                bc.Show();
            }
            
        }
       

       

       
       
    }
}