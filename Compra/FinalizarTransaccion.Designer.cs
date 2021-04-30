
namespace Compra
{
    partial class FinalizarTransaccion
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
            this.precio = new System.Windows.Forms.TextBox();
            this.identificador = new System.Windows.Forms.TextBox();
            this.privada = new System.Windows.Forms.TextBox();
            this.comprador = new System.Windows.Forms.TextBox();
            this.vendedor = new System.Windows.Forms.TextBox();
            this.fecha = new System.Windows.Forms.DateTimePicker();
            this.firmados = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.estado = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // precio
            // 
            this.precio.Location = new System.Drawing.Point(204, 48);
            this.precio.Multiline = true;
            this.precio.Name = "precio";
            this.precio.ReadOnly = true;
            this.precio.Size = new System.Drawing.Size(571, 20);
            this.precio.TabIndex = 0;
            // 
            // identificador
            // 
            this.identificador.Location = new System.Drawing.Point(204, 22);
            this.identificador.Multiline = true;
            this.identificador.Name = "identificador";
            this.identificador.ReadOnly = true;
            this.identificador.Size = new System.Drawing.Size(571, 20);
            this.identificador.TabIndex = 1;
            // 
            // privada
            // 
            this.privada.Location = new System.Drawing.Point(204, 218);
            this.privada.Multiline = true;
            this.privada.Name = "privada";
            this.privada.Size = new System.Drawing.Size(571, 68);
            this.privada.TabIndex = 2;
            // 
            // comprador
            // 
            this.comprador.Location = new System.Drawing.Point(204, 100);
            this.comprador.Multiline = true;
            this.comprador.Name = "comprador";
            this.comprador.ReadOnly = true;
            this.comprador.Size = new System.Drawing.Size(571, 45);
            this.comprador.TabIndex = 3;
            // 
            // vendedor
            // 
            this.vendedor.Location = new System.Drawing.Point(204, 151);
            this.vendedor.Multiline = true;
            this.vendedor.Name = "vendedor";
            this.vendedor.ReadOnly = true;
            this.vendedor.Size = new System.Drawing.Size(571, 61);
            this.vendedor.TabIndex = 4;
            // 
            // fecha
            // 
            this.fecha.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.fecha.Location = new System.Drawing.Point(204, 74);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(571, 20);
            this.fecha.TabIndex = 5;
            // 
            // firmados
            // 
            this.firmados.Location = new System.Drawing.Point(29, 371);
            this.firmados.Multiline = true;
            this.firmados.Name = "firmados";
            this.firmados.Size = new System.Drawing.Size(746, 80);
            this.firmados.TabIndex = 6;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Red;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(26)))), ((int)(((byte)(100)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.button4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button4.Location = new System.Drawing.Point(29, 458);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(159, 30);
            this.button4.TabIndex = 113;
            this.button4.Text = "Regresar a Menú";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(26)))), ((int)(((byte)(100)))));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(26)))), ((int)(((byte)(100)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(593, 315);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(182, 30);
            this.button2.TabIndex = 114;
            this.button2.Text = "Firmar Datos";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(26)))), ((int)(((byte)(100)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(26)))), ((int)(((byte)(100)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(593, 458);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 30);
            this.button1.TabIndex = 115;
            this.button1.Text = "Notificar a Regulador";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(109, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 17);
            this.label5.TabIndex = 116;
            this.label5.Text = "Identificador:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(146, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 117;
            this.label1.Text = "Precio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(146, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 118;
            this.label2.Text = "Fecha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(116, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 119;
            this.label3.Text = "Comprador:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(124, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 17);
            this.label4.TabIndex = 120;
            this.label4.Text = "Vendedor:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(85, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 17);
            this.label6.TabIndex = 121;
            this.label6.Text = "Su llave privada:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(26, 351);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 17);
            this.label7.TabIndex = 122;
            this.label7.Text = "Datos firmados:";
            // 
            // estado
            // 
            this.estado.Location = new System.Drawing.Point(204, 292);
            this.estado.Multiline = true;
            this.estado.Name = "estado";
            this.estado.Size = new System.Drawing.Size(571, 20);
            this.estado.TabIndex = 123;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(26, 292);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(173, 17);
            this.label8.TabIndex = 124;
            this.label8.Text = "Estado de la Transacción:";
            // 
            // FinalizarTransaccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(26)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(800, 499);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.estado);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.firmados);
            this.Controls.Add(this.fecha);
            this.Controls.Add(this.vendedor);
            this.Controls.Add(this.comprador);
            this.Controls.Add(this.privada);
            this.Controls.Add(this.identificador);
            this.Controls.Add(this.precio);
            this.Name = "FinalizarTransaccion";
            this.Text = "FinalizarTransaccion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox privada;
        private System.Windows.Forms.TextBox firmados;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox precio;
        public System.Windows.Forms.TextBox identificador;
        public System.Windows.Forms.TextBox comprador;
        public System.Windows.Forms.TextBox vendedor;
        public System.Windows.Forms.DateTimePicker fecha;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox estado;
        private System.Windows.Forms.Label label8;
    }
}