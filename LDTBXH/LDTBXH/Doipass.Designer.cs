namespace LDTBXH
{
    partial class Doipass
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
            this.btndoi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txttkhoan = new System.Windows.Forms.TextBox();
            this.txtmkhau = new System.Windows.Forms.TextBox();
            this.txtmkmoi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtnhaplai = new System.Windows.Forms.TextBox();
            this.lbdoipass = new System.Windows.Forms.Label();
            this.btnthoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btndoi
            // 
            this.btndoi.BackgroundImage = global::LDTBXH.Properties.Resources.Modify;
            this.btndoi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btndoi.Location = new System.Drawing.Point(191, 246);
            this.btndoi.Margin = new System.Windows.Forms.Padding(4);
            this.btndoi.Name = "btndoi";
            this.btndoi.Size = new System.Drawing.Size(80, 48);
            this.btndoi.TabIndex = 4;
            this.btndoi.Text = "Đổi ";
            this.btndoi.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btndoi.UseVisualStyleBackColor = true;
            this.btndoi.Click += new System.EventHandler(this.btndoi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(20, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tài khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(20, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mật khẩu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(20, 122);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mật khẩu mới:";
            // 
            // txttkhoan
            // 
            this.txttkhoan.Location = new System.Drawing.Point(147, 30);
            this.txttkhoan.Margin = new System.Windows.Forms.Padding(4);
            this.txttkhoan.MaxLength = 20;
            this.txttkhoan.Name = "txttkhoan";
            this.txttkhoan.Size = new System.Drawing.Size(273, 24);
            this.txttkhoan.TabIndex = 0;
            this.txttkhoan.Validating += new System.ComponentModel.CancelEventHandler(this.txttkhoan_Validating);
            // 
            // txtmkhau
            // 
            this.txtmkhau.Location = new System.Drawing.Point(147, 71);
            this.txtmkhau.Margin = new System.Windows.Forms.Padding(4);
            this.txtmkhau.MaxLength = 32;
            this.txtmkhau.Name = "txtmkhau";
            this.txtmkhau.PasswordChar = '*';
            this.txtmkhau.Size = new System.Drawing.Size(273, 24);
            this.txtmkhau.TabIndex = 1;
            this.txtmkhau.Validating += new System.ComponentModel.CancelEventHandler(this.txtmkhau_Validating);
            // 
            // txtmkmoi
            // 
            this.txtmkmoi.Location = new System.Drawing.Point(147, 118);
            this.txtmkmoi.Margin = new System.Windows.Forms.Padding(4);
            this.txtmkmoi.MaxLength = 32;
            this.txtmkmoi.Name = "txtmkmoi";
            this.txtmkmoi.PasswordChar = '*';
            this.txtmkmoi.Size = new System.Drawing.Size(273, 24);
            this.txtmkmoi.TabIndex = 2;
            this.txtmkmoi.Validating += new System.ComponentModel.CancelEventHandler(this.txtmkmoi_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(20, 169);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nhập lại";
            // 
            // txtnhaplai
            // 
            this.txtnhaplai.Location = new System.Drawing.Point(147, 165);
            this.txtnhaplai.Margin = new System.Windows.Forms.Padding(4);
            this.txtnhaplai.MaxLength = 32;
            this.txtnhaplai.Name = "txtnhaplai";
            this.txtnhaplai.PasswordChar = '*';
            this.txtnhaplai.Size = new System.Drawing.Size(273, 24);
            this.txtnhaplai.TabIndex = 3;
            // 
            // lbdoipass
            // 
            this.lbdoipass.AutoSize = true;
            this.lbdoipass.BackColor = System.Drawing.Color.Transparent;
            this.lbdoipass.Location = new System.Drawing.Point(142, 209);
            this.lbdoipass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbdoipass.Name = "lbdoipass";
            this.lbdoipass.Size = new System.Drawing.Size(147, 18);
            this.lbdoipass.TabIndex = 10;
            this.lbdoipass.Text = "Mời nhập thông tin";
            // 
            // btnthoat
            // 
            this.btnthoat.BackgroundImage = global::LDTBXH.Properties.Resources.exit;
            this.btnthoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnthoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnthoat.Location = new System.Drawing.Point(305, 246);
            this.btnthoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(82, 48);
            this.btnthoat.TabIndex = 5;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // Doipass
            // 
            this.AcceptButton = this.btndoi;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BackgroundImage = global::LDTBXH.Properties.Resources.images;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnthoat;
            this.ClientSize = new System.Drawing.Size(457, 324);
            this.Controls.Add(this.lbdoipass);
            this.Controls.Add(this.txtnhaplai);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.txtmkmoi);
            this.Controls.Add(this.txtmkhau);
            this.Controls.Add(this.txttkhoan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btndoi);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Brown;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Doipass";
            this.Text = "Đổi Password";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Doipass_FormClosing);
            this.Load += new System.EventHandler(this.Doipass_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btndoi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txttkhoan;
        private System.Windows.Forms.TextBox txtmkhau;
        private System.Windows.Forms.TextBox txtmkmoi;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtnhaplai;
        private System.Windows.Forms.Label lbdoipass;
    }
}