namespace HospitalWF
{
    partial class FormMenu
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
            this.cboFiltro = new System.Windows.Forms.ComboBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblFiltros = new System.Windows.Forms.Label();
            this.pnlFiltros = new System.Windows.Forms.Panel();
            this.cboBuscarPorCampo = new System.Windows.Forms.ComboBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grdPersonal = new System.Windows.Forms.DataGridView();
            this.lblTituloGrd = new System.Windows.Forms.Label();
            this.pnlFiltros.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPersonal)).BeginInit();
            this.SuspendLayout();
            // 
            // cboFiltro
            // 
            this.cboFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboFiltro.FormattingEnabled = true;
            this.cboFiltro.Items.AddRange(new object[] {
            "Todos",
            "Médicos",
            "Pacientes"});
            this.cboFiltro.Location = new System.Drawing.Point(4, 16);
            this.cboFiltro.Margin = new System.Windows.Forms.Padding(4);
            this.cboFiltro.Name = "cboFiltro";
            this.cboFiltro.Size = new System.Drawing.Size(160, 24);
            this.cboFiltro.TabIndex = 2;
            this.cboFiltro.SelectedIndexChanged += new System.EventHandler(this.cboFiltro_SelectedIndexChanged);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(343, 16);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(809, 22);
            this.txtBuscar.TabIndex = 4;
            this.txtBuscar.TextChanged += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblFiltros
            // 
            this.lblFiltros.AutoSize = true;
            this.lblFiltros.Location = new System.Drawing.Point(29, 12);
            this.lblFiltros.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFiltros.Name = "lblFiltros";
            this.lblFiltros.Size = new System.Drawing.Size(126, 16);
            this.lblFiltros.TabIndex = 0;
            this.lblFiltros.Text = "Filtros de búsqueda";
            // 
            // pnlFiltros
            // 
            this.pnlFiltros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFiltros.Controls.Add(this.cboBuscarPorCampo);
            this.pnlFiltros.Controls.Add(this.cboFiltro);
            this.pnlFiltros.Controls.Add(this.txtBuscar);
            this.pnlFiltros.Location = new System.Drawing.Point(13, 22);
            this.pnlFiltros.Margin = new System.Windows.Forms.Padding(4);
            this.pnlFiltros.Name = "pnlFiltros";
            this.pnlFiltros.Size = new System.Drawing.Size(1159, 59);
            this.pnlFiltros.TabIndex = 1;
            // 
            // cboBuscarPorCampo
            // 
            this.cboBuscarPorCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBuscarPorCampo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboBuscarPorCampo.FormattingEnabled = true;
            this.cboBuscarPorCampo.Items.AddRange(new object[] {
            "Nombre",
            "Edad",
            "Sexo",
            "DocIdentidad",
            "Email",
            "NumTelefono"});
            this.cboBuscarPorCampo.Location = new System.Drawing.Point(173, 16);
            this.cboBuscarPorCampo.Margin = new System.Windows.Forms.Padding(4);
            this.cboBuscarPorCampo.Name = "cboBuscarPorCampo";
            this.cboBuscarPorCampo.Size = new System.Drawing.Size(160, 24);
            this.cboBuscarPorCampo.TabIndex = 3;
            this.cboBuscarPorCampo.SelectedIndexChanged += new System.EventHandler(this.cboBuscarPorCampo_SelectedIndexChanged);
            // 
            // btnModificar
            // 
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnModificar.Location = new System.Drawing.Point(995, 585);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(87, 34);
            this.btnModificar.TabIndex = 7;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnInsertar.Location = new System.Drawing.Point(903, 585);
            this.btnInsertar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(87, 34);
            this.btnInsertar.TabIndex = 6;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnBuscar.Location = new System.Drawing.Point(811, 585);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(87, 34);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.TabStop = false;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Visible = false;
            this.btnBuscar.Click += new System.EventHandler(this.cboFiltro_SelectedIndexChanged);
            // 
            // btnEliminar
            // 
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnEliminar.Location = new System.Drawing.Point(1087, 585);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(87, 34);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.grdPersonal);
            this.panel1.Location = new System.Drawing.Point(13, 112);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1158, 456);
            this.panel1.TabIndex = 10;
            // 
            // grdPersonal
            // 
            this.grdPersonal.AllowUserToAddRows = false;
            this.grdPersonal.AllowUserToDeleteRows = false;
            this.grdPersonal.AllowUserToOrderColumns = true;
            this.grdPersonal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grdPersonal.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.grdPersonal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPersonal.Location = new System.Drawing.Point(15, 14);
            this.grdPersonal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grdPersonal.Name = "grdPersonal";
            this.grdPersonal.ReadOnly = true;
            this.grdPersonal.RowHeadersWidth = 51;
            this.grdPersonal.RowTemplate.Height = 24;
            this.grdPersonal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdPersonal.Size = new System.Drawing.Size(1128, 429);
            this.grdPersonal.TabIndex = 11;
            this.grdPersonal.TabStop = false;
            // 
            // lblTituloGrd
            // 
            this.lblTituloGrd.AutoSize = true;
            this.lblTituloGrd.Location = new System.Drawing.Point(29, 101);
            this.lblTituloGrd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTituloGrd.Name = "lblTituloGrd";
            this.lblTituloGrd.Size = new System.Drawing.Size(47, 16);
            this.lblTituloGrd.TabIndex = 11;
            this.lblTituloGrd.Text = "Todos";
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 625);
            this.Controls.Add(this.lblTituloGrd);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.lblFiltros);
            this.Controls.Add(this.pnlFiltros);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.btnModificar);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormMenu";
            this.Text = "Hospital Menu";
            this.pnlFiltros.ResumeLayout(false);
            this.pnlFiltros.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdPersonal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cboFiltro;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblFiltros;
        private System.Windows.Forms.Panel pnlFiltros;
        private System.Windows.Forms.ComboBox cboBuscarPorCampo;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView grdPersonal;
        private System.Windows.Forms.Label lblTituloGrd;
    }
}

