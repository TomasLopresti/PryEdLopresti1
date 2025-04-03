namespace PryEdLopresti
{
    partial class FrmProvincia
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
            this.txtProvincias = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGrabarProv = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.dgvProvincia = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProvincia)).BeginInit();
            this.SuspendLayout();
            // 
            // txtProvincias
            // 
            this.txtProvincias.Location = new System.Drawing.Point(136, 13);
            this.txtProvincias.Name = "txtProvincias";
            this.txtProvincias.Size = new System.Drawing.Size(100, 20);
            this.txtProvincias.TabIndex = 0;
            this.txtProvincias.TextChanged += new System.EventHandler(this.txtProvincias_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Provincias:";
            // 
            // btnGrabarProv
            // 
            this.btnGrabarProv.Location = new System.Drawing.Point(66, 91);
            this.btnGrabarProv.Name = "btnGrabarProv";
            this.btnGrabarProv.Size = new System.Drawing.Size(75, 23);
            this.btnGrabarProv.TabIndex = 2;
            this.btnGrabarProv.Text = "Grabar";
            this.btnGrabarProv.UseVisualStyleBackColor = true;
            this.btnGrabarProv.Click += new System.EventHandler(this.btnGrabarProv_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Codigo:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(136, 54);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 5;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            // 
            // dgvProvincia
            // 
            this.dgvProvincia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProvincia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvProvincia.Location = new System.Drawing.Point(12, 120);
            this.dgvProvincia.Name = "dgvProvincia";
            this.dgvProvincia.Size = new System.Drawing.Size(240, 262);
            this.dgvProvincia.TabIndex = 6;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Codigo";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
            this.Column2.Name = "Column2";
            // 
            // FrmProvincia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 386);
            this.Controls.Add(this.dgvProvincia);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGrabarProv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtProvincias);
            this.Name = "FrmProvincia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Provincia";
            this.Load += new System.EventHandler(this.FrmProvincia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProvincia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtProvincias;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGrabarProv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.DataGridView dgvProvincia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}