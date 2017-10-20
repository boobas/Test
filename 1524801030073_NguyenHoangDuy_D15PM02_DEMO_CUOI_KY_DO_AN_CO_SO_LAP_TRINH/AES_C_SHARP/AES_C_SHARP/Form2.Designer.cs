namespace AES_C_SHARP
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.BTMAHOA = new System.Windows.Forms.Button();
            this.BTRCON = new System.Windows.Forms.RichTextBox();
            this.BTE = new System.Windows.Forms.Button();
            this.BTGIAIMA = new System.Windows.Forms.Button();
            this.BTCOPY = new System.Windows.Forms.Button();
            this.RT2 = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BTPHU = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BTMAHOA
            // 
            this.BTMAHOA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTMAHOA.Location = new System.Drawing.Point(4, 6);
            this.BTMAHOA.Name = "BTMAHOA";
            this.BTMAHOA.Size = new System.Drawing.Size(202, 60);
            this.BTMAHOA.TabIndex = 0;
            this.BTMAHOA.Text = "MÃ HÓA";
            this.BTMAHOA.UseVisualStyleBackColor = true;
            this.BTMAHOA.Click += new System.EventHandler(this.BTMAHOA_Click);
            // 
            // BTRCON
            // 
            this.BTRCON.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTRCON.Location = new System.Drawing.Point(5, 11);
            this.BTRCON.Name = "BTRCON";
            this.BTRCON.ReadOnly = true;
            this.BTRCON.Size = new System.Drawing.Size(655, 355);
            this.BTRCON.TabIndex = 1;
            this.BTRCON.Text = resources.GetString("BTRCON.Text");
            // 
            // BTE
            // 
            this.BTE.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTE.ForeColor = System.Drawing.Color.Red;
            this.BTE.Location = new System.Drawing.Point(4, 319);
            this.BTE.Name = "BTE";
            this.BTE.Size = new System.Drawing.Size(202, 47);
            this.BTE.TabIndex = 3;
            this.BTE.Text = "THOÁT XEM";
            this.BTE.UseVisualStyleBackColor = true;
            this.BTE.Click += new System.EventHandler(this.BTE_Click);
            // 
            // BTGIAIMA
            // 
            this.BTGIAIMA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTGIAIMA.Location = new System.Drawing.Point(4, 67);
            this.BTGIAIMA.Name = "BTGIAIMA";
            this.BTGIAIMA.Size = new System.Drawing.Size(202, 60);
            this.BTGIAIMA.TabIndex = 1;
            this.BTGIAIMA.Text = "GIẢI MÃ";
            this.BTGIAIMA.UseVisualStyleBackColor = true;
            this.BTGIAIMA.Click += new System.EventHandler(this.BTGIAIMA_Click);
            // 
            // BTCOPY
            // 
            this.BTCOPY.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTCOPY.Location = new System.Drawing.Point(4, 128);
            this.BTCOPY.Name = "BTCOPY";
            this.BTCOPY.Size = new System.Drawing.Size(202, 76);
            this.BTCOPY.TabIndex = 2;
            this.BTCOPY.Text = "COPY";
            this.BTCOPY.UseVisualStyleBackColor = true;
            this.BTCOPY.Click += new System.EventHandler(this.BTCOPY_Click);
            // 
            // RT2
            // 
            this.RT2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RT2.Location = new System.Drawing.Point(6, 11);
            this.RT2.Name = "RT2";
            this.RT2.ReadOnly = true;
            this.RT2.Size = new System.Drawing.Size(655, 355);
            this.RT2.TabIndex = 2;
            this.RT2.Text = resources.GetString("RT2.Text");
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BTRCON);
            this.groupBox1.Controls.Add(this.RT2);
            this.groupBox1.Location = new System.Drawing.Point(209, -1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(668, 369);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // BTPHU
            // 
            this.BTPHU.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTPHU.Location = new System.Drawing.Point(4, 205);
            this.BTPHU.Name = "BTPHU";
            this.BTPHU.Size = new System.Drawing.Size(202, 54);
            this.BTPHU.TabIndex = 1;
            this.BTPHU.Text = "BẢNG PHỤ";
            this.BTPHU.UseVisualStyleBackColor = true;
            this.BTPHU.Click += new System.EventHandler(this.BTPHU_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 374);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BTE);
            this.Controls.Add(this.BTCOPY);
            this.Controls.Add(this.BTPHU);
            this.Controls.Add(this.BTGIAIMA);
            this.Controls.Add(this.BTMAHOA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XEM CODE CHƯƠNG TRÌNH MÔ PHỎNG THUẬT TOÁN MÃ HÓA HAI CHIỀU AES";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTMAHOA;
        private System.Windows.Forms.RichTextBox BTRCON;
        private System.Windows.Forms.Button BTE;
        private System.Windows.Forms.Button BTGIAIMA;
        private System.Windows.Forms.Button BTCOPY;
        private System.Windows.Forms.RichTextBox RT2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BTPHU;
    }
}