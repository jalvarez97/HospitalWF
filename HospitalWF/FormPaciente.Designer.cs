namespace HospitalWF
{
    partial class FormPaciente
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
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblDatosPer = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblEdad = new System.Windows.Forms.Label();
            this.txtTelf = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.lblTelf = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbHombre = new System.Windows.Forms.RadioButton();
            this.rbMujer = new System.Windows.Forms.RadioButton();
            this.lblNif = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtNif = new System.Windows.Forms.TextBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.txtTratamiento = new System.Windows.Forms.TextBox();
            this.lblTratamiento = new System.Windows.Forms.Label();
            this.txtEnfermedad = new System.Windows.Forms.TextBox();
            this.lblEnfermedad = new System.Windows.Forms.Label();
            this.lblMedAsignado = new System.Windows.Forms.Label();
            this.lblNumCol = new System.Windows.Forms.Label();
            this.lblTituloGrd = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.grdMedicos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMedicos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAceptar.Location = new System.Drawing.Point(862, 580);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(87, 34);
            this.btnAceptar.TabIndex = 19;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCancelar.Location = new System.Drawing.Point(954, 580);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(87, 34);
            this.btnCancelar.TabIndex = 20;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblDatosPer
            // 
            this.lblDatosPer.AutoSize = true;
            this.lblDatosPer.Location = new System.Drawing.Point(39, 5);
            this.lblDatosPer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDatosPer.Name = "lblDatosPer";
            this.lblDatosPer.Size = new System.Drawing.Size(115, 16);
            this.lblDatosPer.TabIndex = 0;
            this.lblDatosPer.Text = "Datos Personales";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblSexo);
            this.panel2.Controls.Add(this.lblNombre);
            this.panel2.Controls.Add(this.txtNombre);
            this.panel2.Controls.Add(this.lblEdad);
            this.panel2.Controls.Add(this.txtTelf);
            this.panel2.Controls.Add(this.txtEdad);
            this.panel2.Controls.Add(this.lblTelf);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.lblNif);
            this.panel2.Controls.Add(this.txtMail);
            this.panel2.Controls.Add(this.txtNif);
            this.panel2.Controls.Add(this.lblMail);
            this.panel2.Location = new System.Drawing.Point(27, 15);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1014, 107);
            this.panel2.TabIndex = 27;
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(804, 6);
            this.lblSexo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(41, 16);
            this.lblSexo.TabIndex = 11;
            this.lblSexo.Text = "Sexo:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(11, 28);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(59, 16);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(81, 25);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(132, 22);
            this.txtNombre.TabIndex = 2;
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(408, 28);
            this.lblEdad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(43, 16);
            this.lblEdad.TabIndex = 5;
            this.lblEdad.Text = "Edad:";
            // 
            // txtTelf
            // 
            this.txtTelf.Location = new System.Drawing.Point(81, 57);
            this.txtTelf.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTelf.Name = "txtTelf";
            this.txtTelf.Size = new System.Drawing.Size(132, 22);
            this.txtTelf.TabIndex = 8;
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(463, 25);
            this.txtEdad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(132, 22);
            this.txtEdad.TabIndex = 6;
            // 
            // lblTelf
            // 
            this.lblTelf.AutoSize = true;
            this.lblTelf.Location = new System.Drawing.Point(4, 60);
            this.lblTelf.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelf.Name = "lblTelf";
            this.lblTelf.Size = new System.Drawing.Size(64, 16);
            this.lblTelf.TabIndex = 7;
            this.lblTelf.Text = "Teléfono:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.rbHombre);
            this.panel1.Controls.Add(this.rbMujer);
            this.panel1.Location = new System.Drawing.Point(795, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(198, 77);
            this.panel1.TabIndex = 16;
            // 
            // rbHombre
            // 
            this.rbHombre.AutoSize = true;
            this.rbHombre.Location = new System.Drawing.Point(17, 15);
            this.rbHombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbHombre.Name = "rbHombre";
            this.rbHombre.Size = new System.Drawing.Size(77, 20);
            this.rbHombre.TabIndex = 12;
            this.rbHombre.TabStop = true;
            this.rbHombre.Text = "Hombre";
            this.rbHombre.UseVisualStyleBackColor = true;
            // 
            // rbMujer
            // 
            this.rbMujer.AutoSize = true;
            this.rbMujer.Location = new System.Drawing.Point(17, 44);
            this.rbMujer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbMujer.Name = "rbMujer";
            this.rbMujer.Size = new System.Drawing.Size(61, 20);
            this.rbMujer.TabIndex = 13;
            this.rbMujer.TabStop = true;
            this.rbMujer.Text = "Mujer";
            this.rbMujer.UseVisualStyleBackColor = true;
            // 
            // lblNif
            // 
            this.lblNif.AutoSize = true;
            this.lblNif.Location = new System.Drawing.Point(223, 28);
            this.lblNif.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNif.Name = "lblNif";
            this.lblNif.Size = new System.Drawing.Size(31, 16);
            this.lblNif.TabIndex = 3;
            this.lblNif.Text = "NIF:";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(267, 57);
            this.txtMail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(132, 22);
            this.txtMail.TabIndex = 10;
            // 
            // txtNif
            // 
            this.txtNif.Location = new System.Drawing.Point(267, 25);
            this.txtNif.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNif.Name = "txtNif";
            this.txtNif.Size = new System.Drawing.Size(132, 22);
            this.txtNif.TabIndex = 4;
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(223, 60);
            this.lblMail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(44, 16);
            this.lblMail.TabIndex = 9;
            this.lblMail.Text = "Email:";
            // 
            // txtTratamiento
            // 
            this.txtTratamiento.Location = new System.Drawing.Point(396, 149);
            this.txtTratamiento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTratamiento.Name = "txtTratamiento";
            this.txtTratamiento.Size = new System.Drawing.Size(132, 22);
            this.txtTratamiento.TabIndex = 17;
            // 
            // lblTratamiento
            // 
            this.lblTratamiento.AutoSize = true;
            this.lblTratamiento.Location = new System.Drawing.Point(300, 153);
            this.lblTratamiento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTratamiento.Name = "lblTratamiento";
            this.lblTratamiento.Size = new System.Drawing.Size(82, 16);
            this.lblTratamiento.TabIndex = 16;
            this.lblTratamiento.Text = "Tratamiento:";
            // 
            // txtEnfermedad
            // 
            this.txtEnfermedad.Location = new System.Drawing.Point(129, 149);
            this.txtEnfermedad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEnfermedad.Name = "txtEnfermedad";
            this.txtEnfermedad.Size = new System.Drawing.Size(132, 22);
            this.txtEnfermedad.TabIndex = 15;
            // 
            // lblEnfermedad
            // 
            this.lblEnfermedad.AutoSize = true;
            this.lblEnfermedad.Location = new System.Drawing.Point(32, 153);
            this.lblEnfermedad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEnfermedad.Name = "lblEnfermedad";
            this.lblEnfermedad.Size = new System.Drawing.Size(84, 16);
            this.lblEnfermedad.TabIndex = 14;
            this.lblEnfermedad.Text = "Enfermedad:";
            // 
            // lblMedAsignado
            // 
            this.lblMedAsignado.AutoSize = true;
            this.lblMedAsignado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedAsignado.Location = new System.Drawing.Point(583, 150);
            this.lblMedAsignado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMedAsignado.Name = "lblMedAsignado";
            this.lblMedAsignado.Size = new System.Drawing.Size(147, 18);
            this.lblMedAsignado.TabIndex = 17;
            this.lblMedAsignado.Text = "Médico Asignado: ";
            // 
            // lblNumCol
            // 
            this.lblNumCol.AutoSize = true;
            this.lblNumCol.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumCol.Location = new System.Drawing.Point(757, 153);
            this.lblNumCol.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumCol.Name = "lblNumCol";
            this.lblNumCol.Size = new System.Drawing.Size(104, 17);
            this.lblNumCol.TabIndex = 28;
            this.lblNumCol.Text = "Num Colegiado";
            // 
            // lblTituloGrd
            // 
            this.lblTituloGrd.AutoSize = true;
            this.lblTituloGrd.Location = new System.Drawing.Point(-143, 13);
            this.lblTituloGrd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTituloGrd.Name = "lblTituloGrd";
            this.lblTituloGrd.Size = new System.Drawing.Size(47, 16);
            this.lblTituloGrd.TabIndex = 30;
            this.lblTituloGrd.Text = "Todos";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.grdMedicos);
            this.panel3.Location = new System.Drawing.Point(27, 211);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1014, 349);
            this.panel3.TabIndex = 29;
            // 
            // grdMedicos
            // 
            this.grdMedicos.AllowUserToAddRows = false;
            this.grdMedicos.AllowUserToDeleteRows = false;
            this.grdMedicos.AllowUserToOrderColumns = true;
            this.grdMedicos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grdMedicos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.grdMedicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMedicos.Location = new System.Drawing.Point(10, 15);
            this.grdMedicos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grdMedicos.Name = "grdMedicos";
            this.grdMedicos.ReadOnly = true;
            this.grdMedicos.RowHeadersWidth = 51;
            this.grdMedicos.RowTemplate.Height = 24;
            this.grdMedicos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdMedicos.Size = new System.Drawing.Size(992, 318);
            this.grdMedicos.TabIndex = 11;
            this.grdMedicos.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 200);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 16);
            this.label1.TabIndex = 31;
            this.label1.Text = "Asignar médico";
            // 
            // FormPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 625);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTituloGrd);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.lblNumCol);
            this.Controls.Add(this.lblMedAsignado);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblDatosPer);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtTratamiento);
            this.Controls.Add(this.lblTratamiento);
            this.Controls.Add(this.txtEnfermedad);
            this.Controls.Add(this.lblEnfermedad);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormPaciente";
            this.Text = "Paciente";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdMedicos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblDatosPer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.TextBox txtTelf;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Label lblTelf;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbHombre;
        private System.Windows.Forms.RadioButton rbMujer;
        private System.Windows.Forms.Label lblNif;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtNif;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.TextBox txtTratamiento;
        private System.Windows.Forms.Label lblTratamiento;
        private System.Windows.Forms.TextBox txtEnfermedad;
        private System.Windows.Forms.Label lblEnfermedad;
        private System.Windows.Forms.Label lblMedAsignado;
        private System.Windows.Forms.Label lblNumCol;
        private System.Windows.Forms.Label lblTituloGrd;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView grdMedicos;
        private System.Windows.Forms.Label label1;
    }
}