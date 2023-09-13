using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        int i = 20;
        
        private void timer1_Tick(object sender, EventArgs e)
        {

            i--;
            if (i == 0)
            {
                timer1.Enabled = false;

                Application.Exit();
            }
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }
    }
}
