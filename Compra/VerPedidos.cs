using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Compra
{
    public partial class VerPedidos : Form
    {

        XmlSerializer xs;
        List<SolicitudCompra> ls;
        public VerPedidos()
        {
            InitializeComponent();

            ls = new List<SolicitudCompra>();
            xs = new XmlSerializer(typeof(List<SolicitudCompra>));

            string startupPath = Environment.CurrentDirectory;

            var path = String.Format("Datos/SolicitudCompra.xml", startupPath);

            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            ls = (List<SolicitudCompra>)xs.Deserialize(fs);

            dataGridView1.DataSource = ls;
            fs.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Guid identificador = Guid.NewGuid();

            guid.Text = identificador.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Vendedor v = new Vendedor();
            v.ShowDialog();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dataGridView1.CurrentRow.Index;

            nombre.Text = Convert.ToString(dataGridView1[0, row].Value);
            comprador.Text = Convert.ToString(dataGridView1[5, row].Value);

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int row = dataGridView1.CurrentRow.Index;

            this.Hide();
            GenerarCompraVenta gcv = new GenerarCompraVenta();
            gcv.comprador.Text = comprador.Text;
            gcv.precio.Text= Convert.ToString(dataGridView1[3, row].Value);
            gcv.hash.Text= Convert.ToString(dataGridView1[2, row].Value);
            gcv.identificador.Text = guid.Text;
            gcv.ShowDialog();
            this.Close();
        }
    }
}
