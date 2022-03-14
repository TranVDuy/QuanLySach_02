namespace QuanLySach
{
    partial class FormSach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSach));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNapLai = new System.Windows.Forms.ToolStripButton();
            this.btnThemMoi = new System.Windows.Forms.ToolStripButton();
            this.btnChinhSua = new System.Windows.Forms.ToolStripButton();
            this.btnXoa = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblThongKe = new System.Windows.Forms.ToolStripStatusLabel();
            this.gridSach = new System.Windows.Forms.DataGridView();
            this.colMaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTieuDe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTacGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNhaXuatBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSach)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNapLai,
            this.btnThemMoi,
            this.btnChinhSua,
            this.btnXoa});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(765, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnNapLai
            // 
            this.btnNapLai.Image = ((System.Drawing.Image)(resources.GetObject("btnNapLai.Image")));
            this.btnNapLai.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNapLai.Name = "btnNapLai";
            this.btnNapLai.Size = new System.Drawing.Size(81, 24);
            this.btnNapLai.Text = "Nạp lại";
            this.btnNapLai.Click += new System.EventHandler(this.btnNapLai_Click);
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Image = ((System.Drawing.Image)(resources.GetObject("btnThemMoi.Image")));
            this.btnThemMoi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(100, 24);
            this.btnThemMoi.Text = "Thêm mới";
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // btnChinhSua
            // 
            this.btnChinhSua.Image = ((System.Drawing.Image)(resources.GetObject("btnChinhSua.Image")));
            this.btnChinhSua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnChinhSua.Name = "btnChinhSua";
            this.btnChinhSua.Size = new System.Drawing.Size(97, 24);
            this.btnChinhSua.Text = "Chỉnh sửa";
            this.btnChinhSua.Click += new System.EventHandler(this.btnChinhSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(59, 24);
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblThongKe});
            this.statusStrip1.Location = new System.Drawing.Point(0, 481);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(765, 26);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblThongKe
            // 
            this.lblThongKe.Name = "lblThongKe";
            this.lblThongKe.Size = new System.Drawing.Size(82, 20);
            this.lblThongKe.Text = "Có [0] sách";
            this.lblThongKe.Click += new System.EventHandler(this.lblThongKe_Click);
            // 
            // gridSach
            // 
            this.gridSach.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gridSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaSach,
            this.colTieuDe,
            this.colTacGia,
            this.colNhaXuatBan});
            this.gridSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridSach.Location = new System.Drawing.Point(0, 27);
            this.gridSach.Name = "gridSach";
            this.gridSach.RowHeadersWidth = 51;
            this.gridSach.RowTemplate.Height = 24;
            this.gridSach.Size = new System.Drawing.Size(765, 454);
            this.gridSach.TabIndex = 2;
            this.gridSach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // colMaSach
            // 
            this.colMaSach.HeaderText = "Mã sách";
            this.colMaSach.MinimumWidth = 6;
            this.colMaSach.Name = "colMaSach";
            this.colMaSach.Width = 125;
            // 
            // colTieuDe
            // 
            this.colTieuDe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTieuDe.HeaderText = "Tiêu đề";
            this.colTieuDe.MinimumWidth = 150;
            this.colTieuDe.Name = "colTieuDe";
            // 
            // colTacGia
            // 
            this.colTacGia.HeaderText = "Tác giả";
            this.colTacGia.MinimumWidth = 150;
            this.colTacGia.Name = "colTacGia";
            this.colTacGia.Width = 220;
            // 
            // colNhaXuatBan
            // 
            this.colNhaXuatBan.HeaderText = "Mã nhà xuất bản";
            this.colNhaXuatBan.MinimumWidth = 100;
            this.colNhaXuatBan.Name = "colNhaXuatBan";
            this.colNhaXuatBan.Width = 200;
            // 
            // FormSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 507);
            this.Controls.Add(this.gridSach);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FormSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý sách";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnNapLai;
        private System.Windows.Forms.ToolStripButton btnThemMoi;
        private System.Windows.Forms.ToolStripButton btnChinhSua;
        private System.Windows.Forms.ToolStripButton btnXoa;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblThongKe;
        private System.Windows.Forms.DataGridView gridSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTieuDe;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTacGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNhaXuatBan;
    }
}

