
namespace Compra
{
    partial class GenerarCompraVenta
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.TextBox();
            this.identificador = new System.Windows.Forms.TextBox();
            this.precio = new System.Windows.Forms.TextBox();
            this.hash = new System.Windows.Forms.TextBox();
            this.llavePriv = new System.Windows.Forms.TextBox();
            this.firmado = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.comprador = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.entidad = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.exp = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.firmacert = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.llavevend = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.llavereg = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(566, 102);
            this.dataGridView1.TabIndex = 56;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(16, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 17);
            this.label1.TabIndex = 57;
            this.label1.Text = "Seleccione su certificado de autorización:";
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(725, 50);
            this.nombre.Multiline = true;
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(432, 23);
            this.nombre.TabIndex = 67;
            // 
            // identificador
            // 
            this.identificador.Location = new System.Drawing.Point(140, 206);
            this.identificador.Multiline = true;
            this.identificador.Name = "identificador";
            this.identificador.Size = new System.Drawing.Size(438, 24);
            this.identificador.TabIndex = 68;
            // 
            // precio
            // 
            this.precio.Location = new System.Drawing.Point(140, 236);
            this.precio.Multiline = true;
            this.precio.Name = "precio";
            this.precio.Size = new System.Drawing.Size(438, 24);
            this.precio.TabIndex = 69;
            // 
            // hash
            // 
            this.hash.Location = new System.Drawing.Point(140, 266);
            this.hash.Multiline = true;
            this.hash.Name = "hash";
            this.hash.Size = new System.Drawing.Size(438, 24);
            this.hash.TabIndex = 70;
            // 
            // llavePriv
            // 
            this.llavePriv.Location = new System.Drawing.Point(140, 296);
            this.llavePriv.Multiline = true;
            this.llavePriv.Name = "llavePriv";
            this.llavePriv.Size = new System.Drawing.Size(438, 63);
            this.llavePriv.TabIndex = 71;
            // 
            // firmado
            // 
            this.firmado.Location = new System.Drawing.Point(19, 421);
            this.firmado.Multiline = true;
            this.firmado.Name = "firmado";
            this.firmado.Size = new System.Drawing.Size(1138, 63);
            this.firmado.TabIndex = 72;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(26)))), ((int)(((byte)(100)))));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(26)))), ((int)(((byte)(100)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(446, 365);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 30);
            this.button2.TabIndex = 73;
            this.button2.Text = "Firmar Datos";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(722, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 74;
            this.label2.Text = "Certificado:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(45, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 17);
            this.label3.TabIndex = 75;
            this.label3.Text = "Identificador:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(82, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 76;
            this.label4.Text = "Precio:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(89, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 77;
            this.label5.Text = "Hash:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(36, 319);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 17);
            this.label6.TabIndex = 78;
            this.label6.Text = "Llave Privada:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(26)))), ((int)(((byte)(100)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(26)))), ((int)(((byte)(100)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(1025, 490);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 30);
            this.button1.TabIndex = 79;
            this.button1.Text = "Crear Orden";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(26)))), ((int)(((byte)(100)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Location = new System.Drawing.Point(19, 490);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(132, 30);
            this.button3.TabIndex = 80;
            this.button3.Text = "Regresar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // comprador
            // 
            this.comprador.Location = new System.Drawing.Point(140, 150);
            this.comprador.Multiline = true;
            this.comprador.Name = "comprador";
            this.comprador.Size = new System.Drawing.Size(438, 50);
            this.comprador.TabIndex = 81;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(56, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 17);
            this.label7.TabIndex = 82;
            this.label7.Text = "Comprador:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(16, 401);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 17);
            this.label8.TabIndex = 83;
            this.label8.Text = "Datos Firmados:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(639, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 17);
            this.label9.TabIndex = 84;
            this.label9.Text = "Información:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(657, 80);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 17);
            this.label10.TabIndex = 86;
            this.label10.Text = "Entidad:";
            // 
            // entidad
            // 
            this.entidad.Location = new System.Drawing.Point(725, 79);
            this.entidad.Multiline = true;
            this.entidad.Name = "entidad";
            this.entidad.Size = new System.Drawing.Size(432, 23);
            this.entidad.TabIndex = 85;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(584, 109);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(140, 17);
            this.label11.TabIndex = 88;
            this.label11.Text = "Fecha de Expiración:";
            // 
            // exp
            // 
            this.exp.Location = new System.Drawing.Point(725, 108);
            this.exp.Multiline = true;
            this.exp.Name = "exp";
            this.exp.Size = new System.Drawing.Size(432, 23);
            this.exp.TabIndex = 87;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label12.Location = new System.Drawing.Point(677, 161);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 17);
            this.label12.TabIndex = 90;
            this.label12.Text = "Firma:";
            // 
            // firmacert
            // 
            this.firmacert.Location = new System.Drawing.Point(725, 138);
            this.firmacert.Multiline = true;
            this.firmacert.Name = "firmacert";
            this.firmacert.Size = new System.Drawing.Size(432, 62);
            this.firmacert.TabIndex = 89;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label13.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label13.Location = new System.Drawing.Point(614, 227);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(110, 17);
            this.label13.TabIndex = 92;
            this.label13.Text = "Llave vendedor:";
            // 
            // llavevend
            // 
            this.llavevend.Location = new System.Drawing.Point(725, 206);
            this.llavevend.Multiline = true;
            this.llavevend.Name = "llavevend";
            this.llavevend.Size = new System.Drawing.Size(432, 68);
            this.llavevend.TabIndex = 91;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label14.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label14.Location = new System.Drawing.Point(608, 310);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(116, 17);
            this.label14.TabIndex = 94;
            this.label14.Text = "Llave Regulador:";
            // 
            // llavereg
            // 
            this.llavereg.Location = new System.Drawing.Point(725, 280);
            this.llavereg.Multiline = true;
            this.llavereg.Name = "llavereg";
            this.llavereg.Size = new System.Drawing.Size(432, 79);
            this.llavereg.TabIndex = 93;
            // 
            // GenerarCompraVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(26)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(1188, 526);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.llavereg);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.llavevend);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.firmacert);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.exp);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.entidad);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comprador);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.firmado);
            this.Controls.Add(this.llavePriv);
            this.Controls.Add(this.hash);
            this.Controls.Add(this.precio);
            this.Controls.Add(this.identificador);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GenerarCompraVenta";
            this.Text = "GenerarCompraVenta";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox firmado;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        public System.Windows.Forms.TextBox nombre;
        public System.Windows.Forms.TextBox identificador;
        public System.Windows.Forms.TextBox precio;
        public System.Windows.Forms.TextBox hash;
        public System.Windows.Forms.TextBox llavePriv;
        public System.Windows.Forms.TextBox comprador;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox entidad;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox exp;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.TextBox firmacert;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.TextBox llavevend;
        private System.Windows.Forms.Label label14;
        public System.Windows.Forms.TextBox llavereg;
    }
}