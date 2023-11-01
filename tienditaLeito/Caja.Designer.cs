namespace tienditaLeito
{
    partial class Caja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Caja));
            this.cajaLabel = new System.Windows.Forms.Label();
            this.nombreLabel = new System.Windows.Forms.Label();
            this.telefonoLabel = new System.Windows.Forms.Label();
            this.cedulaLabel = new System.Windows.Forms.Label();
            this.cedulaTB = new System.Windows.Forms.TextBox();
            this.telefonoTB = new System.Windows.Forms.TextBox();
            this.nombreTB = new System.Windows.Forms.TextBox();
            this.codigoLabel = new System.Windows.Forms.Label();
            this.codigoTB = new System.Windows.Forms.TextBox();
            this.buscar = new System.Windows.Forms.PictureBox();
            this.cantidadLabel = new System.Windows.Forms.Label();
            this.cantidadTB = new System.Windows.Forms.TextBox();
            this.agregarButton = new System.Windows.Forms.Button();
            this.dataGridViewProductos = new System.Windows.Forms.DataGridView();
            this.nombreColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioUnitarioColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ivaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioTotalColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eliminarImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.totalLabel = new System.Windows.Forms.Label();
            this.facturarButton = new System.Windows.Forms.Button();
            this.Logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.buscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // cajaLabel
            // 
            this.cajaLabel.AutoSize = true;
            this.cajaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold);
            this.cajaLabel.Location = new System.Drawing.Point(390, 35);
            this.cajaLabel.Name = "cajaLabel";
            this.cajaLabel.Size = new System.Drawing.Size(115, 51);
            this.cajaLabel.TabIndex = 0;
            this.cajaLabel.Text = "Caja";
            // 
            // nombreLabel
            // 
            this.nombreLabel.AutoSize = true;
            this.nombreLabel.Location = new System.Drawing.Point(600, 137);
            this.nombreLabel.Name = "nombreLabel";
            this.nombreLabel.Size = new System.Drawing.Size(56, 16);
            this.nombreLabel.TabIndex = 1;
            this.nombreLabel.Text = "Nombre";
            // 
            // telefonoLabel
            // 
            this.telefonoLabel.AutoSize = true;
            this.telefonoLabel.Location = new System.Drawing.Point(408, 137);
            this.telefonoLabel.Name = "telefonoLabel";
            this.telefonoLabel.Size = new System.Drawing.Size(61, 16);
            this.telefonoLabel.TabIndex = 2;
            this.telefonoLabel.Text = "Telefono";
            // 
            // cedulaLabel
            // 
            this.cedulaLabel.AutoSize = true;
            this.cedulaLabel.Location = new System.Drawing.Point(183, 134);
            this.cedulaLabel.Name = "cedulaLabel";
            this.cedulaLabel.Size = new System.Drawing.Size(50, 16);
            this.cedulaLabel.TabIndex = 3;
            this.cedulaLabel.Text = "Cedula";
            // 
            // cedulaTB
            // 
            this.cedulaTB.BackColor = System.Drawing.SystemColors.Info;
            this.cedulaTB.Location = new System.Drawing.Point(239, 131);
            this.cedulaTB.Name = "cedulaTB";
            this.cedulaTB.Size = new System.Drawing.Size(100, 22);
            this.cedulaTB.TabIndex = 4;
            // 
            // telefonoTB
            // 
            this.telefonoTB.Location = new System.Drawing.Point(475, 131);
            this.telefonoTB.Name = "telefonoTB";
            this.telefonoTB.Size = new System.Drawing.Size(100, 22);
            this.telefonoTB.TabIndex = 5;
            // 
            // nombreTB
            // 
            this.nombreTB.Location = new System.Drawing.Point(662, 134);
            this.nombreTB.Name = "nombreTB";
            this.nombreTB.Size = new System.Drawing.Size(100, 22);
            this.nombreTB.TabIndex = 6;
            // 
            // codigoLabel
            // 
            this.codigoLabel.AutoSize = true;
            this.codigoLabel.Location = new System.Drawing.Point(185, 183);
            this.codigoLabel.Name = "codigoLabel";
            this.codigoLabel.Size = new System.Drawing.Size(129, 16);
            this.codigoLabel.TabIndex = 7;
            this.codigoLabel.Text = "Codigo del producto";
            // 
            // codigoTB
            // 
            this.codigoTB.Location = new System.Drawing.Point(320, 180);
            this.codigoTB.Name = "codigoTB";
            this.codigoTB.Size = new System.Drawing.Size(105, 22);
            this.codigoTB.TabIndex = 8;
            // 
            // buscar
            // 
            this.buscar.Image = ((System.Drawing.Image)(resources.GetObject("buscar.Image")));
            this.buscar.Location = new System.Drawing.Point(345, 131);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(30, 25);
            this.buscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buscar.TabIndex = 9;
            this.buscar.TabStop = false;
            this.buscar.Click += new System.EventHandler(this.buscar_Click);
            // 
            // cantidadLabel
            // 
            this.cantidadLabel.AutoSize = true;
            this.cantidadLabel.Location = new System.Drawing.Point(449, 183);
            this.cantidadLabel.Name = "cantidadLabel";
            this.cantidadLabel.Size = new System.Drawing.Size(61, 16);
            this.cantidadLabel.TabIndex = 10;
            this.cantidadLabel.Text = "Cantidad";
            // 
            // cantidadTB
            // 
            this.cantidadTB.Location = new System.Drawing.Point(537, 180);
            this.cantidadTB.Name = "cantidadTB";
            this.cantidadTB.Size = new System.Drawing.Size(100, 22);
            this.cantidadTB.TabIndex = 11;
            // 
            // agregarButton
            // 
            this.agregarButton.BackColor = System.Drawing.Color.LavenderBlush;
            this.agregarButton.Location = new System.Drawing.Point(662, 175);
            this.agregarButton.Name = "agregarButton";
            this.agregarButton.Size = new System.Drawing.Size(75, 33);
            this.agregarButton.TabIndex = 12;
            this.agregarButton.Text = "Agregar";
            this.agregarButton.UseVisualStyleBackColor = false;
            this.agregarButton.Click += new System.EventHandler(this.agregarButton_Click);
            // 
            // dataGridViewProductos
            // 
            this.dataGridViewProductos.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewProductos.ColumnHeadersHeight = 29;
            this.dataGridViewProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreColumn,
            this.cantidadColumn,
            this.precioUnitarioColumn,
            this.ivaColumn,
            this.precioTotalColumn,
            this.codigoColumn,
            this.eliminarImage});
            this.dataGridViewProductos.Location = new System.Drawing.Point(56, 239);
            this.dataGridViewProductos.Name = "dataGridViewProductos";
            this.dataGridViewProductos.RowHeadersVisible = false;
            this.dataGridViewProductos.RowHeadersWidth = 51;
            this.dataGridViewProductos.RowTemplate.Height = 24;
            this.dataGridViewProductos.Size = new System.Drawing.Size(791, 334);
            this.dataGridViewProductos.TabIndex = 13;
            this.dataGridViewProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProductos_CellContentClick);
            // 
            // nombreColumn
            // 
            this.nombreColumn.HeaderText = "Nombre";
            this.nombreColumn.MinimumWidth = 6;
            this.nombreColumn.Name = "nombreColumn";
            this.nombreColumn.Width = 125;
            // 
            // cantidadColumn
            // 
            this.cantidadColumn.HeaderText = "Cantidad";
            this.cantidadColumn.MinimumWidth = 6;
            this.cantidadColumn.Name = "cantidadColumn";
            this.cantidadColumn.Width = 85;
            // 
            // precioUnitarioColumn
            // 
            this.precioUnitarioColumn.HeaderText = "Precio unitario";
            this.precioUnitarioColumn.MinimumWidth = 6;
            this.precioUnitarioColumn.Name = "precioUnitarioColumn";
            this.precioUnitarioColumn.Width = 125;
            // 
            // ivaColumn
            // 
            this.ivaColumn.HeaderText = "Iva";
            this.ivaColumn.MinimumWidth = 6;
            this.ivaColumn.Name = "ivaColumn";
            this.ivaColumn.Width = 65;
            // 
            // precioTotalColumn
            // 
            this.precioTotalColumn.HeaderText = "Precio total";
            this.precioTotalColumn.MinimumWidth = 6;
            this.precioTotalColumn.Name = "precioTotalColumn";
            this.precioTotalColumn.Width = 125;
            // 
            // codigoColumn
            // 
            this.codigoColumn.HeaderText = "Codigo";
            this.codigoColumn.MinimumWidth = 6;
            this.codigoColumn.Name = "codigoColumn";
            this.codigoColumn.Width = 125;
            // 
            // eliminarImage
            // 
            this.eliminarImage.HeaderText = "Eliminar";
            this.eliminarImage.MinimumWidth = 6;
            this.eliminarImage.Name = "eliminarImage";
            this.eliminarImage.Width = 60;
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(36, 615);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(41, 16);
            this.totalLabel.TabIndex = 15;
            this.totalLabel.Text = "Total:";
            // 
            // facturarButton
            // 
            this.facturarButton.BackColor = System.Drawing.Color.LavenderBlush;
            this.facturarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.facturarButton.Location = new System.Drawing.Point(406, 640);
            this.facturarButton.Name = "facturarButton";
            this.facturarButton.Size = new System.Drawing.Size(99, 51);
            this.facturarButton.TabIndex = 16;
            this.facturarButton.Text = "Facturar";
            this.facturarButton.UseVisualStyleBackColor = false;
            this.facturarButton.Click += new System.EventHandler(this.facturarButton_Click);
            // 
            // Logo
            // 
            this.Logo.Image = global::tienditaLeito.Properties.Resources.logonor;
            this.Logo.Location = new System.Drawing.Point(56, 124);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(93, 78);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo.TabIndex = 17;
            this.Logo.TabStop = false;
            this.Logo.Click += new System.EventHandler(this.Logo_Click_1);
            // 
            // Caja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(884, 734);
            this.Controls.Add(this.facturarButton);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.dataGridViewProductos);
            this.Controls.Add(this.agregarButton);
            this.Controls.Add(this.cantidadTB);
            this.Controls.Add(this.cantidadLabel);
            this.Controls.Add(this.buscar);
            this.Controls.Add(this.codigoTB);
            this.Controls.Add(this.codigoLabel);
            this.Controls.Add(this.nombreTB);
            this.Controls.Add(this.telefonoTB);
            this.Controls.Add(this.cedulaTB);
            this.Controls.Add(this.cedulaLabel);
            this.Controls.Add(this.telefonoLabel);
            this.Controls.Add(this.nombreLabel);
            this.Controls.Add(this.cajaLabel);
            this.Controls.Add(this.Logo);
            this.Name = "Caja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Caja";
            this.Load += new System.EventHandler(this.caja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.buscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cajaLabel;
        private System.Windows.Forms.Label nombreLabel;
        private System.Windows.Forms.Label telefonoLabel;
        private System.Windows.Forms.Label cedulaLabel;
        private System.Windows.Forms.TextBox cedulaTB;
        private System.Windows.Forms.TextBox telefonoTB;
        private System.Windows.Forms.TextBox nombreTB;
        private System.Windows.Forms.Label codigoLabel;
        private System.Windows.Forms.TextBox codigoTB;
        private System.Windows.Forms.PictureBox buscar;
        private System.Windows.Forms.Label cantidadLabel;
        private System.Windows.Forms.TextBox cantidadTB;
        private System.Windows.Forms.Button agregarButton;
        private System.Windows.Forms.DataGridView dataGridViewProductos;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Button facturarButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioUnitarioColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ivaColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioTotalColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoColumn;
        private System.Windows.Forms.DataGridViewImageColumn eliminarImage;
        private System.Windows.Forms.PictureBox Logo;
    }
}