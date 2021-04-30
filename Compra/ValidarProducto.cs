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
    public partial class ValidarProducto : Form
    {

        XmlSerializer xs;
        List<productoClass> ls;

        XmlSerializer xs2;
        List<productoClass> ls2;
        public ValidarProducto()
        {
            InitializeComponent();


            //Para verificar
            ls = new List<productoClass>();
            xs = new XmlSerializer(typeof(List<productoClass>));

            string startupPath = Environment.CurrentDirectory;

            var path = String.Format("Datos/Producto.xml", startupPath);

            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            ls = (List<productoClass>)xs.Deserialize(fs);

            dataGridView1.DataSource = ls;
            fs.Close();


            //Aprobados
            ls2 = new List<productoClass>();
            xs2 = new XmlSerializer(typeof(List<productoClass>));

            var path2 = String.Format("Datos/ProductosAprobados.xml", startupPath);

            FileStream fs2 = new FileStream(path2, FileMode.Open, FileAccess.Read);
            ls2 = (List<productoClass>)xs2.Deserialize(fs2);

            fs2.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            int row = dataGridView1.CurrentRow.Index;

            string startupPath = Environment.CurrentDirectory;

            var path = String.Format("Datos/ProductosAprobados.xml", startupPath);

            FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write);
            productoClass pc = new productoClass();

            pc.nombreProducto = Convert.ToString(dataGridView1[0, row].Value);
            pc.precio = Convert.ToString(dataGridView1[3, row].Value);
            pc.hash = Convert.ToString(dataGridView1[2, row].Value);
            pc.descripcionProducto = Convert.ToString(dataGridView1[1, row].Value);
            pc.llave = Convert.ToString(dataGridView1[4, row].Value);
            pc.firmado = Convert.ToString(dataGridView1[5, row].Value);


            infoText.Text = "";
            infoFirmaText.Text = "";
            llaveText.Text = "";
            verificarText.Text = "";

            ls2.Add(pc);

            xs2.Serialize(fs, ls2);

            fs.Close();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dataGridView1.CurrentRow.Index;

            string nombre = "Nombre: " + Convert.ToString(dataGridView1[0, row].Value);
            string descripcion= ", Descripcion: " + Convert.ToString(dataGridView1[1, row].Value); 
            string hash = ", Hash: " + Convert.ToString(dataGridView1[2, row].Value); 
            string precio = ", Precio: " + Convert.ToString(dataGridView1[3, row].Value);

            infoFirmaText.Text = Convert.ToString(dataGridView1[5, row].Value);
            llaveText.Text = Convert.ToString(dataGridView1[4, row].Value);
            infoText.Text = nombre + descripcion + hash + precio;
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
            AprobarProducto ap = new AprobarProducto();
            ap.ShowDialog();
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
    }
}
