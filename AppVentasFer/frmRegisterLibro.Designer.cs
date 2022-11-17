namespace AppVentasFer
{
    partial class frmRegisterLibro
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
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
            this.errorGral = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorGral)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.Controls.Add(this.txtSinopsis, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtStock, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtPrecio, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtEditorial, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtAutor, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtNombre, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelCodigo, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelNombre, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelAutor, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelEditorial, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelPrecio, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.labelStock, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.labelSinopsis, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtCodigo, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(18, 17);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1009, 405);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // txtSinopsis
            // 
            this.txtSinopsis.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtSinopsis.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtSinopsis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSinopsis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSinopsis.Location = new System.Drawing.Point(204, 298);
            this.txtSinopsis.Multiline = true;
            this.txtSinopsis.Name = "txtSinopsis";
            this.txtSinopsis.Size = new System.Drawing.Size(779, 97);
            this.txtSinopsis.TabIndex = 13;
            // 
            // txtStock
            // 
            this.txtStock.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtStock.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtStock.Location = new System.Drawing.Point(204, 249);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(110, 29);
            this.txtStock.TabIndex = 12;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtPrecio.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtPrecio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPrecio.Location = new System.Drawing.Point(204, 201);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(110, 29);
            this.txtPrecio.TabIndex = 11;
            // 
            // txtEditorial
            // 
            this.txtEditorial.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtEditorial.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtEditorial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEditorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEditorial.Location = new System.Drawing.Point(204, 153);
            this.txtEditorial.Name = "txtEditorial";
            this.txtEditorial.Size = new System.Drawing.Size(261, 29);
            this.txtEditorial.TabIndex = 10;
            // 
            // txtAutor
            // 
            this.txtAutor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtAutor.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtAutor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAutor.Location = new System.Drawing.Point(204, 105);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(261, 29);
            this.txtAutor.TabIndex = 9;
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtNombre.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNombre.Location = new System.Drawing.Point(204, 57);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(261, 29);
            this.txtNombre.TabIndex = 8;
            // 
            // labelCodigo
            // 
            this.labelCodigo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelCodigo.AutoSize = true;
            this.labelCodigo.BackColor = System.Drawing.SystemColors.Control;
            this.labelCodigo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.labelCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCodigo.Location = new System.Drawing.Point(127, 14);
            this.labelCodigo.Name = "labelCodigo";
            this.labelCodigo.Size = new System.Drawing.Size(71, 20);
            this.labelCodigo.TabIndex = 0;
            this.labelCodigo.Text = "Codigo :";
            // 
            // labelNombre
            // 
            this.labelNombre.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelNombre.AutoSize = true;
            this.labelNombre.BackColor = System.Drawing.SystemColors.Control;
            this.labelNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.labelNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNombre.Location = new System.Drawing.Point(120, 62);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(78, 20);
            this.labelNombre.TabIndex = 1;
            this.labelNombre.Text = "Nombre :";
            // 
            // labelAutor
            // 
            this.labelAutor.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelAutor.AutoSize = true;
            this.labelAutor.BackColor = System.Drawing.SystemColors.Control;
            this.labelAutor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.labelAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelAutor.Location = new System.Drawing.Point(139, 110);
            this.labelAutor.Name = "labelAutor";
            this.labelAutor.Size = new System.Drawing.Size(59, 20);
            this.labelAutor.TabIndex = 2;
            this.labelAutor.Text = "Autor :";
            // 
            // labelEditorial
            // 
            this.labelEditorial.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelEditorial.AutoSize = true;
            this.labelEditorial.BackColor = System.Drawing.SystemColors.Control;
            this.labelEditorial.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.labelEditorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelEditorial.Location = new System.Drawing.Point(118, 158);
            this.labelEditorial.Name = "labelEditorial";
            this.labelEditorial.Size = new System.Drawing.Size(80, 20);
            this.labelEditorial.TabIndex = 3;
            this.labelEditorial.Text = "Editorial :";
            // 
            // labelPrecio
            // 
            this.labelPrecio.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelPrecio.AutoSize = true;
            this.labelPrecio.BackColor = System.Drawing.SystemColors.Control;
            this.labelPrecio.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.labelPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPrecio.Location = new System.Drawing.Point(131, 206);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(67, 20);
            this.labelPrecio.TabIndex = 4;
            this.labelPrecio.Text = "Precio :";
            // 
            // labelStock
            // 
            this.labelStock.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelStock.AutoSize = true;
            this.labelStock.BackColor = System.Drawing.SystemColors.Control;
            this.labelStock.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.labelStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelStock.Location = new System.Drawing.Point(137, 254);
            this.labelStock.Name = "labelStock";
            this.labelStock.Size = new System.Drawing.Size(61, 20);
            this.labelStock.TabIndex = 5;
            this.labelStock.Text = "Stock :";
            // 
            // labelSinopsis
            // 
            this.labelSinopsis.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelSinopsis.AutoSize = true;
            this.labelSinopsis.BackColor = System.Drawing.SystemColors.Control;
            this.labelSinopsis.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.labelSinopsis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSinopsis.Location = new System.Drawing.Point(115, 336);
            this.labelSinopsis.Name = "labelSinopsis";
            this.labelSinopsis.Size = new System.Drawing.Size(83, 20);
            this.labelSinopsis.TabIndex = 6;
            this.labelSinopsis.Text = "Sinopsis :";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCodigo.Location = new System.Drawing.Point(204, 9);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(75, 29);
            this.txtCodigo.TabIndex = 7;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnGuardar.Location = new System.Drawing.Point(80, 445);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(180, 48);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click_1);
            // 
            // errorGral
            // 
            this.errorGral.ContainerControl = this;
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnActualizar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnActualizar.Location = new System.Drawing.Point(278, 445);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(180, 48);
            this.btnActualizar.TabIndex = 2;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click_1);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnEliminar.Location = new System.Drawing.Point(475, 445);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(180, 48);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // frmRegisterLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1071, 580);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmRegisterLibro";
            this.Text = "REGISTRO DE LIBROS";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorGral)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelCodigo;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelAutor;
        private System.Windows.Forms.Label labelEditorial;
        private System.Windows.Forms.Label labelPrecio;
        private System.Windows.Forms.Label labelStock;
        private System.Windows.Forms.Label labelSinopsis;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtSinopsis;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtEditorial;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ErrorProvider errorGral;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
    }
}