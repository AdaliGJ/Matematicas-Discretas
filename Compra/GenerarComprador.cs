using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Compra
{
    public partial class Generar_Comprador : Form
    {
        public Generar_Comprador()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RSACryptoServiceProvider provider = new RSACryptoServiceProvider(2048);
            string privateKey = provider.ToXmlString(true);//generate the private key
            string publicKey = provider.ToXmlString(false);//generate oublic key


            textBoxPrivada.Text = privateKey;
            textBoxPublica.Text = publicKey;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Comprador c = new Comprador();
            c.ShowDialog();
            this.Close();

            textBoxPrivada.Text = "";
            textBoxPublica.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistroComprador rc = new RegistroComprador();
            rc.ShowDialog();
            this.Close();

            textBoxPrivada.Text = "";
            textBoxPublica.Text = "";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxPrivada_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPublica_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
