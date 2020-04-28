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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblSeleccionCliente = new System.Windows.Forms.Label();
            this.dgPendientes = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lb_HoraActual = new System.Windows.Forms.Label();
            this.listClientes = new System.Windows.Forms.ListBox();
            this.dgEntrega = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nuevoClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoPedidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lb_FPUsuario = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgPendientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgEntrega)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSeleccionCliente
            // 
            this.lblSeleccionCliente.AutoSize = true;
            this.lblSeleccionCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeleccionCliente.Location = new System.Drawing.Point(12, 36);
            this.lblSeleccionCliente.Name = "lblSeleccionCliente";
            this.lblSeleccionCliente.Size = new System.Drawing.Size(110, 13);
            this.lblSeleccionCliente.TabIndex = 0;
            this.lblSeleccionCliente.Text = "Seleccionar Clinte";
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
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle31.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle31.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle31.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle31.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle31.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle31.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgPendientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle31;
            this.dgPendientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPendientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle32.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle32.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle32.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle32.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle32.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle32.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgPendientes.DefaultCellStyle = dataGridViewCellStyle32;
            this.dgPendientes.GridColor = System.Drawing.Color.Black;
            this.dgPendientes.Location = new System.Drawing.Point(275, 75);
            this.dgPendientes.Name = "dgPendientes";
            dataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle33.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle33.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle33.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle33.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle33.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle33.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgPendientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle33;
            this.dgPendientes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgPendientes.Size = new System.Drawing.Size(355, 331);
            this.dgPendientes.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Pendientes";
            this.Column1.Name = "Column1";
            // 
            // lb_HoraActual
            // 
            this.lb_HoraActual.AutoSize = true;
            this.lb_HoraActual.Location = new System.Drawing.Point(858, 36);
            this.lb_HoraActual.Name = "lb_HoraActual";
            this.lb_HoraActual.Size = new System.Drawing.Size(63, 13);
            this.lb_HoraActual.TabIndex = 2;
            this.lb_HoraActual.Text = "Hora Actual";
            // 
            // listClientes
            // 
            this.listClientes.FormattingEnabled = true;
            this.listClientes.Location = new System.Drawing.Point(0, 52);
            this.listClientes.Name = "listClientes";
            this.listClientes.Size = new System.Drawing.Size(245, 355);
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
            dataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle34.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle34.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle34.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle34.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle34.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle34.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgEntrega.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle34;
            this.dgEntrega.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEntrega.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2});
            dataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle35.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle35.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle35.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle35.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle35.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle35.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgEntrega.DefaultCellStyle = dataGridViewCellStyle35;
            this.dgEntrega.Location = new System.Drawing.Point(648, 75);
            this.dgEntrega.Name = "dgEntrega";
            dataGridViewCellStyle36.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle36.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle36.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle36.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle36.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle36.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle36.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgEntrega.RowHeadersDefaultCellStyle = dataGridViewCellStyle36;
            this.dgEntrega.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgEntrega.Size = new System.Drawing.Size(328, 331);
            this.dgEntrega.TabIndex = 4;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Para entregar";
            this.Column2.Name = "Column2";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoClienteToolStripMenuItem,
            this.editarClienteToolStripMenuItem,
            this.nuevoPedidoToolStripMenuItem,
            this.editarUsuarioToolStripMenuItem,
            this.cerrarSesiónToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(976, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nuevoClienteToolStripMenuItem
            // 
            this.nuevoClienteToolStripMenuItem.Name = "nuevoClienteToolStripMenuItem";
            this.nuevoClienteToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.nuevoClienteToolStripMenuItem.Text = "Nuevo Cliente";
            this.nuevoClienteToolStripMenuItem.Click += new System.EventHandler(this.nuevoClienteToolStripMenuItem_Click);
            // 
            // editarClienteToolStripMenuItem
            // 
            this.editarClienteToolStripMenuItem.Name = "editarClienteToolStripMenuItem";
            this.editarClienteToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.editarClienteToolStripMenuItem.Text = "Editar Cliente";
            this.editarClienteToolStripMenuItem.Click += new System.EventHandler(this.editarClienteToolStripMenuItem_Click);
            // 
            // nuevoPedidoToolStripMenuItem
            // 
            this.nuevoPedidoToolStripMenuItem.Name = "nuevoPedidoToolStripMenuItem";
            this.nuevoPedidoToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.nuevoPedidoToolStripMenuItem.Text = "Nuevo Pedido";
            this.nuevoPedidoToolStripMenuItem.Click += new System.EventHandler(this.nuevoPedidoToolStripMenuItem_Click);
            // 
            // editarUsuarioToolStripMenuItem
            // 
            this.editarUsuarioToolStripMenuItem.Name = "editarUsuarioToolStripMenuItem";
            this.editarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.editarUsuarioToolStripMenuItem.Text = "Editar Usuario";
            this.editarUsuarioToolStripMenuItem.Click += new System.EventHandler(this.editarUsuarioToolStripMenuItem_Click);
            // 
            // lb_FPUsuario
            // 
            this.lb_FPUsuario.AutoSize = true;
            this.lb_FPUsuario.Location = new System.Drawing.Point(298, 36);
            this.lb_FPUsuario.Name = "lb_FPUsuario";
            this.lb_FPUsuario.Size = new System.Drawing.Size(35, 13);
            this.lb_FPUsuario.TabIndex = 6;
            this.lb_FPUsuario.Text = "label1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            this.cerrarSesiónToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            this.cerrarSesiónToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.cerrarSesiónToolStripMenuItem.Text = "Cerrar Sesion";
            this.cerrarSesiónToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesionToolStripMenuItem_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(976, 406);
            this.Controls.Add(this.lb_FPUsuario);
            this.Controls.Add(this.lb_HoraActual);
            this.Controls.Add(this.dgEntrega);
            this.Controls.Add(this.lblSeleccionCliente);
            this.Controls.Add(this.dgPendientes);
            this.Controls.Add(this.listClientes);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bienvenido al Menu Principal";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgPendientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgEntrega)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSeleccionCliente;
        private System.Windows.Forms.DataGridView dgPendientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Label lb_HoraActual;
        private System.Windows.Forms.ListBox listClientes;
        private System.Windows.Forms.DataGridView dgEntrega;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nuevoClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoPedidoToolStripMenuItem;
        private System.Windows.Forms.Label lb_FPUsuario;
        private System.Windows.Forms.ToolStripMenuItem editarUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

