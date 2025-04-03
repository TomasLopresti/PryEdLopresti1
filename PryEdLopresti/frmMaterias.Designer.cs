namespace PryEdLopresti
{
    partial class frmMaterias
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
            this.txtMateria = new System.Windows.Forms.TextBox();
            this.txtNota = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.dgvMostrarMat = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarMat)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMateria
            // 
            this.txtMateria.Location = new System.Drawing.Point(145, 53);
            this.txtMateria.Name = "txtMateria";
            this.txtMateria.Size = new System.Drawing.Size(100, 20);
            this.txtMateria.TabIndex = 0;
            // 
            // txtNota
            // 
            this.txtNota.Location = new System.Drawing.Point(145, 93);
            this.txtNota.Name = "txtNota";
            this.txtNota.Size = new System.Drawing.Size(100, 20);
            this.txtNota.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Materia";
            // 
            // lblPromedio
            // 
            this.lblPromedio.AutoSize = true;
            this.lblPromedio.Location = new System.Drawing.Point(210, 137);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(0, 13);
            this.lblPromedio.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(157, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Promedio:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nota";
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(67, 132);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(75, 23);
            this.btnGrabar.TabIndex = 6;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // dgvMostrarMat
            // 
            this.dgvMostrarMat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostrarMat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Nota});
            this.dgvMostrarMat.Location = new System.Drawing.Point(12, 177);
            this.dgvMostrarMat.Name = "dgvMostrarMat";
            this.dgvMostrarMat.Size = new System.Drawing.Size(245, 150);
            this.dgvMostrarMat.TabIndex = 7;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Materia";
            this.Column1.Name = "Column1";
            // 
            // Nota
            // 
            this.Nota.HeaderText = "Nota";
            this.Nota.Name = "Nota";
            // 
            // frmMaterias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 336);
            this.Controls.Add(this.dgvMostrarMat);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblPromedio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNota);
            this.Controls.Add(this.txtMateria);
            this.Name = "frmMaterias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Materias";
            this.Load += new System.EventHandler(this.frmMaterias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarMat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMateria;
        private System.Windows.Forms.TextBox txtNota;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.DataGridView dgvMostrarMat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nota;
    }
}