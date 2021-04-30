
namespace Compra
{
    partial class EntregaProducto
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label nombre_EntidadLabel;
            System.Windows.Forms.Label entidadLabel;
            System.Windows.Forms.Label label3;
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.regresar = new System.Windows.Forms.Button();
            this.verificarText = new System.Windows.Forms.TextBox();
            this.infoText = new System.Windows.Forms.TextBox();
            this.verificar = new System.Windows.Forms.Button();
            this.llaveText = new System.Windows.Forms.TextBox();
            this.infoFirmaText = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            nombre_EntidadLabel = new System.Windows.Forms.Label();
            entidadLabel = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            label1.Location = new System.Drawing.Point(34, 339);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(167, 17);
            label1.TabIndex = 94;
            label1.Text = "Información Transacción:";
            // 
            // nombre_EntidadLabel
            // 
            nombre_EntidadLabel.AutoSize = true;
            nombre_EntidadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            nombre_EntidadLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            nombre_EntidadLabel.Location = new System.Drawing.Point(60, 214);
            nombre_EntidadLabel.Name = "nombre_EntidadLabel";
            nombre_EntidadLabel.Size = new System.Drawing.Size(140, 17);
            nombre_EntidadLabel.TabIndex = 90;
            nombre_EntidadLabel.Text = "Información Firmada:";
            // 
            // entidadLabel
            // 
            entidadLabel.AutoSize = true;
            entidadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            entidadLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            entidadLabel.Location = new System.Drawing.Point(17, 275);
            entidadLabel.Name = "entidadLabel";
            entidadLabel.Size = new System.Drawing.Size(183, 17);
            entidadLabel.TabIndex = 91;
            entidadLabel.Text = "Llave Pública de la Entidad:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            label3.Location = new System.Drawing.Point(416, 177);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(173, 17);
            label3.TabIndex = 100;
            label3.Text = "Verificar Firma Regulador:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 103);
            this.dataGridView1.TabIndex = 83;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(9, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 17);
            this.label2.TabIndex = 89;
            this.label2.Text = "Seleccionar transacción deseada:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(26)))), ((int)(((byte)(100)))));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(26)))), ((int)(((byte)(100)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(595, 406);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(193, 30);
            this.button2.TabIndex = 99;
            this.button2.Text = "Ir a enviar producto";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // regresar
            // 
            this.regresar.BackColor = System.Drawing.Color.Red;
            this.regresar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(26)))), ((int)(((byte)(100)))));
            this.regresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.regresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.regresar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.regresar.Location = new System.Drawing.Point(12, 410);
            this.regresar.Name = "regresar";
            this.regresar.Size = new System.Drawing.Size(159, 30);
            this.regresar.TabIndex = 98;
            this.regresar.Text = "Regresar a Menú";
            this.regresar.UseVisualStyleBackColor = false;
            this.regresar.Click += new System.EventHandler(this.regresar_Click);
            // 
            // verificarText
            // 
            this.verificarText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.verificarText.Location = new System.Drawing.Point(391, 415);
            this.verificarText.Name = "verificarText";
            this.verificarText.Size = new System.Drawing.Size(175, 23);
            this.verificarText.TabIndex = 97;
            // 
            // infoText
            // 
            this.infoText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.infoText.Location = new System.Drawing.Point(203, 322);
            this.infoText.Multiline = true;
            this.infoText.Name = "infoText";
            this.infoText.Size = new System.Drawing.Size(585, 48);
            this.infoText.TabIndex = 96;
            // 
            // verificar
            // 
            this.verificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(26)))), ((int)(((byte)(100)))));
            this.verificar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(26)))), ((int)(((byte)(100)))));
            this.verificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.verificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.verificar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.verificar.Location = new System.Drawing.Point(226, 410);
            this.verificar.Name = "verificar";
            this.verificar.Size = new System.Drawing.Size(159, 30);
            this.verificar.TabIndex = 95;
            this.verificar.Text = "Verificar Firma";
            this.verificar.UseVisualStyleBackColor = false;
            this.verificar.Click += new System.EventHandler(this.verificar_Click);
            // 
            // llaveText
            // 
            this.llaveText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.llaveText.Location = new System.Drawing.Point(203, 253);
            this.llaveText.Multiline = true;
            this.llaveText.Name = "llaveText";
            this.llaveText.Size = new System.Drawing.Size(585, 63);
            this.llaveText.TabIndex = 92;
            // 
            // infoFirmaText
            // 
            this.infoFirmaText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.infoFirmaText.Location = new System.Drawing.Point(203, 197);
            this.infoFirmaText.Multiline = true;
            this.infoFirmaText.Name = "infoFirmaText";
            this.infoFirmaText.Size = new System.Drawing.Size(585, 50);
            this.infoFirmaText.TabIndex = 93;
            // 
            // EntregaProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(26)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.regresar);
            this.Controls.Add(this.verificarText);
            this.Controls.Add(this.infoText);
            this.Controls.Add(this.verificar);
            this.Controls.Add(label1);
            this.Controls.Add(nombre_EntidadLabel);
            this.Controls.Add(entidadLabel);
            this.Controls.Add(this.llaveText);
            this.Controls.Add(this.infoFirmaText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "EntregaProducto";
            this.Text = "EntregaProducto";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button regresar;
        private System.Windows.Forms.TextBox verificarText;
        private System.Windows.Forms.TextBox infoText;
        private System.Windows.Forms.Button verificar;
        public System.Windows.Forms.TextBox llaveText;
        private System.Windows.Forms.TextBox infoFirmaText;
    }
}