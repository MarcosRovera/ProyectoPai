namespace PryPaiLab3
{
    partial class FrmInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInicio));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.nuevoClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.totalesPorClienteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.agregarNuevoProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevosPedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pAGOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nUEVOPAGOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.productosMasVendidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuStrip1.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sistemaToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.productosToolStripMenuItem,
            this.pedidosToolStripMenuItem,
            this.pAGOSToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(1902, 26);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.sistemaToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.sistemaToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Gray;
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(130, 26);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listadoDeClientesToolStripMenuItem,
            this.toolStripSeparator1,
            this.nuevoClienteToolStripMenuItem,
            this.buscarClienteToolStripMenuItem,
            this.totalesPorClienteToolStripMenuItem1});
            this.clientesToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // listadoDeClientesToolStripMenuItem
            // 
            this.listadoDeClientesToolStripMenuItem.Name = "listadoDeClientesToolStripMenuItem";
            this.listadoDeClientesToolStripMenuItem.Size = new System.Drawing.Size(264, 26);
            this.listadoDeClientesToolStripMenuItem.Text = "Listado de Clientes...";
            this.listadoDeClientesToolStripMenuItem.Click += new System.EventHandler(this.listadoDeClientesToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(261, 6);
            // 
            // nuevoClienteToolStripMenuItem
            // 
            this.nuevoClienteToolStripMenuItem.Name = "nuevoClienteToolStripMenuItem";
            this.nuevoClienteToolStripMenuItem.Size = new System.Drawing.Size(264, 26);
            this.nuevoClienteToolStripMenuItem.Text = "Nuevo Cliente...";
            this.nuevoClienteToolStripMenuItem.Click += new System.EventHandler(this.nuevoClienteToolStripMenuItem_Click);
            // 
            // buscarClienteToolStripMenuItem
            // 
            this.buscarClienteToolStripMenuItem.Name = "buscarClienteToolStripMenuItem";
            this.buscarClienteToolStripMenuItem.Size = new System.Drawing.Size(264, 26);
            this.buscarClienteToolStripMenuItem.Text = "Buscar Cliente...";
            this.buscarClienteToolStripMenuItem.Click += new System.EventHandler(this.buscarClienteToolStripMenuItem_Click);
            // 
            // totalesPorClienteToolStripMenuItem1
            // 
            this.totalesPorClienteToolStripMenuItem1.Name = "totalesPorClienteToolStripMenuItem1";
            this.totalesPorClienteToolStripMenuItem1.Size = new System.Drawing.Size(264, 26);
            this.totalesPorClienteToolStripMenuItem1.Text = "Totales por Cliente...";
            this.totalesPorClienteToolStripMenuItem1.Click += new System.EventHandler(this.totalesPorClienteToolStripMenuItem1_Click);
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listadoDeProductosToolStripMenuItem,
            this.toolStripSeparator2,
            this.agregarNuevoProductoToolStripMenuItem,
            this.editarProductoToolStripMenuItem,
            this.productosMasVendidosToolStripMenuItem});
            this.productosToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.productosToolStripMenuItem.Text = "Productos";
            this.productosToolStripMenuItem.Click += new System.EventHandler(this.productosToolStripMenuItem_Click);
            // 
            // listadoDeProductosToolStripMenuItem
            // 
            this.listadoDeProductosToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.listadoDeProductosToolStripMenuItem.ForeColor = System.Drawing.SystemColors.MenuText;
            this.listadoDeProductosToolStripMenuItem.Name = "listadoDeProductosToolStripMenuItem";
            this.listadoDeProductosToolStripMenuItem.Size = new System.Drawing.Size(311, 26);
            this.listadoDeProductosToolStripMenuItem.Text = "Listado de Productos...";
            this.listadoDeProductosToolStripMenuItem.Click += new System.EventHandler(this.listadoDeProductosToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.BackColor = System.Drawing.Color.White;
            this.toolStripSeparator2.ForeColor = System.Drawing.SystemColors.MenuText;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(308, 6);
            // 
            // agregarNuevoProductoToolStripMenuItem
            // 
            this.agregarNuevoProductoToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.agregarNuevoProductoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.MenuText;
            this.agregarNuevoProductoToolStripMenuItem.Name = "agregarNuevoProductoToolStripMenuItem";
            this.agregarNuevoProductoToolStripMenuItem.Size = new System.Drawing.Size(311, 26);
            this.agregarNuevoProductoToolStripMenuItem.Text = "Agregar Nuevo Producto...";
            this.agregarNuevoProductoToolStripMenuItem.Click += new System.EventHandler(this.agregarNuevoProductoToolStripMenuItem_Click);
            // 
            // editarProductoToolStripMenuItem
            // 
            this.editarProductoToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.editarProductoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.MenuText;
            this.editarProductoToolStripMenuItem.Name = "editarProductoToolStripMenuItem";
            this.editarProductoToolStripMenuItem.Size = new System.Drawing.Size(311, 26);
            this.editarProductoToolStripMenuItem.Text = "Buscar Producto...";
            this.editarProductoToolStripMenuItem.Click += new System.EventHandler(this.editarProductoToolStripMenuItem_Click);
            // 
            // pedidosToolStripMenuItem
            // 
            this.pedidosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevosPedidosToolStripMenuItem});
            this.pedidosToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.pedidosToolStripMenuItem.Name = "pedidosToolStripMenuItem";
            this.pedidosToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.pedidosToolStripMenuItem.Text = "Pedidos";
            // 
            // nuevosPedidosToolStripMenuItem
            // 
            this.nuevosPedidosToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.nuevosPedidosToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.nuevosPedidosToolStripMenuItem.Name = "nuevosPedidosToolStripMenuItem";
            this.nuevosPedidosToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.nuevosPedidosToolStripMenuItem.Text = "Nuevos Pedidos";
            this.nuevosPedidosToolStripMenuItem.Click += new System.EventHandler(this.nuevosPedidosToolStripMenuItem_Click);
            // 
            // pAGOSToolStripMenuItem
            // 
            this.pAGOSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nUEVOPAGOToolStripMenuItem});
            this.pAGOSToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.pAGOSToolStripMenuItem.Name = "pAGOSToolStripMenuItem";
            this.pAGOSToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.pAGOSToolStripMenuItem.Text = "PAGOS";
            // 
            // nUEVOPAGOToolStripMenuItem
            // 
            this.nUEVOPAGOToolStripMenuItem.Name = "nUEVOPAGOToolStripMenuItem";
            this.nUEVOPAGOToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.nUEVOPAGOToolStripMenuItem.Text = "NUEVO PAGO";
            this.nUEVOPAGOToolStripMenuItem.Click += new System.EventHandler(this.nUEVOPAGOToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(567, 211);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(835, 553);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // productosMasVendidosToolStripMenuItem
            // 
            this.productosMasVendidosToolStripMenuItem.Name = "productosMasVendidosToolStripMenuItem";
            this.productosMasVendidosToolStripMenuItem.Size = new System.Drawing.Size(311, 26);
            this.productosMasVendidosToolStripMenuItem.Text = "Productos mas vendidos";
            this.productosMasVendidosToolStripMenuItem.Click += new System.EventHandler(this.productosMasVendidosToolStripMenuItem_Click);
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmInicio";
            this.Text = "PAI FABRICA DE COPETIN";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem agregarNuevoProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pedidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevosPedidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem totalesPorClienteToolStripMenuItem1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem pAGOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nUEVOPAGOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosMasVendidosToolStripMenuItem;
    }
}