namespace AppVentasFer
{
    partial class frmMuestrarioDeLibros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMuestrarioDeLibros));
            this.dgvMuestrario = new System.Windows.Forms.DataGridView();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.labelNombre = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMuestrario)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMuestrario
            // 
            this.dgvMuestrario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMuestrario.Location = new System.Drawing.Point(12, 93);
            this.dgvMuestrario.Name = "dgvMuestrario";
            this.dgvMuestrario.ReadOnly = true;
            this.dgvMuestrario.RowHeadersWidth = 53;
            this.dgvMuestrario.RowTemplate.Height = 31;
            this.dgvMuestrario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMuestrario.Size = new System.Drawing.Size(656, 318);
            this.dgvMuestrario.TabIndex = 0;
            this.dgvMuestrario.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNuestrario_CellDoubleClick);
            // 
            // txtFiltro
            // 
            this.txtFiltro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFiltro.Location = new System.Drawing.Point(154, 41);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(310, 29);
            this.txtFiltro.TabIndex = 1;
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Segoe UI Historic", 10.944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNombre.Location = new System.Drawing.Point(58, 41);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(90, 25);
            this.labelNombre.TabIndex = 2;
            this.labelNombre.Text = "Nombre: ";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBuscar.Location = new System.Drawing.Point(505, 39);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(129, 31);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // frmMuestrarioDeLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 423);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.dgvMuestrario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMuestrarioDeLibros";
            this.Text = "frmMuestrarioDeLibros";
            this.Load += new System.EventHandler(this.frmMuestrarioDeLibros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMuestrario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMuestrario;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Button btnBuscar;
    }
}