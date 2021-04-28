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

    public partial class FinalizarTransaccion : Form
    {
        XmlSerializer xs;
        List<Cerrada> ls;


        public FinalizarTransaccion()
        {
            InitializeComponent();

            ls = new List<Cerrada>();
            xs = new XmlSerializer(typeof(List<Cerrada>));


            string startupPath = Environment.CurrentDirectory;

            var path = String.Format("Datos/Terminadas.xml", startupPath);

            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            ls = (List<Cerrada>)xs.Deserialize(fs);

            fs.Close();
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

        private void button2_Click(object sender, EventArgs e)
        {
            string id = "Identificador: " + identificador.Text;
            string pr = ", Precio: " + precio.Text;
            string comp = ", Comprador: " + comprador.Text;
            string vend = ", Vendedor: " + vendedor.Text;
            string fe = ", Fecha: " + fecha.Text;
            string state = ", Estado: " + estado.Text;

            string info = id + pr + comp + vend + fe + state;

            firmados.Text = Signature(info, privada.Text, "utf-8");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string startupPath = Environment.CurrentDirectory;

            var path = String.Format("Datos/Terminadas.xml", startupPath);

            FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write);
            Cerrada c = new Cerrada();
            c.Identificador = identificador.Text;
            c.Precio = precio.Text;
            c.Comprador = comprador.Text;
            c.Vendedor = vendedor.Text;
            c.FechaTransaccion = fecha.Text;
            c.Firma = firmados.Text;
            c.Estado = estado.Text;

            identificador.Text = "";
            precio.Text = "";
            comprador.Text="";
            vendedor.Text = "";
            fecha.Text = "";
            firmados.Text = "";
            privada.Text = "";
            estado.Text = "";

            ls.Add(c);

            xs.Serialize(fs, ls);

            fs.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Comprador c = new Comprador();
            c.ShowDialog();
            this.Close();
        }
    }
}
