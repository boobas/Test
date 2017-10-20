using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace AES_C_SHARP
{
    public partial class Form2 : Form
    {
        int temp = 0;
        string copy;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {


        }
        private void BTMAHOA_Click(object sender, EventArgs e)
        {
            temp = 1;
            BTRCON.Show();
            RT2.Hide();
            BTCOPY.Enabled = true;
            BTCOPY.Text = "COPY THUẬT TOÁN MÃ HÓA";
        }
        private void BTGIAIMA_Click(object sender, EventArgs e)
        {
            temp = 2;
            BTRCON.Hide();
            RT2.Show();
            BTCOPY.Enabled = true;
            BTCOPY.Text = "COPY THUẬT TOÁN GIẢI MÃ";
        }
        private void BTCOPY_Click(object sender, EventArgs e)
        {

            if (temp == 1)
            {
                copy = BTRCON.Text;
                Clipboard.SetText(copy);
                MessageBox.Show("ĐÃ SAO CHÉP THÀNH CÔNG THUẬT TOÁN MÃ HÓA", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (temp == 2)
            {
                copy = RT2.Text;
                Clipboard.SetText(copy);
                MessageBox.Show("ĐÃ SAO CHÉP THÀNH CÔNG THUẬT TOÁN GIẢI MÃ", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (temp == 0)
            {
                
            }

        }
        private void BTPHU_Click(object sender, EventArgs e)
        {
            BANG_SBOX ViewCode = new BANG_SBOX();
            this.Enabled = true;
            ViewCode.ShowDialog();
        }

        private void BTE_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            BTRCON.Hide();
            RT2.Hide();
            BTCOPY.Enabled = false;
        }
    }
}
