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
    public partial class text_math : Form
    {
        public text_math()
        {
            InitializeComponent();
        }

        private void button_result_Click(object sender, EventArgs e)
        {
            int add1 = 0, add2 = 0;
            try
            {
                add1 = Int32.Parse(textBox1.Text);
                add2 = Int32.Parse(textBox2.Text);
            }
            catch (System.FormatException)
            {
                MessageBox.Show("請輸入數字");
            }
          
            label2.Text = (add1 + add2).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int reduce1 = 0, reduce2 = 0;
            try
            {
                reduce1 = Int32.Parse(textBox_reduce1.Text);
                reduce2 = Int32.Parse(textBox_reduce2.Text);
            }
            catch (System.FormatException)
            {
                MessageBox.Show("請輸入數字");
            }

            label_reduse.Text = (reduce1 - reduce2).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int input1 = 0, input2 = 0;
            try
            {
                input1 = Int32.Parse(textBox_X1.Text);
                input2 = Int32.Parse(textBox_X2.Text);
            }
            catch (System.Exception)
            {
                MessageBox.Show("請輸入數字");
                input1 = 0;
                input2 = 0;
            }

            label_X.Text = (input1 * input2).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int input1 = 0, input2 = 0;
            try
            {
                input1 = Int32.Parse(textBox_div1.Text);
                input2 = Int32.Parse(textBox_div2.Text);
            }
            catch (System.Exception)
            {
                MessageBox.Show("請輸入數字");
                input1 = 0;
                input2 = 0;
            }

            label_div.Text = (input1 / input2).ToString();
        }
    }
}
