namespace TrabajoPracticoPOO.Windows
{
    partial class frmGimnasioAE
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtNombre = new TextBox();
            txtDNI = new TextBox();
            tipoClienteCbo = new ComboBox();
            localidadCbo = new ComboBox();
            btnOK = new Button();
            btnCancelar = new Button();
            errorProvider1 = new ErrorProvider(components);
            dtpFechaAlta = new DateTimePicker();
            fechaAltaLbl = new Label();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 29);
            label1.Name = "label1";
            label1.Size = new Size(139, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre y Apellido:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(135, 97);
            label2.Name = "label2";
            label2.Size = new Size(38, 20);
            label2.TabIndex = 0;
            label2.Text = "DNI:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(66, 171);
            label3.Name = "label3";
            label3.Size = new Size(113, 20);
            label3.TabIndex = 0;
            label3.Text = "Tipo de Cliente:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(99, 229);
            label4.Name = "label4";
            label4.Size = new Size(77, 20);
            label4.TabIndex = 0;
            label4.Text = "Localidad:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(190, 25);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(310, 27);
            txtNombre.TabIndex = 1;
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(190, 93);
            txtDNI.Margin = new Padding(3, 4, 3, 4);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(310, 27);
            txtDNI.TabIndex = 2;
            // 
            // tipoClienteCbo
            // 
            tipoClienteCbo.FormattingEnabled = true;
            tipoClienteCbo.Location = new Point(190, 167);
            tipoClienteCbo.Margin = new Padding(3, 4, 3, 4);
            tipoClienteCbo.Name = "tipoClienteCbo";
            tipoClienteCbo.Size = new Size(310, 28);
            tipoClienteCbo.TabIndex = 3;
            // 
            // localidadCbo
            // 
            localidadCbo.FormattingEnabled = true;
            localidadCbo.Location = new Point(190, 225);
            localidadCbo.Margin = new Padding(3, 4, 3, 4);
            localidadCbo.Name = "localidadCbo";
            localidadCbo.Size = new Size(310, 28);
            localidadCbo.TabIndex = 4;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(43, 377);
            btnOK.Margin = new Padding(3, 4, 3, 4);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(110, 111);
            btnOK.TabIndex = 5;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(391, 377);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(110, 111);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // dtpFechaAlta
            // 
            dtpFechaAlta.Format = DateTimePickerFormat.Short;
            dtpFechaAlta.Location = new Point(190, 289);
            dtpFechaAlta.Name = "dtpFechaAlta";
            dtpFechaAlta.Size = new Size(110, 27);
            dtpFechaAlta.TabIndex = 6;
            // 
            // fechaAltaLbl
            // 
            fechaAltaLbl.AutoSize = true;
            fechaAltaLbl.Location = new Point(73, 294);
            fechaAltaLbl.Name = "fechaAltaLbl";
            fechaAltaLbl.Size = new Size(100, 20);
            fechaAltaLbl.TabIndex = 7;
            fechaAltaLbl.Text = "Fecha de alta:";
            // 
            // frmGimnasioAE
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(fechaAltaLbl);
            Controls.Add(dtpFechaAlta);
            Controls.Add(btnCancelar);
            Controls.Add(btnOK);
            Controls.Add(localidadCbo);
            Controls.Add(tipoClienteCbo);
            Controls.Add(txtDNI);
            Controls.Add(txtNombre);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmGimnasioAE";
            Text = "frmGimnasioAE";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtNombre;
        private TextBox txtDNI;
        private ComboBox tipoClienteCbo;
        private ComboBox localidadCbo;
        private Button btnOK;
        private Button btnCancelar;
        private ErrorProvider errorProvider1;
        private DateTimePicker dtpFechaAlta;
        private Label fechaAltaLbl;
    }
}