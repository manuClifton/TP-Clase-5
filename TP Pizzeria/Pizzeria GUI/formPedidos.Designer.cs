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
            this.btnNuevoCliente = new System.Windows.Forms.Button();
            this.lblTipoDePizza = new System.Windows.Forms.Label();
            this.comboBoxTipoPizza = new System.Windows.Forms.ComboBox();
            this.lblCoccion = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.checkedListBoxCoccion = new System.Windows.Forms.CheckedListBox();
            this.lblEnvio = new System.Windows.Forms.Label();
            this.numericUpDownCantidad = new System.Windows.Forms.NumericUpDown();
            this.listBoxPedidos = new System.Windows.Forms.ListBox();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnFinalizarPedido = new System.Windows.Forms.Button();
            this.checkSiNo = new System.Windows.Forms.CheckedListBox();
            this.lblPedidoError = new System.Windows.Forms.Label();
            this.lblPedido_Nombre = new System.Windows.Forms.Label();
            this.lblPedido_Apellido = new System.Windows.Forms.Label();
            this.lblPedido_Domicilio = new System.Windows.Forms.Label();
            this.textPedido_Nombre = new System.Windows.Forms.TextBox();
            this.textPedido_Apellido = new System.Windows.Forms.TextBox();
            this.textPedido_Domicilio = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNuevoCliente
            // 
            this.btnNuevoCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNuevoCliente.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnNuevoCliente.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnNuevoCliente.Location = new System.Drawing.Point(549, 14);
            this.btnNuevoCliente.Name = "btnNuevoCliente";
            this.btnNuevoCliente.Size = new System.Drawing.Size(176, 47);
            this.btnNuevoCliente.TabIndex = 3;
            this.btnNuevoCliente.Text = "Nuevo  Cliente";
            this.btnNuevoCliente.UseVisualStyleBackColor = false;
            // 
            // lblTipoDePizza
            // 
            this.lblTipoDePizza.AutoSize = true;
            this.lblTipoDePizza.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoDePizza.Location = new System.Drawing.Point(202, 35);
            this.lblTipoDePizza.Name = "lblTipoDePizza";
            this.lblTipoDePizza.Size = new System.Drawing.Size(84, 13);
            this.lblTipoDePizza.TabIndex = 4;
            this.lblTipoDePizza.Text = "Tipo de Pizza";
            // 
            // comboBoxTipoPizza
            // 
            this.comboBoxTipoPizza.BackColor = System.Drawing.Color.AliceBlue;
            this.comboBoxTipoPizza.FormattingEnabled = true;
            this.comboBoxTipoPizza.Items.AddRange(new object[] {
            "Muzzarella",
            "Fugazzeta",
            "Especial",
            "Anana(Un Boludo)",
            "Calabreza",
            "De la Casa"});
            this.comboBoxTipoPizza.Location = new System.Drawing.Point(172, 58);
            this.comboBoxTipoPizza.Name = "comboBoxTipoPizza";
            this.comboBoxTipoPizza.Size = new System.Drawing.Size(138, 21);
            this.comboBoxTipoPizza.TabIndex = 5;
            // 
            // lblCoccion
            // 
            this.lblCoccion.AutoSize = true;
            this.lblCoccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoccion.Location = new System.Drawing.Point(351, 14);
            this.lblCoccion.Name = "lblCoccion";
            this.lblCoccion.Size = new System.Drawing.Size(53, 13);
            this.lblCoccion.TabIndex = 6;
            this.lblCoccion.Text = "Coccion";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(217, 95);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(57, 13);
            this.lblCantidad.TabIndex = 7;
            this.lblCantidad.Text = "Cantidad";
            // 
            // checkedListBoxCoccion
            // 
            this.checkedListBoxCoccion.BackColor = System.Drawing.Color.AliceBlue;
            this.checkedListBoxCoccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.checkedListBoxCoccion.FormattingEnabled = true;
            this.checkedListBoxCoccion.Items.AddRange(new object[] {
            "A la Piedra",
            "Media Masa"});
            this.checkedListBoxCoccion.Location = new System.Drawing.Point(328, 39);
            this.checkedListBoxCoccion.Name = "checkedListBoxCoccion";
            this.checkedListBoxCoccion.Size = new System.Drawing.Size(103, 32);
            this.checkedListBoxCoccion.TabIndex = 10;
            // 
            // lblEnvio
            // 
            this.lblEnvio.AutoSize = true;
            this.lblEnvio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnvio.Location = new System.Drawing.Point(443, 14);
            this.lblEnvio.Name = "lblEnvio";
            this.lblEnvio.Size = new System.Drawing.Size(46, 13);
            this.lblEnvio.TabIndex = 11;
            this.lblEnvio.Text = "Envio?";
            // 
            // numericUpDownCantidad
            // 
            this.numericUpDownCantidad.BackColor = System.Drawing.Color.AliceBlue;
            this.numericUpDownCantidad.Location = new System.Drawing.Point(208, 118);
            this.numericUpDownCantidad.Name = "numericUpDownCantidad";
            this.numericUpDownCantidad.Size = new System.Drawing.Size(78, 20);
            this.numericUpDownCantidad.TabIndex = 12;
            // 
            // listBoxPedidos
            // 
            this.listBoxPedidos.FormattingEnabled = true;
            this.listBoxPedidos.Location = new System.Drawing.Point(1, 177);
            this.listBoxPedidos.Name = "listBoxPedidos";
            this.listBoxPedidos.Size = new System.Drawing.Size(770, 199);
            this.listBoxPedidos.TabIndex = 15;
            // 
            // btnCargar
            // 
            this.btnCargar.BackColor = System.Drawing.Color.DarkGreen;
            this.btnCargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargar.Location = new System.Drawing.Point(434, 100);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(91, 53);
            this.btnCargar.TabIndex = 16;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = false;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnFinalizarPedido
            // 
            this.btnFinalizarPedido.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnFinalizarPedido.Location = new System.Drawing.Point(549, 95);
            this.btnFinalizarPedido.Name = "btnFinalizarPedido";
            this.btnFinalizarPedido.Size = new System.Drawing.Size(176, 63);
            this.btnFinalizarPedido.TabIndex = 17;
            this.btnFinalizarPedido.Text = "Finalizar Pedido";
            this.btnFinalizarPedido.UseVisualStyleBackColor = false;
            this.btnFinalizarPedido.Click += new System.EventHandler(this.btnFinalizarPedido_Click);
            // 
            // checkSiNo
            // 
            this.checkSiNo.FormattingEnabled = true;
            this.checkSiNo.Items.AddRange(new object[] {
            "Si",
            "No"});
            this.checkSiNo.Location = new System.Drawing.Point(446, 37);
            this.checkSiNo.Name = "checkSiNo";
            this.checkSiNo.Size = new System.Drawing.Size(61, 34);
            this.checkSiNo.TabIndex = 18;
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
            // lblPedido_Nombre
            // 
            this.lblPedido_Nombre.AutoSize = true;
            this.lblPedido_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPedido_Nombre.Location = new System.Drawing.Point(12, 9);
            this.lblPedido_Nombre.Name = "lblPedido_Nombre";
            this.lblPedido_Nombre.Size = new System.Drawing.Size(50, 13);
            this.lblPedido_Nombre.TabIndex = 20;
            this.lblPedido_Nombre.Text = "Nombre";
            // 
            // lblPedido_Apellido
            // 
            this.lblPedido_Apellido.AutoSize = true;
            this.lblPedido_Apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPedido_Apellido.Location = new System.Drawing.Point(12, 58);
            this.lblPedido_Apellido.Name = "lblPedido_Apellido";
            this.lblPedido_Apellido.Size = new System.Drawing.Size(52, 13);
            this.lblPedido_Apellido.TabIndex = 21;
            this.lblPedido_Apellido.Text = "Apellido";
            // 
            // lblPedido_Domicilio
            // 
            this.lblPedido_Domicilio.AutoSize = true;
            this.lblPedido_Domicilio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPedido_Domicilio.Location = new System.Drawing.Point(9, 111);
            this.lblPedido_Domicilio.Name = "lblPedido_Domicilio";
            this.lblPedido_Domicilio.Size = new System.Drawing.Size(58, 13);
            this.lblPedido_Domicilio.TabIndex = 22;
            this.lblPedido_Domicilio.Text = "Domicilio";
            // 
            // textPedido_Nombre
            // 
            this.textPedido_Nombre.BackColor = System.Drawing.Color.AliceBlue;
            this.textPedido_Nombre.Location = new System.Drawing.Point(12, 28);
            this.textPedido_Nombre.Name = "textPedido_Nombre";
            this.textPedido_Nombre.Size = new System.Drawing.Size(111, 20);
            this.textPedido_Nombre.TabIndex = 23;
            // 
            // textPedido_Apellido
            // 
            this.textPedido_Apellido.BackColor = System.Drawing.Color.AliceBlue;
            this.textPedido_Apellido.Location = new System.Drawing.Point(12, 74);
            this.textPedido_Apellido.Name = "textPedido_Apellido";
            this.textPedido_Apellido.Size = new System.Drawing.Size(111, 20);
            this.textPedido_Apellido.TabIndex = 24;
            // 
            // textPedido_Domicilio
            // 
            this.textPedido_Domicilio.BackColor = System.Drawing.Color.AliceBlue;
            this.textPedido_Domicilio.Location = new System.Drawing.Point(12, 127);
            this.textPedido_Domicilio.Name = "textPedido_Domicilio";
            this.textPedido_Domicilio.Size = new System.Drawing.Size(107, 20);
            this.textPedido_Domicilio.TabIndex = 25;
            // 
            // FormPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(764, 368);
            this.Controls.Add(this.textPedido_Domicilio);
            this.Controls.Add(this.textPedido_Apellido);
            this.Controls.Add(this.textPedido_Nombre);
            this.Controls.Add(this.lblPedido_Domicilio);
            this.Controls.Add(this.lblPedido_Apellido);
            this.Controls.Add(this.lblPedido_Nombre);
            this.Controls.Add(this.lblPedidoError);
            this.Controls.Add(this.checkSiNo);
            this.Controls.Add(this.btnFinalizarPedido);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.listBoxPedidos);
            this.Controls.Add(this.numericUpDownCantidad);
            this.Controls.Add(this.lblEnvio);
            this.Controls.Add(this.checkedListBoxCoccion);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblCoccion);
            this.Controls.Add(this.comboBoxTipoPizza);
            this.Controls.Add(this.lblTipoDePizza);
            this.Controls.Add(this.btnNuevoCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormPedidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Pedido";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnNuevoCliente;
        private System.Windows.Forms.Label lblTipoDePizza;
        private System.Windows.Forms.ComboBox comboBoxTipoPizza;
        private System.Windows.Forms.Label lblCoccion;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.CheckedListBox checkedListBoxCoccion;
        private System.Windows.Forms.Label lblEnvio;
        private System.Windows.Forms.NumericUpDown numericUpDownCantidad;
        private System.Windows.Forms.ListBox listBoxPedidos;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnFinalizarPedido;
        private System.Windows.Forms.CheckedListBox checkSiNo;
        private System.Windows.Forms.Label lblPedidoError;
        private System.Windows.Forms.Label lblPedido_Nombre;
        private System.Windows.Forms.Label lblPedido_Apellido;
        private System.Windows.Forms.Label lblPedido_Domicilio;
        private System.Windows.Forms.TextBox textPedido_Nombre;
        private System.Windows.Forms.TextBox textPedido_Apellido;
        private System.Windows.Forms.TextBox textPedido_Domicilio;
    }
}