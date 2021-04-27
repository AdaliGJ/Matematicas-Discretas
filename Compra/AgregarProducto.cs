using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;

using System.Security.Cryptography;

namespace Compra
{
    public partial class AgregarProducto : Form
    {

        XmlSerializer xs;
        string startupPath = Environment.CurrentDirectory; List<productoClass> ls;
        public AgregarProducto()
        {
            InitializeComponent();

            ls = new List<productoClass>();
            xs = new XmlSerializer(typeof(List<productoClass>));

            string startupPath = Environment.CurrentDirectory;

            var path = String.Format("Datos/Producto.xml", startupPath);

            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);

            ls = (List<productoClass>)xs.Deserialize(fs);

            fs.Close();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

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

        //Firmar
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
            string sSourceData;
            byte[] tmpSource;
            byte[] tmpHash;

            sSourceData = path.Text;

            tmpSource = ASCIIEncoding.ASCII.GetBytes(sSourceData);
            tmpHash = new MD5CryptoServiceProvider().ComputeHash(tmpSource);

            hash.Text = ByteArrayToString(tmpHash);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string infoProducto = "Nombre: " + nombreProducto.Text + ", Descripcion: " + descripcionProducto.Text + ", Hash: " + hash.Text + ", Precio: " + precio.Text;
            string pk = llave.Text;
            string firmado = Signature(infoProducto, pk, "utf-8");

            firma.Text = firmado;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Guardado de datos en xml
            var paths = String.Format("Datos/Producto.xml", AppDomain.CurrentDomain.BaseDirectory);

            FileStream fs = new FileStream(paths, FileMode.Create, FileAccess.Write);

            productoClass sc = new productoClass();
            sc.nombreProducto = nombreProducto.Text;
            sc.descripcionProducto = descripcionProducto.Text;
            sc.hash = hash.Text;
            sc.precio = precio.Text;
            sc.llave = publica.Text;
            sc.firmado = firma.Text;


            ls.Add(sc);

            xs.Serialize(fs, ls);
            fs.Close();


            nombreProducto.Text = "";
            descripcionProducto.Text = "";
            hash.Text = "";
            precio.Text = "";
            llave.Text = "";
            publica.Text = "";
            path.Text = "";
            firma.Text = "";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Vendedor r = new Vendedor();
            r.ShowDialog();
            this.Close();
        }
    }

}

