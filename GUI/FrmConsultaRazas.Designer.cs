namespace GUI
{
    partial class FrmConsultaRazas
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
            this.dgvRazas = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSalir = new System.Windows.Forms.Button();
            this.grillaPrueba = new System.Windows.Forms.DataGridView();
            this.grilla3 = new System.Windows.Forms.DataGridView();
            this.menuOpciones = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRazas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaPrueba)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grilla3)).BeginInit();
            this.menuOpciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvRazas
            // 
            this.dgvRazas.AllowUserToAddRows = false;
            this.dgvRazas.AllowUserToDeleteRows = false;
            this.dgvRazas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRazas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvRazas.ContextMenuStrip = this.menuOpciones;
            this.dgvRazas.Location = new System.Drawing.Point(32, 38);
            this.dgvRazas.Name = "dgvRazas";
            this.dgvRazas.ReadOnly = true;
            this.dgvRazas.RowHeadersWidth = 62;
            this.dgvRazas.RowTemplate.Height = 24;
            this.dgvRazas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRazas.Size = new System.Drawing.Size(656, 153);
            this.dgvRazas.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Codigo Raza";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 85;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre Raza";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Nombre Especie";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 150;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(409, 533);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(338, 23);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // grillaPrueba
            // 
            this.grillaPrueba.AllowUserToAddRows = false;
            this.grillaPrueba.AllowUserToDeleteRows = false;
            this.grillaPrueba.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaPrueba.Location = new System.Drawing.Point(32, 208);
            this.grillaPrueba.Name = "grillaPrueba";
            this.grillaPrueba.ReadOnly = true;
            this.grillaPrueba.RowHeadersWidth = 62;
            this.grillaPrueba.RowTemplate.Height = 24;
            this.grillaPrueba.Size = new System.Drawing.Size(656, 136);
            this.grillaPrueba.TabIndex = 2;
            // 
            // grilla3
            // 
            this.grilla3.AllowUserToAddRows = false;
            this.grilla3.AllowUserToDeleteRows = false;
            this.grilla3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilla3.Location = new System.Drawing.Point(32, 360);
            this.grilla3.Name = "grilla3";
            this.grilla3.ReadOnly = true;
            this.grilla3.RowHeadersWidth = 62;
            this.grilla3.RowTemplate.Height = 24;
            this.grilla3.Size = new System.Drawing.Size(656, 136);
            this.grilla3.TabIndex = 3;
            // 
            // menuOpciones
            // 
            this.menuOpciones.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuOpciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eliminarToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuOpciones.Name = "menuOpciones";
            this.menuOpciones.Size = new System.Drawing.Size(147, 68);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(240, 32);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(240, 32);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // FrmConsultaRazas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 640);
            this.Controls.Add(this.grilla3);
            this.Controls.Add(this.grillaPrueba);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgvRazas);
            this.Name = "FrmConsultaRazas";
            this.Text = "FrmConsultaRazas";
            this.Load += new System.EventHandler(this.FrmConsultaRazas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRazas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaPrueba)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grilla3)).EndInit();
            this.menuOpciones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRazas;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView grillaPrueba;
        private System.Windows.Forms.DataGridView grilla3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.ContextMenuStrip menuOpciones;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}