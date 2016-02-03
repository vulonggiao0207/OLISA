using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LDTBXH
{
    public partial class Timkiemthongtin : Form
    {
        DataTable dtkehoach = null;
        DataTable dtdoituong = null;
        DataTable dtdienuutien = null;
        DataTable dt = null;
        public bool flag = false;

        public Timkiemthongtin()
        {
            InitializeComponent();
        }

        private void Timkiemthongtin_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm.KTtimkiem = false;
        }

        private void Timkiemthongtin_Load(object sender, EventArgs e)
        {
            Code.Xulyngaysinh.khoitaocomboboxkh(cbthangtrienkhai, cbnamtrienkhai);
            Code.Xulyngaysinh.khoitaocomboboxkh(cbthangketthuc, cbnamketthuc);
            cbnamtrienkhai.SelectedIndex = 0;
            flag = true;
            cbthangtrienkhai.SelectedIndex = 0;
            cbngaytrienkhai.SelectedIndex = 0;

            flag = false;
            cbnamketthuc.SelectedIndex = 0;
            flag = true;
            cbthangketthuc.SelectedIndex = 0;
            cbngayketthuc.SelectedIndex = 0;
        }

        private void rdkehoach_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                cbthongtin.AutoCompleteCustomSource.Clear();
                if (rdkehoach.Checked == true)
                {
                    dtkehoach = Code.QLKehoach.LietkeKH();
                    Code.Khoitao.bindingcombobox(dtkehoach, cbthongtin, "tenkh", "makh");
                    groupBox2.Enabled = true;
                    Code.Khoitao.KhoidongAutoCombobox(dtkehoach, cbthongtin, "tenkh");
                }
                else if (rddienuutien.Checked == true)
                {
                    dtdienuutien = Code.QlDienuutien.Lietkedienut();
                    Code.Khoitao.bindingcombobox(dtdienuutien, cbthongtin, "tendut", "madut");
                    groupBox2.Enabled = false;
                    Code.Khoitao.KhoidongAutoCombobox(dtdienuutien, cbthongtin, "tendut");
                }
                else
                {
                    dtdoituong = Code.Qldoituong.Lietkedoituong();
                    Code.Khoitao.bindingcombobox(dtdoituong, cbthongtin, "ten", "madt");
                    groupBox2.Enabled = false;
                    Code.Khoitao.KhoidongAutoCombobox(dtdoituong, cbthongtin, "ten");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void rddienuutien_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                cbthongtin.AutoCompleteCustomSource.Clear();
                if (rddienuutien.Checked == true)
                {
                    dtdienuutien = Code.QlDienuutien.Lietkedienut();
                    Code.Khoitao.bindingcombobox(dtdienuutien, cbthongtin, "tendut", "madut");
                    groupBox2.Enabled = false;
                    Code.Khoitao.KhoidongAutoCombobox(dtdienuutien, cbthongtin, "tendut");
                }
                else if (rddoituong.Checked == true)
                {
                    dtdoituong = Code.Qldoituong.Lietkedoituong();
                    Code.Khoitao.bindingcombobox(dtdoituong, cbthongtin, "ten", "madt");
                    groupBox2.Enabled = false;
                    Code.Khoitao.KhoidongAutoCombobox(dtdoituong, cbthongtin, "ten");
                }
                else
                {
                    dtkehoach = Code.QLKehoach.LietkeKH();
                    Code.Khoitao.bindingcombobox(dtkehoach, cbthongtin, "tenkh", "makh");
                    groupBox2.Enabled = true;
                    Code.Khoitao.KhoidongAutoCombobox(dtkehoach, cbthongtin, "tenkh");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btntim_Click(object sender, EventArgs e)
        {
            try
            {
                if (rdkehoach.Checked == true)
                {
                    string ngaytrienkhai = Code.Xulyngaysinh.layngaysinh(cbngaytrienkhai, cbthangtrienkhai, cbnamtrienkhai);
                    string ngayketthuc = Code.Xulyngaysinh.layngaysinh(cbngayketthuc, cbthangketthuc, cbnamketthuc);
                    dt = Code.QLKehoach.LietkeKH(cbthongtin.Text,ngaytrienkhai,ngayketthuc);
                }
                else if (rddienuutien.Checked == true)
                    dt = Code.QlDienuutien.Timkiemdut(cbthongtin.Text);
                else
                    dt = Code.Qldoituong.Lietkedoituong(cbthongtin.Text);
                dgvthongtin.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbnamtrienkhai_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (flag == true)
                {
                    int namtk = Convert.ToInt32(cbnamtrienkhai.SelectedItem.ToString());
                    int thangtk = Convert.ToInt32(cbthangtrienkhai.SelectedItem.ToString());
                    Code.Xulyngaysinh.Xulyngay(thangtk, namtk, cbngaytrienkhai);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbthangtrienkhai_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (flag == true)
                {
                    int namtk = Convert.ToInt32(cbnamtrienkhai.SelectedItem.ToString());
                    int thangtk = Convert.ToInt32(cbthangtrienkhai.SelectedItem.ToString());
                    Code.Xulyngaysinh.Xulyngay(thangtk, namtk, cbngaytrienkhai);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbnamketthuc_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (flag == true)
                {
                    int namkt = Convert.ToInt32(cbnamketthuc.SelectedItem.ToString());
                    int thangkt = Convert.ToInt32(cbthangketthuc.SelectedItem.ToString());
                    Code.Xulyngaysinh.Xulyngay(thangkt, namkt, cbngayketthuc);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbthangketthuc_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (flag == true)
                {
                    int namkt = Convert.ToInt32(cbnamketthuc.SelectedItem.ToString());
                    int thangkt = Convert.ToInt32(cbthangketthuc.SelectedItem.ToString());
                    Code.Xulyngaysinh.Xulyngay(thangkt, namkt, cbngayketthuc);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}