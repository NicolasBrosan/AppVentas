namespace AppVentasFer
{
    partial class frmVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVenta));
            this.dgvMuestrarioLibros = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMuestrarioLibros)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMuestrarioLibros
            // 
            this.dgvMuestrarioLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMuestrarioLibros.Location = new System.Drawing.Point(24, 301);
            this.dgvMuestrarioLibros.Name = "dgvMuestrarioLibros";
            this.dgvMuestrarioLibros.ReadOnly = true;
            this.dgvMuestrarioLibros.RowHeadersWidth = 53;
            this.dgvMuestrarioLibros.RowTemplate.Height = 31;
            this.dgvMuestrarioLibros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMuestrarioLibros.Size = new System.Drawing.Size(1040, 234);
            this.dgvMuestrarioLibros.TabIndex = 0;
            // 
            // frmVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 547);
            this.Controls.Add(this.dgvMuestrarioLibros);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmVenta";
            this.Text = "frmVenta";
            this.Load += new System.EventHandler(this.frmVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMuestrarioLibros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMuestrarioLibros;
    }
}