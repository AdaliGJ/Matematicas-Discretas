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
    public partial class RecibirProducto : Form
    {
        XmlSerializer xs;
        List<EntregaClass> ls;
        public RecibirProducto()
        {
            InitializeComponent();

            ls = new List<EntregaClass>();
            xs = new XmlSerializer(typeof(List<EntregaClass>));

            string startupPath = Environment.CurrentDirectory;

            var path = String.Format("Datos/ProductosEnviados.xml", startupPath);

            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            ls = (List<EntregaClass>)xs.Deserialize(fs);

            dataGridView1.DataSource = ls;
            fs.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dataGridView1.CurrentRow.Index;

            encriptado.Text = Convert.ToString(dataGridView1[4, row].Value);
            registrado.Text = Convert.ToString(dataGridView1[3, row].Value);
        }

        private void verificar_Click(object sender, EventArgs e)
        {
            if (obtenido.Text == registrado.Text)
            {
                verificado.Text = "Producto Correcto";
            }
            else
            {
                verificado.Text = "Producto Incorrecto";
            }
        }

        private static string Desencriptar(string llavepriv, string mensaje)
        {
            RSACryptoServiceProvider key = new RSACryptoServiceProvider();
            key.FromXmlString(llavepriv);

            byte[] mensajeCifrado = Convert.FromBase64String(mensaje);

            //byte[] mensajeCifrado = Encoding.Default.GetBytes(mensaje);

            byte[] mensajeDescifrado = key.Decrypt(mensajeCifrado, false);

            string descifrado = Encoding.Default.GetString(mensajeDescifrado);

            return descifrado;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            path.Text = Desencriptar(privada.Text, encriptado.Text);
        }

        //hash
        static string ByteArrayToString(byte[] arrInput)
        {
            int i;
            StringBuilder sOutput = new StringBuilder(arrInput.Length);
            for (i = 0; i < arrInput.Length; i++)
            {
                sOutput.Append(arrInput[i].ToString("X2"));
            }
            return sOutput.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sSourceData;
            byte[] tmpSource;
            byte[] tmpHash;

            sSourceData = path.Text;

            tmpSource = ASCIIEncoding.ASCII.GetBytes(sSourceData);
            tmpHash = new MD5CryptoServiceProvider().ComputeHash(tmpSource);

            obtenido.Text = ByteArrayToString(tmpHash);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Comprador c = new Comprador();
            c.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int row = dataGridView1.CurrentRow.Index;

            this.Hide();
            FinalizarTransaccion f = new FinalizarTransaccion();
            f.identificador.Text = Convert.ToString(dataGridView1[2, row].Value);
            f.comprador.Text = Convert.ToString(dataGridView1[0, row].Value);
            f.vendedor.Text = Convert.ToString(dataGridView1[1, row].Value);
            f.precio.Text = Convert.ToString(dataGridView1[5, row].Value);
            f.ShowDialog();
            this.Close();
        }
    }
}
