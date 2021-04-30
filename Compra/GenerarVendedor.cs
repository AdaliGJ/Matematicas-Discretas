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
    public partial class GenerarVendedor : Form
    {
        public GenerarVendedor()
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistroVendedor rv = new RegistroVendedor();
            rv.llaveText.Text = "";
            rv.privText.Text = "";
            rv.ShowDialog();
            this.Close();

            textBoxPrivada.Text = "";
            textBoxPublica.Text = "";

            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Vendedor v = new Vendedor();
            v.ShowDialog();
            this.Close();

            textBoxPrivada.Text = "";
            textBoxPublica.Text = "";
        }
    }
}
