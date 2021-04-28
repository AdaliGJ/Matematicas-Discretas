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
    public partial class CrearCuentaV : Form
    {
        

        public CrearCuentaV()
        {
            InitializeComponent();

            saldoText.Text = "Q1000";


            string startupPath = Environment.CurrentDirectory;
            var path = String.Format("Datos/CuentasVendedores.xml", startupPath);

            DataSet dataset = new DataSet();
            dataset.ReadXml(path);
            dataGridView1.DataSource = dataset.Tables[0];

        }

        private void button4_Click(object sender, EventArgs e)
        {
           
            string startupPath = Environment.CurrentDirectory;

            var path = String.Format("Datos/CuentasVendedores.xml", startupPath);

            DataTable dt = GetDataTableFromDGV(dataGridView1);
            DataSet ds = new DataSet();

            ds.Tables.Add(dt);
            ds.WriteXml(File.OpenWrite(path));

        }


        private DataTable GetDataTableFromDGV(DataGridView dgv)
        {
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


        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Regulador r = new Regulador();
            r.ShowDialog();
            this.Close();
        }
    }
}
