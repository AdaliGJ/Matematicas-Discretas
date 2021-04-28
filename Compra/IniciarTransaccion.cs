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


    public partial class IniciarTransaccion : Form
    {

        XmlSerializer xs;
        List<CompraVentaFirmar> ls;

        XmlSerializer xs2;
        List<InicioTransaccionClass> ls2;

        public IniciarTransaccion()
        {
            InitializeComponent();

            //Certificados
            ls = new List<CompraVentaFirmar>();
            xs = new XmlSerializer(typeof(List<CompraVentaFirmar>));

            string startupPath = Environment.CurrentDirectory;

            var path = String.Format("Datos/CompraVentaRegulador.xml", startupPath);

            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            ls = (List<CompraVentaFirmar>)xs.Deserialize(fs);

            dataGridView1.DataSource = ls;
            fs.Close();


            //Paquete Firmado
            ls2 = new List<InicioTransaccionClass>();
            xs2 = new XmlSerializer(typeof(List<InicioTransaccionClass>));

            var path2 = String.Format("Datos/TransaccionesIniciadas.xml", startupPath);

            FileStream fs2 = new FileStream(path2, FileMode.Open, FileAccess.Read);
            ls2 = (List<InicioTransaccionClass>)xs2.Deserialize(fs2);

            fs2.Close();

        }

        private void verificar_Click(object sender, EventArgs e)
        {
            string pk = llaveText.Text;
            string info = infoFirmaText.Text;

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            int row = dataGridView1.CurrentRow.Index;

            string infoe = ", Información Entidad: "+ Convert.ToString(dataGridView1[0, row].Value);
            string hashp = ", Hash Producto: " + Convert.ToString(dataGridView1[8, row].Value);
            string guid = "Identificador Único: " + Convert.ToString(dataGridView1[6, row].Value);
            string pr = ", Precio Producto: " + Convert.ToString(dataGridView1[7, row].Value);
            string fechaexp = ", Fecha de Expiración: " + Convert.ToString(dataGridView1[1, row].Value);
            string ent = ", Entidad: " + Convert.ToString(dataGridView1[2, row].Value);
            string firmacert = ", Certificado Firmado: " + Convert.ToString(dataGridView1[3, row].Value);
            string firmavend = ", Firma Vendedor: " + Convert.ToString(dataGridView1[10, row].Value);
            string firmacompr =", Firma Comprador: " + Convert.ToString(dataGridView1[11, row].Value);

            string info = guid + hashp + infoe + fechaexp + ent + firmacert + pr + firmavend + firmacompr;

            infoFirmaText.Text = info;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string startupPath = Environment.CurrentDirectory;

            var path = String.Format("Datos/TransaccionesIniciadas.xml", startupPath);

            int row = dataGridView1.CurrentRow.Index;

            FileStream fs2 = new FileStream(path, FileMode.Create, FileAccess.Write);
            InicioTransaccionClass cv = new InicioTransaccionClass();
            cv.InformacionCert = Convert.ToString(dataGridView1[0, row].Value);
            cv.EntidadCert = Convert.ToString(dataGridView1[2, row].Value);
            cv.ExpiraCert = Convert.ToString(dataGridView1[1, row].Value);
            cv.FirmaCert = Convert.ToString(dataGridView1[3, row].Value);
            cv.LlaveVendCert = Convert.ToString(dataGridView1[4, row].Value);
            cv.ReguladorCert = Convert.ToString(dataGridView1[5, row].Value);
            cv.identificadorTransaccion = Convert.ToString(dataGridView1[6, row].Value);
            cv.precio = Convert.ToString(dataGridView1[7, row].Value);
            cv.hashProducto = Convert.ToString(dataGridView1[8, row].Value);
            cv.comprador = Convert.ToString(dataGridView1[9, row].Value);
            cv.firmaVendedor = Convert.ToString(dataGridView1[10, row].Value);
            cv.firmaComprador = Convert.ToString(dataGridView1[11, row].Value);
            cv.firmaRegulador = firmText.Text;

            infoFirmaText.Text = "";
            llaveText.Text = "";
            firmText.Text = "";
            identificadorText.Text = "";

            ls2.Add(cv);

            xs2.Serialize(fs2, ls2);

            fs2.Close();

        }

        private void regresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Regulador r = new Regulador();
            r.ShowDialog();
            this.Close();
        }
    }
}
