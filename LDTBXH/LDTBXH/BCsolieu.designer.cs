namespace LDTBXH
{
    partial class BCsolieu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbmakh = new System.Windows.Forms.Label();
            this.cbdangkhac = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbnam = new System.Windows.Forms.ComboBox();
            this.cbqui = new System.Windows.Forms.ComboBox();
            this.rdthang = new System.Windows.Forms.RadioButton();
            this.cbthang = new System.Windows.Forms.ComboBox();
            this.rdqui = new System.Windows.Forms.RadioButton();
            this.rdnam = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txttenkh = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.lbmakh);
            this.panel1.Controls.Add(this.cbdangkhac);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txttenkh);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(928, 189);
            this.panel1.TabIndex = 0;
            // 
            // lbmakh
            // 
            this.lbmakh.AutoSize = true;
            this.lbmakh.Location = new System.Drawing.Point(141, 71);
            this.lbmakh.Name = "lbmakh";
            this.lbmakh.Size = new System.Drawing.Size(35, 13);
            this.lbmakh.TabIndex = 6;
            this.lbmakh.Text = "label2";
            // 
            // cbdangkhac
            // 
            this.cbdangkhac.AutoSize = true;
            this.cbdangkhac.Location = new System.Drawing.Point(144, 147);
            this.cbdangkhac.Name = "cbdangkhac";
            this.cbdangkhac.Size = new System.Drawing.Size(82, 17);
            this.cbdangkhac.TabIndex = 5;
            this.cbdangkhac.Text = "Dạng khác:";
            this.cbdangkhac.UseVisualStyleBackColor = true;
            this.cbdangkhac.CheckedChanged += new System.EventHandler(this.cbdangkhac_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbnam);
            this.groupBox1.Controls.Add(this.cbqui);
            this.groupBox1.Controls.Add(this.rdthang);
            this.groupBox1.Controls.Add(this.cbthang);
            this.groupBox1.Controls.Add(this.rdqui);
            this.groupBox1.Controls.Add(this.rdnam);
            this.groupBox1.Location = new System.Drawing.Point(232, 124);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(656, 59);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Báo cáo theo";
            // 
            // cbnam
            // 
            this.cbnam.Enabled = false;
            this.cbnam.FormattingEnabled = true;
            this.cbnam.Location = new System.Drawing.Point(455, 19);
            this.cbnam.Name = "cbnam";
            this.cbnam.Size = new System.Drawing.Size(121, 21);
            this.cbnam.TabIndex = 10;
            // 
            // cbqui
            // 
            this.cbqui.Enabled = false;
            this.cbqui.FormattingEnabled = true;
            this.cbqui.Location = new System.Drawing.Point(262, 19);
            this.cbqui.Name = "cbqui";
            this.cbqui.Size = new System.Drawing.Size(121, 21);
            this.cbqui.TabIndex = 9;
            // 
            // rdthang
            // 
            this.rdthang.AutoSize = true;
            this.rdthang.Enabled = false;
            this.rdthang.Location = new System.Drawing.Point(20, 20);
            this.rdthang.Name = "rdthang";
            this.rdthang.Size = new System.Drawing.Size(56, 17);
            this.rdthang.TabIndex = 5;
            this.rdthang.TabStop = true;
            this.rdthang.Text = "Tháng";
            this.rdthang.UseVisualStyleBackColor = true;
            this.rdthang.CheckedChanged += new System.EventHandler(this.rdthang_CheckedChanged);
            // 
            // cbthang
            // 
            this.cbthang.Enabled = false;
            this.cbthang.FormattingEnabled = true;
            this.cbthang.Location = new System.Drawing.Point(76, 19);
            this.cbthang.Name = "cbthang";
            this.cbthang.Size = new System.Drawing.Size(111, 21);
            this.cbthang.TabIndex = 8;
            // 
            // rdqui
            // 
            this.rdqui.AutoSize = true;
            this.rdqui.Enabled = false;
            this.rdqui.Location = new System.Drawing.Point(204, 20);
            this.rdqui.Name = "rdqui";
            this.rdqui.Size = new System.Drawing.Size(43, 17);
            this.rdqui.TabIndex = 6;
            this.rdqui.TabStop = true;
            this.rdqui.Text = "Quí";
            this.rdqui.UseVisualStyleBackColor = true;
            this.rdqui.CheckedChanged += new System.EventHandler(this.rdqui_CheckedChanged);
            // 
            // rdnam
            // 
            this.rdnam.AutoSize = true;
            this.rdnam.Enabled = false;
            this.rdnam.Location = new System.Drawing.Point(396, 20);
            this.rdnam.Name = "rdnam";
            this.rdnam.Size = new System.Drawing.Size(47, 17);
            this.rdnam.TabIndex = 7;
            this.rdnam.TabStop = true;
            this.rdnam.Text = "Năm";
            this.rdnam.UseVisualStyleBackColor = true;
            this.rdnam.CheckedChanged += new System.EventHandler(this.rdnam_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(232, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(575, 74);
            this.dataGridView1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tên kế hoạch:";
            // 
            // txttenkh
            // 
            this.txttenkh.Location = new System.Drawing.Point(232, 17);
            this.txttenkh.Name = "txttenkh";
            this.txttenkh.Size = new System.Drawing.Size(575, 20);
            this.txttenkh.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::LDTBXH.Properties.Resources.process_remove;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Brown;
            this.button2.Location = new System.Drawing.Point(813, 71);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 46);
            this.button2.TabIndex = 1;
            this.button2.Text = "Lập báo cáo";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::LDTBXH.Properties.Resources.Search1;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Brown;
            this.button1.Location = new System.Drawing.Point(813, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 51);
            this.button1.TabIndex = 0;
            this.button1.Text = "Tìm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.crystalReportViewer1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 189);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(928, 260);
            this.panel2.TabIndex = 1;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.SelectionFormula = "";
            this.crystalReportViewer1.Size = new System.Drawing.Size(928, 260);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.ViewTimeSelectionFormula = "";
            // 
            // BCsolieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LDTBXH.Properties.Resources.images;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(928, 449);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "BCsolieu";
            this.Text = "Bao cao so lieu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BCsolieu_FormClosing);
            this.Load += new System.EventHandler(this.BCsolieu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txttenkh;
        private System.Windows.Forms.RadioButton rdnam;
        private System.Windows.Forms.RadioButton rdqui;
        private System.Windows.Forms.RadioButton rdthang;
        private System.Windows.Forms.DataGridView dataGridView1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbnam;
        private System.Windows.Forms.ComboBox cbqui;
        private System.Windows.Forms.ComboBox cbthang;
        private System.Windows.Forms.CheckBox cbdangkhac;
        private System.Windows.Forms.Label lbmakh;
    }
}