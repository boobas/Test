namespace AES_C_SHARP
{
    partial class AES_CSHARP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AES_CSHARP));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.RD128 = new System.Windows.Forms.RadioButton();
            this.RD256 = new System.Windows.Forms.RadioButton();
            this.RD192 = new System.Windows.Forms.RadioButton();
            this.BTXOA1 = new System.Windows.Forms.Button();
            this.BTMAHOA = new System.Windows.Forms.Button();
            this.BTSAOCHEP = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LB1 = new System.Windows.Forms.Label();
            this.TBKQ1 = new System.Windows.Forms.TextBox();
            this.TBKEY1 = new System.Windows.Forms.TextBox();
            this.TBNMH = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.RD1281 = new System.Windows.Forms.RadioButton();
            this.RD2561 = new System.Windows.Forms.RadioButton();
            this.RD1921 = new System.Windows.Forms.RadioButton();
            this.BTXOA2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.BTGIAIMA = new System.Windows.Forms.Button();
            this.BTDAN = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TBKQ2 = new System.Windows.Forms.TextBox();
            this.TBNGM = new System.Windows.Forms.TextBox();
            this.TBKEY2 = new System.Windows.Forms.TextBox();
            this.PICSTT = new System.Windows.Forms.PictureBox();
            this.BTE = new System.Windows.Forms.Button();
            this.BTTT = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BTKTTT = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PICSTT)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.BTXOA1);
            this.groupBox1.Controls.Add(this.BTMAHOA);
            this.groupBox1.Controls.Add(this.BTSAOCHEP);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.LB1);
            this.groupBox1.Controls.Add(this.TBKQ1);
            this.groupBox1.Controls.Add(this.TBKEY1);
            this.groupBox1.Controls.Add(this.TBNMH);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(8, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(754, 266);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mã Hóa Dữ Liệu";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.RD128);
            this.groupBox3.Controls.Add(this.RD256);
            this.groupBox3.Controls.Add(this.RD192);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(20, 153);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(171, 98);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chọn Số Bits Mã Hóa";
            // 
            // RD128
            // 
            this.RD128.AutoSize = true;
            this.RD128.Location = new System.Drawing.Point(26, 18);
            this.RD128.Name = "RD128";
            this.RD128.Size = new System.Drawing.Size(77, 21);
            this.RD128.TabIndex = 14;
            this.RD128.TabStop = true;
            this.RD128.Text = "128 Bits";
            this.RD128.UseVisualStyleBackColor = true;
            // 
            // RD256
            // 
            this.RD256.AutoSize = true;
            this.RD256.Location = new System.Drawing.Point(26, 72);
            this.RD256.Name = "RD256";
            this.RD256.Size = new System.Drawing.Size(77, 21);
            this.RD256.TabIndex = 14;
            this.RD256.TabStop = true;
            this.RD256.Text = "256 Bits";
            this.RD256.UseVisualStyleBackColor = true;
            // 
            // RD192
            // 
            this.RD192.AutoSize = true;
            this.RD192.Location = new System.Drawing.Point(26, 45);
            this.RD192.Name = "RD192";
            this.RD192.Size = new System.Drawing.Size(77, 21);
            this.RD192.TabIndex = 14;
            this.RD192.TabStop = true;
            this.RD192.Text = "192 Bits";
            this.RD192.UseVisualStyleBackColor = true;
            // 
            // BTXOA1
            // 
            this.BTXOA1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTXOA1.Location = new System.Drawing.Point(487, 198);
            this.BTXOA1.Name = "BTXOA1";
            this.BTXOA1.Size = new System.Drawing.Size(257, 57);
            this.BTXOA1.TabIndex = 6;
            this.BTXOA1.Text = "XÓA";
            this.BTXOA1.UseVisualStyleBackColor = true;
            this.BTXOA1.Click += new System.EventHandler(this.BTXOA1_Click);
            // 
            // BTMAHOA
            // 
            this.BTMAHOA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTMAHOA.Location = new System.Drawing.Point(214, 198);
            this.BTMAHOA.Name = "BTMAHOA";
            this.BTMAHOA.Size = new System.Drawing.Size(267, 57);
            this.BTMAHOA.TabIndex = 4;
            this.BTMAHOA.Text = "MÃ HÓA";
            this.BTMAHOA.UseVisualStyleBackColor = true;
            this.BTMAHOA.Click += new System.EventHandler(this.BTMAHOA_Click);
            // 
            // BTSAOCHEP
            // 
            this.BTSAOCHEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTSAOCHEP.Location = new System.Drawing.Point(662, 110);
            this.BTSAOCHEP.Name = "BTSAOCHEP";
            this.BTSAOCHEP.Size = new System.Drawing.Size(82, 82);
            this.BTSAOCHEP.TabIndex = 5;
            this.BTSAOCHEP.Text = "SAO CHÉP";
            this.BTSAOCHEP.UseVisualStyleBackColor = true;
            this.BTSAOCHEP.Click += new System.EventHandler(this.BTSAOCHEP_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nội Dung Đã Được Mã Hóa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Khóa";
            // 
            // LB1
            // 
            this.LB1.AutoSize = true;
            this.LB1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB1.Location = new System.Drawing.Point(6, 27);
            this.LB1.Name = "LB1";
            this.LB1.Size = new System.Drawing.Size(168, 20);
            this.LB1.TabIndex = 1;
            this.LB1.Text = "Nội Dung Cần Mã Hóa";
            // 
            // TBKQ1
            // 
            this.TBKQ1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBKQ1.Location = new System.Drawing.Point(214, 110);
            this.TBKQ1.Multiline = true;
            this.TBKQ1.Name = "TBKQ1";
            this.TBKQ1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TBKQ1.Size = new System.Drawing.Size(442, 81);
            this.TBKQ1.TabIndex = 3;
            this.TBKQ1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TBKEY1
            // 
            this.TBKEY1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBKEY1.Location = new System.Drawing.Point(214, 65);
            this.TBKEY1.Multiline = true;
            this.TBKEY1.Name = "TBKEY1";
            this.TBKEY1.Size = new System.Drawing.Size(530, 39);
            this.TBKEY1.TabIndex = 2;
            this.TBKEY1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TBNMH
            // 
            this.TBNMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBNMH.Location = new System.Drawing.Point(214, 20);
            this.TBNMH.Multiline = true;
            this.TBNMH.Name = "TBNMH";
            this.TBNMH.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TBNMH.Size = new System.Drawing.Size(530, 39);
            this.TBNMH.TabIndex = 1;
            this.TBNMH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.BTXOA2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.BTGIAIMA);
            this.groupBox2.Controls.Add(this.BTDAN);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.TBKQ2);
            this.groupBox2.Controls.Add(this.TBNGM);
            this.groupBox2.Controls.Add(this.TBKEY2);
            this.groupBox2.Controls.Add(this.PICSTT);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(8, 313);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(755, 278);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Giải Mã Dữ Liệu";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.RD1281);
            this.groupBox4.Controls.Add(this.RD2561);
            this.groupBox4.Controls.Add(this.RD1921);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(20, 170);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(171, 98);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Chọn Số Bits Giải Mã";
            // 
            // RD1281
            // 
            this.RD1281.AutoSize = true;
            this.RD1281.Location = new System.Drawing.Point(26, 18);
            this.RD1281.Name = "RD1281";
            this.RD1281.Size = new System.Drawing.Size(77, 21);
            this.RD1281.TabIndex = 14;
            this.RD1281.TabStop = true;
            this.RD1281.Text = "128 Bits";
            this.RD1281.UseVisualStyleBackColor = true;
            // 
            // RD2561
            // 
            this.RD2561.AutoSize = true;
            this.RD2561.Location = new System.Drawing.Point(26, 72);
            this.RD2561.Name = "RD2561";
            this.RD2561.Size = new System.Drawing.Size(77, 21);
            this.RD2561.TabIndex = 14;
            this.RD2561.TabStop = true;
            this.RD2561.Text = "256 Bits";
            this.RD2561.UseVisualStyleBackColor = true;
            // 
            // RD1921
            // 
            this.RD1921.AutoSize = true;
            this.RD1921.Location = new System.Drawing.Point(26, 45);
            this.RD1921.Name = "RD1921";
            this.RD1921.Size = new System.Drawing.Size(77, 21);
            this.RD1921.TabIndex = 14;
            this.RD1921.TabStop = true;
            this.RD1921.Text = "192 Bits";
            this.RD1921.UseVisualStyleBackColor = true;
            // 
            // BTXOA2
            // 
            this.BTXOA2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTXOA2.Location = new System.Drawing.Point(487, 210);
            this.BTXOA2.Name = "BTXOA2";
            this.BTXOA2.Size = new System.Drawing.Size(257, 57);
            this.BTXOA2.TabIndex = 12;
            this.BTXOA2.Text = "XÓA";
            this.BTXOA2.UseVisualStyleBackColor = true;
            this.BTXOA2.Click += new System.EventHandler(this.BTXOA2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nội Dung Đã Được Giải Mã";
            // 
            // BTGIAIMA
            // 
            this.BTGIAIMA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTGIAIMA.Location = new System.Drawing.Point(214, 210);
            this.BTGIAIMA.Name = "BTGIAIMA";
            this.BTGIAIMA.Size = new System.Drawing.Size(267, 57);
            this.BTGIAIMA.TabIndex = 11;
            this.BTGIAIMA.Text = "GIẢI MÃ";
            this.BTGIAIMA.UseVisualStyleBackColor = true;
            this.BTGIAIMA.Click += new System.EventHandler(this.BTGIAIMA_Click);
            // 
            // BTDAN
            // 
            this.BTDAN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTDAN.Location = new System.Drawing.Point(662, 22);
            this.BTDAN.Name = "BTDAN";
            this.BTDAN.Size = new System.Drawing.Size(82, 65);
            this.BTDAN.TabIndex = 7;
            this.BTDAN.Text = "DÁN";
            this.BTDAN.UseVisualStyleBackColor = true;
            this.BTDAN.Click += new System.EventHandler(this.BTDAN_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Khóa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Nội Dung Cần Giải Mã";
            // 
            // TBKQ2
            // 
            this.TBKQ2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBKQ2.Location = new System.Drawing.Point(215, 143);
            this.TBKQ2.Multiline = true;
            this.TBKQ2.Name = "TBKQ2";
            this.TBKQ2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TBKQ2.Size = new System.Drawing.Size(530, 55);
            this.TBKQ2.TabIndex = 10;
            this.TBKQ2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TBNGM
            // 
            this.TBNGM.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBNGM.Location = new System.Drawing.Point(214, 22);
            this.TBNGM.Multiline = true;
            this.TBNGM.Name = "TBNGM";
            this.TBNGM.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TBNGM.Size = new System.Drawing.Size(442, 65);
            this.TBNGM.TabIndex = 8;
            this.TBNGM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TBKEY2
            // 
            this.TBKEY2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBKEY2.Location = new System.Drawing.Point(214, 93);
            this.TBKEY2.Multiline = true;
            this.TBKEY2.Name = "TBKEY2";
            this.TBKEY2.Size = new System.Drawing.Size(530, 39);
            this.TBKEY2.TabIndex = 9;
            this.TBKEY2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PICSTT
            // 
            this.PICSTT.Location = new System.Drawing.Point(209, 136);
            this.PICSTT.Name = "PICSTT";
            this.PICSTT.Size = new System.Drawing.Size(542, 68);
            this.PICSTT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PICSTT.TabIndex = 18;
            this.PICSTT.TabStop = false;
            // 
            // BTE
            // 
            this.BTE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTE.ForeColor = System.Drawing.Color.Red;
            this.BTE.Location = new System.Drawing.Point(8, 356);
            this.BTE.Name = "BTE";
            this.BTE.Size = new System.Drawing.Size(203, 50);
            this.BTE.TabIndex = 13;
            this.BTE.Text = "THOÁT";
            this.BTE.UseVisualStyleBackColor = true;
            this.BTE.Click += new System.EventHandler(this.BTE_Click);
            // 
            // BTTT
            // 
            this.BTTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTTT.Location = new System.Drawing.Point(8, 244);
            this.BTTT.Name = "BTTT";
            this.BTTT.Size = new System.Drawing.Size(203, 50);
            this.BTTT.TabIndex = 13;
            this.BTTT.Text = "THÔNG TIN";
            this.BTTT.UseVisualStyleBackColor = true;
            this.BTTT.Click += new System.EventHandler(this.BTTT_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(123, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(738, 36);
            this.label6.TabIndex = 16;
            this.label6.Text = "MÔ PHỎNG THUẬT TOÁN MÃ HÓA HAI CHIỀU AES ";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.pictureBox1);
            this.groupBox5.Controls.Add(this.BTE);
            this.groupBox5.Controls.Add(this.BTKTTT);
            this.groupBox5.Controls.Add(this.BTTT);
            this.groupBox5.Location = new System.Drawing.Point(768, 47);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(217, 418);
            this.groupBox5.TabIndex = 17;
            this.groupBox5.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AES_C_SHARP.Properties.Resources.LogoDHThuDauMot;
            this.pictureBox1.Location = new System.Drawing.Point(4, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(210, 226);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // BTKTTT
            // 
            this.BTKTTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTKTTT.Location = new System.Drawing.Point(8, 300);
            this.BTKTTT.Name = "BTKTTT";
            this.BTKTTT.Size = new System.Drawing.Size(203, 50);
            this.BTKTTT.TabIndex = 13;
            this.BTKTTT.Text = "XEM THUẬT TOÁN";
            this.BTKTTT.UseVisualStyleBackColor = true;
            this.BTKTTT.Click += new System.EventHandler(this.BTKTTT_Click);
            // 
            // AES_CSHARP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 599);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AES_CSHARP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MÔ PHỎNG THUẬT TOÁN MÃ HÓA HAI CHIỀU AES";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PICSTT)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TBNMH;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LB1;
        private System.Windows.Forms.TextBox TBKQ1;
        private System.Windows.Forms.TextBox TBKEY1;
        private System.Windows.Forms.TextBox TBKQ2;
        private System.Windows.Forms.TextBox TBNGM;
        private System.Windows.Forms.TextBox TBKEY2;
        private System.Windows.Forms.Button BTSAOCHEP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton RD256;
        private System.Windows.Forms.RadioButton RD192;
        private System.Windows.Forms.RadioButton RD128;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton RD1281;
        private System.Windows.Forms.RadioButton RD2561;
        private System.Windows.Forms.RadioButton RD1921;
        private System.Windows.Forms.Button BTXOA1;
        private System.Windows.Forms.Button BTMAHOA;
        private System.Windows.Forms.Button BTXOA2;
        private System.Windows.Forms.Button BTGIAIMA;
        private System.Windows.Forms.Button BTDAN;
        private System.Windows.Forms.Button BTE;
        private System.Windows.Forms.Button BTTT;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button BTKTTT;
        private System.Windows.Forms.PictureBox PICSTT;
    }
}

