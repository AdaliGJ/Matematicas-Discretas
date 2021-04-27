
namespace Compra
{
    partial class MostrarProductos
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
            System.Windows.Forms.Label nombre_EntidadLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label entidadLabel;
            System.Windows.Forms.Label label3;
            this.regresar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.descripcion = new System.Windows.Forms.TextBox();
            this.nombre = new System.Windows.Forms.TextBox();
            this.precio = new System.Windows.Forms.TextBox();
            this.comprador = new System.Windows.Forms.TextBox();
            nombre_EntidadLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            entidadLabel = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // regresar
            // 
            this.regresar.BackColor = System.Drawing.Color.Red;
            this.regresar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(26)))), ((int)(((byte)(100)))));
            this.regresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.regresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.regresar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.regresar.Location = new System.Drawing.Point(35, 393);
            this.regresar.Name = "regresar";
            this.regresar.Size = new System.Drawing.Size(228, 30);
            this.regresar.TabIndex = 61;
            this.regresar.Text = "Regresar a Menú Comprador";
            this.regresar.UseVisualStyleBackColor = false;
            this.regresar.Click += new System.EventHandler(this.regresar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(35, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(717, 139);
            this.dataGridView1.TabIndex = 60;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // nombre_EntidadLabel
            // 
            nombre_EntidadLabel.AutoSize = true;
            nombre_EntidadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            nombre_EntidadLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            nombre_EntidadLabel.Location = new System.Drawing.Point(30, 23);
            nombre_EntidadLabel.Name = "nombre_EntidadLabel";
            nombre_EntidadLabel.Size = new System.Drawing.Size(539, 25);
            nombre_EntidadLabel.TabIndex = 59;
            nombre_EntidadLabel.Text = "Haga doble click sobre el producto en el que está interesado:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(26)))), ((int)(((byte)(100)))));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(26)))), ((int)(((byte)(100)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(619, 393);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 30);
            this.button2.TabIndex = 62;
            this.button2.Text = "Pedir Producto";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // descripcion
            // 
            this.descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.descripcion.Location = new System.Drawing.Point(167, 262);
            this.descripcion.Multiline = true;
            this.descripcion.Name = "descripcion";
            this.descripcion.Size = new System.Drawing.Size(585, 55);
            this.descripcion.TabIndex = 68;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            label1.Location = new System.Drawing.Point(75, 281);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(89, 17);
            label1.TabIndex = 67;
            label1.Text = "Desciripción:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            label2.Location = new System.Drawing.Point(102, 199);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(62, 17);
            label2.TabIndex = 63;
            label2.Text = "Nombre:";
            // 
            // entidadLabel
            // 
            entidadLabel.AutoSize = true;
            entidadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            entidadLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            entidadLabel.Location = new System.Drawing.Point(112, 232);
            entidadLabel.Name = "entidadLabel";
            entidadLabel.Size = new System.Drawing.Size(52, 17);
            entidadLabel.TabIndex = 64;
            entidadLabel.Text = "Precio:";
            // 
            // nombre
            // 
            this.nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nombre.Location = new System.Drawing.Point(167, 196);
            this.nombre.Multiline = true;
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(585, 27);
            this.nombre.TabIndex = 65;
            // 
            // precio
            // 
            this.precio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.precio.Location = new System.Drawing.Point(167, 229);
            this.precio.Multiline = true;
            this.precio.Name = "precio";
            this.precio.Size = new System.Drawing.Size(585, 27);
            this.precio.TabIndex = 66;
            // 
            // comprador
            // 
            this.comprador.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comprador.Location = new System.Drawing.Point(167, 323);
            this.comprador.Multiline = true;
            this.comprador.Name = "comprador";
            this.comprador.Size = new System.Drawing.Size(585, 55);
            this.comprador.TabIndex = 69;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            label3.Location = new System.Drawing.Point(53, 342);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(111, 17);
            label3.TabIndex = 70;
            label3.Text = "Tu llave pública:";
            // 
            // MostrarProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(26)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(label3);
            this.Controls.Add(this.comprador);
            this.Controls.Add(this.descripcion);
            this.Controls.Add(label1);
            this.Controls.Add(label2);
            this.Controls.Add(entidadLabel);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.precio);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.regresar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(nombre_EntidadLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MostrarProductos";
            this.Text = "MostrarProductos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button regresar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox descripcion;
        public System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.TextBox precio;
        private System.Windows.Forms.TextBox comprador;
    }
}