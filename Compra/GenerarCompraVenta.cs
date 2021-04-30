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
    public partial class GenerarCompraVenta : Form
    {

        XmlSerializer xs;
        List<Certificados> ls;

        XmlSerializer xs2;
        List<CompraVenta> ls2;
        public GenerarCompraVenta()
        {
            InitializeComponent();

            //Certificados
            ls = new List<Certificados>();
            xs = new XmlSerializer(typeof(List<Certificados>));

            string startupPath = Environment.CurrentDirectory;

            var path = String.Format("Datos/CertificadosVendedores.xml", startupPath);

            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            ls = (List<Certificados>)xs.Deserialize(fs);

            dataGridView1.DataSource = ls;
            fs.Close();

            //Agregar Orden Compra-Venta
            ls2 = new List<CompraVenta>();
            xs2 = new XmlSerializer(typeof(List<CompraVenta>));

            var path2 = String.Format("Datos/OrdenesCompraVenta.xml", startupPath);

            FileStream fs2 = new FileStream(path2, FileMode.Open, FileAccess.Read);
            ls2 = (List<CompraVenta>)xs2.Deserialize(fs2);

            fs2.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string pk = llavePriv.Text;
            string infoe = ", Información entidad: " + nombre.Text;
            string hashp = ", Hash: " + hash.Text;
            string guid = "Identificador Único: " + identificador.Text;
            string pr = ", Precio: " + precio.Text;
            string fechaexp = ", Fecha de expiración: "+ exp.Text;
            string ent = ", Tipo de Entidad: "+ entidad.Text;
            string firmac = ", Firma Certificado: "+ firmacert.Text;

            string info = guid + hashp + infoe + fechaexp + ent + firmac + pr;

            string signed = Signature(info, pk, "utf-8");

            firmado.Text = signed;
        }

        public static string Signature(string str, string privateKey, string encoding)
        {
            //SHA256withRSA
            // According to the need to add a hash algorithm when converted to the corresponding hash character section
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dataGridView1.CurrentRow.Index;

            nombre.Text = Convert.ToString(dataGridView1[0, row].Value);
            exp.Text = Convert.ToString(dataGridView1[1, row].Value);
            entidad.Text = Convert.ToString(dataGridView1[2, row].Value);
            firmacert.Text = Convert.ToString(dataGridView1[3, row].Value);
            llavevend.Text = Convert.ToString(dataGridView1[4, row].Value);
            llavereg.Text = Convert.ToString(dataGridView1[5, row].Value);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string startupPath = Environment.CurrentDirectory;

            var path = String.Format("Datos/OrdenesCompraVenta.xml", startupPath);

            FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write);
            CompraVenta cv = new CompraVenta();
            cv.InformacionCert = nombre.Text;
            cv.EntidadCert = entidad.Text;
            cv.ExpiraCert = exp.Text;
            cv.FirmaCert = firmacert.Text;
            cv.LlaveVendCert = llavevend.Text;
            cv.ReguladorCert = llavereg.Text;
            cv.identificadorTransaccion = identificador.Text;
            cv.precio = precio.Text;
            cv.hashProducto = hash.Text;
            cv.comprador = comprador.Text;
            cv.firmaVendedor = firmado.Text;



            nombre.Text = "";
            identificador.Text = "";
            precio.Text = "";
            hash.Text = "";
            comprador.Text = "";
            firmado.Text = "";
            llavePriv.Text = "";
            entidad.Text = "";
            exp.Text = "";
            firmacert.Text = "";
            llavevend.Text = "";
            llavereg.Text = "";
            

            ls2.Add(cv);

            xs2.Serialize(fs, ls2);

            fs.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Vendedor v = new Vendedor();
            v.ShowDialog();
            this.Close();
        }
    }
}
