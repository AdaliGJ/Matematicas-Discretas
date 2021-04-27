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
    public partial class AprobarProducto : Form
    {

        XmlSerializer xs;
        List<productoClass> ls;
        public AprobarProducto()
        {
            InitializeComponent();

            
            ls = new List<productoClass>();
            xs = new XmlSerializer(typeof(List<productoClass>));

            string startupPath = Environment.CurrentDirectory;

            var path = String.Format("Datos/ProductosAprobados.xml", startupPath);

            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            ls = (List<productoClass>)xs.Deserialize(fs);

            dataGridView1.DataSource = ls;
            fs.Close();
        }


        private void regresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Regulador r = new Regulador();
            r.ShowDialog();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void nombre_EntidadLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
