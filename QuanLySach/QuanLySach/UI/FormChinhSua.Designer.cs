namespace QuanLySach.UI
{
    partial class FormChinhSua
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
            this.btnHuy = new System.Windows.Forms.Button();
            this.bntDongY = new System.Windows.Forms.Button();
            this.cboNXB = new System.Windows.Forms.ComboBox();
            this.txtDSTG = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNXB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTD = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMS = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(367, 285);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(84, 23);
            this.btnHuy.TabIndex = 21;
            this.btnHuy.Text = "Cancel";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // bntDongY
            // 
            this.bntDongY.Location = new System.Drawing.Point(278, 285);
            this.bntDongY.Name = "bntDongY";
            this.bntDongY.Size = new System.Drawing.Size(83, 23);
            this.bntDongY.TabIndex = 20;
            this.bntDongY.Text = "OK";
            this.bntDongY.UseVisualStyleBackColor = true;
            this.bntDongY.Click += new System.EventHandler(this.bntDongY_Click);
            // 
            // cboNXB
            // 
            this.cboNXB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNXB.FormattingEnabled = true;
            this.cboNXB.Location = new System.Drawing.Point(160, 134);
            this.cboNXB.Name = "cboNXB";
            this.cboNXB.Size = new System.Drawing.Size(291, 24);
            this.cboNXB.TabIndex = 16;
            // 
            // txtDSTG
            // 
            this.txtDSTG.Location = new System.Drawing.Point(160, 179);
            this.txtDSTG.Name = "txtDSTG";
            this.txtDSTG.Size = new System.Drawing.Size(291, 22);
            this.txtDSTG.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Danh sách tác giả:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Nhà xuất bản:";
            // 
            // txtNXB
            // 
            this.txtNXB.Location = new System.Drawing.Point(160, 229);
            this.txtNXB.Name = "txtNXB";
            this.txtNXB.Size = new System.Drawing.Size(291, 22);
            this.txtNXB.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Năm xuất bản";
            // 
            // txtTD
            // 
            this.txtTD.Location = new System.Drawing.Point(160, 81);
            this.txtTD.Name = "txtTD";
            this.txtTD.Size = new System.Drawing.Size(291, 22);
            this.txtTD.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tiêu đề:";
            // 
            // txtMS
            // 
            this.txtMS.Location = new System.Drawing.Point(160, 32);
            this.txtMS.Name = "txtMS";
            this.txtMS.Size = new System.Drawing.Size(291, 22);
            this.txtMS.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Mã sách:";
            // 
            // FormChinhSua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 350);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.bntDongY);
            this.Controls.Add(this.cboNXB);
            this.Controls.Add(this.txtDSTG);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNXB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMS);
            this.Controls.Add(this.label1);
            this.Name = "FormChinhSua";
            this.Text = "Chỉnh sửa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button bntDongY;
        private System.Windows.Forms.ComboBox cboNXB;
        private System.Windows.Forms.TextBox txtDSTG;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNXB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMS;
        private System.Windows.Forms.Label label1;
    }
}