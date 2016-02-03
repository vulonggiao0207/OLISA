using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace LDTBXH
{
    class Auto_Matn
    {
        public static string laykitu(string s)
        {
            //   s = "Giao Long"==> GL;
            string t = "";
            int cdai = s.Length;
            char[] chart = new char[2];
            char[] chars = s.ToCharArray();
            for (int i = 0; i < cdai; i++)
            {
                chart[0] = chars[0];
                if (chars[i] == ' ')
                {
                    chart[1] = chars[i + 1];
                    break;
                }
            }
            t = new string(chart);
            return t;
        }
        public static bool TonTai(string s)
        {
            bool flag = false; // default khong ton tai user tennd
            string sql = "SELECT 1 From thannhan where matn='" + s + "'";
            SqlConnection sqlconn = new SqlConnection(chuoiketnoi.chuoikn);
            SqlCommand cmd = new SqlCommand(sql, sqlconn);
            sqlconn.Open();
            object obj = cmd.ExecuteScalar();
            sqlconn.Close();
            if (obj != null)
            {
                flag = true;
            }
            return flag;
        }
        public static string taoso(int num)
        {
            if (num < 10)
            {
                string num1 = num.ToString();
                return ("0" + "0" + num1);
            }
            if (num < 100)
            {
                string num1 = num.ToString();
                return ("0" + num1);
            }
            return num.ToString();
        }
        public static string taoid(string s)
        {
            string temp = laykitu(s);
            string kq = "";
            if (!TonTai(temp = temp + "001"))
            {
                kq = temp;
                return kq;
            }
            for (int i = 1; i < 1000; i++)
            {
                string temp1 = taoso(i);
                temp = laykitu(s);
                temp = temp + temp1;
                if (TonTai(temp))
                {
                    temp = laykitu(s);
                    temp1 = taoso(i + 1);
                    temp = temp + temp1;
                    kq = temp;
                }
            }
            return kq;
        }
    }
}
