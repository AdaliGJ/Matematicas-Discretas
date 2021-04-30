
namespace Compra
{
    partial class VerificarSolicitudC
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.verificar = new System.Windows.Forms.Button();
            this.llaveText = new System.Windows.Forms.TextBox();
            this.infoFirmaText = new System.Windows.Forms.TextBox();
            this.infoText = new System.Windows.Forms.TextBox();
            this.verificarText = new System.Windows.Forms.TextBox();
            this.regresar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            nombre_EntidadLabel = new System.Windows.Forms.Label();
            entidadLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            label1.Location = new System.Drawing.Point(10, 369);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(172, 17);
            label1.TabIndex = 38;
            label1.Text = "Información de la Entidad:";
            label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // nombre_EntidadLabel
            // 
            nombre_EntidadLabel.AutoSize = true;
            nombre_EntidadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            nombre_EntidadLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            nombre_EntidadLabel.Location = new System.Drawing.Point(42, 223);
            nombre_EntidadLabel.Name = "nombre_EntidadLabel";
            nombre_EntidadLabel.Size = new System.Drawing.Size(140, 17);
            nombre_EntidadLabel.TabIndex = 33;
            nombre_EntidadLabel.Text = "Información Firmada:";
            nombre_EntidadLabel.Click += new System.EventHandler(this.nombre_EntidadLabel_Click);
            // 
            // entidadLabel
            // 
            entidadLabel.AutoSize = true;
            entidadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            entidadLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            entidadLabel.Location = new System.Drawing.Point(-1, 311);
            entidadLabel.Name = "entidadLabel";
            entidadLabel.Size = new System.Drawing.Size(183, 17);
            entidadLabel.TabIndex = 34;
            entidadLabel.Text = "Llave Pública de la Entidad:";
            entidadLabel.Click += new System.EventHandler(this.entidadLabel_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(752, 107);
            this.dataGridView1.TabIndex = 41;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // verificar
            // 
            this.verificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(26)))), ((int)(((byte)(100)))));
            this.verificar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(26)))), ((int)(((byte)(100)))));
            this.verificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.verificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.verificar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.verificar.Location = new System.Drawing.Point(185, 412);
            this.verificar.Name = "verificar";
            this.verificar.Size = new System.Drawing.Size(159, 30);
            this.verificar.TabIndex = 40;
            this.verificar.Text = "Verificar Firma";
            this.verificar.UseVisualStyleBackColor = false;
            this.verificar.Click += new System.EventHandler(this.verificar_Click);
            // 
            // llaveText
            // 
            this.llaveText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.llaveText.Location = new System.Drawing.Point(185, 284);
            this.llaveText.Multiline = true;
            this.llaveText.Name = "llaveText";
            this.llaveText.Size = new System.Drawing.Size(585, 63);
            this.llaveText.TabIndex = 35;
            this.llaveText.TextChanged += new System.EventHandler(this.llaveText_TextChanged);
            // 
            // infoFirmaText
            // 
            this.infoFirmaText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.infoFirmaText.Location = new System.Drawing.Point(185, 190);
            this.infoFirmaText.Multiline = true;
            this.infoFirmaText.Name = "infoFirmaText";
            this.infoFirmaText.Size = new System.Drawing.Size(585, 78);
            this.infoFirmaText.TabIndex = 36;
            this.infoFirmaText.TextChanged += new System.EventHandler(this.infoFirmaText_TextChanged);
            // 
            // infoText
            // 
            this.infoText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.infoText.Location = new System.Drawing.Point(185, 366);
            this.infoText.Name = "infoText";
            this.infoText.Size = new System.Drawing.Size(585, 23);
            this.infoText.TabIndex = 42;
            this.infoText.TextChanged += new System.EventHandler(this.infoText_TextChanged);
            // 
            // verificarText
            // 
            this.verificarText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.verificarText.Location = new System.Drawing.Point(351, 416);
            this.verificarText.Name = "verificarText";
            this.verificarText.Size = new System.Drawing.Size(175, 23);
            this.verificarText.TabIndex = 43;
            this.verificarText.TextChanged += new System.EventHandler(this.verificarText_TextChanged);
            // 
            // regresar
            // 
            this.regresar.BackColor = System.Drawing.Color.Red;
            this.regresar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(26)))), ((int)(((byte)(100)))));
            this.regresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.regresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.regresar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.regresar.Location = new System.Drawing.Point(12, 412);
            this.regresar.Name = "regresar";
            this.regresar.Size = new System.Drawing.Size(159, 30);
            this.regresar.TabIndex = 44;
            this.regresar.Text = "Regresar a Menú";
            this.regresar.UseVisualStyleBackColor = false;
            this.regresar.Click += new System.EventHandler(this.regresar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(26, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 45;
            this.label2.Text = "Solicitudes:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(427, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 46;
            this.label3.Text = "Verificar Firma";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(26)))), ((int)(((byte)(100)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(26)))), ((int)(((byte)(100)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(575, 412);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 30);
            this.button1.TabIndex = 47;
            this.button1.Text = "Continuar con Registro";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // VerificarSolicitudC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(26)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.regresar);
            this.Controls.Add(this.verificarText);
            this.Controls.Add(this.infoText);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.verificar);
            this.Controls.Add(label1);
            this.Controls.Add(nombre_EntidadLabel);
            this.Controls.Add(entidadLabel);
            this.Controls.Add(this.llaveText);
            this.Controls.Add(this.infoFirmaText);
            this.Name = "VerificarSolicitudC";
            this.Text = "VerificarSolicitudC";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button verificar;
        private System.Windows.Forms.TextBox infoFirmaText;
        private System.Windows.Forms.TextBox infoText;
        private System.Windows.Forms.TextBox verificarText;
        private System.Windows.Forms.Button regresar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox llaveText;
    }
}