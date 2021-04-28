using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Compra
{
    public partial class Validación_compra : Form
    {
        public Validación_compra()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Regulador r = new Regulador();
            r.ShowDialog();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            VerificarCompraVentaReg vcv = new VerificarCompraVentaReg();
            vcv.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Finalizadas f = new Finalizadas();
            f.ShowDialog();
            this.Close();
        }
    }
}
