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
    public partial class BANG_SBOX : Form
    {
        public BANG_SBOX()
        {
            InitializeComponent();
        }

        private void BANG_SBOX_Load(object sender, EventArgs e)
        {
            PIC_SBOXTHUAN.Hide();
            PIC_SBOXNGHICH.Hide();
            PIC_RCON.Hide();
            LBTXT.Text = null;
        }

        private void BTE_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTRCON_Click(object sender, EventArgs e)
        {
            PIC_SBOXTHUAN.Hide();
            PIC_SBOXNGHICH.Hide();
            PIC_RCON.Show();
            LBTXT.Text = "BẠN ĐANG XEM :\n BẢNG RCON";
        }

        private void BT_SBOX_THUAN_Click(object sender, EventArgs e)
        {
            PIC_SBOXTHUAN.Show();
            PIC_SBOXNGHICH.Hide();
            PIC_RCON.Hide();
            LBTXT.Text = "BẠN ĐANG XEM :\n BẢNG S-BOX THUẬN";
        }

        private void BT_SBOX_NGUOC_Click(object sender, EventArgs e)
        {
            PIC_SBOXTHUAN.Hide();
            PIC_SBOXNGHICH.Show();
            PIC_RCON.Hide();
            LBTXT.Text = "BẠN ĐANG XEM :\n BẢNG S-BOX NGHỊCH";
        }
    }
}
