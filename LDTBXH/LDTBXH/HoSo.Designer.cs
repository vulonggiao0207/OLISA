namespace LDTBXH
{
    partial class HoSo
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
            this.txttenhoso = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvhoso = new System.Windows.Forms.DataGridView();
            this.btnthem = new System.Windows.Forms.Button();
            this.rtxtnoidung = new System.Windows.Forms.RichTextBox();
            this.lbhs = new System.Windows.Forms.Label();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvhoso)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(72, 96);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên hồ sơ:";
            // 
            // txttenhoso
            // 
            this.txttenhoso.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txttenhoso.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txttenhoso.Location = new System.Drawing.Point(193, 92);
            this.txttenhoso.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txttenhoso.Name = "txttenhoso";
            this.txttenhoso.Size = new System.Drawing.Size(428, 24);
            this.txttenhoso.TabIndex = 3;
            this.txttenhoso.Validating += new System.ComponentModel.CancelEventHandler(this.txttenhoso_Validating);
            this.txttenhoso.TextChanged += new System.EventHandler(this.txttenhoso_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(72, 146);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nội dung:";
            // 
            // dgvhoso
            // 
            this.dgvhoso.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvhoso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvhoso.Location = new System.Drawing.Point(193, 284);
            this.dgvhoso.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dgvhoso.Name = "dgvhoso";
            this.dgvhoso.ReadOnly = true;
            this.dgvhoso.Size = new System.Drawing.Size(515, 194);
            this.dgvhoso.TabIndex = 6;
            // 
            // btnthem
            // 
            this.btnthem.BackgroundImage = global::LDTBXH.Properties.Resources.Them;
            this.btnthem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnthem.Location = new System.Drawing.Point(100, 311);
            this.btnthem.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(71, 61);
            this.btnthem.TabIndex = 7;
            this.btnthem.Text = "Thêm hồ sơ";
            this.btnthem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // rtxtnoidung
            // 
            this.rtxtnoidung.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtnoidung.Location = new System.Drawing.Point(193, 133);
            this.rtxtnoidung.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.rtxtnoidung.Name = "rtxtnoidung";
            this.rtxtnoidung.Size = new System.Drawing.Size(513, 141);
            this.rtxtnoidung.TabIndex = 11;
            this.rtxtnoidung.Text = "";
            // 
            // lbhs
            // 
            this.lbhs.AutoSize = true;
            this.lbhs.BackColor = System.Drawing.Color.Transparent;
            this.lbhs.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbhs.Location = new System.Drawing.Point(72, 244);
            this.lbhs.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbhs.Name = "lbhs";
            this.lbhs.Size = new System.Drawing.Size(39, 18);
            this.lbhs.TabIndex = 14;
            this.lbhs.Text = "lbhs";
            // 
            // btnTim
            // 
            this.btnTim.BackgroundImage = global::LDTBXH.Properties.Resources.Search1;
            this.btnTim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTim.Location = new System.Drawing.Point(643, 79);
            this.btnTim.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(63, 46);
            this.btnTim.TabIndex = 13;
            this.btnTim.Text = "Tìm";
            this.btnTim.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackgroundImage = global::LDTBXH.Properties.Resources.process_remove;
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancel.Location = new System.Drawing.Point(283, 498);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 52);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Hủy Thao Tác";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.BackgroundImage = global::LDTBXH.Properties.Resources.exit;
            this.btnthoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnthoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnthoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnthoat.Location = new System.Drawing.Point(596, 498);
            this.btnthoat.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(89, 52);
            this.btnthoat.TabIndex = 10;
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
            this.btnluu.Location = new System.Drawing.Point(440, 498);
            this.btnluu.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(89, 52);
            this.btnluu.TabIndex = 9;
            this.btnluu.Text = "Lưu";
            this.btnluu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.BackgroundImage = global::LDTBXH.Properties.Resources.Xoa;
            this.btnxoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnxoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnxoa.Location = new System.Drawing.Point(100, 395);
            this.btnxoa.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(71, 61);
            this.btnxoa.TabIndex = 8;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // HoSo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BackgroundImage = global::LDTBXH.Properties.Resources.Notepad;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnthoat;
            this.ClientSize = new System.Drawing.Size(816, 608);
            this.Controls.Add(this.lbhs);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.rtxtnoidung);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.dgvhoso);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txttenhoso);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Brown;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "HoSo";
            this.Text = "Hồ Sơ";
            this.Activated += new System.EventHandler(this.HoSo_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HoSo_FormClosing);
            this.Load += new System.EventHandler(this.HoSo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvhoso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txttenhoso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvhoso;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.RichTextBox rtxtnoidung;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Label lbhs;
    }
}