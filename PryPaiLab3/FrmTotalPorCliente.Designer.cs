namespace PryPaiLab3
{
    partial class FrmTotalPorCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTotalPorCliente));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CbxNombres = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.DgvTotalPorPedido = new System.Windows.Forms.DataGridView();
            this.ColPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTotalPagado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSaldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.LblTotal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LblPagado = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LblSaldo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTotalPorPedido)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(68, 30);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(177, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(312, 35);
            this.label2.TabIndex = 27;
            this.label2.Text = "TOTALES POR CLIENTE";
            // 
            // CbxNombres
            // 
            this.CbxNombres.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CbxNombres.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxNombres.FormattingEnabled = true;
            this.CbxNombres.Location = new System.Drawing.Point(483, 140);
            this.CbxNombres.Margin = new System.Windows.Forms.Padding(5);
            this.CbxNombres.Name = "CbxNombres";
            this.CbxNombres.Size = new System.Drawing.Size(335, 31);
            this.CbxNombres.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(83, 145);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 26);
            this.label1.TabIndex = 24;
            this.label1.Text = "NOMBRE DEL CLIENTE";
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackColor = System.Drawing.Color.Red;
            this.BtnBuscar.ForeColor = System.Drawing.Color.White;
            this.BtnBuscar.Location = new System.Drawing.Point(221, 197);
            this.BtnBuscar.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(471, 37);
            this.BtnBuscar.TabIndex = 28;
            this.BtnBuscar.Text = "BUSCAR";
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // DgvTotalPorPedido
            // 
            this.DgvTotalPorPedido.BackgroundColor = System.Drawing.Color.White;
            this.DgvTotalPorPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvTotalPorPedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColPedido,
            this.ColFecha,
            this.ColTotal,
            this.ColTotalPagado,
            this.ColSaldo});
            this.DgvTotalPorPedido.Location = new System.Drawing.Point(36, 262);
            this.DgvTotalPorPedido.Margin = new System.Windows.Forms.Padding(8);
            this.DgvTotalPorPedido.Name = "DgvTotalPorPedido";
            this.DgvTotalPorPedido.RowHeadersWidth = 51;
            this.DgvTotalPorPedido.RowTemplate.Height = 24;
            this.DgvTotalPorPedido.Size = new System.Drawing.Size(835, 334);
            this.DgvTotalPorPedido.TabIndex = 29;
            // 
            // ColPedido
            // 
            this.ColPedido.HeaderText = "N° PEDIDO";
            this.ColPedido.MinimumWidth = 6;
            this.ColPedido.Name = "ColPedido";
            this.ColPedido.Width = 125;
            // 
            // ColFecha
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColFecha.DefaultCellStyle = dataGridViewCellStyle1;
            this.ColFecha.HeaderText = "FECHA";
            this.ColFecha.MinimumWidth = 6;
            this.ColFecha.Name = "ColFecha";
            this.ColFecha.Width = 250;
            // 
            // ColTotal
            // 
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.ColTotal.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColTotal.HeaderText = "TOTAL PEDIDO";
            this.ColTotal.MinimumWidth = 6;
            this.ColTotal.Name = "ColTotal";
            this.ColTotal.Width = 160;
            // 
            // ColTotalPagado
            // 
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.ColTotalPagado.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColTotalPagado.HeaderText = "TOTAL PAGADO";
            this.ColTotalPagado.MinimumWidth = 6;
            this.ColTotalPagado.Name = "ColTotalPagado";
            this.ColTotalPagado.Width = 125;
            // 
            // ColSaldo
            // 
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            this.ColSaldo.DefaultCellStyle = dataGridViewCellStyle4;
            this.ColSaldo.HeaderText = "SALDO PENDIENTE";
            this.ColSaldo.MinimumWidth = 6;
            this.ColSaldo.Name = "ColSaldo";
            this.ColSaldo.Width = 125;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(31, 619);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 26);
            this.label5.TabIndex = 34;
            this.label5.Text = "TOTAL";
            // 
            // LblTotal
            // 
            this.LblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblTotal.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotal.ForeColor = System.Drawing.Color.Black;
            this.LblTotal.Location = new System.Drawing.Point(115, 618);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(127, 27);
            this.LblTotal.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(309, 618);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 26);
            this.label3.TabIndex = 36;
            this.label3.Text = "TOTAL PAGADO";
            // 
            // LblPagado
            // 
            this.LblPagado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblPagado.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPagado.ForeColor = System.Drawing.Color.Black;
            this.LblPagado.Location = new System.Drawing.Point(478, 617);
            this.LblPagado.Name = "LblPagado";
            this.LblPagado.Size = new System.Drawing.Size(127, 27);
            this.LblPagado.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(647, 619);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 26);
            this.label6.TabIndex = 38;
            this.label6.Text = "SALDO";
            // 
            // LblSaldo
            // 
            this.LblSaldo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblSaldo.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSaldo.ForeColor = System.Drawing.Color.Black;
            this.LblSaldo.Location = new System.Drawing.Point(744, 618);
            this.LblSaldo.Name = "LblSaldo";
            this.LblSaldo.Size = new System.Drawing.Size(127, 27);
            this.LblSaldo.TabIndex = 37;
            // 
            // FrmTotalPorCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(912, 734);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LblSaldo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LblPagado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LblTotal);
            this.Controls.Add(this.DgvTotalPorPedido);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CbxNombres);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmTotalPorCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TOTAL POR CLIENTE";
            this.Load += new System.EventHandler(this.FrmTotalPorCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTotalPorPedido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CbxNombres;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.DataGridView DgvTotalPorPedido;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblPagado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LblSaldo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTotalPagado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSaldo;
    }
}