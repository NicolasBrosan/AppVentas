namespace AppVentasFer
{
    partial class frmDatosCliente
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
            this.tlpDatosCliente = new System.Windows.Forms.TableLayoutPanel();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelApellido = new System.Windows.Forms.Label();
            this.labelTelefono = new System.Windows.Forms.Label();
            this.labelDireccion = new System.Windows.Forms.Label();
            this.labelLocalidad = new System.Windows.Forms.Label();
            this.labelProvincia = new System.Windows.Forms.Label();
            this.labelTarjeta = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtLocalidad = new System.Windows.Forms.TextBox();
            this.txtProvincia = new System.Windows.Forms.TextBox();
            this.txtTarjeta = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.tlpDatosCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpDatosCliente
            // 
            this.tlpDatosCliente.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tlpDatosCliente.ColumnCount = 2;
            this.tlpDatosCliente.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.00358F));
            this.tlpDatosCliente.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.99642F));
            this.tlpDatosCliente.Controls.Add(this.txtTarjeta, 1, 6);
            this.tlpDatosCliente.Controls.Add(this.txtProvincia, 1, 5);
            this.tlpDatosCliente.Controls.Add(this.txtLocalidad, 1, 4);
            this.tlpDatosCliente.Controls.Add(this.txtDireccion, 1, 3);
            this.tlpDatosCliente.Controls.Add(this.txtTelefono, 1, 2);
            this.tlpDatosCliente.Controls.Add(this.txtApellido, 1, 1);
            this.tlpDatosCliente.Controls.Add(this.labelNombre, 0, 0);
            this.tlpDatosCliente.Controls.Add(this.labelApellido, 0, 1);
            this.tlpDatosCliente.Controls.Add(this.labelTelefono, 0, 2);
            this.tlpDatosCliente.Controls.Add(this.labelDireccion, 0, 3);
            this.tlpDatosCliente.Controls.Add(this.labelLocalidad, 0, 4);
            this.tlpDatosCliente.Controls.Add(this.labelProvincia, 0, 5);
            this.tlpDatosCliente.Controls.Add(this.labelTarjeta, 0, 6);
            this.tlpDatosCliente.Controls.Add(this.txtNombre, 1, 0);
            this.tlpDatosCliente.Location = new System.Drawing.Point(14, 12);
            this.tlpDatosCliente.Name = "tlpDatosCliente";
            this.tlpDatosCliente.RowCount = 7;
            this.tlpDatosCliente.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlpDatosCliente.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlpDatosCliente.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlpDatosCliente.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlpDatosCliente.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlpDatosCliente.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlpDatosCliente.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlpDatosCliente.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpDatosCliente.Size = new System.Drawing.Size(515, 370);
            this.tlpDatosCliente.TabIndex = 0;
            // 
            // labelNombre
            // 
            this.labelNombre.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelNombre.AutoSize = true;
            this.labelNombre.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.labelNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNombre.Location = new System.Drawing.Point(32, 17);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(78, 20);
            this.labelNombre.TabIndex = 0;
            this.labelNombre.Text = "Nombre :";
            // 
            // labelApellido
            // 
            this.labelApellido.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelApellido.AutoSize = true;
            this.labelApellido.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.labelApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelApellido.Location = new System.Drawing.Point(32, 69);
            this.labelApellido.Name = "labelApellido";
            this.labelApellido.Size = new System.Drawing.Size(78, 20);
            this.labelApellido.TabIndex = 1;
            this.labelApellido.Text = "Apellido :";
            // 
            // labelTelefono
            // 
            this.labelTelefono.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelTelefono.AutoSize = true;
            this.labelTelefono.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.labelTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTelefono.Location = new System.Drawing.Point(27, 121);
            this.labelTelefono.Name = "labelTelefono";
            this.labelTelefono.Size = new System.Drawing.Size(83, 20);
            this.labelTelefono.TabIndex = 2;
            this.labelTelefono.Text = "Teléfono :";
            // 
            // labelDireccion
            // 
            this.labelDireccion.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelDireccion.AutoSize = true;
            this.labelDireccion.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.labelDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDireccion.Location = new System.Drawing.Point(19, 173);
            this.labelDireccion.Name = "labelDireccion";
            this.labelDireccion.Size = new System.Drawing.Size(91, 20);
            this.labelDireccion.TabIndex = 3;
            this.labelDireccion.Text = "Dirección :";
            // 
            // labelLocalidad
            // 
            this.labelLocalidad.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelLocalidad.AutoSize = true;
            this.labelLocalidad.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.labelLocalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelLocalidad.Location = new System.Drawing.Point(19, 225);
            this.labelLocalidad.Name = "labelLocalidad";
            this.labelLocalidad.Size = new System.Drawing.Size(91, 20);
            this.labelLocalidad.TabIndex = 4;
            this.labelLocalidad.Text = "Localidad :";
            // 
            // labelProvincia
            // 
            this.labelProvincia.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelProvincia.AutoSize = true;
            this.labelProvincia.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.labelProvincia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelProvincia.Location = new System.Drawing.Point(22, 277);
            this.labelProvincia.Name = "labelProvincia";
            this.labelProvincia.Size = new System.Drawing.Size(88, 20);
            this.labelProvincia.TabIndex = 5;
            this.labelProvincia.Text = "Provincia :";
            // 
            // labelTarjeta
            // 
            this.labelTarjeta.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelTarjeta.AutoSize = true;
            this.labelTarjeta.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.labelTarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTarjeta.Location = new System.Drawing.Point(39, 331);
            this.labelTarjeta.Name = "labelTarjeta";
            this.labelTarjeta.Size = new System.Drawing.Size(71, 20);
            this.labelTarjeta.TabIndex = 6;
            this.labelTarjeta.Text = "Tarjeta :";
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNombre.Location = new System.Drawing.Point(118, 13);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(349, 27);
            this.txtNombre.TabIndex = 7;
            // 
            // txtApellido
            // 
            this.txtApellido.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtApellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtApellido.Location = new System.Drawing.Point(118, 65);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(349, 27);
            this.txtApellido.TabIndex = 8;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTelefono.Location = new System.Drawing.Point(118, 117);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(349, 27);
            this.txtTelefono.TabIndex = 9;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDireccion.Location = new System.Drawing.Point(118, 169);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(349, 27);
            this.txtDireccion.TabIndex = 10;
            // 
            // txtLocalidad
            // 
            this.txtLocalidad.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtLocalidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLocalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLocalidad.Location = new System.Drawing.Point(118, 221);
            this.txtLocalidad.Name = "txtLocalidad";
            this.txtLocalidad.Size = new System.Drawing.Size(349, 27);
            this.txtLocalidad.TabIndex = 11;
            // 
            // txtProvincia
            // 
            this.txtProvincia.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtProvincia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProvincia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtProvincia.Location = new System.Drawing.Point(118, 273);
            this.txtProvincia.Name = "txtProvincia";
            this.txtProvincia.Size = new System.Drawing.Size(349, 27);
            this.txtProvincia.TabIndex = 12;
            // 
            // txtTarjeta
            // 
            this.txtTarjeta.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtTarjeta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTarjeta.Location = new System.Drawing.Point(118, 327);
            this.txtTarjeta.Name = "txtTarjeta";
            this.txtTarjeta.Size = new System.Drawing.Size(349, 27);
            this.txtTarjeta.TabIndex = 13;
            // 
            // btnGuardar
            // 
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGuardar.Location = new System.Drawing.Point(18, 398);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(139, 42);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // frmDatosCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 503);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.tlpDatosCliente);
            this.Name = "frmDatosCliente";
            this.Text = "DATOS DEL CLIENTE";
            this.tlpDatosCliente.ResumeLayout(false);
            this.tlpDatosCliente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpDatosCliente;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelApellido;
        private System.Windows.Forms.Label labelTelefono;
        private System.Windows.Forms.Label labelDireccion;
        private System.Windows.Forms.Label labelLocalidad;
        private System.Windows.Forms.Label labelProvincia;
        private System.Windows.Forms.Label labelTarjeta;
        private System.Windows.Forms.TextBox txtTarjeta;
        private System.Windows.Forms.TextBox txtProvincia;
        private System.Windows.Forms.TextBox txtLocalidad;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnGuardar;
    }
}