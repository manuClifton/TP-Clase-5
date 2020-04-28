namespace Pizzeria_GUI
{
    partial class FormUsuario
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
            this.lbl_PassActual = new System.Windows.Forms.Label();
            this.lbl_NuevaPass = new System.Windows.Forms.Label();
            this.lbl_ConfirmarPass = new System.Windows.Forms.Label();
            this.lbl_NombreUsuario = new System.Windows.Forms.Label();
            this.txtPassActual = new System.Windows.Forms.TextBox();
            this.txtNuevaPass = new System.Windows.Forms.TextBox();
            this.txtConfirmPass = new System.Windows.Forms.TextBox();
            this.btnCancelarUsuario = new System.Windows.Forms.Button();
            this.btnEditarUsuario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_PassActual
            // 
            this.lbl_PassActual.AutoSize = true;
            this.lbl_PassActual.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lbl_PassActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PassActual.Location = new System.Drawing.Point(19, 86);
            this.lbl_PassActual.Name = "lbl_PassActual";
            this.lbl_PassActual.Size = new System.Drawing.Size(111, 13);
            this.lbl_PassActual.TabIndex = 0;
            this.lbl_PassActual.Text = "Contraseña Actual";
            // 
            // lbl_NuevaPass
            // 
            this.lbl_NuevaPass.AutoSize = true;
            this.lbl_NuevaPass.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lbl_NuevaPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NuevaPass.Location = new System.Drawing.Point(19, 131);
            this.lbl_NuevaPass.Name = "lbl_NuevaPass";
            this.lbl_NuevaPass.Size = new System.Drawing.Size(112, 13);
            this.lbl_NuevaPass.TabIndex = 1;
            this.lbl_NuevaPass.Text = "Nueva Contraseña";
            // 
            // lbl_ConfirmarPass
            // 
            this.lbl_ConfirmarPass.AutoSize = true;
            this.lbl_ConfirmarPass.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lbl_ConfirmarPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ConfirmarPass.Location = new System.Drawing.Point(66, 184);
            this.lbl_ConfirmarPass.Name = "lbl_ConfirmarPass";
            this.lbl_ConfirmarPass.Size = new System.Drawing.Size(64, 13);
            this.lbl_ConfirmarPass.TabIndex = 2;
            this.lbl_ConfirmarPass.Text = "Confirmar ";
            // 
            // lbl_NombreUsuario
            // 
            this.lbl_NombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NombreUsuario.Location = new System.Drawing.Point(97, 22);
            this.lbl_NombreUsuario.Name = "lbl_NombreUsuario";
            this.lbl_NombreUsuario.Size = new System.Drawing.Size(267, 23);
            this.lbl_NombreUsuario.TabIndex = 3;
            this.lbl_NombreUsuario.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtPassActual
            // 
            this.txtPassActual.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtPassActual.Location = new System.Drawing.Point(162, 83);
            this.txtPassActual.Name = "txtPassActual";
            this.txtPassActual.Size = new System.Drawing.Size(193, 20);
            this.txtPassActual.TabIndex = 4;
            this.txtPassActual.UseSystemPasswordChar = true;
            // 
            // txtNuevaPass
            // 
            this.txtNuevaPass.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtNuevaPass.Location = new System.Drawing.Point(162, 128);
            this.txtNuevaPass.Name = "txtNuevaPass";
            this.txtNuevaPass.Size = new System.Drawing.Size(193, 20);
            this.txtNuevaPass.TabIndex = 5;
            // 
            // txtConfirmPass
            // 
            this.txtConfirmPass.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtConfirmPass.Location = new System.Drawing.Point(162, 181);
            this.txtConfirmPass.Name = "txtConfirmPass";
            this.txtConfirmPass.Size = new System.Drawing.Size(193, 20);
            this.txtConfirmPass.TabIndex = 6;
            // 
            // btnCancelarUsuario
            // 
            this.btnCancelarUsuario.BackColor = System.Drawing.Color.Silver;
            this.btnCancelarUsuario.Location = new System.Drawing.Point(51, 242);
            this.btnCancelarUsuario.Name = "btnCancelarUsuario";
            this.btnCancelarUsuario.Size = new System.Drawing.Size(118, 38);
            this.btnCancelarUsuario.TabIndex = 7;
            this.btnCancelarUsuario.Text = "Cancelar";
            this.btnCancelarUsuario.UseVisualStyleBackColor = false;
            this.btnCancelarUsuario.Click += new System.EventHandler(this.btnCancelarUsuario_Click);
            // 
            // btnEditarUsuario
            // 
            this.btnEditarUsuario.BackColor = System.Drawing.Color.Silver;
            this.btnEditarUsuario.Location = new System.Drawing.Point(243, 240);
            this.btnEditarUsuario.Name = "btnEditarUsuario";
            this.btnEditarUsuario.Size = new System.Drawing.Size(181, 42);
            this.btnEditarUsuario.TabIndex = 8;
            this.btnEditarUsuario.Text = "Editar";
            this.btnEditarUsuario.UseVisualStyleBackColor = false;
            this.btnEditarUsuario.Click += new System.EventHandler(this.btnEditarUsuario_Click);
            // 
            // FormUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(463, 309);
            this.Controls.Add(this.btnEditarUsuario);
            this.Controls.Add(this.btnCancelarUsuario);
            this.Controls.Add(this.txtConfirmPass);
            this.Controls.Add(this.txtNuevaPass);
            this.Controls.Add(this.txtPassActual);
            this.Controls.Add(this.lbl_NombreUsuario);
            this.Controls.Add(this.lbl_ConfirmarPass);
            this.Controls.Add(this.lbl_NuevaPass);
            this.Controls.Add(this.lbl_PassActual);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormUsuario";
            this.Text = "Editar Usuario";
            this.Load += new System.EventHandler(this.FormUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_PassActual;
        private System.Windows.Forms.Label lbl_NuevaPass;
        private System.Windows.Forms.Label lbl_ConfirmarPass;
        private System.Windows.Forms.TextBox txtPassActual;
        private System.Windows.Forms.TextBox txtNuevaPass;
        private System.Windows.Forms.TextBox txtConfirmPass;
        private System.Windows.Forms.Button btnCancelarUsuario;
        private System.Windows.Forms.Button btnEditarUsuario;
        private System.Windows.Forms.Label lbl_NombreUsuario;
    }
}