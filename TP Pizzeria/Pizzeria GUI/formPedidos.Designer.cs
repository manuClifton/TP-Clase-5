namespace Pizzeria_GUI
{
    partial class FormPedidos
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
            this.lb_Gusto = new System.Windows.Forms.Label();
            this.cmbGusto = new System.Windows.Forms.ComboBox();
            this.lblCoccion = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.numCantidad = new System.Windows.Forms.NumericUpDown();
            this.listPizzas = new System.Windows.Forms.ListBox();
            this.btnAgregarPizza = new System.Windows.Forms.Button();
            this.btnFinalizarPedido = new System.Windows.Forms.Button();
            this.lblPedidoError = new System.Windows.Forms.Label();
            this.cmbCoccion = new System.Windows.Forms.ComboBox();
            this.checkEnvio = new System.Windows.Forms.CheckBox();
            this.btnCancelarPedido = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_Gusto
            // 
            this.lb_Gusto.AutoSize = true;
            this.lb_Gusto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Gusto.Location = new System.Drawing.Point(72, 234);
            this.lb_Gusto.Name = "lb_Gusto";
            this.lb_Gusto.Size = new System.Drawing.Size(92, 13);
            this.lb_Gusto.TabIndex = 4;
            this.lb_Gusto.Text = "Gusto de Pizza";
            // 
            // cmbGusto
            // 
            this.cmbGusto.BackColor = System.Drawing.Color.AliceBlue;
            this.cmbGusto.FormattingEnabled = true;
            this.cmbGusto.Items.AddRange(new object[] {
            "Muzzarella",
            "Fugazzeta",
            "Especial",
            "Anana(Un Boludo)",
            "Calabreza",
            "De la Casa"});
            this.cmbGusto.Location = new System.Drawing.Point(43, 266);
            this.cmbGusto.Name = "cmbGusto";
            this.cmbGusto.Size = new System.Drawing.Size(138, 21);
            this.cmbGusto.TabIndex = 5;
            // 
            // lblCoccion
            // 
            this.lblCoccion.AutoSize = true;
            this.lblCoccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoccion.Location = new System.Drawing.Point(360, 234);
            this.lblCoccion.Name = "lblCoccion";
            this.lblCoccion.Size = new System.Drawing.Size(53, 13);
            this.lblCoccion.TabIndex = 6;
            this.lblCoccion.Text = "Coccion";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(227, 234);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(57, 13);
            this.lblCantidad.TabIndex = 7;
            this.lblCantidad.Text = "Cantidad";
            // 
            // numCantidad
            // 
            this.numCantidad.BackColor = System.Drawing.Color.AliceBlue;
            this.numCantidad.Location = new System.Drawing.Point(217, 267);
            this.numCantidad.Name = "numCantidad";
            this.numCantidad.Size = new System.Drawing.Size(81, 20);
            this.numCantidad.TabIndex = 12;
            // 
            // listPizzas
            // 
            this.listPizzas.BackColor = System.Drawing.SystemColors.Info;
            this.listPizzas.FormattingEnabled = true;
            this.listPizzas.Location = new System.Drawing.Point(21, 12);
            this.listPizzas.Name = "listPizzas";
            this.listPizzas.Size = new System.Drawing.Size(530, 186);
            this.listPizzas.TabIndex = 15;
            // 
            // btnAgregarPizza
            // 
            this.btnAgregarPizza.BackColor = System.Drawing.Color.DarkGreen;
            this.btnAgregarPizza.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarPizza.Location = new System.Drawing.Point(589, 230);
            this.btnAgregarPizza.Name = "btnAgregarPizza";
            this.btnAgregarPizza.Size = new System.Drawing.Size(91, 53);
            this.btnAgregarPizza.TabIndex = 16;
            this.btnAgregarPizza.Text = "Agregar Pizza";
            this.btnAgregarPizza.UseVisualStyleBackColor = false;
            this.btnAgregarPizza.Click += new System.EventHandler(this.btnAgregarPizza_Click);
            // 
            // btnFinalizarPedido
            // 
            this.btnFinalizarPedido.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnFinalizarPedido.Location = new System.Drawing.Point(570, 12);
            this.btnFinalizarPedido.Name = "btnFinalizarPedido";
            this.btnFinalizarPedido.Size = new System.Drawing.Size(110, 48);
            this.btnFinalizarPedido.TabIndex = 17;
            this.btnFinalizarPedido.Text = "Finalizar Pedido";
            this.btnFinalizarPedido.UseVisualStyleBackColor = false;
            this.btnFinalizarPedido.Click += new System.EventHandler(this.btnFinalizarPedido_Click);
            // 
            // lblPedidoError
            // 
            this.lblPedidoError.AutoSize = true;
            this.lblPedidoError.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblPedidoError.ForeColor = System.Drawing.Color.Maroon;
            this.lblPedidoError.Location = new System.Drawing.Point(310, 151);
            this.lblPedidoError.Name = "lblPedidoError";
            this.lblPedidoError.Size = new System.Drawing.Size(0, 13);
            this.lblPedidoError.TabIndex = 19;
            this.lblPedidoError.Visible = false;
            // 
            // cmbCoccion
            // 
            this.cmbCoccion.FormattingEnabled = true;
            this.cmbCoccion.Items.AddRange(new object[] {
            "A la Piedra",
            "Media Maza"});
            this.cmbCoccion.Location = new System.Drawing.Point(337, 267);
            this.cmbCoccion.Name = "cmbCoccion";
            this.cmbCoccion.Size = new System.Drawing.Size(114, 21);
            this.cmbCoccion.TabIndex = 20;
            // 
            // checkEnvio
            // 
            this.checkEnvio.AutoSize = true;
            this.checkEnvio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkEnvio.Location = new System.Drawing.Point(466, 249);
            this.checkEnvio.Name = "checkEnvio";
            this.checkEnvio.Size = new System.Drawing.Size(98, 17);
            this.checkEnvio.TabIndex = 21;
            this.checkEnvio.Text = "A  domicilio?";
            this.checkEnvio.UseVisualStyleBackColor = true;
            // 
            // btnCancelarPedido
            // 
            this.btnCancelarPedido.Location = new System.Drawing.Point(582, 93);
            this.btnCancelarPedido.Name = "btnCancelarPedido";
            this.btnCancelarPedido.Size = new System.Drawing.Size(80, 44);
            this.btnCancelarPedido.TabIndex = 22;
            this.btnCancelarPedido.Text = "Cancelar Pedido";
            this.btnCancelarPedido.UseVisualStyleBackColor = true;
            // 
            // FormPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(709, 322);
            this.Controls.Add(this.btnCancelarPedido);
            this.Controls.Add(this.checkEnvio);
            this.Controls.Add(this.cmbCoccion);
            this.Controls.Add(this.lblPedidoError);
            this.Controls.Add(this.btnFinalizarPedido);
            this.Controls.Add(this.btnAgregarPizza);
            this.Controls.Add(this.listPizzas);
            this.Controls.Add(this.numCantidad);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblCoccion);
            this.Controls.Add(this.cmbGusto);
            this.Controls.Add(this.lb_Gusto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormPedidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Pedido";
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lb_Gusto;
        private System.Windows.Forms.ComboBox cmbGusto;
        private System.Windows.Forms.Label lblCoccion;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.NumericUpDown numCantidad;
        private System.Windows.Forms.ListBox listPizzas;
        private System.Windows.Forms.Button btnAgregarPizza;
        private System.Windows.Forms.Button btnFinalizarPedido;
        private System.Windows.Forms.Label lblPedidoError;
        private System.Windows.Forms.ComboBox cmbCoccion;
        private System.Windows.Forms.CheckBox checkEnvio;
        private System.Windows.Forms.Button btnCancelarPedido;
    }
}