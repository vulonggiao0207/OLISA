using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace LDTBXH.Code
{
    class Xulyngaysinh
    {
        public static void khoitaocombobox(ComboBox cbthang,ComboBox cbnam)
        {
            for (int i = DateTime.Now.Year-1; i >= 1900; i--)
                cbnam.Items.Add(i);
            for (int i = 1; i <= 12; i++)
            {
                if (i < 10)
                    cbthang.Items.Add("0" + i);
                else
                    cbthang.Items.Add(i);
            }
        }
        public static void khoitaocomboboxkh(ComboBox cbthang, ComboBox cbnam)
        {
            for (int i = DateTime.Now.Year; i < DateTime.Now.Year + 100; i++)
            {
                cbnam.Items.Add(i);
            }
            for (int i = 1; i <= 12; i++)
            {
                if (i < 10)
                    cbthang.Items.Add("0" + i);
                else
                    cbthang.Items.Add(i);
            }
        }

        public static Boolean Lanamnhuan(int nam)
        {
            if ((nam % 4 == 0 && nam % 100 != 0) || nam % 400 == 0)
                return true;
            return false;
        }

        public static string layngaysinh(ComboBox cbngay,ComboBox cbthang, ComboBox cbnam)
        {
            return  cbngay.Text+ "/" + cbthang.Text  + "/" + cbnam.Text;
        }

        public static string Convertngaysinh(string ngaysinh)
        {
            return laythang(ngaysinh) + "/" + layngay(ngaysinh) + "/" + laynam(ngaysinh);
        }

        public static string layngay(string ngaysinh)
        {
            return DateTime.Parse(ngaysinh).Day.ToString();
        }

        public static string laythang(string ngaysinh)
        {
            return DateTime.Parse(ngaysinh).Month.ToString();
        }

        public static string laynam(string ngaysinh)
        {
            return DateTime.Parse(ngaysinh).Year.ToString();
        }

        public static void Xulyngay(int thang,int nam,ComboBox cbngay)
        {
            cbngay.Items.Clear();
            switch (thang)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    for (int i = 1; i <= 31; i++)
                    {
                        if (i < 10)
                            cbngay.Items.Add("0" + i);
                        else
                            cbngay.Items.Add(i);
                    }
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    
                    for (int i = 1; i <= 30; i++)
                    {
                        if (i < 10)
                            cbngay.Items.Add("0" + i);
                        else
                            cbngay.Items.Add(i);
                    }
                    if (cbngay.Text == "31")
                        cbngay.Text = "30";
                    break;
                case 2:
                    if (Lanamnhuan(nam) == true)
                    {
                        
                        for (int i = 1; i <= 29; i++)
                        {
                            if (i < 10)
                                cbngay.Items.Add("0" + i);
                            else
                                cbngay.Items.Add(i);
                        }
                        if (cbngay.Text == "30" || cbngay.Text == "31")
                            cbngay.Text = "29";
                    }
                    else
                    {
                        for (int i = 1; i <= 28; i++)
                        {
                            if (i < 10)
                                cbngay.Items.Add("0" + i);
                            else
                                cbngay.Items.Add(i);
                        }
                        if (cbngay.Text == "29" || cbngay.Text == "30" || cbngay.Text == "31")
                            cbngay.Text = "28";
                    }
                    break;
            }
        }
    }
}
