using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace AES_C_SHARP
{
    public partial class AES_CSHARP : Form
    {
        string ABC;
        int key1 = 0, key2 = 0;
        SEC_AES aes = new SEC_AES();
        public AES_CSHARP()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PICSTT.ImageLocation = "../../image/grey.png";
            TBKQ1.ReadOnly = true;
            TBKQ2.ReadOnly = true;
            RD128.Checked = true;
            RD1281.Checked = true;
        }

        private void BTE_Click(object sender, EventArgs e)
        { this.Close(); }
        private void BTKTTT_Click(object sender, EventArgs e)
        {
            // XUẤT CỬA SỔ VIEW CODE
            Form2 ViewCode = new Form2();
            this.Enabled = true;
            ViewCode.ShowDialog();



            //DialogResult A;
            //A = MessageBox.Show("BẠN CÓ MUỐN XEM THUẬT TOÁN", "THÔNG BÁO", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            //if (A == DialogResult.OK)
            //{
               
            //}

            //if (A == DialogResult.Cancel)
            //{
            //    //nothing
            //}
        }
        private void BTTT_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ĐỒ ÁN CUỐI KÌ MÔN THỰC TẬP CƠ SỞ\nChương trình mô phỏng thuật toán mã hóa dữ liệu hai chiều AES bằng ngôn ngữ lập trình C# \n - Sinh viên thực hiện : Nguyễn Hoàng Duy\n - MSSV : 1524801030073\n - Lớp : D15PM02\n - Chương trình phục vụ mục đích học tập, nghiên cứu.", "THÔNG TIN", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void TESTBIT1(object sender, EventArgs e)
        {
            if (RD128.Checked == true) key1 = 128;
            if (RD192.Checked == true) key1 = 192;
            if (RD256.Checked == true) key1 = 256;
        }
        private void TESTBIT2(object sender, EventArgs e)
        {
            if (RD1281.Checked == true) key2 = 128;
            if (RD1921.Checked == true) key2 = 192;
            if (RD2561.Checked == true) key2 = 256;
        }
        private void BTMAHOA_Click(object sender, EventArgs e)
        {
            TBKQ1.Clear();
            if (TBNMH.Text != "" || TBNMH.Text == null)
            {
                TESTBIT1(sender, e);
                try
                {
                    TBKQ1.Text = aes.Encrypt(TBNMH.Text, TBKEY1.Text, key1);
                }
                catch
                {
                    MessageBox.Show("KHÔNG THỂ MÃ HÓA DỮ LIỆU ĐÃ NHẬP", "ĐÃ CÓ LỖI XẢY RA!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            else
            {
                MessageBox.Show("NỘI DUNG CẦN MÃ HÓA KHÔNG ĐƯỢC ĐỂ TRỐNG", "CHÚ Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            TBKQ1.ReadOnly = false;
        }

        private void BTXOA1_Click(object sender, EventArgs e)
        {
            if (TBNMH.Text == null || TBNMH.Text == "")
            {
                MessageBox.Show("MỤC RỖNG! KHÔNG CÓ GÌ ĐỂ XÓA", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TBNMH.Focus();
            }
            else
            {
                TBNMH.Text = null;
                TBKQ1.Text = null;
                TBKEY1.Text = null;
                TBKQ1.ReadOnly = true;
                TBNMH.Focus();
            }
        }

        private void BTGIAIMA_Click(object sender, EventArgs e)
        {
            if (TBNGM.Text != "")
            {
                TESTBIT2(sender, e);
                try
                {
                    TBKQ2.Text = aes.Decrypt(TBNGM.Text, TBKEY2.Text, key2);
                    PICSTT.Image = null;
                    PICSTT.ImageLocation = "../../image/green.png";
                }
                catch
                {
                    PICSTT.Image = null;
                    PICSTT.ImageLocation = "../../image/red.png";
                    MessageBox.Show("KHÔNG THỂ GIẢI MÃ DỮ LIỆU ĐÃ NHẬP, VUI LÒNG KIỂM TRA CHUỖI MÃ HÓA ĐÃ NHẬP, KHÓA HOẶC ĐỘ DÀI KHÓA", "ĐÃ CÓ LỖI XẢY RA!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            else
            {
                MessageBox.Show("NỘI DUNG CẦN GIẢI MÃ KHÔNG ĐƯỢC ĐỂ TRỐNG", "CHÚ Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            TBKQ2.ReadOnly = false;
        }

        private void BTXOA2_Click(object sender, EventArgs e)
        {
            if (TBNGM.Text == null || TBNGM.Text == "")
            {
                MessageBox.Show("MỤC RỖNG! KHÔNG CÓ GÌ ĐỂ XÓA", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TBNGM.Focus();
            }
            else
            {
                PICSTT.Image = null;
                PICSTT.ImageLocation = "../../image/grey.png";
                TBNGM.Text = null;
                TBKQ2.Text = null;
                TBKEY2.Text = null;
                TBKQ2.ReadOnly = true;
                TBNGM.Focus();
            }
        }

        private void BTSAOCHEP_Click(object sender, EventArgs e)
        {
            if (TBKQ1.Text == null || TBKQ1.Text == "")
            {
                MessageBox.Show("MỤC RỖNG! KHÔNG CÓ GÌ ĐỂ SAO CHÉP.", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                ABC = TBKQ1.Text;
                Clipboard.SetText(ABC);
                //Clipboard.GetText();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            BTTT_Click(sender, e);
        }

        private void BTDAN_Click(object sender, EventArgs e)
        {
            if (ABC == null || ABC == "")
            {
                MessageBox.Show("MỤC RỖNG! KHÔNG CÓ GÌ ĐỂ DÁN, VUI LÒNG MÃ HÓA CHUỖI CẦN MÃ HÓA VÀ NHẤP VÀO NÚT SAO CHÉP!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                TBNGM.Clear();
                TBNGM.Text = ABC;
            }
        }
    }
}
