namespace pry_Luna_Verduleros
{
    partial class frmVentas
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
            this.dgvVentas = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.txtKilos = new System.Windows.Forms.TextBox();
            this.lblVendedor = new System.Windows.Forms.Label();
            this.lblProducto = new System.Windows.Forms.Label();
            this.lblFechas = new System.Windows.Forms.Label();
            this.lblKilos = new System.Windows.Forms.Label();
            this.dtpFechas = new System.Windows.Forms.DateTimePicker();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.vERDULEROSDataSet = new pry_Luna_Verduleros.VERDULEROSDataSet();
            this.vERDULEROSDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mrcVenta = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vERDULEROSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vERDULEROSDataSetBindingSource)).BeginInit();
            this.mrcVenta.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvVentas
            // 
            this.dgvVentas.AllowUserToAddRows = false;
            this.dgvVentas.AutoGenerateColumns = false;
            this.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentas.DataSource = this.vERDULEROSDataSetBindingSource;
            this.dgvVentas.Location = new System.Drawing.Point(12, 140);
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.Size = new System.Drawing.Size(410, 167);
            this.dgvVentas.TabIndex = 0;
            this.dgvVentas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(64, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(132, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(277, 19);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 2;
            // 
            // txtKilos
            // 
            this.txtKilos.Location = new System.Drawing.Point(277, 60);
            this.txtKilos.Name = "txtKilos";
            this.txtKilos.Size = new System.Drawing.Size(121, 20);
            this.txtKilos.TabIndex = 3;
            // 
            // lblVendedor
            // 
            this.lblVendedor.AutoSize = true;
            this.lblVendedor.Location = new System.Drawing.Point(8, 22);
            this.lblVendedor.Name = "lblVendedor";
            this.lblVendedor.Size = new System.Drawing.Size(53, 13);
            this.lblVendedor.TabIndex = 4;
            this.lblVendedor.Text = "Vendedor";
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Location = new System.Drawing.Point(221, 22);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(50, 13);
            this.lblProducto.TabIndex = 5;
            this.lblProducto.Text = "Producto";
            // 
            // lblFechas
            // 
            this.lblFechas.AutoSize = true;
            this.lblFechas.Location = new System.Drawing.Point(8, 63);
            this.lblFechas.Name = "lblFechas";
            this.lblFechas.Size = new System.Drawing.Size(42, 13);
            this.lblFechas.TabIndex = 6;
            this.lblFechas.Text = "Fechas";
            // 
            // lblKilos
            // 
            this.lblKilos.AutoSize = true;
            this.lblKilos.Location = new System.Drawing.Point(221, 63);
            this.lblKilos.Name = "lblKilos";
            this.lblKilos.Size = new System.Drawing.Size(29, 13);
            this.lblKilos.TabIndex = 7;
            this.lblKilos.Text = "Kilos";
            // 
            // dtpFechas
            // 
            this.dtpFechas.Location = new System.Drawing.Point(64, 63);
            this.dtpFechas.Name = "dtpFechas";
            this.dtpFechas.Size = new System.Drawing.Size(132, 20);
            this.dtpFechas.TabIndex = 8;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(224, 90);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // vERDULEROSDataSet
            // 
            this.vERDULEROSDataSet.DataSetName = "VERDULEROSDataSet";
            this.vERDULEROSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vERDULEROSDataSetBindingSource
            // 
            this.vERDULEROSDataSetBindingSource.DataSource = this.vERDULEROSDataSet;
            this.vERDULEROSDataSetBindingSource.Position = 0;
            // 
            // mrcVenta
            // 
            this.mrcVenta.Controls.Add(this.comboBox2);
            this.mrcVenta.Controls.Add(this.btnGuardar);
            this.mrcVenta.Controls.Add(this.comboBox1);
            this.mrcVenta.Controls.Add(this.dtpFechas);
            this.mrcVenta.Controls.Add(this.txtKilos);
            this.mrcVenta.Controls.Add(this.lblKilos);
            this.mrcVenta.Controls.Add(this.lblVendedor);
            this.mrcVenta.Controls.Add(this.lblFechas);
            this.mrcVenta.Controls.Add(this.lblProducto);
            this.mrcVenta.Location = new System.Drawing.Point(12, 12);
            this.mrcVenta.Name = "mrcVenta";
            this.mrcVenta.Size = new System.Drawing.Size(410, 122);
            this.mrcVenta.TabIndex = 10;
            this.mrcVenta.TabStop = false;
            this.mrcVenta.Text = "Venta";
            // 
            // frmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 326);
            this.Controls.Add(this.mrcVenta);
            this.Controls.Add(this.dgvVentas);
            this.Name = "frmVentas";
            this.Text = "Ventas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vERDULEROSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vERDULEROSDataSetBindingSource)).EndInit();
            this.mrcVenta.ResumeLayout(false);
            this.mrcVenta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVentas;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox txtKilos;
        private System.Windows.Forms.Label lblVendedor;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Label lblFechas;
        private System.Windows.Forms.Label lblKilos;
        private System.Windows.Forms.DateTimePicker dtpFechas;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.BindingSource vERDULEROSDataSetBindingSource;
        private VERDULEROSDataSet vERDULEROSDataSet;
        private System.Windows.Forms.GroupBox mrcVenta;
    }
}

