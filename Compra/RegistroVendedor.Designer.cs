
namespace Compra
{
    partial class RegistroVendedor
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
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label nombre_EntidadLabel;
            System.Windows.Forms.Label entidadLabel;
            this.privText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonRegresar = new System.Windows.Forms.Button();
            this.buttonEnviar = new System.Windows.Forms.Button();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.firmText = new System.Windows.Forms.TextBox();
            this.nitText = new System.Windows.Forms.TextBox();
            this.entText = new System.Windows.Forms.TextBox();
            this.llaveText = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            nombre_EntidadLabel = new System.Windows.Forms.Label();
            entidadLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            label4.Location = new System.Drawing.Point(184, 260);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(362, 13);
            label4.TabIndex = 67;
            label4.Text = "La llave privada no se guardará en el sistema. Se utilizará solo para la firma.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            label3.Location = new System.Drawing.Point(78, 199);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(98, 17);
            label3.TabIndex = 66;
            label3.Text = "Llave Privada:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            label1.Location = new System.Drawing.Point(140, 91);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(34, 17);
            label1.TabIndex = 58;
            label1.Text = "NIT:";
            // 
            // nombre_EntidadLabel
            // 
            nombre_EntidadLabel.AutoSize = true;
            nombre_EntidadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            nombre_EntidadLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            nombre_EntidadLabel.Location = new System.Drawing.Point(78, 140);
            nombre_EntidadLabel.Name = "nombre_EntidadLabel";
            nombre_EntidadLabel.Size = new System.Drawing.Size(96, 17);
            nombre_EntidadLabel.TabIndex = 54;
            nombre_EntidadLabel.Text = "Llave Pública:";
            // 
            // entidadLabel
            // 
            entidadLabel.AutoSize = true;
            entidadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            entidadLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            entidadLabel.Location = new System.Drawing.Point(25, 62);
            entidadLabel.Name = "entidadLabel";
            entidadLabel.Size = new System.Drawing.Size(149, 17);
            entidadLabel.TabIndex = 55;
            entidadLabel.Text = "Nombre de la Entidad:";
            // 
            // privText
            // 
            this.privText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.privText.Location = new System.Drawing.Point(180, 184);
            this.privText.Multiline = true;
            this.privText.Name = "privText";
            this.privText.Size = new System.Drawing.Size(585, 70);
            this.privText.TabIndex = 65;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(14, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(312, 20);
            this.label2.TabIndex = 64;
            this.label2.Text = "Por Favor Ingrese los Datos de su Entidad:";
            // 
            // buttonRegresar
            // 
            this.buttonRegresar.BackColor = System.Drawing.Color.Red;
            this.buttonRegresar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(26)))), ((int)(((byte)(100)))));
            this.buttonRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.buttonRegresar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonRegresar.Location = new System.Drawing.Point(28, 404);
            this.buttonRegresar.Name = "buttonRegresar";
            this.buttonRegresar.Size = new System.Drawing.Size(168, 30);
            this.buttonRegresar.TabIndex = 63;
            this.buttonRegresar.Text = "Regresar a Menú";
            this.buttonRegresar.UseVisualStyleBackColor = false;
            this.buttonRegresar.Click += new System.EventHandler(this.buttonRegresar_Click);
            // 
            // buttonEnviar
            // 
            this.buttonEnviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(26)))), ((int)(((byte)(100)))));
            this.buttonEnviar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(26)))), ((int)(((byte)(100)))));
            this.buttonEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.buttonEnviar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonEnviar.Location = new System.Drawing.Point(552, 404);
            this.buttonEnviar.Name = "buttonEnviar";
            this.buttonEnviar.Size = new System.Drawing.Size(213, 30);
            this.buttonEnviar.TabIndex = 62;
            this.buttonEnviar.Text = "Enviar Solicitud";
            this.buttonEnviar.UseVisualStyleBackColor = false;
            this.buttonEnviar.Click += new System.EventHandler(this.buttonEnviar_Click);
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(26)))), ((int)(((byte)(100)))));
            this.buttonAceptar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(26)))), ((int)(((byte)(100)))));
            this.buttonAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.buttonAceptar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonAceptar.Location = new System.Drawing.Point(552, 260);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(213, 30);
            this.buttonAceptar.TabIndex = 61;
            this.buttonAceptar.Text = "Aceptar y Firmar Datos";
            this.buttonAceptar.UseVisualStyleBackColor = false;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // firmText
            // 
            this.firmText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.firmText.Location = new System.Drawing.Point(28, 311);
            this.firmText.Multiline = true;
            this.firmText.Name = "firmText";
            this.firmText.Size = new System.Drawing.Size(737, 78);
            this.firmText.TabIndex = 60;
            // 
            // nitText
            // 
            this.nitText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nitText.Location = new System.Drawing.Point(180, 88);
            this.nitText.Name = "nitText";
            this.nitText.Size = new System.Drawing.Size(585, 23);
            this.nitText.TabIndex = 59;
            // 
            // entText
            // 
            this.entText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.entText.Location = new System.Drawing.Point(180, 59);
            this.entText.Name = "entText";
            this.entText.Size = new System.Drawing.Size(585, 23);
            this.entText.TabIndex = 56;
            // 
            // llaveText
            // 
            this.llaveText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.llaveText.Location = new System.Drawing.Point(180, 117);
            this.llaveText.Multiline = true;
            this.llaveText.Name = "llaveText";
            this.llaveText.Size = new System.Drawing.Size(585, 61);
            this.llaveText.TabIndex = 57;
            // 
            // RegistroVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(26)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(label4);
            this.Controls.Add(label3);
            this.Controls.Add(this.privText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonRegresar);
            this.Controls.Add(this.buttonEnviar);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.firmText);
            this.Controls.Add(this.nitText);
            this.Controls.Add(label1);
            this.Controls.Add(nombre_EntidadLabel);
            this.Controls.Add(entidadLabel);
            this.Controls.Add(this.entText);
            this.Controls.Add(this.llaveText);
            this.Name = "RegistroVendedor";
            this.Text = "RegistrarVendedor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonRegresar;
        private System.Windows.Forms.Button buttonEnviar;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.TextBox firmText;
        private System.Windows.Forms.TextBox nitText;
        private System.Windows.Forms.TextBox entText;
        public System.Windows.Forms.TextBox privText;
        public System.Windows.Forms.TextBox llaveText;
    }
}