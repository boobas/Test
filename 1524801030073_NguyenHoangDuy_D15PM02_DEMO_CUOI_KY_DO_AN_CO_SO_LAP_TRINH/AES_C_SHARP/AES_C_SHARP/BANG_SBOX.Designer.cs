namespace AES_C_SHARP
{
    partial class BANG_SBOX
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BANG_SBOX));
            this.BT_SBOX_THUAN = new System.Windows.Forms.Button();
            this.BT_SBOX_NGUOC = new System.Windows.Forms.Button();
            this.BTE = new System.Windows.Forms.Button();
            this.BTRCON = new System.Windows.Forms.Button();
            this.LBTXT = new System.Windows.Forms.Label();
            this.PIC_RCON = new System.Windows.Forms.PictureBox();
            this.PIC_SBOXNGHICH = new System.Windows.Forms.PictureBox();
            this.PIC_SBOXTHUAN = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PIC_RCON)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PIC_SBOXNGHICH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PIC_SBOXTHUAN)).BeginInit();
            this.SuspendLayout();
            // 
            // BT_SBOX_THUAN
            // 
            this.BT_SBOX_THUAN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_SBOX_THUAN.Location = new System.Drawing.Point(5, 7);
            this.BT_SBOX_THUAN.Name = "BT_SBOX_THUAN";
            this.BT_SBOX_THUAN.Size = new System.Drawing.Size(217, 70);
            this.BT_SBOX_THUAN.TabIndex = 7;
            this.BT_SBOX_THUAN.Text = "BẢNG S - BOX THUẬN";
            this.BT_SBOX_THUAN.UseVisualStyleBackColor = true;
            this.BT_SBOX_THUAN.Click += new System.EventHandler(this.BT_SBOX_THUAN_Click);
            // 
            // BT_SBOX_NGUOC
            // 
            this.BT_SBOX_NGUOC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_SBOX_NGUOC.Location = new System.Drawing.Point(5, 83);
            this.BT_SBOX_NGUOC.Name = "BT_SBOX_NGUOC";
            this.BT_SBOX_NGUOC.Size = new System.Drawing.Size(217, 70);
            this.BT_SBOX_NGUOC.TabIndex = 7;
            this.BT_SBOX_NGUOC.Text = "BẢNG S - BOX NGHỊCH";
            this.BT_SBOX_NGUOC.UseVisualStyleBackColor = true;
            this.BT_SBOX_NGUOC.Click += new System.EventHandler(this.BT_SBOX_NGUOC_Click);
            // 
            // BTE
            // 
            this.BTE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTE.ForeColor = System.Drawing.Color.Red;
            this.BTE.Location = new System.Drawing.Point(5, 235);
            this.BTE.Name = "BTE";
            this.BTE.Size = new System.Drawing.Size(217, 70);
            this.BTE.TabIndex = 7;
            this.BTE.Text = "THOÁT";
            this.BTE.UseVisualStyleBackColor = true;
            this.BTE.Click += new System.EventHandler(this.BTE_Click);
            // 
            // BTRCON
            // 
            this.BTRCON.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTRCON.Location = new System.Drawing.Point(5, 159);
            this.BTRCON.Name = "BTRCON";
            this.BTRCON.Size = new System.Drawing.Size(217, 70);
            this.BTRCON.TabIndex = 7;
            this.BTRCON.Text = "BẢNG RCON";
            this.BTRCON.UseVisualStyleBackColor = true;
            this.BTRCON.Click += new System.EventHandler(this.BTRCON_Click);
            // 
            // LBTXT
            // 
            this.LBTXT.AutoSize = true;
            this.LBTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBTXT.Location = new System.Drawing.Point(12, 334);
            this.LBTXT.Name = "LBTXT";
            this.LBTXT.Size = new System.Drawing.Size(190, 20);
            this.LBTXT.TabIndex = 8;
            this.LBTXT.Text = "BẠN ĐANG XEM : BẢNG";
            // 
            // PIC_RCON
            // 
            this.PIC_RCON.Image = global::AES_C_SHARP.Properties.Resources.bang_rcon1;
            this.PIC_RCON.Location = new System.Drawing.Point(227, 139);
            this.PIC_RCON.Name = "PIC_RCON";
            this.PIC_RCON.Size = new System.Drawing.Size(394, 124);
            this.PIC_RCON.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PIC_RCON.TabIndex = 6;
            this.PIC_RCON.TabStop = false;
            // 
            // PIC_SBOXNGHICH
            // 
            this.PIC_SBOXNGHICH.Image = global::AES_C_SHARP.Properties.Resources.S_BOX_NGUOC;
            this.PIC_SBOXNGHICH.Location = new System.Drawing.Point(227, 7);
            this.PIC_SBOXNGHICH.Name = "PIC_SBOXNGHICH";
            this.PIC_SBOXNGHICH.Size = new System.Drawing.Size(394, 420);
            this.PIC_SBOXNGHICH.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PIC_SBOXNGHICH.TabIndex = 6;
            this.PIC_SBOXNGHICH.TabStop = false;
            // 
            // PIC_SBOXTHUAN
            // 
            this.PIC_SBOXTHUAN.Image = global::AES_C_SHARP.Properties.Resources.S_BOX;
            this.PIC_SBOXTHUAN.Location = new System.Drawing.Point(227, 7);
            this.PIC_SBOXTHUAN.Name = "PIC_SBOXTHUAN";
            this.PIC_SBOXTHUAN.Size = new System.Drawing.Size(394, 420);
            this.PIC_SBOXTHUAN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PIC_SBOXTHUAN.TabIndex = 6;
            this.PIC_SBOXTHUAN.TabStop = false;
            // 
            // BANG_SBOX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 433);
            this.Controls.Add(this.LBTXT);
            this.Controls.Add(this.BTE);
            this.Controls.Add(this.BTRCON);
            this.Controls.Add(this.BT_SBOX_NGUOC);
            this.Controls.Add(this.BT_SBOX_THUAN);
            this.Controls.Add(this.PIC_RCON);
            this.Controls.Add(this.PIC_SBOXNGHICH);
            this.Controls.Add(this.PIC_SBOXTHUAN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "BANG_SBOX";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BẢNG S- BOX";
            this.Load += new System.EventHandler(this.BANG_SBOX_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PIC_RCON)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PIC_SBOXNGHICH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PIC_SBOXTHUAN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox PIC_SBOXTHUAN;
        private System.Windows.Forms.Button BT_SBOX_THUAN;
        private System.Windows.Forms.Button BT_SBOX_NGUOC;
        private System.Windows.Forms.Button BTE;
        private System.Windows.Forms.Button BTRCON;
        private System.Windows.Forms.Label LBTXT;
        private System.Windows.Forms.PictureBox PIC_SBOXNGHICH;
        private System.Windows.Forms.PictureBox PIC_RCON;
    }
}