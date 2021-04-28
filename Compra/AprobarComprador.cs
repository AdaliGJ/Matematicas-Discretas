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
    public partial class AprobarComprador : Form
    {

        XmlSerializer xs;
        List<Certificados> ls;

        public AprobarComprador()
        {
            InitializeComponent();

            entText.Text = "Comprador";

            ls = new List<Certificados>();
            xs = new XmlSerializer(typeof(List<Certificados>));


            string startupPath = Environment.CurrentDirectory;

            var path = String.Format("Datos/CertificadosCompradores.xml", startupPath);

            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            ls = (List<Certificados>)xs.Deserialize(fs);

            fs.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string startupPath = Environment.CurrentDirectory;

            var path = String.Format("Datos/CertificadosCompradores.xml", startupPath);

            FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write);
            Certificados ca = new Certificados();
            ca.Informacion = infoText.Text;
            ca.Entidad = entText.Text;
            ca.Expira = expText.Text;
            ca.Firma = firmText.Text;
            ca.Llave = llaveText.Text;
            ca.Regulador = publica.Text;


            infoText.Text = "";
            entText.Text = "";
            expText.Text = "";
            privText.Text = "";
            publica.Text = "";

            ls.Add(ca);

            xs.Serialize(fs, ls);

            fs.Close();

            this.Hide();
            CrearCuentaC cc = new CrearCuentaC();
            cc.llaveText.Text = llaveText.Text;
            cc.ShowDialog();
            this.Close();

            llaveText.Text = "";

            firmText.Text = "";
        }

        private void firmar_Click(object sender, EventArgs e)
        {
            string pk = privText.Text;
            string info = "Información Entidad: " + infoText.Text + ", Tipo de Entidad: " + entText.Text + ", Fecha de Expiración: " + expText.Text;

            string signed = Signature(info, pk, "utf-8");

            firmText.Text = signed;
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

        private void regresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Regulador r = new Regulador();
            r.ShowDialog();
            this.Close();
        }

        private void firmText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
