
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
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label nombre_EntidadLabel;
            System.Windows.Forms.Label entidadLabel;
            System.Windows.Forms.Label label4;
            this.regresar = new System.Windows.Forms.Button();
            this.firmar = new System.Windows.Forms.Button();
            this.firmText = new System.Windows.Forms.TextBox();
            this.privText = new System.Windows.Forms.TextBox();
            this.llaveText = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.entText = new System.Windows.Forms.TextBox();
            this.infoText = new System.Windows.Forms.TextBox();
            this.expText = new System.Windows.Forms.DateTimePicker();
            this.publica = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            nombre_EntidadLabel = new System.Windows.Forms.Label();
            entidadLabel = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            label3.Location = new System.Drawing.Point(16, 199);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(168, 17);
            label3.TabIndex = 56;
            label3.Text = "Llave Privada Regulador:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            label2.Location = new System.Drawing.Point(36, 137);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(148, 17);
            label2.TabIndex = 54;
            label2.Text = "Llave Pública Entidad:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            label1.Location = new System.Drawing.Point(44, 88);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(140, 17);
            label1.TabIndex = 51;
            label1.Text = "Fecha de Expiración:";
            // 
            // nombre_EntidadLabel
            // 
            nombre_EntidadLabel.AutoSize = true;
            nombre_EntidadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            nombre_EntidadLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            nombre_EntidadLabel.Location = new System.Drawing.Point(47, 19);
            nombre_EntidadLabel.Name = "nombre_EntidadLabel";
            nombre_EntidadLabel.Size = new System.Drawing.Size(137, 17);
            nombre_EntidadLabel.TabIndex = 46;
            nombre_EntidadLabel.Text = "Información Entidad:";
            // 
            // entidadLabel
            // 
            entidadLabel.AutoSize = true;
            entidadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            entidadLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            entidadLabel.Location = new System.Drawing.Point(72, 57);
            entidadLabel.Name = "entidadLabel";
            entidadLabel.Size = new System.Drawing.Size(112, 17);
            entidadLabel.TabIndex = 47;
            entidadLabel.Text = "Tipo de Entidad:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            label4.Location = new System.Drawing.Point(16, 265);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(166, 17);
            label4.TabIndex = 61;
            label4.Text = "Llave Pública Regulador:";
            // 
            // regresar
            // 
            this.regresar.BackColor = System.Drawing.Color.Red;
            this.regresar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(26)))), ((int)(((byte)(100)))));
            this.regresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.regresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.regresar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.regresar.Location = new System.Drawing.Point(19, 425);
            this.regresar.Name = "regresar";
            this.regresar.Size = new System.Drawing.Size(159, 30);
            this.regresar.TabIndex = 59;
            this.regresar.Text = "Regresar a Menú";
            this.regresar.UseVisualStyleBackColor = false;
            this.regresar.Click += new System.EventHandler(this.regresar_Click);
            // 
            // firmar
            // 
            this.firmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(26)))), ((int)(((byte)(100)))));
            this.firmar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(26)))), ((int)(((byte)(100)))));
            this.firmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.firmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.firmar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.firmar.Location = new System.Drawing.Point(656, 313);
            this.firmar.Name = "firmar";
            this.firmar.Size = new System.Drawing.Size(114, 30);
            this.firmar.TabIndex = 58;
            this.firmar.Text = "Firmar Datos";
            this.firmar.UseVisualStyleBackColor = false;
            this.firmar.Click += new System.EventHandler(this.firmar_Click);
            // 
            // firmText
            // 
            this.firmText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.firmText.Location = new System.Drawing.Point(19, 358);
            this.firmText.Multiline = true;
            this.firmText.Name = "firmText";
            this.firmText.Size = new System.Drawing.Size(758, 61);
            this.firmText.TabIndex = 57;
            this.firmText.TextChanged += new System.EventHandler(this.firmText_TextChanged);
            // 
            // privText
            // 
            this.privText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.privText.Location = new System.Drawing.Point(185, 179);
            this.privText.Multiline = true;
            this.privText.Name = "privText";
            this.privText.Size = new System.Drawing.Size(585, 61);
            this.privText.TabIndex = 55;
            // 
            // llaveText
            // 
            this.llaveText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.llaveText.Location = new System.Drawing.Point(185, 112);
            this.llaveText.Multiline = true;
            this.llaveText.Name = "llaveText";
            this.llaveText.Size = new System.Drawing.Size(585, 61);
            this.llaveText.TabIndex = 53;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(26)))), ((int)(((byte)(100)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(26)))), ((int)(((byte)(100)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(614, 425);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 30);
            this.button1.TabIndex = 52;
            this.button1.Text = "Guardar Certificado";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // entText
            // 
            this.entText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.entText.Location = new System.Drawing.Point(185, 54);
            this.entText.Name = "entText";
            this.entText.Size = new System.Drawing.Size(585, 23);
            this.entText.TabIndex = 48;
            // 
            // infoText
            // 
            this.infoText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.infoText.Location = new System.Drawing.Point(185, 16);
            this.infoText.Multiline = true;
            this.infoText.Name = "infoText";
            this.infoText.Size = new System.Drawing.Size(585, 32);
            this.infoText.TabIndex = 49;
            // 
            // expText
            // 
            this.expText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.expText.Location = new System.Drawing.Point(185, 83);
            this.expText.Name = "expText";
            this.expText.Size = new System.Drawing.Size(585, 23);
            this.expText.TabIndex = 50;
            // 
            // publica
            // 
            this.publica.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.publica.Location = new System.Drawing.Point(185, 246);
            this.publica.Multiline = true;
            this.publica.Name = "publica";
            this.publica.Size = new System.Drawing.Size(585, 61);
            this.publica.TabIndex = 60;
            // 
            // AprobarVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(26)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(800, 466);
            this.Controls.Add(label4);
            this.Controls.Add(this.publica);
            this.Controls.Add(this.regresar);
            this.Controls.Add(this.firmar);
            this.Controls.Add(this.firmText);
            this.Controls.Add(label3);
            this.Controls.Add(this.privText);
            this.Controls.Add(label2);
            this.Controls.Add(this.llaveText);
            this.Controls.Add(this.button1);
            this.Controls.Add(label1);
            this.Controls.Add(nombre_EntidadLabel);
            this.Controls.Add(entidadLabel);
            this.Controls.Add(this.entText);
            this.Controls.Add(this.infoText);
            this.Controls.Add(this.expText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AprobarVendedor";
            this.Text = "AprobarVendedor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button regresar;
        private System.Windows.Forms.Button firmar;
        public System.Windows.Forms.TextBox firmText;
        public System.Windows.Forms.TextBox privText;
        public System.Windows.Forms.TextBox llaveText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox entText;
        public System.Windows.Forms.TextBox infoText;
        private System.Windows.Forms.DateTimePicker expText;
        public System.Windows.Forms.TextBox publica;
    }
}