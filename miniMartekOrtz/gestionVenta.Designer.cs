namespace miniMartekOrtz
{
    partial class gestionVenta
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
            this.components = new System.ComponentModel.Container();
            this.cmbProducto = new System.Windows.Forms.ComboBox();
            this.productoBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.miniMarketOrtzDataSet4 = new miniMartekOrtz.MiniMarketOrtzDataSet4();
            this.productoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.miniMarketOrtzDataSet2 = new miniMartekOrtz.MiniMarketOrtzDataSet2();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.dgvCarrito = new System.Windows.Forms.DataGridView();
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.miniMarketOrtzDataSet1 = new miniMartekOrtz.MiniMarketOrtzDataSet1();
            this.dgvVenta = new System.Windows.Forms.DataGridView();
            this.ventaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.miniMarketOrtzDataSet = new miniMartekOrtz.MiniMarketOrtzDataSet();
            this.ventaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.miniMarketOrtzDataSet5 = new miniMartekOrtz.MiniMarketOrtzDataSet5();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblProducto = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.btnEliminarC = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.productoTableAdapter = new miniMartekOrtz.MiniMarketOrtzDataSet1TableAdapters.ProductoTableAdapter();
            this.productoTableAdapter1 = new miniMartekOrtz.MiniMarketOrtzDataSet2TableAdapters.ProductoTableAdapter();
            this.productoTableAdapter2 = new miniMartekOrtz.MiniMarketOrtzDataSet4TableAdapters.ProductoTableAdapter();
            this.ventaTableAdapter = new miniMartekOrtz.MiniMarketOrtzDataSet5TableAdapters.ventaTableAdapter();
            this.ventaTableAdapter1 = new miniMartekOrtz.MiniMarketOrtzDataSetTableAdapters.ventaTableAdapter();
            this.miniMarketOrtzDataSet6 = new miniMartekOrtz.MiniMarketOrtzDataSet6();
            this.ventaBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.ventaTableAdapter2 = new miniMartekOrtz.MiniMarketOrtzDataSet6TableAdapters.ventaTableAdapter();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblIVA = new System.Windows.Forms.Label();
            this.miniMarketOrtzDataSet7 = new miniMartekOrtz.MiniMarketOrtzDataSet7();
            this.ventaBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.ventaTableAdapter3 = new miniMartekOrtz.MiniMarketOrtzDataSet7TableAdapters.ventaTableAdapter();
            this.idVentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IVA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.miniMarketOrtzDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.miniMarketOrtzDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.miniMarketOrtzDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.miniMarketOrtzDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.miniMarketOrtzDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.miniMarketOrtzDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventaBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.miniMarketOrtzDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventaBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbProducto
            // 
            this.cmbProducto.DataSource = this.productoBindingSource2;
            this.cmbProducto.DisplayMember = "Nombre";
            this.cmbProducto.FormattingEnabled = true;
            this.cmbProducto.Location = new System.Drawing.Point(107, 5);
            this.cmbProducto.Name = "cmbProducto";
            this.cmbProducto.Size = new System.Drawing.Size(104, 21);
            this.cmbProducto.TabIndex = 0;
            this.cmbProducto.ValueMember = "IdProducto";
            this.cmbProducto.SelectedIndexChanged += new System.EventHandler(this.cmbProducto_SelectedIndexChanged);
            // 
            // productoBindingSource2
            // 
            this.productoBindingSource2.DataMember = "Producto";
            this.productoBindingSource2.DataSource = this.miniMarketOrtzDataSet4;
            // 
            // miniMarketOrtzDataSet4
            // 
            this.miniMarketOrtzDataSet4.DataSetName = "MiniMarketOrtzDataSet4";
            this.miniMarketOrtzDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productoBindingSource1
            // 
            this.productoBindingSource1.DataMember = "Producto";
            this.productoBindingSource1.DataSource = this.miniMarketOrtzDataSet2;
            // 
            // miniMarketOrtzDataSet2
            // 
            this.miniMarketOrtzDataSet2.DataSetName = "MiniMarketOrtzDataSet2";
            this.miniMarketOrtzDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nudCantidad
            // 
            this.nudCantidad.Location = new System.Drawing.Point(454, 6);
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(120, 20);
            this.nudCantidad.TabIndex = 1;
            // 
            // dgvCarrito
            // 
            this.dgvCarrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarrito.Location = new System.Drawing.Point(10, 61);
            this.dgvCarrito.Name = "dgvCarrito";
            this.dgvCarrito.Size = new System.Drawing.Size(299, 170);
            this.dgvCarrito.TabIndex = 2;
            // 
            // productoBindingSource
            // 
            this.productoBindingSource.DataMember = "Producto";
            this.productoBindingSource.DataSource = this.miniMarketOrtzDataSet1;
            // 
            // miniMarketOrtzDataSet1
            // 
            this.miniMarketOrtzDataSet1.DataSetName = "MiniMarketOrtzDataSet1";
            this.miniMarketOrtzDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgvVenta
            // 
            this.dgvVenta.AutoGenerateColumns = false;
            this.dgvVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idVentaDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn,
            this.IVA});
            this.dgvVenta.DataSource = this.ventaBindingSource3;
            this.dgvVenta.Location = new System.Drawing.Point(332, 61);
            this.dgvVenta.Name = "dgvVenta";
            this.dgvVenta.Size = new System.Drawing.Size(345, 170);
            this.dgvVenta.TabIndex = 3;
            // 
            // ventaBindingSource1
            // 
            this.ventaBindingSource1.DataMember = "venta";
            this.ventaBindingSource1.DataSource = this.miniMarketOrtzDataSet;
            // 
            // miniMarketOrtzDataSet
            // 
            this.miniMarketOrtzDataSet.DataSetName = "MiniMarketOrtzDataSet";
            this.miniMarketOrtzDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ventaBindingSource
            // 
            this.ventaBindingSource.DataMember = "venta";
            this.ventaBindingSource.DataSource = this.miniMarketOrtzDataSet5;
            // 
            // miniMarketOrtzDataSet5
            // 
            this.miniMarketOrtzDataSet5.DataSetName = "MiniMarketOrtzDataSet5";
            this.miniMarketOrtzDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(50, 237);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(12, 348);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 5;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducto.Location = new System.Drawing.Point(35, 9);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(66, 17);
            this.lblProducto.TabIndex = 6;
            this.lblProducto.Text = "Producto:";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(360, 9);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(67, 17);
            this.lblCantidad.TabIndex = 7;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // btnEliminarC
            // 
            this.btnEliminarC.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnEliminarC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarC.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarC.ForeColor = System.Drawing.Color.White;
            this.btnEliminarC.Location = new System.Drawing.Point(179, 237);
            this.btnEliminarC.Name = "btnEliminarC";
            this.btnEliminarC.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarC.TabIndex = 8;
            this.btnEliminarC.Text = "Eliminar";
            this.btnEliminarC.UseVisualStyleBackColor = false;
            this.btnEliminarC.Click += new System.EventHandler(this.btnEliminarC_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(50, 277);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 9;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(179, 277);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.Location = new System.Drawing.Point(321, 251);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(106, 49);
            this.btnRegistrar.TabIndex = 11;
            this.btnRegistrar.Text = "Registrar venta";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(444, 251);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(106, 49);
            this.btnEliminar.TabIndex = 12;
            this.btnEliminar.Text = "Eliminar venta";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // productoTableAdapter
            // 
            this.productoTableAdapter.ClearBeforeFill = true;
            // 
            // productoTableAdapter1
            // 
            this.productoTableAdapter1.ClearBeforeFill = true;
            // 
            // productoTableAdapter2
            // 
            this.productoTableAdapter2.ClearBeforeFill = true;
            // 
            // ventaTableAdapter
            // 
            this.ventaTableAdapter.ClearBeforeFill = true;
            // 
            // ventaTableAdapter1
            // 
            this.ventaTableAdapter1.ClearBeforeFill = true;
            // 
            // miniMarketOrtzDataSet6
            // 
            this.miniMarketOrtzDataSet6.DataSetName = "MiniMarketOrtzDataSet6";
            this.miniMarketOrtzDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ventaBindingSource2
            // 
            this.ventaBindingSource2.DataMember = "venta";
            this.ventaBindingSource2.DataSource = this.miniMarketOrtzDataSet6;
            // 
            // ventaTableAdapter2
            // 
            this.ventaTableAdapter2.ClearBeforeFill = true;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(35, 36);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(0, 13);
            this.lblPrecio.TabIndex = 13;
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(145, 36);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(0, 13);
            this.lblStock.TabIndex = 14;
            // 
            // lblIVA
            // 
            this.lblIVA.AutoSize = true;
            this.lblIVA.Location = new System.Drawing.Point(274, 36);
            this.lblIVA.Name = "lblIVA";
            this.lblIVA.Size = new System.Drawing.Size(0, 13);
            this.lblIVA.TabIndex = 15;
            // 
            // miniMarketOrtzDataSet7
            // 
            this.miniMarketOrtzDataSet7.DataSetName = "MiniMarketOrtzDataSet7";
            this.miniMarketOrtzDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ventaBindingSource3
            // 
            this.ventaBindingSource3.DataMember = "venta";
            this.ventaBindingSource3.DataSource = this.miniMarketOrtzDataSet7;
            // 
            // ventaTableAdapter3
            // 
            this.ventaTableAdapter3.ClearBeforeFill = true;
            // 
            // idVentaDataGridViewTextBoxColumn
            // 
            this.idVentaDataGridViewTextBoxColumn.DataPropertyName = "IdVenta";
            this.idVentaDataGridViewTextBoxColumn.HeaderText = "IdVenta";
            this.idVentaDataGridViewTextBoxColumn.Name = "idVentaDataGridViewTextBoxColumn";
            this.idVentaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            // 
            // IVA
            // 
            this.IVA.DataPropertyName = "IVA";
            this.IVA.HeaderText = "IVA";
            this.IVA.Name = "IVA";
            // 
            // gestionVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 383);
            this.Controls.Add(this.lblIVA);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnEliminarC);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblProducto);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvVenta);
            this.Controls.Add(this.dgvCarrito);
            this.Controls.Add(this.nudCantidad);
            this.Controls.Add(this.cmbProducto);
            this.Name = "gestionVenta";
            this.Text = "gestionVenta";
            this.Load += new System.EventHandler(this.gestionVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.miniMarketOrtzDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.miniMarketOrtzDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.miniMarketOrtzDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.miniMarketOrtzDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.miniMarketOrtzDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.miniMarketOrtzDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventaBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.miniMarketOrtzDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventaBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbProducto;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.DataGridView dgvCarrito;
        private System.Windows.Forms.DataGridView dgvVenta;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Button btnEliminarC;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnEliminar;
        private MiniMarketOrtzDataSet1 miniMarketOrtzDataSet1;
        private System.Windows.Forms.BindingSource productoBindingSource;
        private MiniMarketOrtzDataSet1TableAdapters.ProductoTableAdapter productoTableAdapter;
        private MiniMarketOrtzDataSet2 miniMarketOrtzDataSet2;
        private System.Windows.Forms.BindingSource productoBindingSource1;
        private MiniMarketOrtzDataSet2TableAdapters.ProductoTableAdapter productoTableAdapter1;
        private MiniMarketOrtzDataSet4 miniMarketOrtzDataSet4;
        private System.Windows.Forms.BindingSource productoBindingSource2;
        private MiniMarketOrtzDataSet4TableAdapters.ProductoTableAdapter productoTableAdapter2;
        private MiniMarketOrtzDataSet5 miniMarketOrtzDataSet5;
        private System.Windows.Forms.BindingSource ventaBindingSource;
        private MiniMarketOrtzDataSet5TableAdapters.ventaTableAdapter ventaTableAdapter;
        private MiniMarketOrtzDataSet miniMarketOrtzDataSet;
        private System.Windows.Forms.BindingSource ventaBindingSource1;
        private MiniMarketOrtzDataSetTableAdapters.ventaTableAdapter ventaTableAdapter1;
        private MiniMarketOrtzDataSet6 miniMarketOrtzDataSet6;
        private System.Windows.Forms.BindingSource ventaBindingSource2;
        private MiniMarketOrtzDataSet6TableAdapters.ventaTableAdapter ventaTableAdapter2;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblIVA;
        private MiniMarketOrtzDataSet7 miniMarketOrtzDataSet7;
        private System.Windows.Forms.BindingSource ventaBindingSource3;
        private MiniMarketOrtzDataSet7TableAdapters.ventaTableAdapter ventaTableAdapter3;
        private System.Windows.Forms.DataGridViewTextBoxColumn idVentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn IVA;
    }
}