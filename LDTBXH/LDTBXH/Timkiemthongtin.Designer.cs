namespace LDTBXH
{
    partial class Timkiemthongtin
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
            this.btntim = new System.Windows.Forms.Button();
            this.dgvthongtin = new System.Windows.Forms.DataGridView();
            this.cbthongtin = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbnamketthuc = new System.Windows.Forms.ComboBox();
            this.cbthangketthuc = new System.Windows.Forms.ComboBox();
            this.cbngayketthuc = new System.Windows.Forms.ComboBox();
            this.cbnamtrienkhai = new System.Windows.Forms.ComboBox();
            this.cbthangtrienkhai = new System.Windows.Forms.ComboBox();
            this.cbngaytrienkhai = new System.Windows.Forms.ComboBox();
            this.rdkehoach = new System.Windows.Forms.RadioButton();
            this.rddienuutien = new System.Windows.Forms.RadioButton();
            this.rddoituong = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvthongtin)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btntim
            // 
            this.btntim.BackgroundImage = global::LDTBXH.Properties.Resources.Search1;
            this.btntim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btntim.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntim.ForeColor = System.Drawing.Color.Brown;
            this.btntim.Location = new System.Drawing.Point(780, 14);
            this.btntim.Name = "btntim";
            this.btntim.Size = new System.Drawing.Size(75, 49);
            this.btntim.TabIndex = 0;
            this.btntim.Text = "Tìm";
            this.btntim.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btntim.UseVisualStyleBackColor = true;
            this.btntim.Click += new System.EventHandler(this.btntim_Click);
            // 
            // dgvthongtin
            // 
            this.dgvthongtin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvthongtin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvthongtin.Location = new System.Drawing.Point(139, 142);
            this.dgvthongtin.Name = "dgvthongtin";
            this.dgvthongtin.Size = new System.Drawing.Size(716, 327);
            this.dgvthongtin.TabIndex = 4;
            // 
            // cbthongtin
            // 
            this.cbthongtin.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbthongtin.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbthongtin.FormattingEnabled = true;
            this.cbthongtin.Location = new System.Drawing.Point(139, 16);
            this.cbthongtin.Name = "cbthongtin";
            this.cbthongtin.Size = new System.Drawing.Size(635, 21);
            this.cbthongtin.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.rdkehoach);
            this.groupBox1.Controls.Add(this.rddienuutien);
            this.groupBox1.Controls.Add(this.rddoituong);
            this.groupBox1.Location = new System.Drawing.Point(139, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(635, 93);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm theo";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cbnamketthuc);
            this.groupBox2.Controls.Add(this.cbthangketthuc);
            this.groupBox2.Controls.Add(this.cbngayketthuc);
            this.groupBox2.Controls.Add(this.cbnamtrienkhai);
            this.groupBox2.Controls.Add(this.cbthangtrienkhai);
            this.groupBox2.Controls.Add(this.cbngaytrienkhai);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(265, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(364, 78);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Đến ngày:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Từ ngày:";
            // 
            // cbnamketthuc
            // 
            this.cbnamketthuc.FormattingEnabled = true;
            this.cbnamketthuc.Location = new System.Drawing.Point(254, 47);
            this.cbnamketthuc.Name = "cbnamketthuc";
            this.cbnamketthuc.Size = new System.Drawing.Size(95, 21);
            this.cbnamketthuc.TabIndex = 8;
            this.cbnamketthuc.SelectedValueChanged += new System.EventHandler(this.cbnamketthuc_SelectedValueChanged);
            // 
            // cbthangketthuc
            // 
            this.cbthangketthuc.FormattingEnabled = true;
            this.cbthangketthuc.Location = new System.Drawing.Point(169, 47);
            this.cbthangketthuc.Name = "cbthangketthuc";
            this.cbthangketthuc.Size = new System.Drawing.Size(79, 21);
            this.cbthangketthuc.TabIndex = 7;
            this.cbthangketthuc.SelectedValueChanged += new System.EventHandler(this.cbthangketthuc_SelectedValueChanged);
            // 
            // cbngayketthuc
            // 
            this.cbngayketthuc.FormattingEnabled = true;
            this.cbngayketthuc.Location = new System.Drawing.Point(85, 47);
            this.cbngayketthuc.Name = "cbngayketthuc";
            this.cbngayketthuc.Size = new System.Drawing.Size(78, 21);
            this.cbngayketthuc.TabIndex = 6;
            // 
            // cbnamtrienkhai
            // 
            this.cbnamtrienkhai.FormattingEnabled = true;
            this.cbnamtrienkhai.Location = new System.Drawing.Point(254, 15);
            this.cbnamtrienkhai.Name = "cbnamtrienkhai";
            this.cbnamtrienkhai.Size = new System.Drawing.Size(95, 21);
            this.cbnamtrienkhai.TabIndex = 5;
            this.cbnamtrienkhai.SelectedValueChanged += new System.EventHandler(this.cbnamtrienkhai_SelectedValueChanged);
            // 
            // cbthangtrienkhai
            // 
            this.cbthangtrienkhai.FormattingEnabled = true;
            this.cbthangtrienkhai.Location = new System.Drawing.Point(169, 15);
            this.cbthangtrienkhai.Name = "cbthangtrienkhai";
            this.cbthangtrienkhai.Size = new System.Drawing.Size(79, 21);
            this.cbthangtrienkhai.TabIndex = 4;
            this.cbthangtrienkhai.SelectedValueChanged += new System.EventHandler(this.cbthangtrienkhai_SelectedValueChanged);
            // 
            // cbngaytrienkhai
            // 
            this.cbngaytrienkhai.FormattingEnabled = true;
            this.cbngaytrienkhai.Location = new System.Drawing.Point(85, 15);
            this.cbngaytrienkhai.Name = "cbngaytrienkhai";
            this.cbngaytrienkhai.Size = new System.Drawing.Size(78, 21);
            this.cbngaytrienkhai.TabIndex = 3;
            // 
            // rdkehoach
            // 
            this.rdkehoach.AutoSize = true;
            this.rdkehoach.Location = new System.Drawing.Point(188, 24);
            this.rdkehoach.Name = "rdkehoach";
            this.rdkehoach.Size = new System.Drawing.Size(71, 17);
            this.rdkehoach.TabIndex = 2;
            this.rdkehoach.Text = "Kế hoạch";
            this.rdkehoach.UseVisualStyleBackColor = true;
            this.rdkehoach.CheckedChanged += new System.EventHandler(this.rdkehoach_CheckedChanged);
            // 
            // rddienuutien
            // 
            this.rddienuutien.AutoSize = true;
            this.rddienuutien.Location = new System.Drawing.Point(43, 59);
            this.rddienuutien.Name = "rddienuutien";
            this.rddienuutien.Size = new System.Drawing.Size(82, 17);
            this.rddienuutien.TabIndex = 1;
            this.rddienuutien.Text = "Diện ưu tiên";
            this.rddienuutien.UseVisualStyleBackColor = true;
            this.rddienuutien.CheckedChanged += new System.EventHandler(this.rddienuutien_CheckedChanged);
            // 
            // rddoituong
            // 
            this.rddoituong.AutoSize = true;
            this.rddoituong.Location = new System.Drawing.Point(43, 24);
            this.rddoituong.Name = "rddoituong";
            this.rddoituong.Size = new System.Drawing.Size(71, 17);
            this.rddoituong.TabIndex = 0;
            this.rddoituong.Text = "Đối tượng";
            this.rddoituong.UseVisualStyleBackColor = true;
            // 
            // Timkiemthongtin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LDTBXH.Properties.Resources.images;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(956, 500);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbthongtin);
            this.Controls.Add(this.dgvthongtin);
            this.Controls.Add(this.btntim);
            this.Name = "Timkiemthongtin";
            this.Text = "Timkiemthongtin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Timkiemthongtin_FormClosing);
            this.Load += new System.EventHandler(this.Timkiemthongtin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvthongtin)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btntim;
        private System.Windows.Forms.DataGridView dgvthongtin;
        private System.Windows.Forms.ComboBox cbthongtin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbnamketthuc;
        private System.Windows.Forms.ComboBox cbthangketthuc;
        private System.Windows.Forms.ComboBox cbngayketthuc;
        private System.Windows.Forms.ComboBox cbnamtrienkhai;
        private System.Windows.Forms.ComboBox cbthangtrienkhai;
        private System.Windows.Forms.ComboBox cbngaytrienkhai;
        private System.Windows.Forms.RadioButton rdkehoach;
        private System.Windows.Forms.RadioButton rddienuutien;
        private System.Windows.Forms.RadioButton rddoituong;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}