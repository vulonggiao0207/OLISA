using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LDTBXH.Code
{
    class QLHoso
    {
        static SqlDataAdapter da = null;
        static DataTable dt = null;
        public static DataTable Lietkehoso()
        {
            string sql = "select * from giayto where madt='" + DoiTuongUuTien.madt + "'";
            SqlConnection cnn = new SqlConnection(chuoiketnoi.chuoikn);
            da = new SqlDataAdapter(sql, cnn);
            new SqlCommandBuilder(da);
            dt = new DataTable();
            cnn.Open();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }

        public static DataTable Lietkehoso(string tenhoso)
        {
            string sql = "select *from giayto where tengt like N'%" + tenhoso + "%'";
            sql += "and madt='" + DoiTuongUuTien.madt + "'";
            SqlConnection cnn = new SqlConnection(chuoiketnoi.chuoikn);
            da = new SqlDataAdapter(sql, cnn);
            new SqlCommandBuilder(da);
            dt = new DataTable();
            cnn.Open();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }


        public static int Themhoso(string magt,string madt,string tenhs,string noidung)
        {
            string sql = "insert into giayto(magt,madt,tengt,noidunggt) ";
            sql += "values('"+magt+"','"+madt+"',N'"+tenhs+"',N'"+noidung+"')";
            SqlConnection cnn = new SqlConnection(chuoiketnoi.chuoikn);
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cnn.Open();
            int n=cmd.ExecuteNonQuery();
            cnn.Close();
            return n;
        }

        public static int Luuhoso(string tenhs,string noidunghs,string mahs)
        {
            if (tenhs == "" && dt.Rows.Count<=0)
            {
                MessageBox.Show("Yêu cầu nhập tên hồ sơ");
                return 0;
            }

            string sql = "update giayto set tengt=N'" + tenhs + "'";
            sql += ",noidunggt=N'" + noidunghs + "' ";
            sql += "where magt='" + mahs + "'";
            SqlConnection cnn = new SqlConnection(chuoiketnoi.chuoikn);
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cnn.Open();
            da.Update(dt);
            int n=cmd.ExecuteNonQuery();
            cnn.Close();
            return n;
        }
    }
}
