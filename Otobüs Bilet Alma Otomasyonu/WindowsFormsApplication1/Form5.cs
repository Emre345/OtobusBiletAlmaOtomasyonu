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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }


        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source =Database1.mdb");
        OleDbCommand cmd;
        OleDbDataAdapter da;
        DataSet ds;
       

        private void Form5_Load(object sender, EventArgs e)
        {
            listele();
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


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox2.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox13.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox12.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox11.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            maskedTextBox1.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            comboBox4.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            textBox7.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            textBox8.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            textBox9.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            textBox10.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
        }

        private void button45_Click(object sender, EventArgs e)
        {
            DialogResult silme = new DialogResult();
            silme = MessageBox.Show("Silinsin mi?", "Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);


            if (silme == DialogResult.Yes)
            {
                if (textBox13.Text != "" && textBox12.Text != "" && textBox11.Text != "" && comboBox4.Text != "" && maskedTextBox1.Text != "" && dateTimePicker1.Text != "" && textBox7.Text != "" && textBox8.Text != "" && textBox9.Text != "" && textBox10.Text != "")
                {


                    cmd = new OleDbCommand();
                    con.Open();
                    cmd.Connection = con;
                    cmd.CommandText = "delete from Tablo1 where tc= + '" + dataGridView1.CurrentRow.Cells[3].Value.ToString() + "'";
                    cmd.ExecuteNonQuery();
                    con.Close();
                    listele();

                    textBox7.Text = "";
                    textBox8.Text = "";
                    textBox9.Text = "";
                    textBox10.Text = "";
                    textBox11.Text = "";
                    textBox12.Text = "";
                    textBox13.Text = "";
                    maskedTextBox1.Text = "";
                    dateTimePicker1.Text = "";
                }
                else
                {
                    DialogResult bos = new DialogResult();
                    bos = MessageBox.Show("Silinecek Kişi Seçili Değil", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                }
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
                da = new OleDbDataAdapter("Select * from Tablo1 where ad Like '" + textBox1.Text + "%'", con);
                ds = new DataSet();
                con.Open();
                da.Fill(ds, "Tablo1");
                con.Close();
                dataGridView1.DataSource = ds.Tables["Tablo1"];
            

        }
        
        private void dd(object sender, EventArgs e)
        {
            textBox11.MaxLength = 11;

        }

        private void button44_Click(object sender, EventArgs e)
        {
            if (textBox13.Text != "" && textBox12.Text != "" && textBox11.Text != "" && comboBox4.Text != "" && maskedTextBox1.Text != "" && dateTimePicker1.Text != "" && textBox7.Text != "" && textBox8.Text != "" && textBox9.Text != "" && textBox10.Text != "")
            {
                DialogResult guncelle = new DialogResult();
                guncelle = MessageBox.Show("Düzenlensin Mi?", "Düzenleme", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (guncelle == DialogResult.Yes)
                {
                    if (textBox13.Text != "" && textBox12.Text != "" && textBox11.Text != "" && comboBox4.Text != "" && maskedTextBox1.Text != "" && dateTimePicker1.Text != "" && textBox7.Text != "" && textBox8.Text != "" && textBox9.Text != "" && textBox10.Text != "")
                    {
                        string tarih = DateTime.Now.ToShortDateString();
                        cmd = new OleDbCommand();
                        con.Open();
                        cmd.Connection = con;
                        cmd.CommandText = "update Tablo1 set ad='" + textBox13.Text + "' ,soyad='" + textBox12.Text + "',tel='" + maskedTextBox1.Text + "',cinsiyet='" + comboBox4.Text + "',binis_tarihi='" + tarih + "',binis_yeri='" + textBox7.Text + "',varis_yeri='" + textBox8.Text + "',bilet_adeti='" + textBox9.Text + "',fiyat='" + textBox10.Text + "' where tc='" + textBox11.Text + "'";
                        cmd.ExecuteNonQuery();
                        con.Close();
                        listele();


                        textBox7.Text = "";
                        textBox8.Text = "";
                        textBox9.Text = "";
                        textBox10.Text = "";
                        textBox11.Text = "";
                        textBox12.Text = "";
                        textBox13.Text = "";
                        maskedTextBox1.Text = "";
                        dateTimePicker1.Text = "";
                    }
                    else
                    {
                        DialogResult bos = new DialogResult();
                        bos = MessageBox.Show("Düzenlenecek Değer Seçili Değil.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
         




        }

        private void yöneticiGirişiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 frm = new Form4();
            frm.Show();
            this.Hide();
        }

        private void biletAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            
            DialogResult nesne = new DialogResult();
            nesne = MessageBox.Show("Çıkış Yapılsın Mı?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (nesne == DialogResult.Yes)
            {

                Application.Exit();
            }

            if (nesne == DialogResult.No)
            {
                DialogResult bos = new DialogResult();
                bos = MessageBox.Show("Çıkış Yapılmadı.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            
        }

    

        
    }
}
