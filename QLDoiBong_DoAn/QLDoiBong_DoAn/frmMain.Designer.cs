namespace QLDoiBong_DoAn
{
    partial class frmMain
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
            this.btnqlct = new System.Windows.Forms.Button();
            this.btnqlhlv = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(290, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Phần mềm quản lý đội bóng";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnqlct
            // 
            this.btnqlct.Location = new System.Drawing.Point(128, 61);
            this.btnqlct.Name = "btnqlct";
            this.btnqlct.Size = new System.Drawing.Size(119, 28);
            this.btnqlct.TabIndex = 2;
            this.btnqlct.Text = "DS Cầu thủ";
            this.btnqlct.UseVisualStyleBackColor = true;
            this.btnqlct.Click += new System.EventHandler(this.btnqlct_Click);
            // 
            // btnqlhlv
            // 
            this.btnqlhlv.Location = new System.Drawing.Point(528, 61);
            this.btnqlhlv.Name = "btnqlhlv";
            this.btnqlhlv.Size = new System.Drawing.Size(77, 28);
            this.btnqlhlv.TabIndex = 3;
            this.btnqlhlv.Text = "DS HLV";
            this.btnqlhlv.UseVisualStyleBackColor = true;
            this.btnqlhlv.Click += new System.EventHandler(this.btnqlhlv_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(327, 139);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 23);
            this.btnthoat.TabIndex = 4;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 207);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnqlhlv);
            this.Controls.Add(this.btnqlct);
            this.Controls.Add(this.label1);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main form";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnqlct;
        private System.Windows.Forms.Button btnqlhlv;
        private System.Windows.Forms.Button btnthoat;
    }
}

