using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace LDTBXH
{
    public partial class KeHoach : Form
    {
        public static string makh = "";
        public static string tenkh = "";
        public static string temp;
        public static Boolean flag = false;
        public Boolean flag2 = false;
        SqlDataAdapter da = null;
        SqlDataAdapter dactkh = null;
        SqlDataAdapter dacv = null;

        DataTable dt = new DataTable();
        DataTable dtctkh = null;
        DataTable dtdut = new DataTable();
        DataTable dtht=new DataTable();
        DataTable dtcv = null;
        DataTable dttiendo = new DataTable();
        public KeHoach()
        {
            InitializeComponent();
        }

        private void KeHoach_Load(object sender, EventArgs e)
        {
            try
            {
                dt = Code.QLKehoach.LietkeKH();
                dtdut = Code.QlDienuutien.Lietkedienut();
                dtht = Code.QLKehoach.LietkeHinhthuc();
                dttiendo = Code.QLKehoach.Lietketiendo();
                Code.Khoitao.bindingcombobox(dtht, cbTThinhthuc, "tenht", "maht");
                dgvkehoach.DataSource = dt;
                AddbindingKH();

                Code.Khoitao.bindingcombobox(dtdut, cbdienuutien, "tendut", "madut");
                Code.Khoitao.AddItemToCombobox(cbhinhthuc, dtht, "tenht");
                Code.Khoitao.KhoidongAutoTextbox(dt, txttenkehoach, "tenkh");

                cbhinhthuc.SelectedIndex = 0;
                lbkehoach.Hide();
                lbtenkh.Hide();
                lbcv.Hide();
                lbdut.Hide();
                lbmaht.Hide();
                dgvkehoach.Columns["makh"].HeaderText = "Mã Kế hoạch";
                dgvkehoach.Columns["tenkh"].HeaderText = "Tên Kế hoạch";
                dgvkehoach.Columns["socv"].HeaderText = "Số công văn";
                dgvkehoach.Columns["ngaytrienkhai"].HeaderText = "Ngày Triển Khai";
                dgvkehoach.Columns["ngayketthuc"].HeaderText = "Ngày Kết Thúc";

                flag2 = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lbkehoach_TextChanged(object sender, EventArgs e)
        {                    
            dtctkh = Code.QLKehoach.LietkeCTKH(lbkehoach.Text);
            dtcv = Code.QLKehoach.LietkeCongvan(lbkehoach.Text);
            dgvDUT.DataSource = dtctkh;
            Code.Khoitao.bindinglistbox(dtcv, lstcongvan, "tencv", "macv");

            ClearbindingCV_DUT();
            AddbindingCV_DUT();
            if (lstcongvan.Text == "")
                rtxtcongvan.Text = "";
            
            dgvDUT.Columns["sotien"].HeaderText = "Số Tiền";
            dgvDUT.Columns["ghichu"].HeaderText = "Ghi Chú";
            dgvDUT.Columns["madut"].Visible = false;
        }
       
        private void btntim_Click(object sender, EventArgs e)
        {
            try
            {
                dt = Code.QLKehoach.LietkeKH(txttenkehoach.Text);
                dgvkehoach.DataSource = dt;
                if (dt.Rows.Count > 0)
                {
                    ClearbindingKH();
                    AddbindingKH();
                }
                else
                {
                    txtngaytrienkhai.Text = "";
                    txtngayketthuc.Text = "";
                    MessageBox.Show("Không có kế hoạch cần tìm");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            MainForm.KTkehoach = false;
            this.Close();
        }

        private void KeHoach_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm.KTkehoach = false;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                string makh = lbkehoach.Text;
                if(makh=="")
                {
                    MessageBox.Show("Không có kế hoạch để xóa");
                    return;
                }
                DataRow[] dr = dt.Select("makh='" + makh + "'");
                DataRow[] drtiendo=dttiendo.Select("makh='"+makh+"'");
                //Xóa trên table tiendo
                for (int i = 0; i < drtiendo.Length; i++)
                    drtiendo[i].Delete();
                //Xóa trên table kehoach
                dr[0].Delete();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            try
            {
                Code.QLKehoach.Luutiendo(dttiendo);
                Code.QLKehoach.Luukehoach(da, dt);
                Code.QLKehoach.LuuchitietKH(dactkh, dtctkh);
                Code.QLKehoach.Luucongvan(dacv, dtcv);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            dttiendo.RejectChanges();
            dt.RejectChanges();
            dtctkh.RejectChanges();
            dtcv.RejectChanges();
            cbdienuutien.SelectedIndex = 0;
            cbhinhthuc.SelectedIndex = 0;
        }


        private void btnthemDUT_Click(object sender, EventArgs e)
        {
            try
            {
                int maht = cbhinhthuc.SelectedIndex + 1;
                try
                {
                    for (int i = 0; i < dtctkh.Rows.Count; i++)
                        if (lbdut.Text == dtctkh.Rows[i]["madut"].ToString())
                        {
                            MessageBox.Show("Đã có diện ưu tiên này");
                            return;
                        }
                }
                catch (DeletedRowInaccessibleException)
                {
                    MessageBox.Show("Dữ liệu đang có sự thay đổi."+"\n"+"Làm ơn Lưu hoặc hủy thao tác trước khi thêm mới");
                    return;
                }
                DataRow dr = dtctkh.NewRow();
                dr["makh"] = lbkehoach.Text;
                dr["madut"] = lbdut.Text;
                dr["maht"] = maht;
                dr["sotien"] = txtsotien.Text;
                dr["ghichu"] = rtxtghichu.Text;
                dtctkh.Rows.Add(dr);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnxoaDUT_Click(object sender, EventArgs e)
        {
            try
            {
                if (lbdut.Text == "")
                {
                    MessageBox.Show("Không có diện ưu tiên để xóa");
                    return;
                }
                DataRow[] dr = dtctkh.Select("madut='" + lbdut.Text + "'");
                try
                {
                    dr[0].Delete();
                }
                catch (IndexOutOfRangeException)
                {
                    MessageBox.Show("Chọn thông tin cần xóa");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnthemcongvan_Click(object sender, EventArgs e)
        {
            if (lbkehoach.Text == "")
                MessageBox.Show("Không có kế hoạch để thêm công văn");
            else if (Themcongvan.KTthemcv == false)
            {
                makh = lbkehoach.Text;
                tenkh = lbtenkh.Text;
                MainForm f = (MainForm)this.MdiParent;
                Themcongvan cv = new Themcongvan();
                cv.MdiParent = f;
                cv.Show();
            }
        }

        private void btnxoacongvan_Click(object sender, EventArgs e)
        {
            try
            {
                if(lbcv.Text=="")
                {
                    MessageBox.Show("Không có công văn để xóa");
                    return;
                }
                DataRow[] dr = dtcv.Select("macv='" + lbcv.Text + "'");
                dr[0].Delete();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        

        private void ClearbindingKH()
        {
            txttenkehoach.DataBindings.Clear();
            txtngaytrienkhai.DataBindings.Clear();
            txtngayketthuc.DataBindings.Clear();
            lbkehoach.DataBindings.Clear();
            lbtenkh.DataBindings.Clear();
        }

        private void AddbindingKH()
        {
            txttenkehoach.DataBindings.Add("text", dt, "tenkh");
            txtngaytrienkhai.DataBindings.Add("text", dt, "ngaytrienkhai", true, DataSourceUpdateMode.Never, null, "dd/MM/yyyy");
            txtngayketthuc.DataBindings.Add("text", dt, "ngayketthuc", true, DataSourceUpdateMode.Never, null, "dd/MM/yyyy");
            lbkehoach.DataBindings.Add("text", dt, "makh");
            lbtenkh.DataBindings.Add("text", dt, "tenkh");
        }

        private void ClearbindingCV_DUT()
        {
            txtTTsotien.DataBindings.Clear();
            lbcv.DataBindings.Clear();
            lbmaht.DataBindings.Clear();
            lbdut.DataBindings.Clear();
            rtxtghichu.DataBindings.Clear();
            rtxtcongvan.DataBindings.Clear();
        }

        private void AddbindingCV_DUT()
        {
            rtxtcongvan.DataBindings.Add("text", dtcv, "noidungcv");
            lbcv.DataBindings.Add("text", dtcv, "macv");
            txtTTsotien.DataBindings.Add("text", dtctkh, "sotien");
            lbmaht.DataBindings.Add("text", dtctkh, "maht");
            lbdut.DataBindings.Add("text", dtctkh, "madut");
            rtxtghichu.DataBindings.Add("text", dtctkh, "ghichu");
        }

        private void cbdienuutien_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbdut.Text = dtdut.Rows[cbdienuutien.SelectedIndex]["madut"].ToString();
        }

        private void lbdut_TextChanged(object sender, EventArgs e)
        {
            if (lbdut.Text != "")
            {
                DataRow[] dr = dtdut.Select("madut='" + lbdut.Text + "'");
                txttendut.Text = dr[0]["tendut"].ToString();
            }
            else
                txttendut.Text = "";
        }

        private void KeHoach_Activated(object sender, EventArgs e)
        {
            if (flag == true)
            {
                flag = false;
                MessageBox.Show("Thêm Công văn mới thành công");
                dtcv = Code.QLKehoach.LietkeCongvan(makh);
                Code.Khoitao.bindinglistbox(dtcv, lstcongvan, "tencv", "macv");
                int i;
                for (i = 0; i < dtcv.Rows.Count; i++)
                    if (temp == dtcv.Rows[i]["macv"].ToString())
                        break;
                lstcongvan.SetSelected(i, true);
                rtxtcongvan.DataBindings.Clear();
                lbcv.DataBindings.Clear();
                rtxtcongvan.DataBindings.Add("text", dtcv, "noidungcv");
                lbcv.DataBindings.Add("text", dtcv, "macv");
            }
        }

        private void txtTTsotien_Validating(object sender, CancelEventArgs e)
        {
            Regex rg = new Regex("^[0-9]{0,9}$");
            if (rg.IsMatch(txtTTsotien.Text) == false)
            {
                MessageBox.Show("Thông tin số tiền không hợp lệ");
                e.Cancel = true;
            }
        }

        private void lbmaht_TextChanged(object sender, EventArgs e)
        {
            if (lbmaht.Text != "")
            {
                cbTThinhthuc.SelectedValue = lbmaht.Text;
            }
            else
                cbTThinhthuc.Text = "";
        }

        private void cbTThinhthuc_SelectedValueChanged(object sender, EventArgs e)
        {
            if(flag2==true)
                lbmaht.Text = cbTThinhthuc.SelectedValue.ToString();
        }

    }
}