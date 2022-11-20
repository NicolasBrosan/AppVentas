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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelApellido = new System.Windows.Forms.Label();
            this.labelTelefono = new System.Windows.Forms.Label();
            this.labelDireccion = new System.Windows.Forms.Label();
            this.labelLocalidad = new System.Windows.Forms.Label();
            this.labelProvincia = new System.Windows.Forms.Label();
            this.labelTarjeta = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.00358F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.99642F));
            this.tableLayoutPanel1.Controls.Add(this.labelNombre, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelApellido, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelTelefono, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelDireccion, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelLocalidad, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.labelProvincia, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.labelTarjeta, 0, 6);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(14, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(515, 370);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // labelNombre
            // 
            this.labelNombre.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelNombre.AutoSize = true;
            this.labelNombre.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.labelNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNombre.Location = new System.Drawing.Point(32, 16);
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
            this.labelApellido.Location = new System.Drawing.Point(32, 68);
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
            this.labelTelefono.Location = new System.Drawing.Point(27, 120);
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
            this.labelDireccion.Location = new System.Drawing.Point(19, 172);
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
            this.labelLocalidad.Location = new System.Drawing.Point(19, 224);
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
            this.labelProvincia.Location = new System.Drawing.Point(22, 276);
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
            // frmDatosCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 508);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmDatosCliente";
            this.Text = "DATOS DEL CLIENTE";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelApellido;
        private System.Windows.Forms.Label labelTelefono;
        private System.Windows.Forms.Label labelDireccion;
        private System.Windows.Forms.Label labelLocalidad;
        private System.Windows.Forms.Label labelProvincia;
        private System.Windows.Forms.Label labelTarjeta;
    }
}