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
    public partial class EnviarProductoAComprador : Form
    {

        XmlSerializer xs;
        List<EntregaClass> ls;
        public EnviarProductoAComprador()
        {
            InitializeComponent();


            ls = new List<EntregaClass>();
            xs = new XmlSerializer(typeof(List<EntregaClass>));

            string startupPath = Environment.CurrentDirectory;

            var path = String.Format("Datos/ProductosEnviados.xml", startupPath);

            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            ls = (List<EntregaClass>)xs.Deserialize(fs);

            fs.Close();
        }

        private void verificar_Click(object sender, EventArgs e)
        {

            string pub = comprador.Text;

            string mensaje = pathp.Text;
            encriptado.Text = Encriptar(pub, mensaje);
        }

        private static string Encriptar(string llavep, string mensaje)
        {
            RSACryptoServiceProvider key = new RSACryptoServiceProvider();
            key.FromXmlString(llavep);
            byte[] mensajeSinCifrar = Encoding.Default.GetBytes(mensaje);

            byte[] mensajeCifrado = key.Encrypt(mensajeSinCifrar, RSAEncryptionPadding.Pkcs1);

            string cifrado = Convert.ToBase64String(mensajeCifrado);



            return cifrado;
        }



        private void button1_Click(object sender, EventArgs e)
        {

            string pub = comprador.Text;

            string mensaje = pathp.Text; 


            string startupPath = Environment.CurrentDirectory;

            var path = String.Format("Datos/ProductosEnviados.xml", startupPath);

            FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write);
            EntregaClass ec = new EntregaClass();
            ec.comprador = comprador.Text;
            ec.vendedor = vendedor.Text;
            ec.identificador = identificador.Text;
            ec.hash = hash.Text;
            ec.path = Encriptar(pub, mensaje);
            ec.precio = precio.Text;

            comprador.Text = "";
            vendedor.Text="";
            identificador.Text="";
            hash.Text="";
            encriptado.Text="";
            precio.Text="";
            pathp.Text = "";


            ls.Add(ec);

            xs.Serialize(fs, ls);

            fs.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Vendedor v = new Vendedor();
            v.ShowDialog();
            this.Close();
        }
    }
}
