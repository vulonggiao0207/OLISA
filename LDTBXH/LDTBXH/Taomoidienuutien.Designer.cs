namespace LDTBXH
{
    partial class Taomoidienuutien
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
            this.txttendut = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btmtaomoi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(20, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên diện ưu tiên:";
            // 
            // txttendut
            // 
            this.txttendut.Location = new System.Drawing.Point(175, 25);
            this.txttendut.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txttendut.Name = "txttendut";
            this.txttendut.Size = new System.Drawing.Size(344, 24);
            this.txttendut.TabIndex = 3;
            this.txttendut.Validating += new System.ComponentModel.CancelEventHandler(this.txttendut_Validating);
            this.txttendut.TextChanged += new System.EventHandler(this.txttendut_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 18);
            this.label2.TabIndex = 4;
            // 
            // btnthoat
            // 
            this.btnthoat.BackgroundImage = global::LDTBXH.Properties.Resources.exit;
            this.btnthoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnthoat.Location = new System.Drawing.Point(378, 73);
            this.btnthoat.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(89, 57);
            this.btnthoat.TabIndex = 1;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btmtaomoi
            // 
            this.btmtaomoi.BackgroundImage = global::LDTBXH.Properties.Resources.Them;
            this.btmtaomoi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btmtaomoi.Location = new System.Drawing.Point(214, 73);
            this.btmtaomoi.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btmtaomoi.Name = "btmtaomoi";
            this.btmtaomoi.Size = new System.Drawing.Size(88, 57);
            this.btmtaomoi.TabIndex = 0;
            this.btmtaomoi.Text = "Tạo mới";
            this.btmtaomoi.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btmtaomoi.UseVisualStyleBackColor = true;
            this.btmtaomoi.Click += new System.EventHandler(this.btmtaomoi_Click);
            // 
            // Taomoidienuutien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BackgroundImage = global::LDTBXH.Properties.Resources.images;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(550, 159);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txttendut);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btmtaomoi);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Brown;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Taomoidienuutien";
            this.Text = "Tao moi dien uu tien";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Taomoidienuutien_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btmtaomoi;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txttendut;
        private System.Windows.Forms.Label label2;
    }
}