namespace HospitalWF
{
    partial class Menu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.pnlMedico = new System.Windows.Forms.TabPage();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.grdMedicos = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.pnlMedico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMedicos)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.pnlMedico);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(18, 8);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1208, 583);
            this.tabControl1.TabIndex = 0;
            // 
            // pnlMedico
            // 
            this.pnlMedico.Controls.Add(this.btnBuscar);
            this.pnlMedico.Controls.Add(this.btnInsertar);
            this.pnlMedico.Controls.Add(this.btnModificar);
            this.pnlMedico.Controls.Add(this.grdMedicos);
            this.pnlMedico.Location = new System.Drawing.Point(4, 25);
            this.pnlMedico.Name = "pnlMedico";
            this.pnlMedico.Padding = new System.Windows.Forms.Padding(3);
            this.pnlMedico.Size = new System.Drawing.Size(1200, 554);
            this.pnlMedico.TabIndex = 0;
            this.pnlMedico.Text = "Médicos";
            this.pnlMedico.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnBuscar.Location = new System.Drawing.Point(907, 502);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(87, 34);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnInsertar.Location = new System.Drawing.Point(1093, 502);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(87, 34);
            this.btnInsertar.TabIndex = 2;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnModificar.Location = new System.Drawing.Point(1000, 502);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(87, 34);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // grdMedicos
            // 
            this.grdMedicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMedicos.Location = new System.Drawing.Point(20, 15);
            this.grdMedicos.Name = "grdMedicos";
            this.grdMedicos.RowHeadersWidth = 51;
            this.grdMedicos.RowTemplate.Height = 24;
            this.grdMedicos.Size = new System.Drawing.Size(1160, 470);
            this.grdMedicos.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1200, 554);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 593);
            this.Controls.Add(this.tabControl1);
            this.Name = "Menu";
            this.Text = "Hospital Menu";
            this.tabControl1.ResumeLayout(false);
            this.pnlMedico.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdMedicos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage pnlMedico;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView grdMedicos;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnModificar;
    }
}

