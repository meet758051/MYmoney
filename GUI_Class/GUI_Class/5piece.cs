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
    public partial class _5piece : Form
    {
        public _5piece()
        {
            InitializeComponent();
            this.Controls.Add(new Place(10, 20)); 
        }

        
    }
}
