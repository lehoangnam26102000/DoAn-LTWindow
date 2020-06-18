namespace QLDoiBong_DoAn
{
    partial class frmCauThu
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
            this.txtMaCT = new System.Windows.Forms.TextBox();
            this.txtTenCT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNamThiDau = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoTran = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBanThang = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLoaiCT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã cầu thủ";
            // 
            // txtMaCT
            // 
            this.txtMaCT.Location = new System.Drawing.Point(152, 22);
            this.txtMaCT.Name = "txtMaCT";
            this.txtMaCT.Size = new System.Drawing.Size(401, 22);
            this.txtMaCT.TabIndex = 1;
            // 
            // txtTenCT
            // 
            this.txtTenCT.Location = new System.Drawing.Point(152, 65);
            this.txtTenCT.Name = "txtTenCT";
            this.txtTenCT.Size = new System.Drawing.Size(401, 22);
            this.txtTenCT.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên cầu thủ";
            // 
            // txtNamThiDau
            // 
            this.txtNamThiDau.Location = new System.Drawing.Point(152, 113);
            this.txtNamThiDau.Name = "txtNamThiDau";
            this.txtNamThiDau.Size = new System.Drawing.Size(401, 22);
            this.txtNamThiDau.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Năm thi đấu";
            // 
            // txtSoTran
            // 
            this.txtSoTran.Location = new System.Drawing.Point(152, 159);
            this.txtSoTran.Name = "txtSoTran";
            this.txtSoTran.Size = new System.Drawing.Size(401, 22);
            this.txtSoTran.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Số trận góp mặt";
            // 
            // txtBanThang
            // 
            this.txtBanThang.Location = new System.Drawing.Point(152, 207);
            this.txtBanThang.Name = "txtBanThang";
            this.txtBanThang.Size = new System.Drawing.Size(401, 22);
            this.txtBanThang.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Bàn thắng đã ghi";
            // 
            // txtLoaiCT
            // 
            this.txtLoaiCT.Location = new System.Drawing.Point(152, 257);
            this.txtLoaiCT.Name = "txtLoaiCT";
            this.txtLoaiCT.Size = new System.Drawing.Size(401, 22);
            this.txtLoaiCT.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Loại cầu thủ";
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(178, 317);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(82, 31);
            this.btnLuu.TabIndex = 12;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(367, 317);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(82, 31);
            this.btnHuy.TabIndex = 13;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // frmCauThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.txtLoaiCT);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBanThang);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSoTran);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNamThiDau);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTenCT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaCT);
            this.Controls.Add(this.label1);
            this.Name = "frmCauThu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCauThu";
            this.Load += new System.EventHandler(this.frmCauThu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaCT;
        private System.Windows.Forms.TextBox txtTenCT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNamThiDau;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSoTran;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBanThang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLoaiCT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
    }
}