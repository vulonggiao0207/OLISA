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
    public partial class MainForm : Form
    {
        public static Boolean KTthemngdung = false;
        public static Boolean KTxemkehoach = false;
        public static Boolean KTdoituong = false;
        public static Boolean KTdienuutien = false;
        public static Boolean KTkehoach = false;
        public static Boolean KThuongdan = false;
        public static Boolean KTtaomoidoituong = false;
        public static Boolean KTtaomoidienuutien = false;
        public static Boolean KTtaomoikehoach = false;
        public static Boolean KTquanhe = false;
        public static Boolean KThinhthuc = false;
        public static Boolean KTbaocaods = false;
        public static Boolean KTbaocaosolieu = false;
        public static Boolean KTtimkiem=false;
        
        public MainForm()
        {
            InitializeComponent();
        }

        private void thêmNgườiDùngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (KTthemngdung == false)
            {
                KTthemngdung = true;
                Themnguoisudung tnsd = new Themnguoisudung();
                tnsd.MdiParent = this;
                tnsd.Show();
            }
        }

        private void mởKếHoạchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (KTxemkehoach == false)
            {
                KTxemkehoach = true;
                XemKeHoach xkh = new XemKeHoach();
                xkh.MdiParent = this;
                xkh.Show();
            }
        }      

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();    
        }

        private void hướngDẫnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (KThuongdan == false)
            {
                KThuongdan = true;
                Huongdan hd = new Huongdan();
                hd.MdiParent = this;
                hd.Show();
            }
        }

        private void đốiTượngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (KTdoituong == false)
            {
                KTdoituong = true;
                DoiTuongUuTien dtut = new DoiTuongUuTien();
                dtut.MdiParent = this;
                dtut.Show();
            }
        }

        private void diệnƯuTiênToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (KTdienuutien == false)
            {
                KTdienuutien = true;
                DienUuTien dut = new DienUuTien();
                dut.MdiParent = this;
                dut.Show();
            }
        }

        private void kếHoạchToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (KTkehoach == false)
            {
                KTkehoach = true;
                KeHoach kh = new KeHoach();
                kh.MdiParent = this;
                kh.Show();
            }
        }

        private void đốiTượngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (KTtaomoidoituong == false)
            {
                KTtaomoidoituong = true;
                Taomoidoituong tmdt = new Taomoidoituong();
                tmdt.MdiParent = this;
                tmdt.Show();
            }            

        }

        private void diệnƯuTiênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (KTtaomoidienuutien == false)
            {
                KTtaomoidienuutien = true;
                Taomoidienuutien tmdut = new Taomoidienuutien();
                tmdut.MdiParent = this;
                tmdut.Show();
            }
        }

        private void kếHoạchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (KTtaomoikehoach == false)
            {
                KTtaomoikehoach = true;
                Taomoikehoach tmkh = new Taomoikehoach();
                tmkh.MdiParent = this;
                tmkh.Show();
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            if (MessageBox.Show("Bạn muốn thoát khỏi chương trình?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {        
                e.Cancel = true;                
            }
            
        }
        private void danhSáchĐốiTượngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (KTbaocaods == false)
            {
                KTbaocaods = true;
                BCdanhsach ds = new BCdanhsach();
                ds.MdiParent = this;
                ds.Show();
            }
        }

        private void sốLiệuTổngHợpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (KTbaocaosolieu == false)
            {
                KTbaocaosolieu = true;
                BCsolieu solieu = new BCsolieu();
                solieu.MdiParent = this;
                solieu.Show();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            string super="";
            string admin = "";
            string doituong = "";
            string dienuutien = "";
            string kehoach = "";
            string tiendo = "";
            SqlConnection cnn = new SqlConnection(chuoiketnoi.chuoikn);
            SqlDataAdapter da= new SqlDataAdapter("select * from Admin where id='"+DangNhap.tendangnhap+"'",cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            super = dt.Rows[0]["id"].ToString();    
            admin = dt.Rows[0]["admin"].ToString();            
            doituong = dt.Rows[0]["doituong"].ToString();
            dienuutien = dt.Rows[0]["dienuutien"].ToString();
            kehoach = dt.Rows[0]["kehoach"].ToString();
            tiendo = dt.Rows[0]["tiendo"].ToString();

            if (super == "admin")
            {
                đốiTượngToolStripMenuItem.Enabled = true;
                đốiTượngToolStripMenuItem1.Enabled = true;
                quanHệToolStripMenuItem.Enabled = true;
                diệnƯuTiênToolStripMenuItem.Enabled = true;
                diệnƯuTiênToolStripMenuItem1.Enabled = true;
                kếHoạchToolStripMenuItem.Enabled = true;
                kếHoạchToolStripMenuItem1.Enabled = true;
                cậpNhậthìnhThứcToolStripMenuItem.Enabled = true;
                danhSáchĐốiTượngToolStripMenuItem.Enabled = true;
                sốLiệuTổngHợpToolStripMenuItem.Enabled = true;
                mởKếHoạchToolStripMenuItem.Enabled = true;
                đốiTượngToolStripMenuItem1.Enabled = true;
                thêmNgườiDùngToolStripMenuItem.Enabled = true;
                thoátToolStripMenuItem.Enabled = true;

            }

            if(admin !="True")
            {
                if (doituong == "True")
                {
                    đốiTượngToolStripMenuItem.Enabled = true;
                    đốiTượngToolStripMenuItem1.Enabled = true;
                    quanHệToolStripMenuItem.Enabled = true;
                    thoátToolStripMenuItem.Enabled = true;

                }
                if(dienuutien=="True")
                {
                    diệnƯuTiênToolStripMenuItem.Enabled = true;
                    diệnƯuTiênToolStripMenuItem1.Enabled = true;
                    thoátToolStripMenuItem.Enabled = true;
                }
                if (kehoach == "True")
                {
                    kếHoạchToolStripMenuItem.Enabled = true;
                    kếHoạchToolStripMenuItem1.Enabled = true;
                    cậpNhậthìnhThứcToolStripMenuItem.Enabled = true;
                    danhSáchĐốiTượngToolStripMenuItem.Enabled = true;
                    sốLiệuTổngHợpToolStripMenuItem.Enabled = true;
                    thoátToolStripMenuItem.Enabled = true;
                }
                if (tiendo == "True")
                {
                    mởKếHoạchToolStripMenuItem.Enabled = true;
                    thoátToolStripMenuItem.Enabled = true;
                }
            }
           
            else
            {
                đốiTượngToolStripMenuItem.Enabled = true;
                đốiTượngToolStripMenuItem1.Enabled = true;
                quanHệToolStripMenuItem.Enabled = true;
                diệnƯuTiênToolStripMenuItem.Enabled = true;
                diệnƯuTiênToolStripMenuItem1.Enabled = true;
                kếHoạchToolStripMenuItem.Enabled = true;
                kếHoạchToolStripMenuItem1.Enabled = true;
                cậpNhậthìnhThứcToolStripMenuItem.Enabled = true;
                danhSáchĐốiTượngToolStripMenuItem.Enabled = true;
                sốLiệuTổngHợpToolStripMenuItem.Enabled = true;
                mởKếHoạchToolStripMenuItem.Enabled = true;
                đốiTượngToolStripMenuItem1.Enabled = true;
            //    thêmNgườiDùngToolStripMenuItem.Enabled = true ;
                thoátToolStripMenuItem.Enabled = true;
            }


            

        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
              Application.Exit();
        }

        private void cậpNhậthìnhThứcToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (KThinhthuc == false)
            {
                KThinhthuc = true;
                KThinhthuc = true;
                Hinhthuc ht = new Hinhthuc();
                ht.MdiParent = this;
                ht.Show();
            }
        }

        private void quanHệToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (KTquanhe == false)
            {
                KTquanhe = true;
                Quanhe qh = new Quanhe();
                qh.MdiParent = this;
                qh.Show();
            }
        }

        private void tìmKiếmThôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (KTtimkiem == false)
            {
                KTtimkiem = true;
                Timkiemthongtin tktt = new Timkiemthongtin();
                tktt.MdiParent = this;
                tktt.Show();
            }
        }

       

        

      

    }
}