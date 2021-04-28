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
    public partial class Finalizadas : Form
    {
        XmlSerializer xs;
        List<Cerrada> ls;
        public Finalizadas()
        {
            InitializeComponent();

            ls = new List<Cerrada>();
            xs = new XmlSerializer(typeof(List<Cerrada>));


            string startupPath = Environment.CurrentDirectory;

            var path = String.Format("Datos/Terminadas.xml", startupPath);

            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            ls = (List<Cerrada>)xs.Deserialize(fs);

            dataGridView1.DataSource = ls;
            fs.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int row = dataGridView1.CurrentRow.Index;

            this.Hide();
            ActualizarCuentas ac = new ActualizarCuentas();
            ac.identificadorText.Text = Convert.ToString(dataGridView1[0, row].Value);
            ac.comprador.Text= Convert.ToString(dataGridView1[2, row].Value);
            ac.vendedor.Text= Convert.ToString(dataGridView1[3, row].Value);
            ac.button1.Visible = false;
            ac.precio.Text="Precio: " + Convert.ToString(dataGridView1[1, row].Value);
            ac.ShowDialog();
            this.Close();
        }

        private void regresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Regulador r = new Regulador();
            r.ShowDialog();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            int row = dataGridView1.CurrentRow.Index;

            string id = "Identificador: " + Convert.ToString(dataGridView1[0, row].Value);
            string pr = ", Precio: " + Convert.ToString(dataGridView1[1, row].Value); 
            string comp = ", Comprador: " + Convert.ToString(dataGridView1[2, row].Value); 
            string vend = ", Vendedor: " + Convert.ToString(dataGridView1[3, row].Value); 
            string fe = ", Fecha: " + Convert.ToString(dataGridView1[4, row].Value); 
            string state = ", Estado: " + Convert.ToString(dataGridView1[6, row].Value); 

            infoText.Text = id + pr + comp + vend + fe + state;
            infoFirmaText.Text = Convert.ToString(dataGridView1[5, row].Value);
            llaveText.Text = Convert.ToString(dataGridView1[2, row].Value);

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
    }
}
