
namespace Compra
{
    partial class AprobarProducto
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.regresar = new System.Windows.Forms.Button();
            nombre_EntidadLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // nombre_EntidadLabel
            // 
            nombre_EntidadLabel.AutoSize = true;
            nombre_EntidadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            nombre_EntidadLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            nombre_EntidadLabel.Location = new System.Drawing.Point(38, 36);
            nombre_EntidadLabel.Name = "nombre_EntidadLabel";
            nombre_EntidadLabel.Size = new System.Drawing.Size(214, 25);
            nombre_EntidadLabel.TabIndex = 37;
            nombre_EntidadLabel.Text = "Productos Registrados:";
            nombre_EntidadLabel.Click += new System.EventHandler(this.nombre_EntidadLabel_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(43, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(717, 290);
            this.dataGridView1.TabIndex = 38;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // regresar
            // 
            this.regresar.BackColor = System.Drawing.Color.Red;
            this.regresar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(26)))), ((int)(((byte)(100)))));
            this.regresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.regresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.regresar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.regresar.Location = new System.Drawing.Point(43, 397);
            this.regresar.Name = "regresar";
            this.regresar.Size = new System.Drawing.Size(228, 30);
            this.regresar.TabIndex = 58;
            this.regresar.Text = "Regresar a Menú Regulador";
            this.regresar.UseVisualStyleBackColor = false;
            this.regresar.Click += new System.EventHandler(this.regresar_Click);
            // 
            // AprobarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(26)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.regresar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(nombre_EntidadLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AprobarProducto";
            this.Text = "AprobarProducto";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button regresar;
    }
}