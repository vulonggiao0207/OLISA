namespace LDTBXH
{
    partial class DoiTuongUuTien
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
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txthoten = new System.Windows.Forms.TextBox();
            this.txtnguyenquan = new System.Windows.Forms.TextBox();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.txtsodienthoai = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rdnam = new System.Windows.Forms.RadioButton();
            this.rdnu = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.txtnghenghiep = new System.Windows.Forms.TextBox();
            this.dgvdienuutien = new System.Windows.Forms.DataGridView();
            this.dgvdoituong = new System.Windows.Forms.DataGridView();
            this.lbmadt = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cbnam = new System.Windows.Forms.ComboBox();
            this.cbngay = new System.Windows.Forms.ComboBox();
            this.cbthang = new System.Windows.Forms.ComboBox();
            this.lbngaysinh = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnxetduyet = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnhoso = new System.Windows.Forms.Button();
            this.btnthannhan = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btntim = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txthokhau = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdienuutien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdoituong)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(18, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ và tên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(0, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Phái:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(324, 70);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nguyên quán:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(4, 109);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Địa chỉ hiện tại:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(324, 107);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Số Điện thoại:";
            // 
            // txthoten
            // 
            this.txthoten.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txthoten.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txthoten.Location = new System.Drawing.Point(123, 20);
            this.txthoten.Margin = new System.Windows.Forms.Padding(4);
            this.txthoten.Name = "txthoten";
            this.txthoten.Size = new System.Drawing.Size(293, 22);
            this.txthoten.TabIndex = 6;
            this.txthoten.Validating += new System.ComponentModel.CancelEventHandler(this.txthoten_Validating);
            // 
            // txtnguyenquan
            // 
            this.txtnguyenquan.Location = new System.Drawing.Point(442, 66);
            this.txtnguyenquan.Margin = new System.Windows.Forms.Padding(4);
            this.txtnguyenquan.Name = "txtnguyenquan";
            this.txtnguyenquan.Size = new System.Drawing.Size(163, 22);
            this.txtnguyenquan.TabIndex = 9;
            this.txtnguyenquan.Validating += new System.ComponentModel.CancelEventHandler(this.txtnguyenquan_Validating);
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(146, 103);
            this.txtdiachi.Margin = new System.Windows.Forms.Padding(4);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(164, 22);
            this.txtdiachi.TabIndex = 10;
            // 
            // txtsodienthoai
            // 
            this.txtsodienthoai.Location = new System.Drawing.Point(442, 103);
            this.txtsodienthoai.Margin = new System.Windows.Forms.Padding(4);
            this.txtsodienthoai.Name = "txtsodienthoai";
            this.txtsodienthoai.Size = new System.Drawing.Size(162, 22);
            this.txtsodienthoai.TabIndex = 11;
            this.txtsodienthoai.Validating += new System.ComponentModel.CancelEventHandler(this.txtsodienthoai_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(17, 21);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Diện ưu tiên:";
            // 
            // rdnam
            // 
            this.rdnam.AutoSize = true;
            this.rdnam.BackColor = System.Drawing.Color.Transparent;
            this.rdnam.Location = new System.Drawing.Point(146, 24);
            this.rdnam.Margin = new System.Windows.Forms.Padding(4);
            this.rdnam.Name = "rdnam";
            this.rdnam.Size = new System.Drawing.Size(58, 20);
            this.rdnam.TabIndex = 26;
            this.rdnam.TabStop = true;
            this.rdnam.Text = "Nam";
            this.rdnam.UseVisualStyleBackColor = false;
            this.rdnam.CheckedChanged += new System.EventHandler(this.rdnam_CheckedChanged);
            // 
            // rdnu
            // 
            this.rdnu.AutoSize = true;
            this.rdnu.BackColor = System.Drawing.Color.Transparent;
            this.rdnu.Location = new System.Drawing.Point(242, 24);
            this.rdnu.Margin = new System.Windows.Forms.Padding(4);
            this.rdnu.Name = "rdnu";
            this.rdnu.Size = new System.Drawing.Size(45, 20);
            this.rdnu.TabIndex = 27;
            this.rdnu.TabStop = true;
            this.rdnu.Text = "Nữ";
            this.rdnu.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(324, 28);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 16);
            this.label10.TabIndex = 30;
            this.label10.Text = "Nghề nghiệp:";
            // 
            // txtnghenghiep
            // 
            this.txtnghenghiep.Location = new System.Drawing.Point(442, 24);
            this.txtnghenghiep.Margin = new System.Windows.Forms.Padding(4);
            this.txtnghenghiep.Name = "txtnghenghiep";
            this.txtnghenghiep.Size = new System.Drawing.Size(163, 22);
            this.txtnghenghiep.TabIndex = 31;
            this.txtnghenghiep.Validating += new System.ComponentModel.CancelEventHandler(this.txtnghenghiep_Validating);
            // 
            // dgvdienuutien
            // 
            this.dgvdienuutien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvdienuutien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdienuutien.Location = new System.Drawing.Point(112, 15);
            this.dgvdienuutien.Margin = new System.Windows.Forms.Padding(4);
            this.dgvdienuutien.Name = "dgvdienuutien";
            this.dgvdienuutien.ReadOnly = true;
            this.dgvdienuutien.Size = new System.Drawing.Size(251, 119);
            this.dgvdienuutien.TabIndex = 33;
            // 
            // dgvdoituong
            // 
            this.dgvdoituong.AllowUserToAddRows = false;
            this.dgvdoituong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvdoituong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdoituong.Location = new System.Drawing.Point(123, 66);
            this.dgvdoituong.Margin = new System.Windows.Forms.Padding(4);
            this.dgvdoituong.Name = "dgvdoituong";
            this.dgvdoituong.ReadOnly = true;
            this.dgvdoituong.Size = new System.Drawing.Size(595, 126);
            this.dgvdoituong.TabIndex = 34;
            // 
            // lbmadt
            // 
            this.lbmadt.AutoSize = true;
            this.lbmadt.ForeColor = System.Drawing.SystemColors.Control;
            this.lbmadt.Location = new System.Drawing.Point(40, 66);
            this.lbmadt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbmadt.Name = "lbmadt";
            this.lbmadt.Size = new System.Drawing.Size(0, 16);
            this.lbmadt.TabIndex = 36;
            this.lbmadt.TextChanged += new System.EventHandler(this.lbmadt_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.cbnam);
            this.groupBox1.Controls.Add(this.cbngay);
            this.groupBox1.Controls.Add(this.cbthang);
            this.groupBox1.Location = new System.Drawing.Point(123, 199);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(626, 72);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ngày sinh";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(422, 31);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 16);
            this.label9.TabIndex = 24;
            this.label9.Text = "Năm";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(215, 31);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 16);
            this.label11.TabIndex = 23;
            this.label11.Text = "Tháng";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 31);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 16);
            this.label12.TabIndex = 22;
            this.label12.Text = "Ngày";
            // 
            // cbnam
            // 
            this.cbnam.FormattingEnabled = true;
            this.cbnam.Location = new System.Drawing.Point(472, 27);
            this.cbnam.Margin = new System.Windows.Forms.Padding(4);
            this.cbnam.Name = "cbnam";
            this.cbnam.Size = new System.Drawing.Size(122, 24);
            this.cbnam.TabIndex = 21;
            this.cbnam.SelectedValueChanged += new System.EventHandler(this.cbnam_SelectedValueChanged);
            // 
            // cbngay
            // 
            this.cbngay.FormattingEnabled = true;
            this.cbngay.Location = new System.Drawing.Point(68, 27);
            this.cbngay.Margin = new System.Windows.Forms.Padding(4);
            this.cbngay.Name = "cbngay";
            this.cbngay.Size = new System.Drawing.Size(68, 24);
            this.cbngay.TabIndex = 18;
            this.cbngay.SelectedValueChanged += new System.EventHandler(this.cbngay_SelectedValueChanged);
            // 
            // cbthang
            // 
            this.cbthang.FormattingEnabled = true;
            this.cbthang.Location = new System.Drawing.Point(280, 27);
            this.cbthang.Margin = new System.Windows.Forms.Padding(4);
            this.cbthang.Name = "cbthang";
            this.cbthang.Size = new System.Drawing.Size(72, 24);
            this.cbthang.TabIndex = 19;
            this.cbthang.SelectedValueChanged += new System.EventHandler(this.cbthang_SelectedValueChanged);
            // 
            // lbngaysinh
            // 
            this.lbngaysinh.AutoSize = true;
            this.lbngaysinh.BackColor = System.Drawing.Color.Transparent;
            this.lbngaysinh.Location = new System.Drawing.Point(13, 229);
            this.lbngaysinh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbngaysinh.Name = "lbngaysinh";
            this.lbngaysinh.Size = new System.Drawing.Size(83, 16);
            this.lbngaysinh.TabIndex = 42;
            this.lbngaysinh.Text = "lbngaysinh";
            this.lbngaysinh.TextChanged += new System.EventHandler(this.lbngaysinh_TextChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.BackgroundImage = global::LDTBXH.Properties.Resources.process_remove;
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancel.Location = new System.Drawing.Point(475, 581);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(89, 52);
            this.btnCancel.TabIndex = 35;
            this.btnCancel.Text = "Hủy Thao Tác";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnxetduyet
            // 
            this.btnxetduyet.BackgroundImage = global::LDTBXH.Properties.Resources.Modify;
            this.btnxetduyet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnxetduyet.Image = global::LDTBXH.Properties.Resources.bOpen;
            this.btnxetduyet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnxetduyet.Location = new System.Drawing.Point(188, 582);
            this.btnxetduyet.Margin = new System.Windows.Forms.Padding(4);
            this.btnxetduyet.Name = "btnxetduyet";
            this.btnxetduyet.Size = new System.Drawing.Size(102, 52);
            this.btnxetduyet.TabIndex = 32;
            this.btnxetduyet.Text = "Xét duyệt";
            this.btnxetduyet.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnxetduyet.UseVisualStyleBackColor = true;
            this.btnxetduyet.Click += new System.EventHandler(this.btnxetduyet_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.BackgroundImage = global::LDTBXH.Properties.Resources.exit;
            this.btnthoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnthoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnthoat.Location = new System.Drawing.Point(608, 582);
            this.btnthoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(84, 52);
            this.btnthoat.TabIndex = 25;
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
            this.btnluu.Location = new System.Drawing.Point(340, 581);
            this.btnluu.Margin = new System.Windows.Forms.Padding(4);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(84, 52);
            this.btnluu.TabIndex = 24;
            this.btnluu.Text = "Lưu";
            this.btnluu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnhoso
            // 
            this.btnhoso.Image = global::LDTBXH.Properties.Resources.bOpen;
            this.btnhoso.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnhoso.Location = new System.Drawing.Point(389, 65);
            this.btnhoso.Margin = new System.Windows.Forms.Padding(4);
            this.btnhoso.Name = "btnhoso";
            this.btnhoso.Size = new System.Drawing.Size(214, 28);
            this.btnhoso.TabIndex = 23;
            this.btnhoso.Text = "Hồ sơ kèm theo...";
            this.btnhoso.UseVisualStyleBackColor = true;
            this.btnhoso.Click += new System.EventHandler(this.btnhoso_Click);
            // 
            // btnthannhan
            // 
            this.btnthannhan.Image = global::LDTBXH.Properties.Resources.bOpen;
            this.btnthannhan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnthannhan.Location = new System.Drawing.Point(389, 19);
            this.btnthannhan.Margin = new System.Windows.Forms.Padding(4);
            this.btnthannhan.Name = "btnthannhan";
            this.btnthannhan.Size = new System.Drawing.Size(215, 28);
            this.btnthannhan.TabIndex = 22;
            this.btnthannhan.Text = "Thân nhân...";
            this.btnthannhan.UseVisualStyleBackColor = true;
            this.btnthannhan.Click += new System.EventHandler(this.btnthannhan_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.BackgroundImage = global::LDTBXH.Properties.Resources.Xoa;
            this.btnxoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnxoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnxoa.Location = new System.Drawing.Point(726, 66);
            this.btnxoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(64, 55);
            this.btnxoa.TabIndex = 15;
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
            this.btntim.Location = new System.Drawing.Point(425, 13);
            this.btntim.Margin = new System.Windows.Forms.Padding(4);
            this.btntim.Name = "btntim";
            this.btntim.Size = new System.Drawing.Size(70, 41);
            this.btntim.TabIndex = 12;
            this.btntim.Text = "Tìm";
            this.btntim.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btntim.UseVisualStyleBackColor = true;
            this.btntim.Click += new System.EventHandler(this.btntim_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txthokhau);
            this.groupBox2.Controls.Add(this.txtsodienthoai);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtnguyenquan);
            this.groupBox2.Controls.Add(this.txtdiachi);
            this.groupBox2.Controls.Add(this.rdnam);
            this.groupBox2.Controls.Add(this.txtnghenghiep);
            this.groupBox2.Controls.Add(this.rdnu);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(120, 278);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(634, 145);
            this.groupBox2.TabIndex = 43;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết đối tượng";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.dgvdienuutien);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.btnthannhan);
            this.groupBox3.Controls.Add(this.btnhoso);
            this.groupBox3.Location = new System.Drawing.Point(120, 429);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(634, 141);
            this.groupBox3.TabIndex = 44;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin khác";
            // 
            // txthokhau
            // 
            this.txthokhau.Location = new System.Drawing.Point(146, 64);
            this.txthokhau.Name = "txthokhau";
            this.txthokhau.Size = new System.Drawing.Size(161, 22);
            this.txthokhau.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 16);
            this.label3.TabIndex = 33;
            this.label3.Text = "Hộ khẩu thường trú:";
            // 
            // DoiTuongUuTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BackgroundImage = global::LDTBXH.Properties.Resources.images;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(812, 663);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lbngaysinh);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbmadt);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.dgvdoituong);
            this.Controls.Add(this.btnxetduyet);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btntim);
            this.Controls.Add(this.txthoten);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Brown;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DoiTuongUuTien";
            this.Text = "Đối Tượng Ưu Tiên";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DoiTuongUuTien_FormClosing);
            this.Load += new System.EventHandler(this.DoiTuongUuTien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdienuutien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdoituong)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txthoten;
        private System.Windows.Forms.TextBox txtnguyenquan;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.TextBox txtsodienthoai;
        private System.Windows.Forms.Button btntim;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnthannhan;
        private System.Windows.Forms.Button btnhoso;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.RadioButton rdnam;
        private System.Windows.Forms.RadioButton rdnu;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtnghenghiep;
        private System.Windows.Forms.Button btnxetduyet;
        private System.Windows.Forms.DataGridView dgvdienuutien;
        private System.Windows.Forms.DataGridView dgvdoituong;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lbmadt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbnam;
        private System.Windows.Forms.ComboBox cbngay;
        private System.Windows.Forms.ComboBox cbthang;
        private System.Windows.Forms.Label lbngaysinh;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txthokhau;
    }
}