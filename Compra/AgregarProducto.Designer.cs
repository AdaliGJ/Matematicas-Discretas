
namespace Compra
{
    partial class AgregarProducto
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.hash = new System.Windows.Forms.TextBox();
            this.descripcionProducto = new System.Windows.Forms.TextBox();
            this.nombreProducto = new System.Windows.Forms.TextBox();
            this.precio = new System.Windows.Forms.TextBox();
            this.path = new System.Windows.Forms.TextBox();
            this.llave = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.firma = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.publica = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(47, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Path del producto:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(25, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nombre del Prodcuto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(119, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Precio:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(85, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Descripción:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(46, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Hash Criptográfico";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(26)))), ((int)(((byte)(100)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(26)))), ((int)(((byte)(100)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(594, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 30);
            this.button1.TabIndex = 29;
            this.button1.Text = "Calcular Hash";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(73, 285);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 17);
            this.label6.TabIndex = 31;
            this.label6.Text = "Llave Privada:";
            // 
            // hash
            // 
            this.hash.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.hash.Location = new System.Drawing.Point(172, 217);
            this.hash.Multiline = true;
            this.hash.Name = "hash";
            this.hash.Size = new System.Drawing.Size(585, 40);
            this.hash.TabIndex = 40;
            // 
            // descripcionProducto
            // 
            this.descripcionProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.descripcionProducto.Location = new System.Drawing.Point(172, 131);
            this.descripcionProducto.Multiline = true;
            this.descripcionProducto.Name = "descripcionProducto";
            this.descripcionProducto.Size = new System.Drawing.Size(585, 44);
            this.descripcionProducto.TabIndex = 39;
            // 
            // nombreProducto
            // 
            this.nombreProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nombreProducto.Location = new System.Drawing.Point(172, 44);
            this.nombreProducto.Name = "nombreProducto";
            this.nombreProducto.Size = new System.Drawing.Size(585, 23);
            this.nombreProducto.TabIndex = 36;
            // 
            // precio
            // 
            this.precio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.precio.Location = new System.Drawing.Point(172, 73);
            this.precio.Multiline = true;
            this.precio.Name = "precio";
            this.precio.Size = new System.Drawing.Size(585, 23);
            this.precio.TabIndex = 37;
            // 
            // path
            // 
            this.path.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.path.Location = new System.Drawing.Point(172, 102);
            this.path.Multiline = true;
            this.path.Name = "path";
            this.path.Size = new System.Drawing.Size(585, 23);
            this.path.TabIndex = 41;
            // 
            // llave
            // 
            this.llave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.llave.Location = new System.Drawing.Point(172, 263);
            this.llave.Multiline = true;
            this.llave.Name = "llave";
            this.llave.Size = new System.Drawing.Size(585, 61);
            this.llave.TabIndex = 42;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(26)))), ((int)(((byte)(100)))));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(26)))), ((int)(((byte)(100)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(594, 397);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(163, 30);
            this.button2.TabIndex = 43;
            this.button2.Text = "Firmar Datos";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // firma
            // 
            this.firma.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.firma.Location = new System.Drawing.Point(12, 446);
            this.firma.Multiline = true;
            this.firma.Name = "firma";
            this.firma.Size = new System.Drawing.Size(745, 61);
            this.firma.TabIndex = 44;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(12, 426);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 17);
            this.label7.TabIndex = 45;
            this.label7.Text = "Datos firmados";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(26)))), ((int)(((byte)(100)))));
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(26)))), ((int)(((byte)(100)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Location = new System.Drawing.Point(594, 526);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(163, 30);
            this.button3.TabIndex = 46;
            this.button3.Text = "Enviar Solicitud";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Red;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(26)))), ((int)(((byte)(100)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.button4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button4.Location = new System.Drawing.Point(8, 526);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(163, 30);
            this.button4.TabIndex = 47;
            this.button4.Text = "Regresar";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // publica
            // 
            this.publica.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.publica.Location = new System.Drawing.Point(172, 330);
            this.publica.Multiline = true;
            this.publica.Name = "publica";
            this.publica.Size = new System.Drawing.Size(585, 61);
            this.publica.TabIndex = 48;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(75, 345);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 17);
            this.label8.TabIndex = 49;
            this.label8.Text = "Llave Pública:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(102, 237);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 17);
            this.label9.TabIndex = 50;
            this.label9.Text = "Producto:";
            // 
            // AgregarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(24)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(800, 568);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.publica);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.firma);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.llave);
            this.Controls.Add(this.path);
            this.Controls.Add(this.hash);
            this.Controls.Add(this.descripcionProducto);
            this.Controls.Add(this.nombreProducto);
            this.Controls.Add(this.precio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AgregarProducto";
            this.Text = "AgregarProducto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox hash;
        public System.Windows.Forms.TextBox descripcionProducto;
        private System.Windows.Forms.TextBox nombreProducto;
        public System.Windows.Forms.TextBox precio;
        public System.Windows.Forms.TextBox path;
        public System.Windows.Forms.TextBox llave;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.TextBox firma;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        public System.Windows.Forms.TextBox publica;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}