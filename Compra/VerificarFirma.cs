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
    public partial class VerificarFirma : Form
    {
        public VerificarFirma()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
                
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

        private void button1_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text;
            string sign = textBox2.Text;
            string pb = textBox3.Text;

            bool correcto = SignCheck(str, sign, pb, "utf-8");

            if (correcto)
            {
                textBox4.Text = "Correcto";
            }
            else
            {
                textBox4.Text = "Incorrecto";
            }
        }
    }
}
