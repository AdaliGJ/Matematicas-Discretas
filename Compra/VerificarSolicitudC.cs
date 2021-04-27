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
    public partial class VerificarSolicitudC : Form
    {

        XmlSerializer xs;
        List<RegistroClase> ls;

        public VerificarSolicitudC()
        {
            InitializeComponent();

            ls = new List<RegistroClase>();
            xs = new XmlSerializer(typeof(List<RegistroClase>));

            string startupPath = Environment.CurrentDirectory;

            var path = String.Format("Datos/SolicitudesCompradores.xml", startupPath);

            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            ls = (List<RegistroClase>)xs.Deserialize(fs);

            dataGridView1.DataSource = ls;
            fs.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dataGridView1.CurrentRow.Index;
            infoFirmaText.Text = Convert.ToString(dataGridView1[2, row].Value);
            llaveText.Text = Convert.ToString(dataGridView1[1, row].Value);
            infoText.Text = Convert.ToString(dataGridView1[0, row].Value);
            
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AprobarComprador ac = new AprobarComprador();
            ac.infoText.Text = infoText.Text;
            ac.llaveText.Text = llaveText.Text;
            ac.ShowDialog();
            this.Close();

           
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
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
    }
}
