namespace LDTBXH
{
    partial class Xetduyet
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
            this.cklbdieukien = new System.Windows.Forms.CheckedListBox();
            this.btnxetduyet = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btntim = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txttendoituong = new System.Windows.Forms.TextBox();
            this.txtdienuutien = new System.Windows.Forms.TextBox();
            this.rtxtnoidung = new System.Windows.Forms.RichTextBox();
            this.dgvdienuutien = new System.Windows.Forms.DataGridView();
            this.lbdut = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdienuutien)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cklbdieukien
            // 
            this.cklbdieukien.FormattingEnabled = true;
            this.cklbdieukien.Location = new System.Drawing.Point(19, 22);
            this.cklbdieukien.Margin = new System.Windows.Forms.Padding(4);
            this.cklbdieukien.Name = "cklbdieukien";
            this.cklbdieukien.Size = new System.Drawing.Size(155, 174);
            this.cklbdieukien.TabIndex = 0;
            this.cklbdieukien.SelectedIndexChanged += new System.EventHandler(this.cklbdieukien_SelectedIndexChanged);
            this.cklbdieukien.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.cklbdieukien_ItemCheck);
            // 
            // btnxetduyet
            // 
            this.btnxetduyet.BackgroundImage = global::LDTBXH.Properties.Resources.Modify;
            this.btnxetduyet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnxetduyet.Enabled = false;
            this.btnxetduyet.Location = new System.Drawing.Point(231, 415);
            this.btnxetduyet.Margin = new System.Windows.Forms.Padding(4);
            this.btnxetduyet.Name = "btnxetduyet";
            this.btnxetduyet.Size = new System.Drawing.Size(91, 46);
            this.btnxetduyet.TabIndex = 1;
            this.btnxetduyet.Text = "Xét ";
            this.btnxetduyet.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnxetduyet.UseVisualStyleBackColor = true;
            this.btnxetduyet.Click += new System.EventHandler(this.btnxetduyet_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.BackgroundImage = global::LDTBXH.Properties.Resources.exit;
            this.btnthoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnthoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnthoat.Location = new System.Drawing.Point(434, 415);
            this.btnthoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(86, 46);
            this.btnthoat.TabIndex = 2;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btntim
            // 
            this.btntim.BackgroundImage = global::LDTBXH.Properties.Resources.Search1;
            this.btntim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btntim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btntim.Location = new System.Drawing.Point(538, 44);
            this.btntim.Margin = new System.Windows.Forms.Padding(4);
            this.btntim.Name = "btntim";
            this.btntim.Size = new System.Drawing.Size(66, 42);
            this.btntim.TabIndex = 3;
            this.btntim.Text = "Tìm";
            this.btntim.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btntim.UseVisualStyleBackColor = true;
            this.btntim.Click += new System.EventHandler(this.btntim_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(18, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tên đối tượng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(18, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Diện ưu tiên:";
            // 
            // txttendoituong
            // 
            this.txttendoituong.Location = new System.Drawing.Point(142, 18);
            this.txttendoituong.Margin = new System.Windows.Forms.Padding(4);
            this.txttendoituong.Name = "txttendoituong";
            this.txttendoituong.ReadOnly = true;
            this.txttendoituong.Size = new System.Drawing.Size(378, 22);
            this.txttendoituong.TabIndex = 6;
            // 
            // txtdienuutien
            // 
            this.txtdienuutien.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtdienuutien.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtdienuutien.Location = new System.Drawing.Point(142, 57);
            this.txtdienuutien.Margin = new System.Windows.Forms.Padding(4);
            this.txtdienuutien.Name = "txtdienuutien";
            this.txtdienuutien.Size = new System.Drawing.Size(378, 22);
            this.txtdienuutien.TabIndex = 7;
            // 
            // rtxtnoidung
            // 
            this.rtxtnoidung.Location = new System.Drawing.Point(198, 22);
            this.rtxtnoidung.Margin = new System.Windows.Forms.Padding(4);
            this.rtxtnoidung.Name = "rtxtnoidung";
            this.rtxtnoidung.Size = new System.Drawing.Size(348, 170);
            this.rtxtnoidung.TabIndex = 11;
            this.rtxtnoidung.Text = "";
            // 
            // dgvdienuutien
            // 
            this.dgvdienuutien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvdienuutien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdienuutien.Location = new System.Drawing.Point(77, 94);
            this.dgvdienuutien.Margin = new System.Windows.Forms.Padding(4);
            this.dgvdienuutien.Name = "dgvdienuutien";
            this.dgvdienuutien.Size = new System.Drawing.Size(542, 95);
            this.dgvdienuutien.TabIndex = 12;
            // 
            // lbdut
            // 
            this.lbdut.AutoSize = true;
            this.lbdut.BackColor = System.Drawing.Color.Transparent;
            this.lbdut.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbdut.Location = new System.Drawing.Point(18, 110);
            this.lbdut.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbdut.Name = "lbdut";
            this.lbdut.Size = new System.Drawing.Size(0, 16);
            this.lbdut.TabIndex = 13;
            this.lbdut.TextChanged += new System.EventHandler(this.lbdut_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.rtxtnoidung);
            this.groupBox1.Controls.Add(this.cklbdieukien);
            this.groupBox1.Location = new System.Drawing.Point(73, 196);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(553, 207);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Điều kiện xét duyệt";
            // 
            // Xetduyet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BackgroundImage = global::LDTBXH.Properties.Resources.images;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(638, 475);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbdut);
            this.Controls.Add(this.dgvdienuutien);
            this.Controls.Add(this.txtdienuutien);
            this.Controls.Add(this.txttendoituong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btntim);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnxetduyet);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Brown;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Xetduyet";
            this.Text = "Xét Duyệt";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Xetduyet_FormClosing);
            this.Load += new System.EventHandler(this.Xetduyet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdienuutien)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox cklbdieukien;
        private System.Windows.Forms.Button btnxetduyet;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btntim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txttendoituong;
        private System.Windows.Forms.TextBox txtdienuutien;
        private System.Windows.Forms.RichTextBox rtxtnoidung;
        private System.Windows.Forms.DataGridView dgvdienuutien;
        private System.Windows.Forms.Label lbdut;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}