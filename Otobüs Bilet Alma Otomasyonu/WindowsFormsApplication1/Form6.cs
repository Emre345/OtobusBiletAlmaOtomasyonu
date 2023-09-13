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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 asd = new Form1();
            asd.Show();
            this.Hide();

                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 dsa = new Form4();
            dsa.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult asd = new DialogResult();
            asd = MessageBox.Show("Çıkış Yapılsın Mı?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (asd == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (asd == DialogResult.No)
            {
                DialogResult no = new DialogResult();
                no= MessageBox.Show("Çıkış Yapılmadı.","",MessageBoxButtons.OK,MessageBoxIcon.Information);

            }
        }
    }
}
