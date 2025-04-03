namespace PryEdLopresti
{
    partial class FrmCiudades
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
            this.btnGrabarCiud = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCiudades = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigoPostal = new System.Windows.Forms.TextBox();
            this.dgvCiudades = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCiudades)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGrabarCiud
            // 
            this.btnGrabarCiud.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnGrabarCiud.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnGrabarCiud.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrabarCiud.Location = new System.Drawing.Point(60, 90);
            this.btnGrabarCiud.Name = "btnGrabarCiud";
            this.btnGrabarCiud.Size = new System.Drawing.Size(75, 27);
            this.btnGrabarCiud.TabIndex = 0;
            this.btnGrabarCiud.Text = "Grabar";
            this.btnGrabarCiud.UseVisualStyleBackColor = false;
            this.btnGrabarCiud.Click += new System.EventHandler(this.btnGrabarCiud_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ciudades:";
            // 
            // txtCiudades
            // 
            this.txtCiudades.Location = new System.Drawing.Point(93, 13);
            this.txtCiudades.Name = "txtCiudades";
            this.txtCiudades.Size = new System.Drawing.Size(100, 20);
            this.txtCiudades.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Codigo Postal:";
            // 
            // txtCodigoPostal
            // 
            this.txtCodigoPostal.Location = new System.Drawing.Point(93, 52);
            this.txtCodigoPostal.Name = "txtCodigoPostal";
            this.txtCodigoPostal.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoPostal.TabIndex = 5;
            // 
            // dgvCiudades
            // 
            this.dgvCiudades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCiudades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvCiudades.Location = new System.Drawing.Point(12, 123);
            this.dgvCiudades.Name = "dgvCiudades";
            this.dgvCiudades.Size = new System.Drawing.Size(243, 254);
            this.dgvCiudades.TabIndex = 6;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Ciudades";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Codigo Postal";
            this.Column2.Name = "Column2";
            // 
            // FrmCiudades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(268, 382);
            this.Controls.Add(this.dgvCiudades);
            this.Controls.Add(this.txtCodigoPostal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCiudades);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGrabarCiud);
            this.Name = "FrmCiudades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ciudades";
            this.Load += new System.EventHandler(this.FrmCiudades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCiudades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGrabarCiud;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCiudades;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodigoPostal;
        private System.Windows.Forms.DataGridView dgvCiudades;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}