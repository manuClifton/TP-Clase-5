namespace Pizzeria_GUI
{
    partial class FormLogin
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
            this.btnIniciarSesion = new System.Windows.Forms.Button();
            this.lblInicioUsuario = new System.Windows.Forms.Label();
            this.lblInicioConstraseña = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.textContraseña = new System.Windows.Forms.TextBox();
            this.lblError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIniciarSesion.BackColor = System.Drawing.Color.PaleGreen;
            this.btnIniciarSesion.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btnIniciarSesion.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarSesion.Location = new System.Drawing.Point(177, 193);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(150, 62);
            this.btnIniciarSesion.TabIndex = 5;
            this.btnIniciarSesion.Text = "Iniciar Sesion";
            this.btnIniciarSesion.UseVisualStyleBackColor = false;
            this.btnIniciarSesion.Click += new System.EventHandler(this.btnIniciarSesion_Click);
            // 
            // lblInicioUsuario
            // 
            this.lblInicioUsuario.AutoSize = true;
            this.lblInicioUsuario.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblInicioUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInicioUsuario.Location = new System.Drawing.Point(71, 77);
            this.lblInicioUsuario.Name = "lblInicioUsuario";
            this.lblInicioUsuario.Size = new System.Drawing.Size(50, 13);
            this.lblInicioUsuario.TabIndex = 1;
            this.lblInicioUsuario.Text = "Usuario";
            // 
            // lblInicioConstraseña
            // 
            this.lblInicioConstraseña.AutoSize = true;
            this.lblInicioConstraseña.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblInicioConstraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInicioConstraseña.Location = new System.Drawing.Point(71, 137);
            this.lblInicioConstraseña.Name = "lblInicioConstraseña";
            this.lblInicioConstraseña.Size = new System.Drawing.Size(71, 13);
            this.lblInicioConstraseña.TabIndex = 3;
            this.lblInicioConstraseña.Text = "Contraseña";
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.SystemColors.Menu;
            this.txtUsuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsuario.Location = new System.Drawing.Point(162, 77);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(180, 20);
            this.txtUsuario.TabIndex = 2;
            // 
            // textContraseña
            // 
            this.textContraseña.BackColor = System.Drawing.SystemColors.Menu;
            this.textContraseña.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textContraseña.Location = new System.Drawing.Point(162, 137);
            this.textContraseña.Name = "textContraseña";
            this.textContraseña.Size = new System.Drawing.Size(180, 20);
            this.textContraseña.TabIndex = 4;
            this.textContraseña.UseSystemPasswordChar = true;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblError.ForeColor = System.Drawing.Color.Maroon;
            this.lblError.Location = new System.Drawing.Point(94, 283);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 13);
            this.lblError.TabIndex = 8;
            this.lblError.Visible = false;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(518, 308);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.textContraseña);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblInicioConstraseña);
            this.Controls.Add(this.lblInicioUsuario);
            this.Controls.Add(this.btnIniciarSesion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio Sesion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIniciarSesion;
        private System.Windows.Forms.Label lblInicioUsuario;
        private System.Windows.Forms.Label lblInicioConstraseña;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox textContraseña;
        private System.Windows.Forms.Label lblError;
    }
}