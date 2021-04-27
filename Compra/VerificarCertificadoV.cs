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
    public partial class VerificarCertificadoV : Form
    {
        //información
        public string infoe;
        public string hashp;
        public string guid;
        public string pr;
        public string fechaexp;
        public string ent;
        public string firmacert;
        public string firmavend;
        //Laves
        public string llavevend;
        public string llavereg;
        public string llavecompr;

        XmlSerializer xs;
        List<CompraVentaFirmar> ls;

        public VerificarCertificadoV()
        {
            InitializeComponent();

            ls = new List<CompraVentaFirmar>();
            xs = new XmlSerializer(typeof(List<CompraVentaFirmar>));

            string startupPath = Environment.CurrentDirectory;

            var path = String.Format("Datos/CompraVentaRegulador.xml", startupPath);

            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            ls = (List<CompraVentaFirmar>)xs.Deserialize(fs);

            fs.Close();
        }

        private void verificar_Click(object sender, EventArgs e)
        {
            string sign = infoFirmaText.Text;
            string pb = llaveText.Text;

            string str = infoText.Text;


            bool correcto = SignCheck(str, sign, pb, "utf-8");

            if (correcto)
            {
                verificarText.Text = "Llave Correcta";
            }
            else
            {
                verificarText.Text = "Llave Incorrecta";
            }
        }

        public static bool SignCheck(string str, string sign, string publicKey, string encoding)
        {
            try
            {
                //byte[] bt = Encoding.GetEncoding("utf-8").GetBytes(str);
                byte[] bt = Encoding.GetEncoding(encoding).GetBytes(str);
                var sha256 = new SHA256CryptoServiceProvider();
                byte[] rgbHash = sha256.ComputeHash(bt);

                RSACryptoServiceProvider key = new RSACryptoServiceProvider();
                key.FromXmlString(publicKey);
                RSAPKCS1SignatureDeformatter deformatter = new RSAPKCS1SignatureDeformatter(key);
                deformatter.SetHashAlgorithm("SHA256");
                byte[] rgbSignature = Convert.FromBase64String(sign);
                if (deformatter.VerifySignature(rgbHash, rgbSignature))
                {
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string pk = comprador.Text;

            string infoe2 = ", Información entidad: " + infoe;
            string hashp2 = ", Hash: " + hashp;
            string guid2 = "Identificador Único: " + guid;
            string pr2 = ", Precio: " + pr;
            string fechaexp2 = ", Fecha de expiración: " + fechaexp;
            string ent2 = ", Tipo de Entidad: " + ent;
            string firmacert2 = ", Firma Certificado: " + firmacert;
            string firmavend2 = ", Firma Vendedor: " + firmavend;


            string info = guid2 + hashp2 + infoe2 + fechaexp2 + ent2 + firmacert2 + pr2 + firmavend2;

            string signed = Signature(info, pk, "utf-8");

            firmado.Text = signed;
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

        private void button1_Click(object sender, EventArgs e)
        {
            string startupPath = Environment.CurrentDirectory;

            var path = String.Format("Datos/CompraVentaRegulador.xml", startupPath);

            FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write);
            CompraVentaFirmar cv = new CompraVentaFirmar();
            cv.InformacionCert = infoe;
            cv.EntidadCert = ent;
            cv.ExpiraCert = fechaexp;
            cv.FirmaCert = firmacert;
            cv.LlaveVendCert = llavevend;
            cv.ReguladorCert = llavereg;
            cv.identificadorTransaccion = guid;
            cv.precio = pr;
            cv.hashProducto = hashp;
            cv.comprador = llavecompr;
            cv.firmaVendedor = firmavend;
            cv.firmaComprador = firmado.Text;


            infoFirmaText.Text = "";
            infoText.Text = "";
            llaveText.Text = "";
            exp.Text = "";
            precio.Text = "";
            comprador.Text = "";
            firmado.Text = "";
            verificarText.Text = "";


            ls.Add(cv);

            xs.Serialize(fs, ls);

            fs.Close();
        }

        private void regresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Comprador c = new Comprador();
            c.ShowDialog();
            this.Close();
        }
    }
}
