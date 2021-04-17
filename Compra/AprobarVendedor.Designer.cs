
namespace Compra
{
    partial class AprobarVendedor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AprobarVendedor));
            System.Windows.Forms.Label nombre_EntidadLabel;
            System.Windows.Forms.Label nITLabel;
            System.Windows.Forms.Label clave_PúblicaLabel;
            System.Windows.Forms.Label nacionalidadLabel;
            System.Windows.Forms.Label fecha_NacimientoLabel;
            this.database = new Compra.Database();
            this.vendedores_AprovadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vendedores_AprovadosTableAdapter = new Compra.DatabaseTableAdapters.Vendedores_AprovadosTableAdapter();
            this.tableAdapterManager = new Compra.DatabaseTableAdapters.TableAdapterManager();
            this.vendedores_AprovadosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.vendedores_AprovadosBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.vendedores_AprovadosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_EntidadTextBox = new System.Windows.Forms.TextBox();
            this.nITTextBox = new System.Windows.Forms.TextBox();
            this.clave_PúblicaTextBox = new System.Windows.Forms.TextBox();
            this.nacionalidadTextBox = new System.Windows.Forms.TextBox();
            this.fecha_NacimientoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            nombre_EntidadLabel = new System.Windows.Forms.Label();
            nITLabel = new System.Windows.Forms.Label();
            clave_PúblicaLabel = new System.Windows.Forms.Label();
            nacionalidadLabel = new System.Windows.Forms.Label();
            fecha_NacimientoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.database)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendedores_AprovadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendedores_AprovadosBindingNavigator)).BeginInit();
            this.vendedores_AprovadosBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vendedores_AprovadosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // database
            // 
            this.database.DataSetName = "Database";
            this.database.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vendedores_AprovadosBindingSource
            // 
            this.vendedores_AprovadosBindingSource.DataMember = "Vendedores_Aprovados";
            this.vendedores_AprovadosBindingSource.DataSource = this.database;
            // 
            // vendedores_AprovadosTableAdapter
            // 
            this.vendedores_AprovadosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Compra.DatabaseTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Vendedores_AprovadosTableAdapter = this.vendedores_AprovadosTableAdapter;
            // 
            // vendedores_AprovadosBindingNavigator
            // 
            this.vendedores_AprovadosBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.vendedores_AprovadosBindingNavigator.BindingSource = this.vendedores_AprovadosBindingSource;
            this.vendedores_AprovadosBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.vendedores_AprovadosBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.vendedores_AprovadosBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.vendedores_AprovadosBindingNavigatorSaveItem});
            this.vendedores_AprovadosBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.vendedores_AprovadosBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.vendedores_AprovadosBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.vendedores_AprovadosBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.vendedores_AprovadosBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.vendedores_AprovadosBindingNavigator.Name = "vendedores_AprovadosBindingNavigator";
            this.vendedores_AprovadosBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.vendedores_AprovadosBindingNavigator.Size = new System.Drawing.Size(806, 25);
            this.vendedores_AprovadosBindingNavigator.TabIndex = 0;
            this.vendedores_AprovadosBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // vendedores_AprovadosBindingNavigatorSaveItem
            // 
            this.vendedores_AprovadosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.vendedores_AprovadosBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("vendedores_AprovadosBindingNavigatorSaveItem.Image")));
            this.vendedores_AprovadosBindingNavigatorSaveItem.Name = "vendedores_AprovadosBindingNavigatorSaveItem";
            this.vendedores_AprovadosBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.vendedores_AprovadosBindingNavigatorSaveItem.Text = "Guardar datos";
            this.vendedores_AprovadosBindingNavigatorSaveItem.Click += new System.EventHandler(this.vendedores_AprovadosBindingNavigatorSaveItem_Click);
            // 
            // vendedores_AprovadosDataGridView
            // 
            this.vendedores_AprovadosDataGridView.AutoGenerateColumns = false;
            this.vendedores_AprovadosDataGridView.BackgroundColor = System.Drawing.Color.Silver;
            this.vendedores_AprovadosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vendedores_AprovadosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.vendedores_AprovadosDataGridView.DataSource = this.vendedores_AprovadosBindingSource;
            this.vendedores_AprovadosDataGridView.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.vendedores_AprovadosDataGridView.Location = new System.Drawing.Point(90, 303);
            this.vendedores_AprovadosDataGridView.Name = "vendedores_AprovadosDataGridView";
            this.vendedores_AprovadosDataGridView.Size = new System.Drawing.Size(632, 135);
            this.vendedores_AprovadosDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nombre Entidad";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre Entidad";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "NIT";
            this.dataGridViewTextBoxColumn3.HeaderText = "NIT";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Clave Pública";
            this.dataGridViewTextBoxColumn4.HeaderText = "Clave Pública";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Nacionalidad";
            this.dataGridViewTextBoxColumn5.HeaderText = "Nacionalidad";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Fecha Nacimiento";
            this.dataGridViewTextBoxColumn6.HeaderText = "Fecha Nacimiento";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // nombre_EntidadLabel
            // 
            nombre_EntidadLabel.AutoSize = true;
            nombre_EntidadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            nombre_EntidadLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            nombre_EntidadLabel.Location = new System.Drawing.Point(87, 79);
            nombre_EntidadLabel.Name = "nombre_EntidadLabel";
            nombre_EntidadLabel.Size = new System.Drawing.Size(114, 17);
            nombre_EntidadLabel.TabIndex = 4;
            nombre_EntidadLabel.Text = "Nombre Entidad:";
            // 
            // nombre_EntidadTextBox
            // 
            this.nombre_EntidadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendedores_AprovadosBindingSource, "Nombre Entidad", true));
            this.nombre_EntidadTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nombre_EntidadTextBox.Location = new System.Drawing.Point(204, 76);
            this.nombre_EntidadTextBox.Name = "nombre_EntidadTextBox";
            this.nombre_EntidadTextBox.Size = new System.Drawing.Size(462, 23);
            this.nombre_EntidadTextBox.TabIndex = 5;
            // 
            // nITLabel
            // 
            nITLabel.AutoSize = true;
            nITLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            nITLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            nITLabel.Location = new System.Drawing.Point(167, 121);
            nITLabel.Name = "nITLabel";
            nITLabel.Size = new System.Drawing.Size(34, 17);
            nITLabel.TabIndex = 6;
            nITLabel.Text = "NIT:";
            // 
            // nITTextBox
            // 
            this.nITTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendedores_AprovadosBindingSource, "NIT", true));
            this.nITTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nITTextBox.Location = new System.Drawing.Point(204, 121);
            this.nITTextBox.Name = "nITTextBox";
            this.nITTextBox.Size = new System.Drawing.Size(462, 23);
            this.nITTextBox.TabIndex = 7;
            // 
            // clave_PúblicaLabel
            // 
            clave_PúblicaLabel.AutoSize = true;
            clave_PúblicaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            clave_PúblicaLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            clave_PúblicaLabel.Location = new System.Drawing.Point(104, 165);
            clave_PúblicaLabel.Name = "clave_PúblicaLabel";
            clave_PúblicaLabel.Size = new System.Drawing.Size(97, 17);
            clave_PúblicaLabel.TabIndex = 8;
            clave_PúblicaLabel.Text = "Clave Pública:";
            // 
            // clave_PúblicaTextBox
            // 
            this.clave_PúblicaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendedores_AprovadosBindingSource, "Clave Pública", true));
            this.clave_PúblicaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.clave_PúblicaTextBox.Location = new System.Drawing.Point(204, 162);
            this.clave_PúblicaTextBox.Name = "clave_PúblicaTextBox";
            this.clave_PúblicaTextBox.Size = new System.Drawing.Size(462, 23);
            this.clave_PúblicaTextBox.TabIndex = 9;
            this.clave_PúblicaTextBox.TextChanged += new System.EventHandler(this.clave_PúblicaTextBox_TextChanged);
            // 
            // nacionalidadLabel
            // 
            nacionalidadLabel.AutoSize = true;
            nacionalidadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            nacionalidadLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            nacionalidadLabel.Location = new System.Drawing.Point(104, 209);
            nacionalidadLabel.Name = "nacionalidadLabel";
            nacionalidadLabel.Size = new System.Drawing.Size(94, 17);
            nacionalidadLabel.TabIndex = 10;
            nacionalidadLabel.Text = "Nacionalidad:";
            // 
            // nacionalidadTextBox
            // 
            this.nacionalidadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendedores_AprovadosBindingSource, "Nacionalidad", true));
            this.nacionalidadTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nacionalidadTextBox.Location = new System.Drawing.Point(204, 206);
            this.nacionalidadTextBox.Name = "nacionalidadTextBox";
            this.nacionalidadTextBox.Size = new System.Drawing.Size(462, 23);
            this.nacionalidadTextBox.TabIndex = 11;
            // 
            // fecha_NacimientoLabel
            // 
            fecha_NacimientoLabel.AutoSize = true;
            fecha_NacimientoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            fecha_NacimientoLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            fecha_NacimientoLabel.Location = new System.Drawing.Point(73, 259);
            fecha_NacimientoLabel.Name = "fecha_NacimientoLabel";
            fecha_NacimientoLabel.Size = new System.Drawing.Size(125, 17);
            fecha_NacimientoLabel.TabIndex = 12;
            fecha_NacimientoLabel.Text = "Fecha Nacimiento:";
            // 
            // fecha_NacimientoDateTimePicker
            // 
            this.fecha_NacimientoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.vendedores_AprovadosBindingSource, "Fecha Nacimiento", true));
            this.fecha_NacimientoDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.fecha_NacimientoDateTimePicker.Location = new System.Drawing.Point(204, 253);
            this.fecha_NacimientoDateTimePicker.Name = "fecha_NacimientoDateTimePicker";
            this.fecha_NacimientoDateTimePicker.Size = new System.Drawing.Size(462, 23);
            this.fecha_NacimientoDateTimePicker.TabIndex = 13;
            // 
            // AprobarVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(24)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(806, 450);
            this.Controls.Add(nombre_EntidadLabel);
            this.Controls.Add(this.nombre_EntidadTextBox);
            this.Controls.Add(nITLabel);
            this.Controls.Add(this.nITTextBox);
            this.Controls.Add(clave_PúblicaLabel);
            this.Controls.Add(this.clave_PúblicaTextBox);
            this.Controls.Add(nacionalidadLabel);
            this.Controls.Add(this.nacionalidadTextBox);
            this.Controls.Add(fecha_NacimientoLabel);
            this.Controls.Add(this.fecha_NacimientoDateTimePicker);
            this.Controls.Add(this.vendedores_AprovadosDataGridView);
            this.Controls.Add(this.vendedores_AprovadosBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AprobarVendedor";
            this.Text = "AprobarVendedor";
            this.Load += new System.EventHandler(this.AprobarVendedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendedores_AprovadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendedores_AprovadosBindingNavigator)).EndInit();
            this.vendedores_AprovadosBindingNavigator.ResumeLayout(false);
            this.vendedores_AprovadosBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vendedores_AprovadosDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Database database;
        private System.Windows.Forms.BindingSource vendedores_AprovadosBindingSource;
        private DatabaseTableAdapters.Vendedores_AprovadosTableAdapter vendedores_AprovadosTableAdapter;
        private DatabaseTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator vendedores_AprovadosBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton vendedores_AprovadosBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView vendedores_AprovadosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.TextBox nombre_EntidadTextBox;
        private System.Windows.Forms.TextBox nITTextBox;
        private System.Windows.Forms.TextBox clave_PúblicaTextBox;
        private System.Windows.Forms.TextBox nacionalidadTextBox;
        private System.Windows.Forms.DateTimePicker fecha_NacimientoDateTimePicker;
    }
}