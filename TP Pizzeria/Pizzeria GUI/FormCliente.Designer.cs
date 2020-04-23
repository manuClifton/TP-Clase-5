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
            this.txtNombreAlta = new System.Windows.Forms.TextBox();
            this.btnCrearUsuario = new System.Windows.Forms.Button();
            this.txtApellidoAlta = new System.Windows.Forms.TextBox();
            this.txtDomicilioAlta = new System.Windows.Forms.TextBox();
            this.lblAltaNombre = new System.Windows.Forms.Label();
            this.lblAltaApellido = new System.Windows.Forms.Label();
            this.lblAltaDireccion = new System.Windows.Forms.Label();
            this.btnCancelarAlta = new System.Windows.Forms.Button();
            this.lblDatos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNombreAlta
            // 
            this.txtNombreAlta.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtNombreAlta.Location = new System.Drawing.Point(126, 45);
            this.txtNombreAlta.Name = "txtNombreAlta";
            this.txtNombreAlta.Size = new System.Drawing.Size(147, 20);
            this.txtNombreAlta.TabIndex = 2;
            // 
            // btnCrearUsuario
            // 
            this.btnCrearUsuario.BackColor = System.Drawing.Color.Silver;
            this.btnCrearUsuario.Location = new System.Drawing.Point(176, 208);
            this.btnCrearUsuario.Name = "btnCrearUsuario";
            this.btnCrearUsuario.Size = new System.Drawing.Size(193, 34);
            this.btnCrearUsuario.TabIndex = 7;
            this.btnCrearUsuario.Text = "Crear Usuario";
            this.btnCrearUsuario.UseVisualStyleBackColor = false;
            this.btnCrearUsuario.Click += new System.EventHandler(this.btnCrearUsuario_Click);
            // 
            // txtApellidoAlta
            // 
            this.txtApellidoAlta.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtApellidoAlta.Location = new System.Drawing.Point(126, 97);
            this.txtApellidoAlta.Name = "txtApellidoAlta";
            this.txtApellidoAlta.Size = new System.Drawing.Size(147, 20);
            this.txtApellidoAlta.TabIndex = 4;
            // 
            // txtDomicilioAlta
            // 
            this.txtDomicilioAlta.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtDomicilioAlta.Location = new System.Drawing.Point(126, 145);
            this.txtDomicilioAlta.Name = "txtDomicilioAlta";
            this.txtDomicilioAlta.Size = new System.Drawing.Size(147, 20);
            this.txtDomicilioAlta.TabIndex = 6;
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
            // btnCancelarAlta
            // 
            this.btnCancelarAlta.BackColor = System.Drawing.Color.Silver;
            this.btnCancelarAlta.Location = new System.Drawing.Point(34, 208);
            this.btnCancelarAlta.Name = "btnCancelarAlta";
            this.btnCancelarAlta.Size = new System.Drawing.Size(107, 34);
            this.btnCancelarAlta.TabIndex = 8;
            this.btnCancelarAlta.Text = "Cancelar";
            this.btnCancelarAlta.UseVisualStyleBackColor = false;
            this.btnCancelarAlta.Click += new System.EventHandler(this.btnCancelarAlta_Click);
            // 
            // lblDatos
            // 
            this.lblDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatos.Location = new System.Drawing.Point(78, 9);
            this.lblDatos.Name = "lblDatos";
            this.lblDatos.Size = new System.Drawing.Size(227, 18);
            this.lblDatos.TabIndex = 0;
            this.lblDatos.Text = "Ingrese Datos del Cliente";
            this.lblDatos.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FormCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(381, 283);
            this.Controls.Add(this.lblDatos);
            this.Controls.Add(this.btnCancelarAlta);
            this.Controls.Add(this.lblAltaDireccion);
            this.Controls.Add(this.lblAltaApellido);
            this.Controls.Add(this.lblAltaNombre);
            this.Controls.Add(this.txtDomicilioAlta);
            this.Controls.Add(this.txtApellidoAlta);
            this.Controls.Add(this.btnCrearUsuario);
            this.Controls.Add(this.txtNombreAlta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta Cliente";
            this.Load += new System.EventHandler(this.FormCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombreAlta;
        private System.Windows.Forms.Button btnCrearUsuario;
        private System.Windows.Forms.TextBox txtApellidoAlta;
        private System.Windows.Forms.TextBox txtDomicilioAlta;
        private System.Windows.Forms.Label lblAltaNombre;
        private System.Windows.Forms.Label lblAltaApellido;
        private System.Windows.Forms.Label lblAltaDireccion;
        private System.Windows.Forms.Button btnCancelarAlta;
        private System.Windows.Forms.Label lblDatos;
    }
}