using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Class
{
    public partial class from_timer : Form
    {
        int second = 0;
        public from_timer()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = second + ("秒");
            second++;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            second = 0;
            label1.Text =  ("0秒");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }
    }
}
