namespace Pizzeria_GUI
{
    partial class FormCliente
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblAltaNombre = new System.Windows.Forms.Label();
            this.lblAltaApellido = new System.Windows.Forms.Label();
            this.lblAltaDireccion = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBox1.Location = new System.Drawing.Point(126, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(147, 20);
            this.textBox1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.Location = new System.Drawing.Point(176, 208);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 34);
            this.button1.TabIndex = 7;
            this.button1.Text = "Crear Usuario";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBox2.Location = new System.Drawing.Point(126, 97);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(147, 20);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBox3.Location = new System.Drawing.Point(126, 145);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(147, 20);
            this.textBox3.TabIndex = 6;
            // 
            // lblAltaNombre
            // 
            this.lblAltaNombre.AutoSize = true;
            this.lblAltaNombre.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblAltaNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltaNombre.Location = new System.Drawing.Point(54, 48);
            this.lblAltaNombre.Name = "lblAltaNombre";
            this.lblAltaNombre.Size = new System.Drawing.Size(50, 13);
            this.lblAltaNombre.TabIndex = 1;
            this.lblAltaNombre.Text = "Nombre";
            // 
            // lblAltaApellido
            // 
            this.lblAltaApellido.AutoSize = true;
            this.lblAltaApellido.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblAltaApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltaApellido.Location = new System.Drawing.Point(54, 100);
            this.lblAltaApellido.Name = "lblAltaApellido";
            this.lblAltaApellido.Size = new System.Drawing.Size(52, 13);
            this.lblAltaApellido.TabIndex = 3;
            this.lblAltaApellido.Text = "Apellido";
            // 
            // lblAltaDireccion
            // 
            this.lblAltaDireccion.AutoSize = true;
            this.lblAltaDireccion.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblAltaDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltaDireccion.Location = new System.Drawing.Point(54, 148);
            this.lblAltaDireccion.Name = "lblAltaDireccion";
            this.lblAltaDireccion.Size = new System.Drawing.Size(61, 13);
            this.lblAltaDireccion.TabIndex = 5;
            this.lblAltaDireccion.Text = "Direccion";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Silver;
            this.button2.Location = new System.Drawing.Point(34, 208);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 34);
            this.button2.TabIndex = 8;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // Nuevo_Pedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(381, 283);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblAltaDireccion);
            this.Controls.Add(this.lblAltaApellido);
            this.Controls.Add(this.lblAltaNombre);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Nuevo_Pedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblAltaNombre;
        private System.Windows.Forms.Label lblAltaApellido;
        private System.Windows.Forms.Label lblAltaDireccion;
        private System.Windows.Forms.Button button2;
    }
}