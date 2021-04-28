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
        XmlSerializer xs;
        List<reguladorLlaves> ls;

        public GeneradorRegulador()
        {
            InitializeComponent();

            ls = new List<reguladorLlaves>();
            xs = new XmlSerializer(typeof(List<reguladorLlaves>));


            string startupPath = Environment.CurrentDirectory;

            var path = String.Format("Datos/LlavesRegulador.xml", startupPath);

            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            ls = (List<reguladorLlaves>)xs.Deserialize(fs);

            fs.Close();
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
            Regulador r = new Regulador();
            r.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string startupPath = Environment.CurrentDirectory;

            var path = String.Format("Datos/LlavesRegulador.xml", startupPath);

            FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write);
            reguladorLlaves rl = new reguladorLlaves();
            rl.Llave = textBoxPublica.Text;



            textBoxPublica.Text = "";
            textBoxPrivada.Text = "";


            ls.Add(rl);

            xs.Serialize(fs, ls);

            fs.Close();
        }
    }
}
