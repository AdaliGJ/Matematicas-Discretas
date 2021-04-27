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
    public partial class MisOrdenesC : Form
    {
        public MisOrdenesC()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            VerificarCompraVenta vcp = new VerificarCompraVenta();
            vcp.ShowDialog();
            this.Close();
        }
    }
}
