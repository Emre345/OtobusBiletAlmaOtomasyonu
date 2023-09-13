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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && maskedTextBox1.Text != "" && textBox5.Text != "" && dateTimePicker1.Text != "" && comboBox1.Text != "" && comboBox2.Text != ""&&comboBox3.Text!=""&&radioButton1.Text!=""&&radioButton2.Text!="")
            {
                if (radioButton2.Checked)
                {
                    Form3 frm3 = new Form3();
                    frm3.label13.Text = textBox5.Text;
                    frm3.textBox13.Text = textBox1.Text;
                    frm3.textBox12.Text = textBox2.Text;
                    frm3.textBox11.Text = textBox3.Text;
                    frm3.maskedTextBox1.Text = maskedTextBox1.Text;
                    frm3.comboBox4.Text = comboBox3.Text;
                    frm3.dateTimePicker1.Text = dateTimePicker1.Text;
                    frm3.comboBox5.Text = comboBox1.Text;
                    frm3.comboBox6.Text = comboBox2.Text;
                    frm3.textBox9.Text = textBox4.Text;
                    frm3.textBox10.Text = textBox5.Text;
                    frm3.textBox7.Text = textBox4.Text;
                    frm3.Show();
                    this.Hide();
            
                }
                else if (radioButton1.Checked)
                {
                 
                    Form2 frm = new Form2();
                    frm.label13.Text = textBox5.Text;
                    frm.textBox13.Text = textBox1.Text;
                    frm.textBox12.Text = textBox2.Text;
                    frm.textBox11.Text = textBox3.Text;
                    frm.maskedTextBox1.Text = maskedTextBox1.Text;
                    frm.comboBox4.Text = comboBox3.Text;
                    frm.dateTimePicker1.Text = dateTimePicker1.Text;
                    frm.comboBox5.Text = comboBox1.Text;
                    frm.comboBox6.Text = comboBox2.Text;
                    frm.textBox9.Text = textBox4.Text;
                    frm.textBox10.Text = textBox5.Text;
                    frm.textBox16.Text = textBox4.Text;
                    
                    frm.Show();
                    this.Hide();
                }
               
            
               
            }
            else
            {
                DialogResult hata = new DialogResult();
                hata = MessageBox.Show("Lütfen Boş Yer Bırakmayınız.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
          
          

           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form6 asd = new Form6();
            asd.Show();
            this.Hide();

        
        }

      

      

      

        
        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                int sonuc;
                int fiyat = 50;
                int biletsay = Convert.ToInt32(textBox4.Text);
                sonuc = fiyat * biletsay*2;
                textBox5.Text = sonuc.ToString()+" TL";
            }



        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {

                int sonuc;
                int fiyat=50;
                int biletsay=Convert.ToInt32(textBox4.Text);
                sonuc = fiyat * biletsay;
                textBox5.Text = sonuc.ToString()+" TL";
                
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void asdaa(object sender, EventArgs e)
        {
            textBox3.MaxLength = 11;
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4();
            frm4.Show();
            this.Hide();
        }

       

        

     

       
    }
}
