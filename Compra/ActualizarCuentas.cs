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
    public partial class ActualizarCuentas : Form
    {

        public ActualizarCuentas()
        {
            InitializeComponent();

            

            string startupPath = Environment.CurrentDirectory;
            var path = String.Format("Datos/CuentasVendedores.xml", startupPath);

            DataSet dataset = new DataSet();
            dataset.ReadXml(path);
            dataGridView1.DataSource = dataset.Tables[0];


           

            var path2 = String.Format("Datos/CuentasCompradores.xml", startupPath);

            DataSet dataset2 = new DataSet();
            dataset2.ReadXml(path2);
            dataGridView2.DataSource = dataset2.Tables[0];

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

            string startupPath = Environment.CurrentDirectory;

            var path = String.Format("Datos/CuentasVendedores.xml", startupPath);

            DataTable dt = GetDataTableFromDGV(dataGridView1);
            DataSet ds = new DataSet();

            ds.Tables.Add(dt);
            ds.WriteXml(File.OpenWrite(path));



            var path2 = String.Format("Datos/CuentasCompradores.xml", startupPath);

            DataTable dt2 = GetDataTableFromDGV(dataGridView2);
            DataSet ds2 = new DataSet();

            ds2.Tables.Add(dt2);
            ds2.WriteXml(File.OpenWrite(path2));
        }

        private DataTable GetDataTableFromDGV(DataGridView dgv)
        {

            if (dgv.Columns[0].Visible)
            {
                dgv.Columns[0].HeaderText = "Saldo";
            }
            if (dgv.Columns[1].Visible)
            {
                dgv.Columns[1].HeaderText = "Llave";
            }
            if (dgv.Columns[2].Visible)
            {
                dgv.Columns[2].HeaderText = "Última Actualización";
            }

            var dt = new DataTable();
            foreach (DataGridViewColumn column in dgv.Columns)
            {
                if (column.Visible)
                {
                    dt.Columns.Add();
                    
                }
            }
            object[] cellValues = new object[dgv.Columns.Count];
            foreach (DataGridViewRow row in dgv.Rows)
            {
                for (int i = 0; i < row.Cells.Count; i++)
                {
                    cellValues[i] = row.Cells[i].Value;
                }
                dt.Rows.Add(cellValues);
            }
            return dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            IniciarTransaccion it = new IniciarTransaccion();
            it.identificadorText.Text = identificadorText.Text;
            it.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Regulador r = new Regulador();
            r.ShowDialog();
            this.Close();
        }
    }
}
