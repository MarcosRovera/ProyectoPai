namespace PryPaiLab3
{
    partial class FrmPago
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPago));
            this.label6 = new System.Windows.Forms.Label();
            this.LblSaldo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LblTotal = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CbxNombres = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.TxtMonto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LblMontoPagado = new System.Windows.Forms.Label();
            this.LstFecha = new System.Windows.Forms.ListBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(523, 322);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 26);
            this.label6.TabIndex = 50;
            this.label6.Text = "SALDO";
            // 
            // LblSaldo
            // 
            this.LblSaldo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblSaldo.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSaldo.ForeColor = System.Drawing.Color.Black;
            this.LblSaldo.Location = new System.Drawing.Point(726, 321);
            this.LblSaldo.Name = "LblSaldo";
            this.LblSaldo.Size = new System.Drawing.Size(264, 27);
            this.LblSaldo.TabIndex = 49;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(523, 119);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 26);
            this.label5.TabIndex = 46;
            this.label5.Text = "TOTAL PEDIDO";
            // 
            // LblTotal
            // 
            this.LblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblTotal.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotal.ForeColor = System.Drawing.Color.Black;
            this.LblTotal.Location = new System.Drawing.Point(726, 118);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(264, 27);
            this.LblTotal.TabIndex = 45;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(33, 20);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(142, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 35);
            this.label2.TabIndex = 42;
            this.label2.Text = "NUEVO PAGO";
            // 
            // CbxNombres
            // 
            this.CbxNombres.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CbxNombres.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxNombres.FormattingEnabled = true;
            this.CbxNombres.Location = new System.Drawing.Point(33, 166);
            this.CbxNombres.Margin = new System.Windows.Forms.Padding(5);
            this.CbxNombres.Name = "CbxNombres";
            this.CbxNombres.Size = new System.Drawing.Size(442, 31);
            this.CbxNombres.TabIndex = 40;
            this.CbxNombres.SelectedIndexChanged += new System.EventHandler(this.CbxNombres_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(28, 119);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 26);
            this.label1.TabIndex = 39;
            this.label1.Text = "NOMBRE DEL CLIENTE";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(28, 216);
            this.label8.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(195, 26);
            this.label8.TabIndex = 51;
            this.label8.Text = "FECHA DEL PEDIDO";
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.Red;
            this.BtnGuardar.ForeColor = System.Drawing.Color.White;
            this.BtnGuardar.Location = new System.Drawing.Point(528, 477);
            this.BtnGuardar.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(462, 37);
            this.BtnGuardar.TabIndex = 53;
            this.BtnGuardar.Text = "GUARDAR PAGO";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // TxtMonto
            // 
            this.TxtMonto.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TxtMonto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMonto.Location = new System.Drawing.Point(726, 417);
            this.TxtMonto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtMonto.Name = "TxtMonto";
            this.TxtMonto.ReadOnly = true;
            this.TxtMonto.Size = new System.Drawing.Size(264, 30);
            this.TxtMonto.TabIndex = 56;
            this.TxtMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtMonto.TextChanged += new System.EventHandler(this.TxtMonto_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(523, 421);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 26);
            this.label3.TabIndex = 55;
            this.label3.Text = "MONTO A PAGAR";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(523, 216);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 26);
            this.label4.TabIndex = 58;
            this.label4.Text = "Monto pagado";
            // 
            // LblMontoPagado
            // 
            this.LblMontoPagado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblMontoPagado.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMontoPagado.ForeColor = System.Drawing.Color.Black;
            this.LblMontoPagado.Location = new System.Drawing.Point(726, 215);
            this.LblMontoPagado.Name = "LblMontoPagado";
            this.LblMontoPagado.Size = new System.Drawing.Size(264, 27);
            this.LblMontoPagado.TabIndex = 57;
            // 
            // LstFecha
            // 
            this.LstFecha.FormattingEnabled = true;
            this.LstFecha.ItemHeight = 26;
            this.LstFecha.Location = new System.Drawing.Point(33, 250);
            this.LstFecha.Name = "LstFecha";
            this.LstFecha.Size = new System.Drawing.Size(442, 264);
            this.LstFecha.TabIndex = 59;
            this.LstFecha.SelectedIndexChanged += new System.EventHandler(this.LstFecha_SelectedIndexChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Red;
            this.pictureBox2.Location = new System.Drawing.Point(495, 121);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(10, 393);
            this.pictureBox2.TabIndex = 60;
            this.pictureBox2.TabStop = false;
            // 
            // FrmPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1037, 567);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.LstFecha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LblMontoPagado);
            this.Controls.Add(this.TxtMonto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LblSaldo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LblTotal);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CbxNombres);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmPago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NUEVO PAGO";
            this.Load += new System.EventHandler(this.FrmPago_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LblSaldo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CbxNombres;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.TextBox TxtMonto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblMontoPagado;
        private System.Windows.Forms.ListBox LstFecha;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}