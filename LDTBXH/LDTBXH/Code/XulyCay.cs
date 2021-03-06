using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LDTBXH.Code
{
    class XulyCay
    {
        SqlConnection myCon = new SqlConnection(chuoiketnoi.chuoikn);
        public static DataTable Table(string strQuery, SqlConnection connection)
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter myAdapter = new SqlDataAdapter(strQuery, connection);
            myAdapter.Fill(dataTable);
            //   SqlCommandBuilder(myAdapter);
            return dataTable;
        }
        public static string layma(string s,string s1,string table,string column, SqlConnection myCon)
        {
            myCon.Open();
            string madt = "";
            SqlCommand cmd = new SqlCommand("select " +column+" from "+table+" where "+s1+" like N'"+s+"'",myCon);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                madt = rd.GetString(0);
            }
            myCon.Close();
            return madt;
        }      
        public static DataTable update_table(DataTable dtb,TreeView trvTest,string makh,SqlDataAdapter da,SqlConnection chuoikn)
        {
            //tạo datatable có dạng....
            da = new SqlDataAdapter("select * from tiendo", chuoikn);
            dtb = new DataTable("data");
            dtb.Columns.Add("MaKH", typeof(string));
            dtb.Columns.Add("MaDT", typeof(string));
            dtb.Columns.Add("MaDUT", typeof(string));
            dtb.Columns.Add("HoanThanh", typeof(int));        
            //đưa dữ liệu vào table
            for (int i = 0; i < trvTest.Nodes.Count; i++)
            {
                for (int j = 0; j < trvTest.Nodes[i].Nodes.Count; j++)
                {
                    //lấy mã đối tượng
                //    chuoikn.Open();
                    string madt = "";
                    SqlCommand cmd = new SqlCommand("select madt from doituong where ten=N'" + trvTest.Nodes[i].Nodes[j].Text + "'", chuoikn);
                    SqlDataReader rd = cmd.ExecuteReader();
                    while (rd.Read())
                    {
                        madt = rd.GetString(0);
                    }
                    chuoikn.Close();
                    chuoikn.Open();
                    //lấy mã diện ưu tiên
                    string madut = "";
                    SqlCommand cmd1 = new SqlCommand("select * from dienuutien where tendut=N'" + trvTest.Nodes[i].Text + "'", chuoikn);
                    SqlDataReader rd1 = cmd1.ExecuteReader();
                    while (rd1.Read())
                    {
                        madut = rd1.GetString(0);
                    }
                    chuoikn.Close();
                    chuoikn.Open();
              //      tạo dòng mới cho datatable đối tượng cần update
                    DataRow row = dtb.NewRow();
                    row["MaKH"] = makh;             
                    row["MaDT"] = madt;
                    row["MaDUT"] = madut;
                    if (trvTest.Nodes[i].Nodes[j].Checked == true)
                    {
                        row["HoanThanh"] = 1;
                    }
                    else
                        row["HoanThanh"] = 0;
                    //thêm dòng mới
                    dtb.Rows.Add(row);
                }
            }
            
            return dtb;

        }
        public static void Update_database(DataTable dtb,SqlConnection mycon)
        {              
            try
            {
                for (int i = 0; i < dtb.Rows.Count; i++)
                {
                    SqlCommand cmd = new SqlCommand("update tiendo set HoanThanh=" + dtb.Rows[i][3] + "where makh='" + dtb.Rows[i][0] + "'and madt='" + dtb.Rows[i][1] + "'and madut='" + dtb.Rows[i][2] + "'", mycon);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ee1)
            {
                MessageBox.Show(ee1.Message);   
            }
        }
        public static void update_table(DataTable tbxoa, TreeView trvTest, string makh, SqlConnection chuoikn)
        {
            try
            {
                if (trvTest.SelectedNode.Parent == null)
                {
                    MessageBox.Show("Đây là diện ưu tiên không phải đối tượng, không được xóa");
                }
                else
                {
                    
                    //lấy mã đối tượng
                    chuoikn.Open();
                    string madt = "";
                    SqlCommand cmd = new SqlCommand("select madt from doituong where ten=N'" + trvTest.SelectedNode.Text + "'", chuoikn);
                    SqlDataReader rd = cmd.ExecuteReader();
                    while (rd.Read())
                    {
                        madt = rd.GetString(0);
                    }
                    chuoikn.Close(); 
                    
                    
                    //lấy mã diện ưu tiên
                    chuoikn.Open();
                    string madut = "";
                    SqlCommand cmd1 = new SqlCommand("select * from dienuutien where tendut=N'" + trvTest.SelectedNode.Parent.Text + "'", chuoikn);
                    SqlDataReader rd1 = cmd1.ExecuteReader();
                    while (rd1.Read())
                    {
                        madut = rd1.GetString(0);
                    }
                    chuoikn.Close();

                    //tạo dòng mới cho datatable đối tượng cần delete
                    DataRow row = tbxoa.NewRow();
                    row["MaKH"] = makh;
                    row["MaDT"] = madt;
                    row["MaDUT"] = madut;
                    tbxoa.Rows.Add(row);
                    trvTest.SelectedNode.Remove();
                }


            }
            catch (Exception e3)
            {
                string error = e3.Message;
                MessageBox.Show("Bạn chưa chọn đối tượng");
            }
        }
        public static void Delete_database(DataTable tbxoa,SqlConnection myCon)
        {
            try
            {
            //    myCon.Open();
                for (int i = 0; i < tbxoa.Rows.Count; i++)
                {
                    SqlCommand cmd = new SqlCommand("delete from tiendo where makh='" + tbxoa.Rows[i][0] + "' and madt='" + tbxoa.Rows[i][1] + "'and madut='" + tbxoa.Rows[i][2] + "'", myCon);
                    cmd.ExecuteNonQuery();                   
                }
           //     myCon.Close();
                tbxoa.Clear();
            }
            catch (Exception ee1)
            {
                MessageBox.Show(ee1.Message);
                myCon.Close();
            }
        }
        public static int Loadcay(DataTable datatable1,DataTable datatalbe2, TreeView tree, SqlConnection cnn, string makh,int hoanthanh)
        {
            for (int i = 0; i < datatable1.Rows.Count; i++)
            {
                //thêm node DUT vào cây
                tree.Nodes.Add(datatable1.Rows[i][1].ToString());
                //lấy các DTUuTien ứng với DUT của node
                datatalbe2 = Code.XulyCay.Table("select Ten,Hoanthanh from tiendo,Doituong where doituong.madt=tiendo.madt and tiendo.MaDUT='" + datatable1.Rows[i][0].ToString() + "'and makh='" + makh + "'", cnn);

                //thêm node DTUutien vào node DUT
                //thống kê đối tượng                    
                for (int j = 0; j < datatalbe2.Rows.Count; j++)
                {
                    tree.Nodes[i].Nodes.Add(datatalbe2.Rows[j][0].ToString());

                    //Kiễm tra đối tượng đã hoàn thành
                    if (datatalbe2.Rows[j][1].Equals(true))
                    {
                        tree.Nodes[i].Nodes[j].Checked = true;
                        hoanthanh++;
                    }
                    else
                        tree.Nodes[i].Nodes[j].Checked = false;
                }
            }
            return hoanthanh;
        }
        public static int thongkeDT(TreeView tree, int tongso)
        {
            for (int i = 0; i < tree.Nodes.Count; i++)
            {
                tongso = tongso + tree.Nodes[i].Nodes.Count;
            }
            return tongso;
            
        }
        public static int laysotien(DataTable dt,string dk)
        {
            int sotien = 0;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i]["HoanThanh"].ToString() == dk.ToString())
                {
                    sotien = sotien + Convert.ToInt32(dt.Rows[i]["Sotien"]);
                }
            }
            return sotien;
        }
        public static void them_phan_tu(TreeView tree,string tendut, string tendt)
        {
            for (int i = 0; i < tree.Nodes.Count; i++)
            {
                if (tree.Nodes[i].Text == tendut)
                {
                    tree.Nodes[i].Nodes.Add(tendt);
                }
            }
        }
        public static void capnhatsotien(string makh, SqlConnection cnn,string tongchi)
        {
            SqlCommand cmd = new SqlCommand("update kehoach set tongchi= '"+tongchi+"' where makh='"+makh+"'",cnn);
            cmd.ExecuteNonQuery();
        }
    }

}


        

