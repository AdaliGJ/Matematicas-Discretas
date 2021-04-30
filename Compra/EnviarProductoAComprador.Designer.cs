
namespace Compra
{
    partial class EnviarProductoAComprador
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
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label7;
            this.enviar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.comprador = new System.Windows.Forms.TextBox();
            this.vendedor = new System.Windows.Forms.TextBox();
            this.hash = new System.Windows.Forms.TextBox();
            this.identificador = new System.Windows.Forms.TextBox();
            this.pathp = new System.Windows.Forms.TextBox();
            this.encriptado = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.precio = new System.Windows.Forms.TextBox();
            nombre_EntidadLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nombre_EntidadLabel
            // 
            nombre_EntidadLabel.AutoSize = true;
            nombre_EntidadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            nombre_EntidadLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            nombre_EntidadLabel.Location = new System.Drawing.Point(36, 97);
            nombre_EntidadLabel.Name = "nombre_EntidadLabel";
            nombre_EntidadLabel.Size = new System.Drawing.Size(159, 17);
            nombre_EntidadLabel.TabIndex = 104;
            nombre_EntidadLabel.Text = "Llave pública vendedor:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            label1.Location = new System.Drawing.Point(28, 39);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(167, 17);
            label1.TabIndex = 105;
            label1.Text = "Llave pública comprador:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            label2.Location = new System.Drawing.Point(28, 145);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(166, 17);
            label2.TabIndex = 106;
            label2.Text = "Identificador transacción:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            label3.Location = new System.Drawing.Point(65, 180);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(129, 17);
            label3.TabIndex = 107;
            label3.Text = "Hash del Producto:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            label4.Location = new System.Drawing.Point(92, 210);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(102, 17);
            label4.TabIndex = 108;
            label4.Text = "Path Producto:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            label5.ForeColor = System.Drawing.Color.Yellow;
            label5.Location = new System.Drawing.Point(210, 270);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(403, 17);
            label5.TabIndex = 109;
            label5.Text = "Por Seguridad se encriptará el path con la llave del comprador";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            label6.Location = new System.Drawing.Point(19, 305);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(197, 17);
            label6.TabIndex = 110;
            label6.Text = "Path Encriptado del Producto:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            label7.Location = new System.Drawing.Point(82, 240);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(113, 17);
            label7.TabIndex = 113;
            label7.Text = "Precio Producto:";
            // 
            // enviar
            // 
            this.enviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(26)))), ((int)(((byte)(100)))));
            this.enviar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(26)))), ((int)(((byte)(100)))));
            this.enviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.enviar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.enviar.Location = new System.Drawing.Point(619, 263);
            this.enviar.Name = "enviar";
            this.enviar.Size = new System.Drawing.Size(159, 30);
            this.enviar.TabIndex = 96;
            this.enviar.Text = "Encriptar Path";
            this.enviar.UseVisualStyleBackColor = false;
            this.enviar.Click += new System.EventHandler(this.verificar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(26)))), ((int)(((byte)(100)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(26)))), ((int)(((byte)(100)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(530, 408);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(248, 30);
            this.button1.TabIndex = 97;
            this.button1.Text = "Enviar producto a comprador";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comprador
            // 
            this.comprador.Location = new System.Drawing.Point(200, 16);
            this.comprador.Multiline = true;
            this.comprador.Name = "comprador";
            this.comprador.Size = new System.Drawing.Size(578, 57);
            this.comprador.TabIndex = 98;
            // 
            // vendedor
            // 
            this.vendedor.Location = new System.Drawing.Point(200, 79);
            this.vendedor.Multiline = true;
            this.vendedor.Name = "vendedor";
            this.vendedor.Size = new System.Drawing.Size(578, 59);
            this.vendedor.TabIndex = 99;
            // 
            // hash
            // 
            this.hash.Location = new System.Drawing.Point(200, 173);
            this.hash.Multiline = true;
            this.hash.Name = "hash";
            this.hash.Size = new System.Drawing.Size(578, 24);
            this.hash.TabIndex = 100;
            // 
            // identificador
            // 
            this.identificador.Location = new System.Drawing.Point(200, 144);
            this.identificador.Multiline = true;
            this.identificador.Name = "identificador";
            this.identificador.Size = new System.Drawing.Size(578, 23);
            this.identificador.TabIndex = 101;
            // 
            // pathp
            // 
            this.pathp.Location = new System.Drawing.Point(200, 203);
            this.pathp.Multiline = true;
            this.pathp.Name = "pathp";
            this.pathp.Size = new System.Drawing.Size(578, 24);
            this.pathp.TabIndex = 102;
            // 
            // encriptado
            // 
            this.encriptado.Location = new System.Drawing.Point(22, 325);
            this.encriptado.Multiline = true;
            this.encriptado.Name = "encriptado";
            this.encriptado.Size = new System.Drawing.Size(756, 77);
            this.encriptado.TabIndex = 103;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(26)))), ((int)(((byte)(100)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(22, 408);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(159, 30);
            this.button2.TabIndex = 111;
            this.button2.Text = "Regresar a Menú";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // precio
            // 
            this.precio.Location = new System.Drawing.Point(200, 233);
            this.precio.Multiline = true;
            this.precio.Name = "precio";
            this.precio.Size = new System.Drawing.Size(578, 24);
            this.precio.TabIndex = 112;
            // 
            // EnviarProductoAComprador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(26)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(label7);
            this.Controls.Add(this.precio);
            this.Controls.Add(this.button2);
            this.Controls.Add(label6);
            this.Controls.Add(label5);
            this.Controls.Add(label4);
            this.Controls.Add(label3);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Controls.Add(nombre_EntidadLabel);
            this.Controls.Add(this.encriptado);
            this.Controls.Add(this.pathp);
            this.Controls.Add(this.identificador);
            this.Controls.Add(this.hash);
            this.Controls.Add(this.vendedor);
            this.Controls.Add(this.comprador);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.enviar);
            this.Name = "EnviarProductoAComprador";
            this.Text = "EnviarProductoAComprador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button enviar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox encriptado;
        public System.Windows.Forms.TextBox identificador;
        public System.Windows.Forms.TextBox pathp;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.TextBox comprador;
        public System.Windows.Forms.TextBox vendedor;
        public System.Windows.Forms.TextBox hash;
        public System.Windows.Forms.TextBox precio;
    }
}