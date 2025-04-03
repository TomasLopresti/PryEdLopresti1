namespace PryEdLopresti
{
    partial class frmMeses
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
            this.txtMeses = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.dgvMostrarMes = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTareas = new System.Windows.Forms.TextBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarMes)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMeses
            // 
            this.txtMeses.Location = new System.Drawing.Point(132, 20);
            this.txtMeses.Name = "txtMeses";
            this.txtMeses.Size = new System.Drawing.Size(100, 20);
            this.txtMeses.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Meses";
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(89, 89);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(75, 23);
            this.btnGrabar.TabIndex = 2;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // dgvMostrarMes
            // 
            this.dgvMostrarMes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostrarMes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvMostrarMes.Location = new System.Drawing.Point(12, 142);
            this.dgvMostrarMes.Name = "dgvMostrarMes";
            this.dgvMostrarMes.Size = new System.Drawing.Size(344, 236);
            this.dgvMostrarMes.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tareas";
            // 
            // txtTareas
            // 
            this.txtTareas.Location = new System.Drawing.Point(132, 56);
            this.txtTareas.Name = "txtTareas";
            this.txtTareas.Size = new System.Drawing.Size(100, 20);
            this.txtTareas.TabIndex = 5;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mes";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tarea";
            this.Column2.Name = "Column2";
            this.Column2.Width = 200;
            // 
            // frmMeses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 386);
            this.Controls.Add(this.txtTareas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvMostrarMes);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMeses);
            this.Name = "frmMeses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Meses";
            this.Load += new System.EventHandler(this.frmMeses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarMes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMeses;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.DataGridView dgvMostrarMes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTareas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}