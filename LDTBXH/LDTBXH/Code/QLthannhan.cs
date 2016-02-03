using System;
using System.Data;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace LDTBXH.Code
{
    class QLthannhan
    {
        public static DataTable lietkethannhan()
        {
            SqlConnection cnn = new SqlConnection(chuoiketnoi.chuoikn);
            string sql = "select matn,madt,hoten,ngaysinh,nghenghiep,diachi,nguyenquan,";
            sql += "chuthich,phai,quanhe.Maqh,tenqh ";
            sql += "from thannhan,quanhe where thannhan.maqh=quanhe.maqh ";
            sql += "and thannhan.madt='" + DoiTuongUuTien.madt + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql,cnn);
            DataTable dt = new DataTable();
            cnn.Open();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }

        public static DataTable lietkethannhan(string tentn)
        {
            string sql = "select matn,madt,hoten,ngaysinh,nghenghiep,diachi,nguyenquan,";
	        sql+="chuthich,phai as Phai,quanhe.Maqh,tenqh ";
            sql+="from thannhan,quanhe where thannhan.maqh=quanhe.maqh ";
	        sql+="and hoten like N'%"+tentn+"%'";
	        sql+="and thannhan.madt='"+DoiTuongUuTien.madt+"'";
            SqlConnection cnn = new SqlConnection(chuoiketnoi.chuoikn);
            //SqlCommand cmd = new SqlCommand("sp_timkiemthannhan", cnn);
            //cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.AddWithValue("@madt", DoiTuongUuTien.madt);
            //cmd.Parameters.AddWithValue("@tentn", tentn);
            SqlDataAdapter da = new SqlDataAdapter(sql,cnn);
            DataTable dt = new DataTable();
            cnn.Open();
            da.Fill(dt);
            cnn.Close();
            return dt;
            
        }

        public static DataTable lietkequanhe()
        {
            
            string sql = "select * from quanhe";
            SqlConnection cnn = new SqlConnection(chuoiketnoi.chuoikn);
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            DataTable dt = new DataTable();
            cnn.Open();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }

        public static DataTable tablethannhan()
        {

            string sql = "select * from thannhan";
            SqlConnection cnn = new SqlConnection(chuoiketnoi.chuoikn);
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            DataTable dt = new DataTable();
            cnn.Open();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }

        public static int Themthannhan(string matn,string madt,int maqh,string hoten,string diachi,int phai,string ngaysinh,string nguyenquan,string nghenghiep,string chuthich)
        {
            string sql = "insert into thannhan(matn,madt,maqh,hoten,diachi,phai,ngaysinh,nguyenquan,nghenghiep,chuthich)";
            sql += " values('" + matn + "',";
            sql += "'" +madt + "',";
            sql += "" + maqh + ",";
            sql += "N'" + hoten + "',";
            sql += "N'" + diachi + "',";
            sql += "" + phai + ",";
            sql += "'" + ngaysinh + "',";
            sql += "N'" + nguyenquan + "',";
            sql += "N'" + nghenghiep + "',";
            sql += "N'" + chuthich + "')";
            SqlConnection cnn = new SqlConnection(chuoiketnoi.chuoikn);
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cnn.Open();
            int n=cmd.ExecuteNonQuery();
            cnn.Close();
            return n;
        }

       
        public static void Luuthannhan(DataTable dt)
        {
            SqlConnection cnn = new SqlConnection(chuoiketnoi.chuoikn);
            string sql = "select matn,madt,hoten,ngaysinh,nghenghiep,diachi,nguyenquan,chuthich,phai,maqh from thannhan";
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            new SqlCommandBuilder(da);
            cnn.Open();
            da.Update(dt);
            cnn.Close();
        }

    }
}
