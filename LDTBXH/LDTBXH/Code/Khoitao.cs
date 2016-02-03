using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace LDTBXH.Code
{
    class Khoitao
    {
        public static void KhoidongAutoTextbox(DataTable dt,TextBox text,string namecolumn)
        {
            for (int i = 0; i < dt.Rows.Count; i++)
                text.AutoCompleteCustomSource.Add(dt.Rows[i][namecolumn].ToString());
        }

        public static void KhoidongAutoCombobox(DataTable dt, ComboBox cb, string namecolumn)
        {
            for (int i = 0; i < dt.Rows.Count; i++)
                cb.AutoCompleteCustomSource.Add(dt.Rows[i][namecolumn].ToString());
        }

        public static void AddItemToCombobox(ComboBox cb, DataTable dt, string namecolumn)
        {
            for (int i = 0; i < dt.Rows.Count; i++)
                cb.Items.Add(dt.Rows[i][namecolumn].ToString());

        }

        public static void bindingcombobox(DataTable dt, ComboBox cb,string displaymember,string valuemember)
        {
            cb.DataSource = dt;
            cb.DisplayMember = displaymember;
            cb.ValueMember = valuemember;
        }

        public static void bindinglistbox(DataTable dt, ListBox lst, string displaymember, string valuemember)
        {
            lst.DataSource = dt;
            lst.DisplayMember = displaymember;
            lst.ValueMember = valuemember;
        }
    }
}
