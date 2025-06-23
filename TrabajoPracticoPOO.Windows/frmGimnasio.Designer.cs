namespace TrabajoPracticoPOO.Windows
{
    partial class frmGimnasio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGimnasio));
            toolStrip1 = new ToolStrip();
            tsbAgregar = new ToolStripButton();
            tsbEditar = new ToolStripButton();
            tsbBorrar = new ToolStripButton();
            tsbActualizar = new ToolStripButton();
            tsbFiltrar = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            tsbSalir = new ToolStripButton();
            dgvDatos = new DataGridView();
            colNombre = new DataGridViewTextBoxColumn();
            colDNI = new DataGridViewTextBoxColumn();
            colTipoCliente = new DataGridViewTextBoxColumn();
            colLocalidad = new DataGridViewTextBoxColumn();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsbAgregar, tsbEditar, tsbBorrar, tsbActualizar, tsbFiltrar, toolStripSeparator1, tsbSalir });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 38);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // tsbAgregar
            // 
            tsbAgregar.Image = (Image)resources.GetObject("tsbAgregar.Image");
            tsbAgregar.ImageTransparentColor = Color.Magenta;
            tsbAgregar.Name = "tsbAgregar";
            tsbAgregar.Size = new Size(63, 35);
            tsbAgregar.Text = "AGREGAR";
            tsbAgregar.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbAgregar.Click += tsbAgregar_Click;
            // 
            // tsbEditar
            // 
            tsbEditar.Image = (Image)resources.GetObject("tsbEditar.Image");
            tsbEditar.ImageTransparentColor = Color.Magenta;
            tsbEditar.Name = "tsbEditar";
            tsbEditar.Size = new Size(49, 35);
            tsbEditar.Text = "EDITAR";
            tsbEditar.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbEditar.Click += tsbEditar_Click;
            // 
            // tsbBorrar
            // 
            tsbBorrar.Image = (Image)resources.GetObject("tsbBorrar.Image");
            tsbBorrar.ImageTransparentColor = Color.Magenta;
            tsbBorrar.Name = "tsbBorrar";
            tsbBorrar.Size = new Size(56, 35);
            tsbBorrar.Text = "BORRAR";
            tsbBorrar.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbBorrar.Click += tsbBorrar_Click;
            // 
            // tsbActualizar
            // 
            tsbActualizar.Image = (Image)resources.GetObject("tsbActualizar.Image");
            tsbActualizar.ImageTransparentColor = Color.Magenta;
            tsbActualizar.Name = "tsbActualizar";
            tsbActualizar.Size = new Size(81, 35);
            tsbActualizar.Text = "ACTUALIZAR";
            tsbActualizar.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbActualizar.Click += tsbActualizar_Click;
            // 
            // tsbFiltrar
            // 
            tsbFiltrar.Image = (Image)resources.GetObject("tsbFiltrar.Image");
            tsbFiltrar.ImageTransparentColor = Color.Magenta;
            tsbFiltrar.Name = "tsbFiltrar";
            tsbFiltrar.Size = new Size(54, 35);
            tsbFiltrar.Text = "FILTRAR";
            tsbFiltrar.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbFiltrar.Click += tsbFiltrar_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 38);
            // 
            // tsbSalir
            // 
            tsbSalir.Image = (Image)resources.GetObject("tsbSalir.Image");
            tsbSalir.ImageTransparentColor = Color.Magenta;
            tsbSalir.Name = "tsbSalir";
            tsbSalir.Size = new Size(41, 35);
            tsbSalir.Text = "SALIR";
            tsbSalir.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbSalir.Click += tsbSalir_Click;
            // 
            // dgvDatos
            // 
            dgvDatos.AllowUserToResizeColumns = false;
            dgvDatos.AllowUserToResizeRows = false;
            dgvDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Columns.AddRange(new DataGridViewColumn[] { colNombre, colDNI, colTipoCliente, colLocalidad });
            dgvDatos.Dock = DockStyle.Fill;
            dgvDatos.Location = new Point(0, 38);
            dgvDatos.MultiSelect = false;
            dgvDatos.Name = "dgvDatos";
            dgvDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDatos.Size = new Size(800, 412);
            dgvDatos.TabIndex = 1;
            // 
            // colNombre
            // 
            colNombre.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colNombre.HeaderText = "Nombre";
            colNombre.Name = "colNombre";
            colNombre.ReadOnly = true;
            colNombre.Resizable = DataGridViewTriState.False;
            colNombre.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colDNI
            // 
            colDNI.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colDNI.HeaderText = "DNI";
            colDNI.Name = "colDNI";
            colDNI.ReadOnly = true;
            colDNI.Resizable = DataGridViewTriState.False;
            colDNI.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colTipoCliente
            // 
            colTipoCliente.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colTipoCliente.HeaderText = "Tipo de Cliente";
            colTipoCliente.Name = "colTipoCliente";
            colTipoCliente.ReadOnly = true;
            colTipoCliente.Resizable = DataGridViewTriState.False;
            colTipoCliente.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colLocalidad
            // 
            colLocalidad.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colLocalidad.HeaderText = "Localidad";
            colLocalidad.Name = "colLocalidad";
            colLocalidad.ReadOnly = true;
            colLocalidad.Resizable = DataGridViewTriState.False;
            colLocalidad.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // frmGimnasio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvDatos);
            Controls.Add(toolStrip1);
            Name = "frmGimnasio";
            Text = "frmGimnasio";
            Load += frmGimnasio_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton tsbAgregar;
        private ToolStripButton tsbEditar;
        private ToolStripButton tsbBorrar;
        private ToolStripButton tsbActualizar;
        private ToolStripButton tsbFiltrar;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton tsbSalir;
        private DataGridView dgvDatos;
        private DataGridViewTextBoxColumn colNombre;
        private DataGridViewTextBoxColumn colDNI;
        private DataGridViewTextBoxColumn colTipoCliente;
        private DataGridViewTextBoxColumn colLocalidad;
    }
}