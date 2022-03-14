namespace QuanLySach.UI
{
    partial class FormSachNew
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
            this.txtMaSach = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTieuDe = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDSTacGia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNamXuatBan = new System.Windows.Forms.TextBox();
            this.cboNhaXuatBan = new System.Windows.Forms.ComboBox();
            this.bntOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnThemNhaXuatBan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sách:";
            // 
            // txtMaSach
            // 
            this.txtMaSach.Location = new System.Drawing.Point(152, 34);
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.Size = new System.Drawing.Size(291, 22);
            this.txtMaSach.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tiêu đề:";
            // 
            // txtTieuDe
            // 
            this.txtTieuDe.Location = new System.Drawing.Point(152, 83);
            this.txtTieuDe.Name = "txtTieuDe";
            this.txtTieuDe.Size = new System.Drawing.Size(291, 22);
            this.txtTieuDe.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nhà xuất bản:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Danh sách tác giả:";
            // 
            // txtDSTacGia
            // 
            this.txtDSTacGia.Location = new System.Drawing.Point(152, 181);
            this.txtDSTacGia.Name = "txtDSTacGia";
            this.txtDSTacGia.Size = new System.Drawing.Size(291, 22);
            this.txtDSTacGia.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Năm xuất bản";
            // 
            // txtNamXuatBan
            // 
            this.txtNamXuatBan.Location = new System.Drawing.Point(152, 231);
            this.txtNamXuatBan.Name = "txtNamXuatBan";
            this.txtNamXuatBan.Size = new System.Drawing.Size(291, 22);
            this.txtNamXuatBan.TabIndex = 6;
            // 
            // cboNhaXuatBan
            // 
            this.cboNhaXuatBan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNhaXuatBan.FormattingEnabled = true;
            this.cboNhaXuatBan.Location = new System.Drawing.Point(152, 136);
            this.cboNhaXuatBan.Name = "cboNhaXuatBan";
            this.cboNhaXuatBan.Size = new System.Drawing.Size(216, 24);
            this.cboNhaXuatBan.TabIndex = 3;
            this.cboNhaXuatBan.SelectedIndexChanged += new System.EventHandler(this.cboNhaXuatBan_SelectedIndexChanged);
            // 
            // bntOK
            // 
            this.bntOK.Location = new System.Drawing.Point(270, 287);
            this.bntOK.Name = "bntOK";
            this.bntOK.Size = new System.Drawing.Size(83, 23);
            this.bntOK.TabIndex = 7;
            this.bntOK.Text = "OK";
            this.bntOK.UseVisualStyleBackColor = true;
            this.bntOK.Click += new System.EventHandler(this.bntOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(359, 287);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(84, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnThemNhaXuatBan
            // 
            this.btnThemNhaXuatBan.Location = new System.Drawing.Point(374, 136);
            this.btnThemNhaXuatBan.Name = "btnThemNhaXuatBan";
            this.btnThemNhaXuatBan.Size = new System.Drawing.Size(69, 24);
            this.btnThemNhaXuatBan.TabIndex = 4;
            this.btnThemNhaXuatBan.Text = "Thêm";
            this.btnThemNhaXuatBan.UseVisualStyleBackColor = true;
            this.btnThemNhaXuatBan.Click += new System.EventHandler(this.bntOK_Click);
            // 
            // FormSachNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 342);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnThemNhaXuatBan);
            this.Controls.Add(this.bntOK);
            this.Controls.Add(this.cboNhaXuatBan);
            this.Controls.Add(this.txtDSTacGia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNamXuatBan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTieuDe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaSach);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSachNew";
            this.Text = "Tạo mới sách";
            this.Load += new System.EventHandler(this.FormSachNew_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaSach;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTieuDe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDSTacGia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNamXuatBan;
        private System.Windows.Forms.ComboBox cboNhaXuatBan;
        private System.Windows.Forms.Button bntOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnThemNhaXuatBan;
    }
}