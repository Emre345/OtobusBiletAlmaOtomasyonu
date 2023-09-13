using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

       OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source =Database1.mdb");
        OleDbCommand cmd;
        OleDbDataAdapter da;
        DataSet ds;
       

        private void Form2_Load(object sender, EventArgs e)
        {
            listele();
            griddoldur();
        }
         void listele()
        {

            da = new OleDbDataAdapter("Select*from Tablo1", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "Tablo1");
            dataGridView1.DataSource = ds.Tables["Tablo1"];
            con.Close();
        }

         void griddoldur()
         {

             da = new OleDbDataAdapter("Select*from Tablo1", con);
             ds = new DataSet();
             con.Open();
             da.Fill(ds, "Tablo1");
             dataGridView2.DataSource = ds.Tables["Tablo1"];
             con.Close();
         }
    

         public static string koltuk;

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            button1.BackColor = Color.Red;
            textBox15.Text = "Koltuk1";
            
            
            biletadet--;
            if (biletadet == 0)
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                button10.Enabled = false;
                button11.Enabled = false;
                button12.Enabled = false;
                button13.Enabled = false;
                button14.Enabled = false;
                button15.Enabled = false;
                button16.Enabled = false;
                button17.Enabled = false;
                button18.Enabled = false;
                button19.Enabled = false;
                button20.Enabled = false;
                button21.Enabled = true;
            }
           
            
            
        }

        

        private void button2_Click_1(object sender, EventArgs e)
        {
         
            button2.BackColor = Color.Red;
            textBox15.Text = "Koltuk2";
            
         
            biletadet--;
            if (biletadet == 0)
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                button10.Enabled = false;
                button11.Enabled = false;
                button12.Enabled = false;
                button13.Enabled = false;
                button14.Enabled = false;
                button15.Enabled = false;
                button16.Enabled = false;
                button17.Enabled = false;
                button18.Enabled = false;
                button19.Enabled = false;
                button20.Enabled = false;
                button21.Enabled = true;

            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
           
            button3.BackColor = Color.Red;
            textBox15.Text = "Koltuk3";
            
            biletadet--;
            if (biletadet == 0)
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                button10.Enabled = false;
                button11.Enabled = false;
                button12.Enabled = false;
                button13.Enabled = false;
                button14.Enabled = false;
                button15.Enabled = false;
                button16.Enabled = false;
                button17.Enabled = false;
                button18.Enabled = false;
                button19.Enabled = false;
                button20.Enabled = false;
                button21.Enabled = true;

            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
           
            button4.BackColor = Color.Red;
            textBox15.Text = "Koltuk4";
            biletadet--;
            if (biletadet == 0)
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                button10.Enabled = false;
                button11.Enabled = false;
                button12.Enabled = false;
                button13.Enabled = false;
                button14.Enabled = false;
                button15.Enabled = false;
                button16.Enabled = false;
                button17.Enabled = false;
                button18.Enabled = false;
                button19.Enabled = false;
                button20.Enabled = false;
                button21.Enabled = true;

            }
        }

        private void button5_Click_1(object sender, EventArgs e)

        {
            
            button5.BackColor = Color.Red;
            textBox15.Text = "Koltuk5";
            biletadet--;
            if (biletadet == 0)
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                button10.Enabled = false;
                button11.Enabled = false;
                button12.Enabled = false;
                button13.Enabled = false;
                button14.Enabled = false;
                button15.Enabled = false;
                button16.Enabled = false;
                button17.Enabled = false;
                button18.Enabled = false;
                button19.Enabled = false;
                button20.Enabled = false;
                button21.Enabled = true;




            }
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            ;
            button6.BackColor = Color.Red;
            textBox15.Text = "Koltuk6";
            biletadet--;
            if (biletadet == 0)
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                button10.Enabled = false;
                button11.Enabled = false;
                button12.Enabled = false;
                button13.Enabled = false;
                button14.Enabled = false;
                button15.Enabled = false;
                button16.Enabled = false;
                button17.Enabled = false;
                button18.Enabled = false;
                button19.Enabled = false;
                button20.Enabled = false;
                button21.Enabled = true;


            }
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
          
            button7.BackColor = Color.Red;
            textBox15.Text = "Koltuk7";
            biletadet--;
            if (biletadet == 0)
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                button10.Enabled = false;
                button11.Enabled = false;
                button12.Enabled = false;
                button13.Enabled = false;
                button14.Enabled = false;
                button15.Enabled = false;
                button16.Enabled = false;
                button17.Enabled = false;
                button18.Enabled = false;
                button19.Enabled = false;
                button20.Enabled = false;
                button21.Enabled = true;

            }
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            
            button8.BackColor = Color.Red;
            textBox15.Text = "Koltuk8";
            biletadet--;
            if (biletadet == 0)
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                button10.Enabled = false;
                button11.Enabled = false;
                button12.Enabled = false;
                button13.Enabled = false;
                button14.Enabled = false;
                button15.Enabled = false;
                button16.Enabled = false;
                button17.Enabled = false;
                button18.Enabled = false;
                button19.Enabled = false;
                button20.Enabled = false;
                button21.Enabled = true;

            }
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
           
            button9.BackColor = Color.Red;
            textBox15.Text = "Koltuk9";
            biletadet--;
            if (biletadet == 0)
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                button10.Enabled = false;
                button11.Enabled = false;
                button12.Enabled = false;
                button13.Enabled = false;
                button14.Enabled = false;
                button15.Enabled = false;
                button16.Enabled = false;
                button17.Enabled = false;
                button18.Enabled = false;
                button19.Enabled = false;
                button20.Enabled = false;
                button21.Enabled = true;

            }
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            textBox15.Text = "Koltuk10";
            button10.BackColor = Color.Red;
            biletadet--;
            if (biletadet == 0)
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                button10.Enabled = false;
                button11.Enabled = false;
                button12.Enabled = false;
                button13.Enabled = false;
                button14.Enabled = false;
                button15.Enabled = false;
                button16.Enabled = false;
                button17.Enabled = false;
                button18.Enabled = false;
                button19.Enabled = false;
                button20.Enabled = false;
                button21.Enabled = true;

            }
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            textBox15.Text = "Koltuk11";
            button11.BackColor = Color.Red;
            biletadet--;
            if (biletadet == 0)
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                button10.Enabled = false;
                button11.Enabled = false;
                button12.Enabled = false;
                button13.Enabled = false;
                button14.Enabled = false;
                button15.Enabled = false;
                button16.Enabled = false;
                button17.Enabled = false;
                button18.Enabled = false;
                button19.Enabled = false;
                button20.Enabled = false;
                button21.Enabled = true;

            }
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            textBox15.Text = "Koltuk12";
            button12.BackColor = Color.Red;
            biletadet--;
            if (biletadet == 0)
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                button10.Enabled = false;
                button11.Enabled = false;
                button12.Enabled = false;
                button13.Enabled = false;
                button14.Enabled = false;
                button15.Enabled = false;
                button16.Enabled = false;
                button17.Enabled = false;
                button18.Enabled = false;
                button19.Enabled = false;
                button20.Enabled = false;
                button21.Enabled = true;

            }
        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            textBox15.Text = "Koltuk13";
            button13.BackColor = Color.Red;
            biletadet--;
            if (biletadet == 0)
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                button10.Enabled = false;
                button11.Enabled = false;
                button12.Enabled = false;
                button13.Enabled = false;
                button14.Enabled = false;
                button15.Enabled = false;
                button16.Enabled = false;
                button17.Enabled = false;
                button18.Enabled = false;
                button19.Enabled = false;
                button20.Enabled = false;
                button21.Enabled = true;

            }
        }

        private void button14_Click_1(object sender, EventArgs e)
        {
            textBox15.Text = "Koltuk14";
            button14.BackColor = Color.Red;
            biletadet--;
            if (biletadet == 0)
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                button10.Enabled = false;
                button11.Enabled = false;
                button12.Enabled = false;
                button13.Enabled = false;
                button14.Enabled = false;
                button15.Enabled = false;
                button16.Enabled = false;
                button17.Enabled = false;
                button18.Enabled = false;
                button19.Enabled = false;
                button20.Enabled = false;
                button21.Enabled = true;

            }
        }

        private void button15_Click_1(object sender, EventArgs e)
        {
            textBox15.Text = "Koltuk15";
            button15.BackColor = Color.Red;
            biletadet--;
            if (biletadet == 0)
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                button10.Enabled = false;
                button11.Enabled = false;
                button12.Enabled = false;
                button13.Enabled = false;
                button14.Enabled = false;
                button15.Enabled = false;
                button16.Enabled = false;
                button17.Enabled = false;
                button18.Enabled = false;
                button19.Enabled = false;
                button20.Enabled = false;
                button21.Enabled = true;

            }
        }

        private void button16_Click_1(object sender, EventArgs e)
        {
            textBox15.Text = "Koltuk16";
            button16.BackColor = Color.Red;
            biletadet--;
            if (biletadet == 0)
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                button10.Enabled = false;
                button11.Enabled = false;
                button12.Enabled = false;
                button13.Enabled = false;
                button14.Enabled = false;
                button15.Enabled = false;
                button16.Enabled = false;
                button17.Enabled = false;
                button18.Enabled = false;
                button19.Enabled = false;
                button20.Enabled = false;
                button21.Enabled = true;

            }
        }

        private void button17_Click_1(object sender, EventArgs e)
        {
            textBox15.Text = "Koltuk17" ;
            button17.BackColor = Color.Red;
            biletadet--;
            if (biletadet == 0)
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                button10.Enabled = false;
                button11.Enabled = false;
                button12.Enabled = false;
                button13.Enabled = false;
                button14.Enabled = false;
                button15.Enabled = false;
                button16.Enabled = false;
                button17.Enabled = false;
                button18.Enabled = false;
                button19.Enabled = false;
                button20.Enabled = false;
                button21.Enabled = true;

            }
        }

        private void button18_Click_1(object sender, EventArgs e)
        {
            textBox15.Text = "Koltuk18";
            button18.BackColor = Color.Red;
            biletadet--;
            if (biletadet == 0)
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                button10.Enabled = false;
                button11.Enabled = false;
                button12.Enabled = false;
                button13.Enabled = false;
                button14.Enabled = false;
                button15.Enabled = false;
                button16.Enabled = false;
                button17.Enabled = false;
                button18.Enabled = false;
                button19.Enabled = false;
                button20.Enabled = false;
                button21.Enabled = true;

            }
        }

        private void button19_Click_1(object sender, EventArgs e)
        {
          textBox15.Text = "Koltuk19";
            button19.BackColor = Color.Red;
            biletadet--;
            if (biletadet == 0)
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                button10.Enabled = false;
                button11.Enabled = false;
                button12.Enabled = false;
                button13.Enabled = false;
                button14.Enabled = false;
                button15.Enabled = false;
                button16.Enabled = false;
                button17.Enabled = false;
                button18.Enabled = false;
                button19.Enabled = false;
                button20.Enabled = false;
                button21.Enabled = true;

            }
        }

        private void button20_Click_1(object sender, EventArgs e)
        {
            textBox15.Text = "Koltuk20";
            button20.BackColor = Color.Red;
            biletadet--;
            if (biletadet == 0)
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                button10.Enabled = false;
                button11.Enabled = false;
                button12.Enabled = false;
                button13.Enabled = false;
                button14.Enabled = false;
                button15.Enabled = false;
                button16.Enabled = false;
                button17.Enabled = false;
                button18.Enabled = false;
                button19.Enabled = false;
                button20.Enabled = false;
                button21.Enabled = true;

            }
         
        }

        private void button21_Click(object sender, EventArgs e)
        {
                tabControl1.SelectedTab = tabPage3;
            
        }

        private void button22_Click(object sender, EventArgs e)
        {
            DialogResult asd = new DialogResult();
            asd = MessageBox.Show("Çıkış Yapılsın Mı?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (asd == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (asd == DialogResult.No)
            {
                MessageBox.Show("Çıkış Yapılmadı..");

            }

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button23_Click(object sender, EventArgs e)
        {
           
            button1.BackColor = Color.Lime;
            biletadet++;
            if (biletadet > 0)
            {
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
                button8.Enabled = true;
                button9.Enabled = true;
                button10.Enabled = true;
                button11.Enabled = true;
                button12.Enabled = true;
                button13.Enabled = true;
                button14.Enabled = true;
                button15.Enabled = true;
                button16.Enabled = true;
                button17.Enabled = true;
                button18.Enabled = true;
                button19.Enabled = true;
                button20.Enabled = true;
                button21.Enabled = false;
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            button2.BackColor = Color.Lime;
            biletadet++;
            if (biletadet > 0)
            {
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
                button8.Enabled = true;
                button9.Enabled = true;
                button10.Enabled = true;
                button11.Enabled = true;
                button12.Enabled = true;
                button13.Enabled = true;
                button14.Enabled = true;
                button15.Enabled = true;
                button16.Enabled = true;
                button17.Enabled = true;
                button18.Enabled = true;
                button19.Enabled = true;
                button20.Enabled = true;
                button21.Enabled = false;
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            button3.BackColor = Color.Lime;
            biletadet++;
            if (biletadet > 0)
            {
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
                button8.Enabled = true;
                button9.Enabled = true;
                button10.Enabled = true;
                button11.Enabled = true;
                button12.Enabled = true;
                button13.Enabled = true;
                button14.Enabled = true;
                button15.Enabled = true;
                button16.Enabled = true;
                button17.Enabled = true;
                button18.Enabled = true;
                button19.Enabled = true;
                button20.Enabled = true;
                button21.Enabled = false;
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            button4.BackColor = Color.Lime;
            biletadet++;
            if (biletadet > 0)
            {
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
                button8.Enabled = true;
                button9.Enabled = true;
                button10.Enabled = true;
                button11.Enabled = true;
                button12.Enabled = true;
                button13.Enabled = true;
                button14.Enabled = true;
                button15.Enabled = true;
                button16.Enabled = true;
                button17.Enabled = true;
                button18.Enabled = true;
                button19.Enabled = true;
                button20.Enabled = true;
                button21.Enabled = false;
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            button5.BackColor = Color.Lime;
            biletadet++;
            if (biletadet > 0)
            {
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
                button8.Enabled = true;
                button9.Enabled = true;
                button10.Enabled = true;
                button11.Enabled = true;
                button12.Enabled = true;
                button13.Enabled = true;
                button14.Enabled = true;
                button15.Enabled = true;
                button16.Enabled = true;
                button17.Enabled = true;
                button18.Enabled = true;
                button19.Enabled = true;
                button20.Enabled = true;
                button21.Enabled = false;
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            button6.BackColor = Color.Lime;
            biletadet++;
            if (biletadet > 0)
            {
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
                button8.Enabled = true;
                button9.Enabled = true;
                button10.Enabled = true;
                button11.Enabled = true;
                button12.Enabled = true;
                button13.Enabled = true;
                button14.Enabled = true;
                button15.Enabled = true;
                button16.Enabled = true;
                button17.Enabled = true;
                button18.Enabled = true;
                button19.Enabled = true;
                button20.Enabled = true;
                button21.Enabled = false;
            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            button7.BackColor = Color.Lime;
            biletadet++;
            if (biletadet > 0)
            {
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
                button8.Enabled = true;
                button9.Enabled = true;
                button10.Enabled = true;
                button11.Enabled = true;
                button12.Enabled = true;
                button13.Enabled = true;
                button14.Enabled = true;
                button15.Enabled = true;
                button16.Enabled = true;
                button17.Enabled = true;
                button18.Enabled = true;
                button19.Enabled = true;
                button20.Enabled = true;
                button21.Enabled = false;
            }
        }

        private void button30_Click(object sender, EventArgs e)
        {
            button8.BackColor = Color.Lime;
            biletadet++;
            if (biletadet > 0)
            {
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
                button8.Enabled = true;
                button9.Enabled = true;
                button10.Enabled = true;
                button11.Enabled = true;
                button12.Enabled = true;
                button13.Enabled = true;
                button14.Enabled = true;
                button15.Enabled = true;
                button16.Enabled = true;
                button17.Enabled = true;
                button18.Enabled = true;
                button19.Enabled = true;
                button20.Enabled = true;
                button21.Enabled = false;
            }
        }

        private void button31_Click(object sender, EventArgs e)
        {
            button9.BackColor = Color.Lime;
            biletadet++;
            if (biletadet > 0)
            {
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
                button8.Enabled = true;
                button9.Enabled = true;
                button10.Enabled = true;
                button11.Enabled = true;
                button12.Enabled = true;
                button13.Enabled = true;
                button14.Enabled = true;
                button15.Enabled = true;
                button16.Enabled = true;
                button17.Enabled = true;
                button18.Enabled = true;
                button19.Enabled = true;
                button20.Enabled = true;
                button21.Enabled = false;
            }
        }

        private void button32_Click(object sender, EventArgs e)
        {
            button10.BackColor = Color.Lime;
            biletadet++;
            if (biletadet > 0)
            {
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
                button8.Enabled = true;
                button9.Enabled = true;
                button10.Enabled = true;
                button11.Enabled = true;
                button12.Enabled = true;
                button13.Enabled = true;
                button14.Enabled = true;
                button15.Enabled = true;
                button16.Enabled = true;
                button17.Enabled = true;
                button18.Enabled = true;
                button19.Enabled = true;
                button20.Enabled = true;
                button21.Enabled = false;
            }
        }

        private void button33_Click(object sender, EventArgs e)
        {
            button11.BackColor = Color.Lime;
            biletadet++;
            if (biletadet > 0)
            {
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
                button8.Enabled = true;
                button9.Enabled = true;
                button10.Enabled = true;
                button11.Enabled = true;
                button12.Enabled = true;
                button13.Enabled = true;
                button14.Enabled = true;
                button15.Enabled = true;
                button16.Enabled = true;
                button17.Enabled = true;
                button18.Enabled = true;
                button19.Enabled = true;
                button20.Enabled = true;
                button21.Enabled = false;
            }
        }

        private void button34_Click(object sender, EventArgs e)
        {
            button12.BackColor = Color.Lime;
            biletadet++;
            if (biletadet > 0)
            {
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
                button8.Enabled = true;
                button9.Enabled = true;
                button10.Enabled = true;
                button11.Enabled = true;
                button12.Enabled = true;
                button13.Enabled = true;
                button14.Enabled = true;
                button15.Enabled = true;
                button16.Enabled = true;
                button17.Enabled = true;
                button18.Enabled = true;
                button19.Enabled = true;
                button20.Enabled = true;
                button21.Enabled = false;
            }
        }

        private void button35_Click(object sender, EventArgs e)
        {
            button13.BackColor = Color.Lime;
            biletadet++;
            if (biletadet > 0)
            {
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
                button8.Enabled = true;
                button9.Enabled = true;
                button10.Enabled = true;
                button11.Enabled = true;
                button12.Enabled = true;
                button13.Enabled = true;
                button14.Enabled = true;
                button15.Enabled = true;
                button16.Enabled = true;
                button17.Enabled = true;
                button18.Enabled = true;
                button19.Enabled = true;
                button20.Enabled = true;
                button21.Enabled = false;
            }
        }

        private void button36_Click(object sender, EventArgs e)
        {
            button14.BackColor = Color.Lime;
            biletadet++;
            if (biletadet > 0)
            {
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
                button8.Enabled = true;
                button9.Enabled = true;
                button10.Enabled = true;
                button11.Enabled = true;
                button12.Enabled = true;
                button13.Enabled = true;
                button14.Enabled = true;
                button15.Enabled = true;
                button16.Enabled = true;
                button17.Enabled = true;
                button18.Enabled = true;
                button19.Enabled = true;
                button20.Enabled = true;
                button21.Enabled = false;
            }
        }

        private void button37_Click(object sender, EventArgs e)
        {
            button15.BackColor = Color.Lime;
            biletadet++;
            if (biletadet > 0)
            {
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
                button8.Enabled = true;
                button9.Enabled = true;
                button10.Enabled = true;
                button11.Enabled = true;
                button12.Enabled = true;
                button13.Enabled = true;
                button14.Enabled = true;
                button15.Enabled = true;
                button16.Enabled = true;
                button17.Enabled = true;
                button18.Enabled = true;
                button19.Enabled = true;
                button20.Enabled = true;
                button21.Enabled = false;
            }
        }

        private void button38_Click(object sender, EventArgs e)
        {
            button16.BackColor = Color.Lime;
            biletadet++;
            if (biletadet > 0)
            {
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
                button8.Enabled = true;
                button9.Enabled = true;
                button10.Enabled = true;
                button11.Enabled = true;
                button12.Enabled = true;
                button13.Enabled = true;
                button14.Enabled = true;
                button15.Enabled = true;
                button16.Enabled = true;
                button17.Enabled = true;
                button18.Enabled = true;
                button19.Enabled = true;
                button20.Enabled = true;
                button21.Enabled = false;
            }
        }

        private void button39_Click(object sender, EventArgs e)
        {
            button17.BackColor = Color.Lime;
            biletadet++;
            if (biletadet > 0)
            {
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
                button8.Enabled = true;
                button9.Enabled = true;
                button10.Enabled = true;
                button11.Enabled = true;
                button12.Enabled = true;
                button13.Enabled = true;
                button14.Enabled = true;
                button15.Enabled = true;
                button16.Enabled = true;
                button17.Enabled = true;
                button18.Enabled = true;
                button19.Enabled = true;
                button20.Enabled = true;
                button21.Enabled = false;
            }
        }

        private void button40_Click(object sender, EventArgs e)
        {
            button18.BackColor = Color.Lime;
            biletadet++;
            if (biletadet > 0)
            {
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
                button8.Enabled = true;
                button9.Enabled = true;
                button10.Enabled = true;
                button11.Enabled = true;
                button12.Enabled = true;
                button13.Enabled = true;
                button14.Enabled = true;
                button15.Enabled = true;
                button16.Enabled = true;
                button17.Enabled = true;
                button18.Enabled = true;
                button19.Enabled = true;
                button21.Enabled = false;
                button20.Enabled = true;
            }
        }

        private void button41_Click(object sender, EventArgs e)
        {
            button19.BackColor = Color.Lime;
            biletadet++;
            if (biletadet > 0)
            {
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
                button8.Enabled = true;
                button9.Enabled = true;
                button10.Enabled = true;
                button11.Enabled = true;
                button12.Enabled = true;
                button13.Enabled = true;
                button14.Enabled = true;
                button15.Enabled = true;
                button16.Enabled = true;
                button17.Enabled = true;
                button18.Enabled = true;
                button19.Enabled = true;
                button20.Enabled = true;
                button21.Enabled = false;
            }
        }

        private void button42_Click(object sender, EventArgs e)
        {
            button20.BackColor = Color.Lime;
            biletadet++;
            if (biletadet > 0)
            {
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
                button8.Enabled = true;
                button9.Enabled = true;
                button10.Enabled = true;
                button11.Enabled = true;
                button12.Enabled = true;
                button13.Enabled = true;
                button14.Enabled = true;
                button15.Enabled = true;
                button16.Enabled = true;
                button17.Enabled = true;
                button18.Enabled = true;
                button19.Enabled = true;
                button20.Enabled = true;
                button21.Enabled = false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.MaxLength = 4;
            if (textBox1.Text.Length == 4)
            {
                textBox2.Focus();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.MaxLength = 4;
            if (textBox2.Text.Length == 4)
            {
                textBox3.Focus();
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.MaxLength = 4;
            if (textBox3.Text.Length == 4)
            {
                textBox4.Focus();
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            textBox4.MaxLength = 4;
            if (textBox4.Text.Length == 4)
            {
                textBox5.Focus();
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            textBox6.MaxLength = 3;
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button43_Click(object sender, EventArgs e)
        {

        }

        public static int biletadet;

        private void button43_Click_1(object sender, EventArgs e)
        {
            DialogResult nesne = new DialogResult();
            nesne = MessageBox.Show("Bilgileri Onaylıyor Musunuz?", "Onaylama", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (nesne == DialogResult.Yes)
            {

                if (textBox13.Text != "" && textBox12.Text != "" && textBox11.Text != "" && comboBox4.Text != "" && maskedTextBox1.Text != "" && dateTimePicker1.Text != "" && comboBox5.Text != "" && comboBox6.Text != "" && textBox9.Text != "" && textBox10.Text != "")
                {
                    string tarih = DateTime.Now.ToShortDateString();
                    DialogResult yes = new DialogResult();
                    yes=MessageBox.Show("Onaylandı","",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    cmd = new OleDbCommand();
                    con.Open();
                    cmd.Connection = con;
                    cmd.CommandText = "Insert into Tablo1 (ad,soyad,tc,tel,cinsiyet,binis_tarihi,binis_yeri,varis_yeri,bilet_adeti,fiyat,gidis) values ('" + textBox13.Text + "','" + textBox12.Text + "','" + textBox11.Text + "','" + maskedTextBox1.Text + "','" + comboBox4.Text + "','" + tarih + "','" + comboBox5.Text + "','" + comboBox6.Text + "','" + textBox9.Text + "','" + textBox10.Text + "','"+textBox15.Text+"')";
                    cmd.ExecuteNonQuery();
                    con.Close();
                    listele();
                    griddoldur();
                 
                  
                    
                    tabControl1.SelectedTab = tabPage2;
                    listele();



                }
             
                else
                {
                    DialogResult bosluk = new DialogResult();
                    bosluk = MessageBox.Show("Boş Yer Bırakmayınız.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }





            }


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

      
        





        

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void fd(object sender, EventArgs e)
        {
            textBox11.MaxLength = 11;
        }

        private void button45_Click(object sender, EventArgs e)
        {

        }

        private void button45_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
        }

        private void button44_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "" && comboBox1.Text != "" && comboBox2.Text != "" && comboBox3.Text != "")
            {
                DialogResult nesne = new DialogResult();
                nesne = MessageBox.Show("Ödeme Tamamlansın Mı?", "Ödeme", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (nesne == DialogResult.Yes)
                {
                    Form7 frm7 = new Form7();
                    frm7.Show();
                    frm7.timer1.Enabled = true;
                    this.Hide();
                }
                else if (nesne == DialogResult.No)
                {
                    DialogResult bos = new DialogResult();
                    bos = MessageBox.Show("Ödenme Tamamlanmadı.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            else
            {
                DialogResult asd = new DialogResult();
                asd = MessageBox.Show("Boş Yer Bırakmayınız.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
         
        }

        private void button46_Click(object sender, EventArgs e)
        {
            DialogResult asd = new DialogResult();
            asd = MessageBox.Show("Çıkış Yapılsın Mı?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (asd == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (asd == DialogResult.No)
            {
                DialogResult geri = new DialogResult();
                geri = MessageBox.Show("Çıkış Yapılmadı.", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                

            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button47_Click(object sender, EventArgs e)
        {

            DialogResult asd = new DialogResult();
            asd = MessageBox.Show("Çıkış Yapılsın Mı?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (asd == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (asd == DialogResult.No)
            {
                DialogResult cikis = new DialogResult();
                cikis=MessageBox.Show("Çıkış Yapılmadı.","",MessageBoxButtons.OK,MessageBoxIcon.Error);

            }
        }

        private void button49_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage3;
        }

        private void button50_Click(object sender, EventArgs e)
        {
            biletadet = Convert.ToInt16(textBox16.Text);
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button10.Enabled = true;
            button11.Enabled = true;
            button12.Enabled = true;
            button13.Enabled = true;
            button14.Enabled = true;
            button15.Enabled = true;
            button16.Enabled = true;
            button17.Enabled = true;
            button18.Enabled = true;
            button19.Enabled = true;
            button20.Enabled = true;
            button23.Enabled = true;
            button24.Enabled = true;
            button25.Enabled = true;
            button26.Enabled = true;
            button27.Enabled = true; 
            button28.Enabled = true;
            button29.Enabled = true; 
            button30.Enabled = true;
            button31.Enabled = true; 
            button32.Enabled = true;
            button33.Enabled = true;
            button34.Enabled = true;
            button35.Enabled = true;
            button36.Enabled = true;
            button37.Enabled = true;
            button38.Enabled = true;
            button39.Enabled = true;
            button40.Enabled = true;
            button41.Enabled = true;
            button42.Enabled = true;
            
        }

        private void button48_Click(object sender, EventArgs e)
        {
            Form1 asd = new Form1();
            asd.Show();
            this.Hide();
        }

       

       


    }
}
