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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source =Database1.mdb");
            OleDbCommand cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "Select * from Tablo2 where k_ad='" + textBox1.Text + "' and k_sifre='" + textBox2.Text + "'";
            OleDbDataReader dr = cmd.ExecuteReader();
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                DialogResult ads = new DialogResult();
                ads = MessageBox.Show("Lütfen Boş Yer Bırakmayınız.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (dr.Read())
            {
                Form5 frm = new Form5();
                frm.Show();
                this.Hide();

            }
            else
            {
                DialogResult hata = new DialogResult();
                hata=MessageBox.Show("Kullanıcı Adı Veya Şifre Hatalı.","",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

       
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.PasswordChar = '\0';
            }
            else
            {
                textBox2.PasswordChar = '*';
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sifre = Convert.ToString(textBox3.Text);
            string sifret = Convert.ToString(textBox4.Text);
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source =Database1.mdb");
            OleDbCommand cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "Select * from Tablo2 where k_ad='" + textBox6.Text + "' and k_sifre='" + textBox5.Text + "'";
            OleDbDataReader dr = cmd.ExecuteReader();
            if (textBox6.Text == "" || textBox5.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                DialogResult ads = new DialogResult();
                ads = MessageBox.Show("Lütfen Boş Yer Bırakmayınız.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


            else if (sifre != sifret)
            {
                DialogResult hata = new DialogResult();
                hata = MessageBox.Show("Şifreler Uyuşmuyor.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                
            }

            else if (dr.Read())
            {
                DialogResult nesne = new DialogResult();
                nesne = MessageBox.Show("Şifre Değiştirilsin Mi?", "Şifre Değiştirme", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (nesne == DialogResult.Yes)
                {
                    con = new OleDbConnection("Provider=Microsoft.JET.OLEDB.4.0;Data Source=Database1.mdb");
                    cmd = new OleDbCommand();
                    con.Open();
                    cmd.Connection = con;
                    cmd.CommandText = "update Tablo2 set k_sifre='" + textBox3.Text + "'";
                    cmd.ExecuteNonQuery();
                    con.Close();
                    DialogResult asd = new DialogResult();
                    asd = MessageBox.Show("Şifreniz Değiştirildi", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tabControl1.SelectedTab = tabPage1;
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                   

                }
                else if (nesne == DialogResult.No)
                {
                    DialogResult no = new DialogResult();
                    no = MessageBox.Show("Şifre Güncellenmedi.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                    textBox6.Text = "";

                }

            }


            else
            {
                DialogResult hata = new DialogResult();
                hata=MessageBox.Show("Kullanıcı Adı Veya Şifre Hatalı.","",MessageBoxButtons.OK,MessageBoxIcon.Information);
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                tabControl1.SelectedTab = tabPage2;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form6 frm = new Form6();
            frm.Show();
            this.Hide();
        }

        

       

        

        






    }
}
