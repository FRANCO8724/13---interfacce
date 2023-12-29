using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13___interfacce
{
    public partial class Form1 : Form
    {
        double Totale;
        string Descrizione;
        public Form1()
        {
            InitializeComponent();
            Totale = 0;
            Descrizione = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Aliante aliante = new Aliante(textBox1.Text, textBox2.Text, textBox3.Text);
            Ala ala = new Ala(Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox5.Text));
            Fusoliera fusoliera = new Fusoliera(Convert.ToInt32(textBox6.Text), textBox7.Text);
            Coda coda = new Coda(Convert.ToInt32(textBox8.Text));
            Ruota ruota = new Ruota(Convert.ToInt32(textBox9.Text), Convert.ToInt32(textBox10.Text), Convert.ToInt32(textBox11.Text), Convert.ToInt32(textBox12.Text));

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
            textBox12.Text = "";


            Totale = ala.Costo() + fusoliera.Costo() + coda.Costo() + ruota.Costo();
            Descrizione = aliante.Descrizione() + fusoliera.Descrizione();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listView1.Items.Add("Totale: " + Convert.ToString(Totale));
            listView1.Items.Add("Descrizione: " + Descrizione);
        }
    }
}
