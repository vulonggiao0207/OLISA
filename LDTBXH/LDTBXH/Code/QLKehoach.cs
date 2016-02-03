using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace LDTBXH.Code
{
    class QLKehoach
    {
        public static DataTable LietkeKH()
        {
            string sql = "select * from kehoach";
            SqlConnection cnn = new SqlConnection(chuoiketnoi.chuoikn);
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            DataTable dt = new DataTable();
            cnn.Open();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }

        public static DataTable LietkeKH(string tenkh)
        {
            string sql = "select * from kehoach where tenkh like N'%"+tenkh+"%'";
            SqlConnection cnn = new SqlConnection(chuoiketnoi.chuoikn);
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            DataTable dt = new DataTable();
            cnn.Open();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }

        public static DataTable LietkeKH(string tenkh,string ngaytrienkhai,string ngayketthuc)
        {
            ngayketthuc = Code.Xulyngaysinh.Convertngaysinh(ngayketthuc);
            ngaytrienkhai = Code.Xulyngaysinh.Convertngaysinh(ngaytrienkhai);
            string sql = "select * from kehoach where tenkh like N'%" + tenkh + "%'";
            sql+=" and (ngaytrienkhai between '"+ngaytrienkhai+"' and '"+ngayketthuc+"' and ngayketthuc between '"+ngaytrienkhai+"' and '"+ngayketthuc+"')";
            SqlConnection cnn = new SqlConnection(chuoiketnoi.chuoikn);
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            DataTable dt = new DataTable();
            cnn.Open();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }

        public static DataTable LietkeCTKH(string makh)
        {
            string sql = "select * from chitietkh ";
            sql += " where makh='" + makh + "'";
            SqlConnection cnn = new SqlConnection(chuoiketnoi.chuoikn);
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            DataTable dt = new DataTable();
            cnn.Open();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }

        public static DataTable LietkeHinhthuc()
        {
            string sql = "select * from hinhthuc";
            SqlConnection cnn = new SqlConnection(chuoiketnoi.chuoikn);
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            DataTable dt = new DataTable();
            cnn.Open();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }

        public static DataTable LietkeCongvan(string makh)
        {
            string sql = "select *from congvan where makh=N'" + makh + "'";
            SqlConnection cnn = new SqlConnection(chuoiketnoi.chuoikn);
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            DataTable dt = new DataTable();
            cnn.Open();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }

        public static DataTable Lietketiendo()
        {
            string sql = "select *from tiendo";
            SqlConnection cnn = new SqlConnection(chuoiketnoi.chuoikn);
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            DataTable dt = new DataTable();
            cnn.Open();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }

        public static void Luukehoach(SqlDataAdapter da, DataTable dt)
        {
            string sql = "select *from kehoach";
            SqlConnection cnn = new SqlConnection(chuoiketnoi.chuoikn);
            da = new SqlDataAdapter(sql, cnn);
            new SqlCommandBuilder(da);
            cnn.Open();
            da.Update(dt);
            cnn.Close();
        }

        public static void Luutiendo(DataTable dt)
        {
            string sql = "select *from tiendo";
            SqlConnection cnn = new SqlConnection(chuoiketnoi.chuoikn);
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            new SqlCommandBuilder(da);
            cnn.Open();
            da.Update(dt);
            cnn.Close();
        }

        public static void LuuchitietKH(SqlDataAdapter da, DataTable dt)
        {
            string sql = "select *from chitietkh";
            SqlConnection cnn = new SqlConnection(chuoiketnoi.chuoikn);
            da = new SqlDataAdapter(sql, cnn);
            new SqlCommandBuilder(da);
            cnn.Open();
            da.Update(dt);
            cnn.Close();
        }

        public static void Luucongvan(SqlDataAdapter da, DataTable dt)
        {
            string sql = "select *from congvan";
            SqlConnection cnn = new SqlConnection(chuoiketnoi.chuoikn);
            da = new SqlDataAdapter(sql, cnn);
            new SqlCommandBuilder(da);
            cnn.Open();
            da.Update(dt);
            cnn.Close();
        }

        public static int themkehoach(string makh,string tenkh,string socv,string ngaytrienkhai,string ngayketthuc,int tongchi)
        {
            ngayketthuc = Code.Xulyngaysinh.Convertngaysinh(ngayketthuc);
            ngaytrienkhai = Code.Xulyngaysinh.Convertngaysinh(ngaytrienkhai);
            SqlConnection cnn = new SqlConnection(chuoiketnoi.chuoikn);
            string sql = "insert into kehoach values('" + makh + "',N'" + tenkh + "',N'"+socv+"','" + ngaytrienkhai + "','" + ngayketthuc + "'," + tongchi + ")";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cnn.Open();
            int n=cmd.ExecuteNonQuery();
            cnn.Close();
            return n;
        }

        public static int themcongvan(string makh, string macv, string tencv, string noidungcv)
        {
            SqlConnection cnn = new SqlConnection(chuoiketnoi.chuoikn);
            string sql = "insert into congvan values('" + macv + "','"+makh+"',N'" + tencv + "',N'" + noidungcv + "')";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cnn.Open();
            int n = cmd.ExecuteNonQuery();
            cnn.Close();
            return n;
        }
        
    }
}
