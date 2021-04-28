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
    public partial class MisOrdenesV : Form
    {
        public MisOrdenesV()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Vendedor v = new Vendedor();
            v.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            VerPedidos vp = new VerPedidos();
            vp.ShowDialog();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            EntregaProducto ep = new EntregaProducto();
            ep.ShowDialog();
            this.Close();
        }
    }
}
