namespace Pizzeria_GUI
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblSeleccionCliente = new System.Windows.Forms.Label();
            this.btnNuevoPedido = new System.Windows.Forms.Button();
            this.dgPendientes = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNuevoCliente = new System.Windows.Forms.Button();
            this.lb_HoraActual = new System.Windows.Forms.Label();
            this.listClientes = new System.Windows.Forms.ListBox();
            this.dgEntrega = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgPendientes)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEntrega)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSeleccionCliente
            // 
            this.lblSeleccionCliente.AutoSize = true;
            this.lblSeleccionCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeleccionCliente.Location = new System.Drawing.Point(47, 7);
            this.lblSeleccionCliente.Name = "lblSeleccionCliente";
            this.lblSeleccionCliente.Size = new System.Drawing.Size(110, 13);
            this.lblSeleccionCliente.TabIndex = 0;
            this.lblSeleccionCliente.Text = "Seleccionar Clinte";
            // 
            // btnNuevoPedido
            // 
            this.btnNuevoPedido.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnNuevoPedido.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnNuevoPedido.Location = new System.Drawing.Point(504, 25);
            this.btnNuevoPedido.Name = "btnNuevoPedido";
            this.btnNuevoPedido.Size = new System.Drawing.Size(113, 81);
            this.btnNuevoPedido.TabIndex = 1;
            this.btnNuevoPedido.Text = "Nuevo Pedido";
            this.btnNuevoPedido.UseVisualStyleBackColor = false;
            this.btnNuevoPedido.Click += new System.EventHandler(this.btnNuevoPedido_Click);
            // 
            // dgPendientes
            // 
            this.dgPendientes.AllowUserToAddRows = false;
            this.dgPendientes.AllowUserToDeleteRows = false;
            this.dgPendientes.AllowUserToResizeColumns = false;
            this.dgPendientes.AllowUserToResizeRows = false;
            this.dgPendientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgPendientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgPendientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgPendientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgPendientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPendientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgPendientes.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgPendientes.GridColor = System.Drawing.Color.Black;
            this.dgPendientes.Location = new System.Drawing.Point(2, 139);
            this.dgPendientes.Name = "dgPendientes";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgPendientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgPendientes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgPendientes.Size = new System.Drawing.Size(305, 232);
            this.dgPendientes.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Pendientes";
            this.Column1.Name = "Column1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnNuevoCliente);
            this.panel1.Controls.Add(this.lb_HoraActual);
            this.panel1.Controls.Add(this.listClientes);
            this.panel1.Controls.Add(this.btnNuevoPedido);
            this.panel1.Controls.Add(this.lblSeleccionCliente);
            this.panel1.Location = new System.Drawing.Point(6, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(636, 137);
            this.panel1.TabIndex = 3;
            // 
            // btnNuevoCliente
            // 
            this.btnNuevoCliente.Location = new System.Drawing.Point(271, 47);
            this.btnNuevoCliente.Name = "btnNuevoCliente";
            this.btnNuevoCliente.Size = new System.Drawing.Size(87, 36);
            this.btnNuevoCliente.TabIndex = 3;
            this.btnNuevoCliente.Text = "Nuevo Cliente";
            this.btnNuevoCliente.UseVisualStyleBackColor = true;
            this.btnNuevoCliente.Click += new System.EventHandler(this.btnNuevoCliente_Click);
            // 
            // lb_HoraActual
            // 
            this.lb_HoraActual.AutoSize = true;
            this.lb_HoraActual.Location = new System.Drawing.Point(402, 25);
            this.lb_HoraActual.Name = "lb_HoraActual";
            this.lb_HoraActual.Size = new System.Drawing.Size(63, 13);
            this.lb_HoraActual.TabIndex = 2;
            this.lb_HoraActual.Text = "Hora Actual";
            // 
            // listClientes
            // 
            this.listClientes.FormattingEnabled = true;
            this.listClientes.Location = new System.Drawing.Point(6, 25);
            this.listClientes.Name = "listClientes";
            this.listClientes.Size = new System.Drawing.Size(245, 108);
            this.listClientes.TabIndex = 1;
            // 
            // dgEntrega
            // 
            this.dgEntrega.AllowUserToAddRows = false;
            this.dgEntrega.AllowUserToDeleteRows = false;
            this.dgEntrega.AllowUserToResizeColumns = false;
            this.dgEntrega.AllowUserToResizeRows = false;
            this.dgEntrega.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgEntrega.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgEntrega.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgEntrega.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgEntrega.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEntrega.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgEntrega.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgEntrega.Location = new System.Drawing.Point(313, 139);
            this.dgEntrega.Name = "dgEntrega";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgEntrega.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgEntrega.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgEntrega.Size = new System.Drawing.Size(328, 232);
            this.dgEntrega.TabIndex = 4;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Para entregar";
            this.Column2.Name = "Column2";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(650, 388);
            this.Controls.Add(this.dgEntrega);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgPendientes);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bienvenido al Menu Principal";
            ((System.ComponentModel.ISupportInitialize)(this.dgPendientes)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEntrega)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblSeleccionCliente;
        private System.Windows.Forms.Button btnNuevoPedido;
        private System.Windows.Forms.DataGridView dgPendientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_HoraActual;
        private System.Windows.Forms.ListBox listClientes;
        private System.Windows.Forms.DataGridView dgEntrega;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button btnNuevoCliente;
    }
}

