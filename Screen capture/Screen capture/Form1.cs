using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Screen_capture
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            System.Threading.Thread.Sleep(1000);
            SendKeys.Send("{PRTSC}");
            Image img = Clipboard.GetImage();
            pictureBox1.Image = img;
            img.Save("D:\\myimg.jpg");
            this.Show();
        }
    }
}
