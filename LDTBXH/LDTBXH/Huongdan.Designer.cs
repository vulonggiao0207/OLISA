namespace LDTBXH
{
    partial class Huongdan
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
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Thêm Người Sử Dụng");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Tìm Đối Tượng");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Xem Kế Hoạch", new System.Windows.Forms.TreeNode[] {
            treeNode15});
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Thân Nhân");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Hồ Sơ Kèm Theo");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Xét Duyệt");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Đối Tượng Ưu Tiên", new System.Windows.Forms.TreeNode[] {
            treeNode17,
            treeNode18,
            treeNode19});
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Diện Ưu Tiên");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Kế Hoạch");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("Danh Sách Đối Tượng");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("Số Liệu Tổng Hợp");
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("In Báo Cáo", new System.Windows.Forms.TreeNode[] {
            treeNode23,
            treeNode24});
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("MainForm", new System.Windows.Forms.TreeNode[] {
            treeNode14,
            treeNode16,
            treeNode20,
            treeNode21,
            treeNode22,
            treeNode25});
            this.rtxthuongdan = new System.Windows.Forms.RichTextBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // rtxthuongdan
            // 
            this.rtxthuongdan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxthuongdan.Location = new System.Drawing.Point(282, 12);
            this.rtxthuongdan.Name = "rtxthuongdan";
            this.rtxthuongdan.Size = new System.Drawing.Size(192, 300);
            this.rtxthuongdan.TabIndex = 0;
            this.rtxthuongdan.Text = "";
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.treeView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView1.ItemHeight = 35;
            this.treeView1.Location = new System.Drawing.Point(12, 12);
            this.treeView1.Name = "treeView1";
            treeNode14.Name = "Themnguoidung";
            treeNode14.Text = "Thêm Người Sử Dụng";
            treeNode15.Name = "Timdt";
            treeNode15.Text = "Tìm Đối Tượng";
            treeNode16.Name = "Xemkh";
            treeNode16.Text = "Xem Kế Hoạch";
            treeNode17.Name = "Thannhan";
            treeNode17.Text = "Thân Nhân";
            treeNode18.Name = "HoSo";
            treeNode18.Text = "Hồ Sơ Kèm Theo";
            treeNode19.Name = "xetduyet";
            treeNode19.Text = "Xét Duyệt";
            treeNode20.Name = "DTUT";
            treeNode20.Text = "Đối Tượng Ưu Tiên";
            treeNode21.Name = "DienUT";
            treeNode21.Text = "Diện Ưu Tiên";
            treeNode22.Name = "Kehoach";
            treeNode22.Text = "Kế Hoạch";
            treeNode23.Name = "dsdoituong";
            treeNode23.Text = "Danh Sách Đối Tượng";
            treeNode24.Name = "solieu";
            treeNode24.Text = "Số Liệu Tổng Hợp";
            treeNode25.Name = "InBaocao";
            treeNode25.Text = "In Báo Cáo";
            treeNode26.Name = "Mainform";
            treeNode26.Text = "MainForm";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode26});
            this.treeView1.Size = new System.Drawing.Size(264, 300);
            this.treeView1.TabIndex = 1;
            // 
            // Huongdan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 324);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.rtxthuongdan);
            this.Name = "Huongdan";
            this.Text = "Huong Dan";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Huongdan_FormClosing);
            this.Load += new System.EventHandler(this.Huongdan_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxthuongdan;
        private System.Windows.Forms.TreeView treeView1;
    }
}