using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace LDTBXH.Code
{
    class Qldoituong
    {
        static SqlDataAdapter da = null;
        static DataTable dt = null;
        public static DataTable Lietkedoituong()
        {
            SqlConnection cnn = new SqlConnection(chuoiketnoi.chuoikn);
            string sql = "select * from doituong";
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            dt = new DataTable();
            cnn.Open();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }

        public static DataTable Lietkedoituong(string tendoituong)
        {
            string sql = "select * from doituong where ten like N'%" + tendoituong + "%'";
            SqlConnection cnn = new SqlConnection(chuoiketnoi.chuoikn);
            da = new SqlDataAdapter(sql, cnn);
            new SqlCommandBuilder(da);
            dt = new DataTable();
            cnn.Open();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }

        

        public static void Luudoituong(SqlDataAdapter da,DataTable dt)
        {
            string sql = "select * from doituong";
            //string sql="update doituong set ten='"+sten+"',";
            //sql+=
            SqlConnection cnn = new SqlConnection(chuoiketnoi.chuoikn);
            da = new SqlDataAdapter(sql, cnn);
            new SqlCommandBuilder(da);
            cnn.Open();
            da.Update(dt);
            cnn.Close();
        }

        public static int Themmoidoituong(string madt,string sten,int phai,string sngaysinh,string snguyenquan,string snghenghiep,string shokhau,string sdiachi,string ssodt)
        {
            SqlConnection cnn = new SqlConnection(chuoiketnoi.chuoikn);
            string sql = "Insert into doituong values";
            sql += "('" + madt + "',N'" + sten + "'," + phai + ",'" + sngaysinh + "',N'" + snguyenquan + "',N'" + snghenghiep + "',N'"+ shokhau +"',N'" + sdiachi + "','" + ssodt + "')";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cnn.Open();
            int n = cmd.ExecuteNonQuery();
            cnn.Close();
            return n;
        }

        public static int Themdoituonguutien(string madt,string dienuutien)
        {
            SqlConnection cnn = new SqlConnection(chuoiketnoi.chuoikn);
            string sql = "insert into dtuutien values ('" + madt + "'";
            sql += " ,'" + dienuutien + "')";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cnn.Open();
            int n=cmd.ExecuteNonQuery();
            cnn.Close();
            return n;
        }
    }
}
