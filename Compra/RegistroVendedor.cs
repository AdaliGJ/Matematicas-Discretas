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
    public partial class RegistroVendedor : Form
    {

        XmlSerializer xs;
        List<RegistroClase> ls;

        public RegistroVendedor()
        {
            InitializeComponent();

            ls = new List<RegistroClase>();
            xs = new XmlSerializer(typeof(List<RegistroClase>));

            ls = new List<RegistroClase>();
            xs = new XmlSerializer(typeof(List<RegistroClase>));

            string startupPath = Environment.CurrentDirectory;

            var path = String.Format("Datos/SolicitudesVendedores.xml", startupPath);

            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            ls = (List<RegistroClase>)xs.Deserialize(fs);

            fs.Close();
        }

        public static string Signature(string str, string privateKey, string encoding)
        {
            //SHA256withRSA
            // According to the need to add a hash algorithm when converted to the corresponding hash character section
            //byte[] bt = Encoding.GetEncoding("utf-8").GetBytes(str);
            byte[] bt = Encoding.GetEncoding(encoding).GetBytes(str);
            var sha256 = new SHA256CryptoServiceProvider();
            byte[] rgbHash = sha256.ComputeHash(bt);

            RSACryptoServiceProvider key = new RSACryptoServiceProvider();
            key.FromXmlString(privateKey);
            RSAPKCS1SignatureFormatter formatter = new RSAPKCS1SignatureFormatter(key);
            formatter.SetHashAlgorithm("SHA256");//This is the hash algorithm you need to add. It needs to be consistent with the algorithm of the hash value you calculated above, otherwise it will report an error.
            byte[] inArray = formatter.CreateSignature(rgbHash);
            return Convert.ToBase64String(inArray);
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            string pk = privText.Text;
            string info = "Entidad: " + entText.Text + " NIT: " + nitText.Text;

            string signed = Signature(info, pk, "utf-8");

            firmText.Text = signed;
        }

        private void buttonEnviar_Click(object sender, EventArgs e)
        {
            string startupPath = Environment.CurrentDirectory;

            var path = String.Format("Datos/SolicitudesVendedores.xml", startupPath);

            FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write);
            RegistroClase rc = new RegistroClase();
            rc.Informacion = "Entidad: " + entText.Text + " NIT: " + nitText.Text;
            rc.Llave = llaveText.Text;
            rc.Firma = firmText.Text;

            entText.Text = "";
            llaveText.Text = "";
            nitText.Text = "";
            firmText.Text = "";
            privText.Text = "";

            ls.Add(rc);

            xs.Serialize(fs, ls);
            fs.Close();
        }

        private void buttonRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Vendedor v = new Vendedor();
            v.ShowDialog();
            this.Close();

            entText.Text = "";
            llaveText.Text = "";
            nitText.Text = "";
            firmText.Text = "";
        }
    }
}
