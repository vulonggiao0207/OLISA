using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace LDTBXH.Code
{
    class QlDienuutien
    {
        static SqlDataAdapter da;
        static DataTable dt;
        public static DataTable Lietkedienut()
        {
            string sql = "select *from dienuutien";
            SqlConnection cnn = new SqlConnection(chuoiketnoi.chuoikn);
            da = new SqlDataAdapter(sql,cnn);
            dt = new DataTable();
            cnn.Open();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }

        public static DataTable Lietkedienut(string madt)
        {
            string sql = "select dienuutien.madut,tendut from dienuutien,dtuutien,doituong";
            sql+=" where dienuutien.madut=dtuutien.madut";
            sql+=" and dtuutien.madt=doituong.madt";
            sql+=" and dtuutien.madt='"+madt+"'";
            SqlConnection cnn = new SqlConnection(chuoiketnoi.chuoikn);
            da = new SqlDataAdapter(sql, cnn);
            dt = new DataTable();
            cnn.Open();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }

        public static DataTable LietkeDUTinCTKH(string makh)
        {
            string sql = "select *from dienuutien where madut not in (select madut from chitietkh where makh='"+makh+"')";
            SqlConnection cnn = new SqlConnection(chuoiketnoi.chuoikn);
            da = new SqlDataAdapter(sql, cnn);
            dt = new DataTable();
            cnn.Open();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }

        public static DataTable LietkeXetDuyetDUT(string madt)
        {
            SqlConnection cnn = new SqlConnection(chuoiketnoi.chuoikn);
            string sql = "select *from dienuutien";
            sql += " where madut not in(select madut from dtuutien where madt='" + DoiTuongUuTien.madt + "')";
            da = new SqlDataAdapter(sql, cnn);
            dt = new DataTable();
            cnn.Open();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }

        public static DataTable Timkiemdut(string tendienut)
        {
            string sql = "select *from dienuutien where tendut like N'%" + tendienut + "%'";
            SqlConnection cnn = new SqlConnection(chuoiketnoi.chuoikn);
            da = new SqlDataAdapter(sql, cnn);
            dt = new DataTable();
            cnn.Open();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }        

        public static DataTable Lietkedieukienut(string madut)
        {
            string sql = "select *from dieukienut where madut='"+madut+"'";
            SqlConnection cnn = new SqlConnection(chuoiketnoi.chuoikn);
            da = new SqlDataAdapter(sql, cnn);
            dt = new DataTable();
            cnn.Open();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }

        public static void Luudienut(SqlDataAdapter da,DataTable dt)
        {
            string sql = "select *from dienuutien";
            SqlConnection cnn = new SqlConnection(chuoiketnoi.chuoikn);
            da = new SqlDataAdapter(sql, cnn);
            new SqlCommandBuilder(da);
            cnn.Open();
            da.Update(dt);
            cnn.Close();
        }

        public static void Luudieukien(SqlDataAdapter da, DataTable dt)
        {
            string sql = "select *from dieukienut";
            SqlConnection cnn = new SqlConnection(chuoiketnoi.chuoikn);
            da = new SqlDataAdapter(sql, cnn);
            new SqlCommandBuilder(da);
            cnn.Open();
            da.Update(dt);
            cnn.Close();
        }

        public static int Themdieukien(string madut,string madkut,string dieukien)
        {
            string sql = "insert into dieukienut ";
            sql += "values('" + madut + "','" + madkut + "',N'" + dieukien + "')";
            SqlConnection cnn = new SqlConnection(chuoiketnoi.chuoikn);
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cnn.Open();
            int n=cmd.ExecuteNonQuery();
            cnn.Close();
            return n; 
        }
    }
}
