using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace LDTBXH
{
    class sinhid
    {
        public static string laykitu(string s)
        {
            //   s = "Giao Long"==> GL;
            string t = "";
            int cdai = s.Length;
            char[] chart = new char[2];
            char[] chars = s.ToCharArray();
            chart[0] = chars[0];
            chart[1] = ' ';
            for (int i = cdai-1; i >=0; i--)
            {                
                if (chars[i] == ' ')
                {
                    chart[1] = chars[i + 1];
                    break;
                }   
            }
            if (chart[1] == ' ')
                chart[1] = chart[0];
            t = new string(chart);
            return t.ToUpper();
        }
        public static bool TonTai(string tb,string cl,string s)
        {
            bool flag = false; // default khong ton tai user tennd
            string sql = "SELECT 1 From " + tb + " where "+ cl + "='" + s + "'";
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
        public static string taoid(string tb,string cl,string s)
        {
            string temp = laykitu(s);
            string kq = "";
            if (!TonTai(tb,cl,temp = temp + "001"))
            {
                kq = temp;
                return kq;
            }
            for (int i = 1; i < 1000; i++)
            {
                string temp1 = taoso(i);
                temp = laykitu(s);
                temp = temp + temp1;
                if (TonTai(tb,cl,temp))
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
