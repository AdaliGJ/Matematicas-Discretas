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
    public partial class AprobarVendedor : Form
    {
        public AprobarVendedor()
        {
            InitializeComponent();
        }

        private void vendedores_AprovadosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vendedores_AprovadosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database);

        }

        private void AprobarVendedor_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'database.Vendedores_Aprovados' Puede moverla o quitarla según sea necesario.
            this.vendedores_AprovadosTableAdapter.Fill(this.database.Vendedores_Aprovados);

        }

        private void clave_PúblicaTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
