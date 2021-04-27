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

    public partial class VerificarCompraVenta : Form

    {

        XmlSerializer xs2;
        List<CompraVenta> ls2;
        

        public VerificarCompraVenta()
        {
            InitializeComponent();

            ls2 = new List<CompraVenta>();
            xs2 = new XmlSerializer(typeof(List<CompraVenta>));

            string startupPath = Environment.CurrentDirectory;

            var path = String.Format("Datos/OrdenesCompraVenta.xml", startupPath);

            FileStream fs2 = new FileStream(path, FileMode.Open, FileAccess.Read);
            ls2 = (List<CompraVenta>)xs2.Deserialize(fs2);

            dataGridView1.DataSource = ls2;
            fs2.Close();
        }

        private void regresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Comprador c = new Comprador();
            c.ShowDialog();
            this.Close();
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            int row = dataGridView1.CurrentRow.Index;

            string infoe = ", Información entidad: " + Convert.ToString(dataGridView1[0, row].Value); 
            string hashp = ", Hash: " + Convert.ToString(dataGridView1[8, row].Value);
            string guid = "Identificador Único: " + Convert.ToString(dataGridView1[6, row].Value);
            string pr = ", Precio: " + Convert.ToString(dataGridView1[7, row].Value);
            string fechaexp = ", Fecha de expiración: " + Convert.ToString(dataGridView1[1, row].Value);
            string ent = ", Tipo de Entidad: " + Convert.ToString(dataGridView1[2, row].Value); 
            string firmac = ", Firma Certificado: " + Convert.ToString(dataGridView1[3, row].Value); 

            

            string firma = Convert.ToString(dataGridView1[10, row].Value);
            string vendedor = Convert.ToString(dataGridView1[4, row].Value);

            infoFirmaText.Text = firma;
            llaveText.Text = vendedor;
            infoText.Text = guid + hashp + infoe + fechaexp + ent + firmac + pr;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int row = dataGridView1.CurrentRow.Index;

            this.Hide();
            VerificarCertificadoV v = new VerificarCertificadoV();
            v.infoFirmaText.Text = Convert.ToString(dataGridView1[3, row].Value);
            v.llaveText.Text = Convert.ToString(dataGridView1[5, row].Value);
            v.infoText.Text = "Información Entidad: " + Convert.ToString(dataGridView1[0, row].Value) + ", Tipo de Entidad: " + Convert.ToString(dataGridView1[2, row].Value) + ", Fecha de Expiración: " + Convert.ToString(dataGridView1[1, row].Value);
            v.exp.Text = Convert.ToString(dataGridView1[1, row].Value);
            v.precio.Text = Convert.ToString(dataGridView1[7, row].Value);


            //Info para firmar después
            v.infoe = Convert.ToString(dataGridView1[0, row].Value);
            v.hashp = Convert.ToString(dataGridView1[8, row].Value);
            v.guid = Convert.ToString(dataGridView1[6, row].Value);
            v.pr = Convert.ToString(dataGridView1[7, row].Value);
            v.fechaexp = Convert.ToString(dataGridView1[1, row].Value);
            v.ent = Convert.ToString(dataGridView1[2, row].Value);
            v.firmacert = Convert.ToString(dataGridView1[3, row].Value);
            v.firmavend = Convert.ToString(dataGridView1[10, row].Value);

            //Identificadores certificado
            v.llavevend = Convert.ToString(dataGridView1[4, row].Value);
            v.llavereg = Convert.ToString(dataGridView1[5, row].Value);
            v.llavecompr = Convert.ToString(dataGridView1[9, row].Value);

            v.ShowDialog();
            this.Close();
        }
    }
}
