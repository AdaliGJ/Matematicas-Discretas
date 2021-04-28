using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Compra
{
    public partial class VerificarCompraVentaReg2 : Form
    {

        public string infoe;
        public string hashp;
        public static string guid;
        public string pr;
        public string fechaexp;
        public string ent;
        public string firmacert;
        public string firmavend;
        public string llavecompr;
        public string llavevend;
        public string firmacompr;
        public VerificarCompraVentaReg2()
        {
            InitializeComponent();


            string infoe2 = ", Información entidad: " + infoe;
            string hashp2 = ", Hash: " + hashp;
            string guid2 = "Identificador Único: " + guid;
            string pr2 = ", Precio: " + pr;
            string fechaexp2 = ", Fecha de expiración: " + fechaexp;
            string ent2 = ", Tipo de Entidad: " + ent;
            string firmacert2 = ", Firma Certificado: " + firmacert;
            string firmavend2 = ", Firma Vendedor: " + firmavend;


            string info = guid2 + hashp2 + infoe2 + fechaexp2 + ent2 + firmacert2 + pr2 + firmavend2;

            infoText.Text = info;
            infoFirmaText.Text = firmacompr;
            llaveText.Text = llavecompr;

            identificadorText.Text = guid;
        }

        private void regresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Regulador r = new Regulador();
            r.ShowDialog();
            this.Close();
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

        private void button2_Click(object sender, EventArgs e)
        {

            
            this.Hide();
            ActualizarCuentas ac = new ActualizarCuentas();
            ac.comprador.Text = llaveText.Text;
            ac.vendedor.Text = llavevend;
            ac.identificadorText.Text = identificadorText.Text;
            ac.precio.Visible = false;
            ac.ShowDialog();
            this.Close();


            llaveText.Text = "";
            infoText.Text = "";
            infoFirmaText.Text = "";

        }
    }
}
