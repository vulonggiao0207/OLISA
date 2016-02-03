namespace LDTBXH
{
    partial class Themcongvan
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
            this.txtkehoach = new System.Windows.Forms.TextBox();
            this.txttencv = new System.Windows.Forms.TextBox();
            this.rtxtnoidungcv = new System.Windows.Forms.RichTextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(109, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kế hoạch";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(109, 136);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tiêu đề Công văn";
            // 
            // txtkehoach
            // 
            this.txtkehoach.Location = new System.Drawing.Point(281, 74);
            this.txtkehoach.Margin = new System.Windows.Forms.Padding(4);
            this.txtkehoach.Name = "txtkehoach";
            this.txtkehoach.ReadOnly = true;
            this.txtkehoach.Size = new System.Drawing.Size(300, 24);
            this.txtkehoach.TabIndex = 2;
            // 
            // txttencv
            // 
            this.txttencv.Location = new System.Drawing.Point(281, 132);
            this.txttencv.Margin = new System.Windows.Forms.Padding(4);
            this.txttencv.Name = "txttencv";
            this.txttencv.Size = new System.Drawing.Size(300, 24);
            this.txttencv.TabIndex = 3;
            // 
            // rtxtnoidungcv
            // 
            this.rtxtnoidungcv.Location = new System.Drawing.Point(113, 182);
            this.rtxtnoidungcv.Margin = new System.Windows.Forms.Padding(4);
            this.rtxtnoidungcv.Name = "rtxtnoidungcv";
            this.rtxtnoidungcv.Size = new System.Drawing.Size(465, 164);
            this.rtxtnoidungcv.TabIndex = 4;
            this.rtxtnoidungcv.Text = "";
            // 
            // btnThoat
            // 
            this.btnThoat.BackgroundImage = global::LDTBXH.Properties.Resources.exit;
            this.btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnThoat.Location = new System.Drawing.Point(430, 374);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(82, 52);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackgroundImage = global::LDTBXH.Properties.Resources.Them;
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThem.Location = new System.Drawing.Point(253, 374);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(82, 52);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // Themcongvan
            // 
            this.AcceptButton = this.btnThem;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BackgroundImage = global::LDTBXH.Properties.Resources.congvan;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnThoat;
            this.ClientSize = new System.Drawing.Size(786, 502);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.rtxtnoidungcv);
            this.Controls.Add(this.txttencv);
            this.Controls.Add(this.txtkehoach);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Brown;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Themcongvan";
            this.Text = "Thêm Công Văn";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Themcongvan_FormClosing);
            this.Load += new System.EventHandler(this.Themcongvan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtkehoach;
        private System.Windows.Forms.TextBox txttencv;
        private System.Windows.Forms.RichTextBox rtxtnoidungcv;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnThoat;
    }
}