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
    public partial class MostrarProductos : Form
    {
        XmlSerializer xs;
        List<productoClass> ls;

        XmlSerializer xs2;
        List<SolicitudCompra> ls2;

        public MostrarProductos()
        {
            InitializeComponent();

            
            //Productos Aprobados
            ls = new List<productoClass>();
            xs = new XmlSerializer(typeof(List<productoClass>));

            string startupPath = Environment.CurrentDirectory;

            var path = String.Format("Datos/ProductosAprobados.xml", startupPath);

            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            ls = (List<productoClass>)xs.Deserialize(fs);

            dataGridView1.DataSource = ls;
            fs.Close();


            //Solicitudes
            ls2 = new List<SolicitudCompra>();
            xs2 = new XmlSerializer(typeof(List<SolicitudCompra>));


            var path2 = String.Format("Datos/SolicitudCompra.xml", startupPath);

            FileStream fs2 = new FileStream(path2, FileMode.Open, FileAccess.Read);
            ls2 = (List<SolicitudCompra>)xs2.Deserialize(fs2);

            fs2.Close();


        }

        private void regresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Comprador c = new Comprador();
            c.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int row = dataGridView1.CurrentRow.Index;

            string startupPath = Environment.CurrentDirectory;

            var path = String.Format("Datos/SolicitudCompra.xml", startupPath);

            FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write);
            SolicitudCompra sc = new SolicitudCompra();
            sc.nombreProducto = nombre.Text;
            sc.descripcionProducto = descripcion.Text;
            sc.precio = precio.Text;
            sc.comprador = comprador.Text;
            sc.hash = Convert.ToString(dataGridView1[2, row].Value);
            sc.vendedor= Convert.ToString(dataGridView1[4, row].Value);


            nombre.Text = "";
            descripcion.Text = "";
            precio.Text = "";
            comprador.Text = "";

            ls2.Add(sc);

            xs2.Serialize(fs, ls2);

            fs.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dataGridView1.CurrentRow.Index;

            nombre.Text = Convert.ToString(dataGridView1[0, row].Value);
            descripcion.Text = Convert.ToString(dataGridView1[1, row].Value);
            precio.Text = Convert.ToString(dataGridView1[3, row].Value);
        }
    }
}
