namespace AppVentasFer
{
    partial class frmLibros
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
            this.tlpRegistro = new System.Windows.Forms.TableLayoutPanel();
            this.txtSinopsis = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtEditorial = new System.Windows.Forms.TextBox();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.labelCodigo = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelAutor = new System.Windows.Forms.Label();
            this.labelEditorial = new System.Windows.Forms.Label();
            this.labelPrecio = new System.Windows.Forms.Label();
            this.labelStock = new System.Windows.Forms.Label();
            this.labelSinopsis = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.errorNombre = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorAutor = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorEditorial = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorPrecio = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorStock = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorSinopsis = new System.Windows.Forms.ErrorProvider(this.components);
            this.tlpRegistro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorNombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorAutor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorEditorial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorSinopsis)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpRegistro
            // 
            this.tlpRegistro.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tlpRegistro.ColumnCount = 2;
            this.tlpRegistro.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpRegistro.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.33334F));
            this.tlpRegistro.Controls.Add(this.txtSinopsis, 1, 6);
            this.tlpRegistro.Controls.Add(this.txtStock, 1, 5);
            this.tlpRegistro.Controls.Add(this.txtPrecio, 1, 4);
            this.tlpRegistro.Controls.Add(this.txtEditorial, 1, 3);
            this.tlpRegistro.Controls.Add(this.txtAutor, 1, 2);
            this.tlpRegistro.Controls.Add(this.txtNombre, 1, 1);
            this.tlpRegistro.Controls.Add(this.labelCodigo, 0, 0);
            this.tlpRegistro.Controls.Add(this.labelNombre, 0, 1);
            this.tlpRegistro.Controls.Add(this.labelAutor, 0, 2);
            this.tlpRegistro.Controls.Add(this.labelEditorial, 0, 3);
            this.tlpRegistro.Controls.Add(this.labelPrecio, 0, 4);
            this.tlpRegistro.Controls.Add(this.labelStock, 0, 5);
            this.tlpRegistro.Controls.Add(this.labelSinopsis, 0, 6);
            this.tlpRegistro.Controls.Add(this.txtCodigo, 1, 0);
            this.tlpRegistro.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tlpRegistro.Location = new System.Drawing.Point(21, 27);
            this.tlpRegistro.Name = "tlpRegistro";
            this.tlpRegistro.RowCount = 7;
            this.tlpRegistro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.51351F));
            this.tlpRegistro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.51351F));
            this.tlpRegistro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.51351F));
            this.tlpRegistro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.51351F));
            this.tlpRegistro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.51351F));
            this.tlpRegistro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.51351F));
            this.tlpRegistro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.91892F));
            this.tlpRegistro.Size = new System.Drawing.Size(986, 429);
            this.tlpRegistro.TabIndex = 0;
            this.tlpRegistro.Paint += new System.Windows.Forms.PaintEventHandler(this.tlpRegistro_Paint);
            // 
            // txtSinopsis
            // 
            this.txtSinopsis.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtSinopsis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSinopsis.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSinopsis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSinopsis.Location = new System.Drawing.Point(170, 347);
            this.txtSinopsis.Multiline = true;
            this.txtSinopsis.Name = "txtSinopsis";
            this.txtSinopsis.Size = new System.Drawing.Size(811, 76);
            this.txtSinopsis.TabIndex = 13;
            // 
            // txtStock
            // 
            this.txtStock.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStock.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtStock.Location = new System.Drawing.Point(170, 301);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(99, 27);
            this.txtStock.TabIndex = 12;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtPrecio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrecio.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPrecio.Location = new System.Drawing.Point(170, 244);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(99, 27);
            this.txtPrecio.TabIndex = 11;
            // 
            // txtEditorial
            // 
            this.txtEditorial.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtEditorial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEditorial.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEditorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEditorial.Location = new System.Drawing.Point(170, 187);
            this.txtEditorial.Name = "txtEditorial";
            this.txtEditorial.Size = new System.Drawing.Size(293, 27);
            this.txtEditorial.TabIndex = 10;
            // 
            // txtAutor
            // 
            this.txtAutor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtAutor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAutor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAutor.Location = new System.Drawing.Point(170, 130);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(293, 27);
            this.txtAutor.TabIndex = 9;
            this.txtAutor.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNombre.Location = new System.Drawing.Point(170, 73);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(293, 27);
            this.txtNombre.TabIndex = 8;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // labelCodigo
            // 
            this.labelCodigo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelCodigo.AutoSize = true;
            this.labelCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCodigo.Location = new System.Drawing.Point(91, 19);
            this.labelCodigo.Name = "labelCodigo";
            this.labelCodigo.Size = new System.Drawing.Size(71, 20);
            this.labelCodigo.TabIndex = 0;
            this.labelCodigo.Text = "Codigo :";
            // 
            // labelNombre
            // 
            this.labelNombre.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNombre.Location = new System.Drawing.Point(84, 76);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(78, 20);
            this.labelNombre.TabIndex = 1;
            this.labelNombre.Text = "Nombre :";
            // 
            // labelAutor
            // 
            this.labelAutor.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelAutor.AutoSize = true;
            this.labelAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelAutor.Location = new System.Drawing.Point(103, 133);
            this.labelAutor.Name = "labelAutor";
            this.labelAutor.Size = new System.Drawing.Size(59, 20);
            this.labelAutor.TabIndex = 2;
            this.labelAutor.Text = "Autor :";
            // 
            // labelEditorial
            // 
            this.labelEditorial.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelEditorial.AutoSize = true;
            this.labelEditorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelEditorial.Location = new System.Drawing.Point(82, 190);
            this.labelEditorial.Name = "labelEditorial";
            this.labelEditorial.Size = new System.Drawing.Size(80, 20);
            this.labelEditorial.TabIndex = 3;
            this.labelEditorial.Text = "Editorial :";
            // 
            // labelPrecio
            // 
            this.labelPrecio.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelPrecio.AutoSize = true;
            this.labelPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPrecio.Location = new System.Drawing.Point(95, 247);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(67, 20);
            this.labelPrecio.TabIndex = 4;
            this.labelPrecio.Text = "Precio :";
            // 
            // labelStock
            // 
            this.labelStock.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelStock.AutoSize = true;
            this.labelStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelStock.Location = new System.Drawing.Point(101, 304);
            this.labelStock.Name = "labelStock";
            this.labelStock.Size = new System.Drawing.Size(61, 20);
            this.labelStock.TabIndex = 5;
            this.labelStock.Text = "Stock :";
            // 
            // labelSinopsis
            // 
            this.labelSinopsis.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelSinopsis.AutoSize = true;
            this.labelSinopsis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSinopsis.Location = new System.Drawing.Point(79, 375);
            this.labelSinopsis.Name = "labelSinopsis";
            this.labelSinopsis.Size = new System.Drawing.Size(83, 20);
            this.labelSinopsis.TabIndex = 6;
            this.labelSinopsis.Text = "Sinopsis :";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCodigo.BackColor = System.Drawing.SystemColors.Control;
            this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCodigo.Location = new System.Drawing.Point(170, 16);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(73, 27);
            this.txtCodigo.TabIndex = 7;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGuardar.Location = new System.Drawing.Point(21, 505);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(191, 48);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBorrar.Location = new System.Drawing.Point(247, 505);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(191, 48);
            this.btnBorrar.TabIndex = 2;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            // 
            // errorNombre
            // 
            this.errorNombre.ContainerControl = this;
            // 
            // errorAutor
            // 
            this.errorAutor.ContainerControl = this;
            // 
            // errorEditorial
            // 
            this.errorEditorial.ContainerControl = this;
            // 
            // errorPrecio
            // 
            this.errorPrecio.ContainerControl = this;
            // 
            // errorStock
            // 
            this.errorStock.ContainerControl = this;
            // 
            // errorSinopsis
            // 
            this.errorSinopsis.ContainerControl = this;
            // 
            // frmLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 599);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.tlpRegistro);
            this.Name = "frmLibros";
            this.Text = "REGISTRO DE LIBROS";
            this.Load += new System.EventHandler(this.frmLibros_Load);
            this.tlpRegistro.ResumeLayout(false);
            this.tlpRegistro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorNombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorAutor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorEditorial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorSinopsis)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpRegistro;
        private System.Windows.Forms.TextBox txtSinopsis;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtEditorial;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label labelCodigo;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelAutor;
        private System.Windows.Forms.Label labelEditorial;
        private System.Windows.Forms.Label labelPrecio;
        private System.Windows.Forms.Label labelStock;
        private System.Windows.Forms.Label labelSinopsis;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.ErrorProvider errorNombre;
        private System.Windows.Forms.ErrorProvider errorAutor;
        private System.Windows.Forms.ErrorProvider errorEditorial;
        private System.Windows.Forms.ErrorProvider errorPrecio;
        private System.Windows.Forms.ErrorProvider errorStock;
        private System.Windows.Forms.ErrorProvider errorSinopsis;
    }
}