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
    public partial class Huongdan : Form
    {
        public Huongdan()
        {
            InitializeComponent();
        }

        private void Huongdan_Load(object sender, EventArgs e)
        {

        }

        private void Huongdan_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm.KThuongdan = false;
        }
    }
}