namespace tienditaLeito
{
    partial class inventario
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
            this.inventarioDGB = new System.Windows.Forms.DataGridView();
            this.nombreColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ivaCheck = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.codigoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eliminarImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.labelInventario = new System.Windows.Forms.Label();
            this.actualizarButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioDGB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // inventarioDGB
            // 
            this.inventarioDGB.BackgroundColor = System.Drawing.Color.White;
            this.inventarioDGB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inventarioDGB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreColumn,
            this.precioColumn,
            this.cantidadColumn,
            this.ivaCheck,
            this.codigoColumn,
            this.eliminarImage});
            this.inventarioDGB.Location = new System.Drawing.Point(116, 146);
            this.inventarioDGB.Name = "inventarioDGB";
            this.inventarioDGB.RowHeadersWidth = 51;
            this.inventarioDGB.RowTemplate.Height = 24;
            this.inventarioDGB.Size = new System.Drawing.Size(840, 374);
            this.inventarioDGB.TabIndex = 1;
            this.inventarioDGB.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.inventarioDGB_CellContentClick);
            // 
            // nombreColumn
            // 
            this.nombreColumn.HeaderText = "Nombre";
            this.nombreColumn.MinimumWidth = 6;
            this.nombreColumn.Name = "nombreColumn";
            this.nombreColumn.Width = 125;
            // 
            // precioColumn
            // 
            this.precioColumn.HeaderText = "Precio";
            this.precioColumn.MinimumWidth = 6;
            this.precioColumn.Name = "precioColumn";
            this.precioColumn.Width = 125;
            // 
            // cantidadColumn
            // 
            this.cantidadColumn.HeaderText = "Cantidad";
            this.cantidadColumn.MinimumWidth = 6;
            this.cantidadColumn.Name = "cantidadColumn";
            this.cantidadColumn.Width = 125;
            // 
            // ivaCheck
            // 
            this.ivaCheck.HeaderText = "Iva";
            this.ivaCheck.MinimumWidth = 6;
            this.ivaCheck.Name = "ivaCheck";
            this.ivaCheck.Width = 65;
            // 
            // codigoColumn
            // 
            this.codigoColumn.HeaderText = "Codigo";
            this.codigoColumn.MinimumWidth = 6;
            this.codigoColumn.Name = "codigoColumn";
            this.codigoColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.codigoColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.codigoColumn.Width = 125;
            // 
            // eliminarImage
            // 
            this.eliminarImage.HeaderText = "Eliminar";
            this.eliminarImage.MinimumWidth = 6;
            this.eliminarImage.Name = "eliminarImage";
            this.eliminarImage.Width = 65;
            // 
            // labelInventario
            // 
            this.labelInventario.AutoSize = true;
            this.labelInventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInventario.Location = new System.Drawing.Point(324, 44);
            this.labelInventario.Name = "labelInventario";
            this.labelInventario.Size = new System.Drawing.Size(222, 51);
            this.labelInventario.TabIndex = 2;
            this.labelInventario.Text = "Inventario";
            // 
            // actualizarButton
            // 
            this.actualizarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actualizarButton.Location = new System.Drawing.Point(472, 543);
            this.actualizarButton.Name = "actualizarButton";
            this.actualizarButton.Size = new System.Drawing.Size(118, 50);
            this.actualizarButton.TabIndex = 3;
            this.actualizarButton.Text = "Actualizar";
            this.actualizarButton.UseVisualStyleBackColor = true;
            this.actualizarButton.Click += new System.EventHandler(this.actualizarButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::tienditaLeito.Properties.Resources.logonor;
            this.pictureBox1.Location = new System.Drawing.Point(552, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(78, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1036, 621);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.actualizarButton);
            this.Controls.Add(this.labelInventario);
            this.Controls.Add(this.inventarioDGB);
            this.Name = "inventario";
            this.Text = "inventario";
            ((System.ComponentModel.ISupportInitialize)(this.inventarioDGB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView inventarioDGB;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ivaCheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoColumn;
        private System.Windows.Forms.DataGridViewImageColumn eliminarImage;
        private System.Windows.Forms.Label labelInventario;
        private System.Windows.Forms.Button actualizarButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}