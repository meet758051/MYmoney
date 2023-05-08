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
    public partial class Form_button : Form
    {
        public Form_button()
        {
            InitializeComponent();
        }

        private void btm0313_Click(object sender, EventArgs e)
        {
            
            if (btm0313.Text == "我已經被按過了")
                btm0313.Text = "請按我一下";
            else if(btm0313.Text == "請按我一下")
                 btm0313.Text = "我已經被按過了";

        }

        private void btmadd_Click(object sender, EventArgs e)
        {
            String labst = lab0.Text;
           
            int sum = Int32.Parse(labst) + 1;
            lab0.Text = sum.ToString();

        }

        private void btn_reubce_Click(object sender, EventArgs e)
        {
            String count = lab0.Text;
            int sun = Int32.Parse(count) - 1;
            lab0.Text = sun.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (label1.Text == "沒意義你還點")
            {
                label1.Text = "好了不要再點了";
            }
            else if (label1.Text == "好了不要再點了")
                label1.Text = "就叫你不要點了";
            else if (label1.Text == "就叫你不要點了")
                label1.Text = "好啊很愛點是不是?";
            else if (label1.Text == "好啊很愛點是不是?")
                label1.Text = "慢慢點吧~";
            else label1.Text = "沒意義你還點";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int size = 10;
            button2.Size = new Size(button2.Width + size, button2.Height + size);
        }
    }
}
