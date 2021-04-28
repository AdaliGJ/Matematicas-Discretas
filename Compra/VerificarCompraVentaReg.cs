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
    public partial class VerificarCompraVentaReg : Form
    {
        XmlSerializer xs;
        List<CompraVentaFirmar> ls;

        public VerificarCompraVentaReg()
        {
            InitializeComponent();

            ls = new List<CompraVentaFirmar>();
            xs = new XmlSerializer(typeof(List<CompraVentaFirmar>));

            string startupPath = Environment.CurrentDirectory;

            var path = String.Format("Datos/CompraVentaRegulador.xml", startupPath);

            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            ls = (List<CompraVentaFirmar>)xs.Deserialize(fs);

            dataGridView1.DataSource = ls;
            fs.Close();

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

        private void regresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Regulador r = new Regulador();
            r.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {


            int row = dataGridView1.CurrentRow.Index;

            this.Hide();
            VerificarCompraVentaReg2 vcv = new VerificarCompraVentaReg2();
            string infoe = Convert.ToString(dataGridView1[0, row].Value);
            string hashp = Convert.ToString(dataGridView1[8, row].Value);
            string guid = Convert.ToString(dataGridView1[6, row].Value);
            string pr = Convert.ToString(dataGridView1[7, row].Value);
            string fechaexp = Convert.ToString(dataGridView1[1, row].Value);
            string ent = Convert.ToString(dataGridView1[2, row].Value);
            string firmacert = Convert.ToString(dataGridView1[3, row].Value);
            string firmavend = Convert.ToString(dataGridView1[10, row].Value);
            vcv.infoFirmaText.Text = Convert.ToString(dataGridView1[11, row].Value);


            string infoe2 = ", Información entidad: " + infoe;
            string hashp2 = ", Hash: " + hashp;
            string guid2 = "Identificador Único: " + guid;
            string pr2 = ", Precio: " + pr;
            string fechaexp2 = ", Fecha de expiración: " + fechaexp;
            string ent2 = ", Tipo de Entidad: " + ent;
            string firmacert2 = ", Firma Certificado: " + firmacert;
            string firmavend2 = ", Firma Vendedor: " + firmavend;

            vcv.infoText.Text = guid2 + hashp2 + infoe2 + fechaexp2 + ent2 + firmacert2 + pr2 + firmavend2;
            vcv.identificadorText.Text = guid;

            //Llaves
            vcv.llaveText.Text = Convert.ToString(dataGridView1[9, row].Value);
            vcv.llavevend = Convert.ToString(dataGridView1[4, row].Value);

            vcv.ShowDialog();
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void verificarText_TextChanged(object sender, EventArgs e)
        {

        }

        private void infoText_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void nombre_EntidadLabel_Click(object sender, EventArgs e)
        {

        }

        private void entidadLabel_Click(object sender, EventArgs e)
        {

        }

        private void llaveText_TextChanged(object sender, EventArgs e)
        {

        }

        private void infoFirmaText_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
