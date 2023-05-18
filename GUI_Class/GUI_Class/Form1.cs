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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("幹嘛?");

        }

        private void btm_0313_Click(object sender, EventArgs e)
        {
            MessageBox.Show("點三小(#`皿´)");
            Form from_button = new Form_button();
            from_button.Show();
        }

        private void btmctof_Click(object sender, EventArgs e)
        {
            Form ctof = new ctof();
            ctof.Show();
        }

        private void button_math_Click(object sender, EventArgs e)
        {
            Form text_math = new text_math();
            text_math.Show();
        }

        private void button_Timer_Click(object sender, EventArgs e)
        {
            Form text_math = new from_timer();
            text_math.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form from = new CheckBox();
            from.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form from = new Layout();
            from.Show();
        }
    }
}
