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
    public partial class EntregaProducto : Form
    {

        XmlSerializer xs;
        List<InicioTransaccionClass> ls;
        public EntregaProducto()
        {
            InitializeComponent();

            ls = new List<InicioTransaccionClass>();
            xs = new XmlSerializer(typeof(List<InicioTransaccionClass>));

            string startupPath = Environment.CurrentDirectory;

            var path = String.Format("Datos/TransaccionesIniciadas.xml", startupPath);

            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            ls = (List<InicioTransaccionClass>)xs.Deserialize(fs);

            dataGridView1.DataSource = ls;
            fs.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int row = dataGridView1.CurrentRow.Index;

            this.Hide();
            EnviarProductoAComprador epc = new EnviarProductoAComprador();
            epc.vendedor.Text = llaveText.Text = Convert.ToString(dataGridView1[4, row].Value);
            epc.comprador.Text = Convert.ToString(dataGridView1[9, row].Value);
            epc.identificador.Text = Convert.ToString(dataGridView1[6, row].Value);
            epc.hash.Text = Convert.ToString(dataGridView1[8, row].Value);
            epc.precio.Text = Convert.ToString(dataGridView1[7, row].Value);
            epc.ShowDialog();
            this.Close();
        }

        private void regresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Vendedor v = new Vendedor();
            v.ShowDialog();
            this.Close();
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

            llaveText.Text = Convert.ToString(dataGridView1[5, row].Value);
            infoFirmaText.Text = Convert.ToString(dataGridView1[12, row].Value);

            string infoe = ", Información Entidad: " + Convert.ToString(dataGridView1[0, row].Value);
            string hashp = ", Hash Producto: " + Convert.ToString(dataGridView1[8, row].Value);
            string guid = "Identificador Único: " + Convert.ToString(dataGridView1[6, row].Value);
            string pr = ", Precio Producto: " + Convert.ToString(dataGridView1[7, row].Value);
            string fechaexp = ", Fecha de Expiración: " + Convert.ToString(dataGridView1[1, row].Value);
            string ent = ", Entidad: " + Convert.ToString(dataGridView1[2, row].Value);
            string firmacert = ", Certificado Firmado: " + Convert.ToString(dataGridView1[3, row].Value);
            string firmavend = ", Firma Vendedor: " + Convert.ToString(dataGridView1[10, row].Value);
            string firmacompr = ", Firma Comprador: " + Convert.ToString(dataGridView1[11, row].Value);

            infoText.Text = guid + hashp + infoe + fechaexp + ent + firmacert + pr + firmavend + firmacompr;
        }

        private void verificar_Click(object sender, EventArgs e)
        {
            string str = infoText.Text;
            string sign = infoFirmaText.Text;
            string pb = llaveText.Text;

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
    }
}
