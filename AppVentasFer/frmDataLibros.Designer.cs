namespace AppVentasFer
{
    partial class frmDataLibros
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
            this.dgvDatosLibros = new System.Windows.Forms.DataGridView();
            this.labelFiltrar = new System.Windows.Forms.Label();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosLibros)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDatosLibros
            // 
            this.dgvDatosLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosLibros.Location = new System.Drawing.Point(12, 101);
            this.dgvDatosLibros.Name = "dgvDatosLibros";
            this.dgvDatosLibros.RowHeadersWidth = 53;
            this.dgvDatosLibros.RowTemplate.Height = 31;
            this.dgvDatosLibros.Size = new System.Drawing.Size(1036, 441);
            this.dgvDatosLibros.TabIndex = 0;
            // 
            // labelFiltrar
            // 
            this.labelFiltrar.AutoSize = true;
            this.labelFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.064F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelFiltrar.Location = new System.Drawing.Point(12, 59);
            this.labelFiltrar.Name = "labelFiltrar";
            this.labelFiltrar.Size = new System.Drawing.Size(171, 17);
            this.labelFiltrar.TabIndex = 1;
            this.labelFiltrar.Text = "FILTRAR POR NOMBRE :";
            // 
            // txtFiltro
            // 
            this.txtFiltro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFiltro.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.064F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFiltro.Location = new System.Drawing.Point(189, 59);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(273, 23);
            this.txtFiltro.TabIndex = 2;
            // 
            // frmDataLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 665);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.labelFiltrar);
            this.Controls.Add(this.dgvDatosLibros);
            this.Name = "frmDataLibros";
            this.Text = "DATOS DE LIBROS";
            this.Load += new System.EventHandler(this.frmDataLibros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosLibros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDatosLibros;
        private System.Windows.Forms.Label labelFiltrar;
        private System.Windows.Forms.TextBox txtFiltro;
    }
}