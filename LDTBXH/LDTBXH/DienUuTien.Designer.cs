namespace LDTBXH
{
    partial class DienUuTien
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
            this.label1 = new System.Windows.Forms.Label();
            this.txttendienuutien = new System.Windows.Forms.TextBox();
            this.lstdieukienuutien = new System.Windows.Forms.ListBox();
            this.btnthemdieukienuutien = new System.Windows.Forms.Button();
            this.dgvdienuutien = new System.Windows.Forms.DataGridView();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lbdut = new System.Windows.Forms.Label();
            this.lbdieukien = new System.Windows.Forms.Label();
            this.rtxtnoidungdk = new System.Windows.Forms.RichTextBox();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnxoadieukienuutien = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btntim = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdienuutien)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(9, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên diện ưu tiên:";
            // 
            // txttendienuutien
            // 
            this.txttendienuutien.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txttendienuutien.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txttendienuutien.Location = new System.Drawing.Point(147, 21);
            this.txttendienuutien.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txttendienuutien.Name = "txttendienuutien";
            this.txttendienuutien.Size = new System.Drawing.Size(444, 24);
            this.txttendienuutien.TabIndex = 2;
            // 
            // lstdieukienuutien
            // 
            this.lstdieukienuutien.FormattingEnabled = true;
            this.lstdieukienuutien.ItemHeight = 18;
            this.lstdieukienuutien.Location = new System.Drawing.Point(6, 29);
            this.lstdieukienuutien.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lstdieukienuutien.Name = "lstdieukienuutien";
            this.lstdieukienuutien.Size = new System.Drawing.Size(142, 130);
            this.lstdieukienuutien.TabIndex = 9;
            // 
            // btnthemdieukienuutien
            // 
            this.btnthemdieukienuutien.BackgroundImage = global::LDTBXH.Properties.Resources.Them;
            this.btnthemdieukienuutien.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnthemdieukienuutien.Location = new System.Drawing.Point(171, 29);
            this.btnthemdieukienuutien.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnthemdieukienuutien.Name = "btnthemdieukienuutien";
            this.btnthemdieukienuutien.Size = new System.Drawing.Size(80, 53);
            this.btnthemdieukienuutien.TabIndex = 10;
            this.btnthemdieukienuutien.Text = "Thêm>>";
            this.btnthemdieukienuutien.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnthemdieukienuutien.UseVisualStyleBackColor = true;
            this.btnthemdieukienuutien.Click += new System.EventHandler(this.btnthemdieukienuutien_Click);
            // 
            // dgvdienuutien
            // 
            this.dgvdienuutien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvdienuutien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdienuutien.Location = new System.Drawing.Point(147, 62);
            this.dgvdienuutien.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dgvdienuutien.Name = "dgvdienuutien";
            this.dgvdienuutien.Size = new System.Drawing.Size(446, 154);
            this.dgvdienuutien.TabIndex = 15;
            // 
            // btnCancel
            // 
            this.btnCancel.BackgroundImage = global::LDTBXH.Properties.Resources.process_remove;
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancel.Location = new System.Drawing.Point(178, 399);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(98, 53);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Hủy Thao Tác";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lbdut
            // 
            this.lbdut.AutoSize = true;
            this.lbdut.BackColor = System.Drawing.Color.Transparent;
            this.lbdut.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbdut.Location = new System.Drawing.Point(22, 91);
            this.lbdut.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbdut.Name = "lbdut";
            this.lbdut.Size = new System.Drawing.Size(44, 18);
            this.lbdut.TabIndex = 17;
            this.lbdut.Text = "lbdut";
            this.lbdut.TextChanged += new System.EventHandler(this.lbdut_TextChanged);
            // 
            // lbdieukien
            // 
            this.lbdieukien.AutoSize = true;
            this.lbdieukien.BackColor = System.Drawing.Color.Transparent;
            this.lbdieukien.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbdieukien.Location = new System.Drawing.Point(20, 132);
            this.lbdieukien.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbdieukien.Name = "lbdieukien";
            this.lbdieukien.Size = new System.Drawing.Size(83, 18);
            this.lbdieukien.TabIndex = 19;
            this.lbdieukien.Text = "lbdieukien";
            // 
            // rtxtnoidungdk
            // 
            this.rtxtnoidungdk.Location = new System.Drawing.Point(262, 29);
            this.rtxtnoidungdk.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.rtxtnoidungdk.Name = "rtxtnoidungdk";
            this.rtxtnoidungdk.Size = new System.Drawing.Size(308, 130);
            this.rtxtnoidungdk.TabIndex = 20;
            this.rtxtnoidungdk.Text = "";
            // 
            // btnthoat
            // 
            this.btnthoat.BackgroundImage = global::LDTBXH.Properties.Resources.exit;
            this.btnthoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnthoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnthoat.Location = new System.Drawing.Point(530, 399);
            this.btnthoat.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(80, 53);
            this.btnthoat.TabIndex = 13;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnluu
            // 
            this.btnluu.BackgroundImage = global::LDTBXH.Properties.Resources.Save2;
            this.btnluu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnluu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnluu.Location = new System.Drawing.Point(358, 399);
            this.btnluu.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(80, 53);
            this.btnluu.TabIndex = 12;
            this.btnluu.Text = "Lưu";
            this.btnluu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnxoadieukienuutien
            // 
            this.btnxoadieukienuutien.BackgroundImage = global::LDTBXH.Properties.Resources.Xoa;
            this.btnxoadieukienuutien.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnxoadieukienuutien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnxoadieukienuutien.Location = new System.Drawing.Point(171, 90);
            this.btnxoadieukienuutien.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnxoadieukienuutien.Name = "btnxoadieukienuutien";
            this.btnxoadieukienuutien.Size = new System.Drawing.Size(81, 52);
            this.btnxoadieukienuutien.TabIndex = 11;
            this.btnxoadieukienuutien.Text = "Xóa";
            this.btnxoadieukienuutien.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnxoadieukienuutien.UseVisualStyleBackColor = true;
            this.btnxoadieukienuutien.Click += new System.EventHandler(this.btnxoadieukienuutien_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.BackgroundImage = global::LDTBXH.Properties.Resources.Xoa;
            this.btnxoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnxoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnxoa.Location = new System.Drawing.Point(613, 66);
            this.btnxoa.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(64, 47);
            this.btnxoa.TabIndex = 4;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btntim
            // 
            this.btntim.BackgroundImage = global::LDTBXH.Properties.Resources.Search1;
            this.btntim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btntim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btntim.Location = new System.Drawing.Point(613, 10);
            this.btntim.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btntim.Name = "btntim";
            this.btntim.Size = new System.Drawing.Size(64, 47);
            this.btntim.TabIndex = 3;
            this.btntim.Text = "Tìm";
            this.btntim.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btntim.UseVisualStyleBackColor = true;
            this.btntim.Click += new System.EventHandler(this.btntim_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnthemdieukienuutien);
            this.groupBox1.Controls.Add(this.rtxtnoidungdk);
            this.groupBox1.Controls.Add(this.lstdieukienuutien);
            this.groupBox1.Controls.Add(this.btnxoadieukienuutien);
            this.groupBox1.Location = new System.Drawing.Point(147, 223);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(578, 173);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Điều kiện xét duyệt";
            // 
            // DienUuTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BackgroundImage = global::LDTBXH.Properties.Resources.images;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(742, 488);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbdieukien);
            this.Controls.Add(this.lbdut);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.dgvdienuutien);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btntim);
            this.Controls.Add(this.txttendienuutien);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Brown;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "DienUuTien";
            this.Text = "Diện Ưu Tiên";
            this.Activated += new System.EventHandler(this.DienUuTien_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DienUuTien_FormClosing);
            this.Load += new System.EventHandler(this.DienUuTien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdienuutien)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txttendienuutien;
        private System.Windows.Forms.Button btntim;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.ListBox lstdieukienuutien;
        private System.Windows.Forms.Button btnthemdieukienuutien;
        private System.Windows.Forms.Button btnxoadieukienuutien;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.DataGridView dgvdienuutien;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lbdut;
        private System.Windows.Forms.Label lbdieukien;
        private System.Windows.Forms.RichTextBox rtxtnoidungdk;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}