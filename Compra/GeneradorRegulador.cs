using Org.BouncyCastle.OpenSsl;
using Org.BouncyCastle.Security;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Compra
{
    
    public partial class GeneradorRegulador : Form
    {

        
        public GeneradorRegulador()
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
            Firmar r = new Firmar();
            r.ShowDialog();
            this.Close();
        }
    }
}
