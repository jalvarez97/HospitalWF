namespace HospitalWF
{
    partial class FormMedico
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblEdad = new System.Windows.Forms.Label();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.rbHombre = new System.Windows.Forms.RadioButton();
            this.rbMujer = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblNif = new System.Windows.Forms.Label();
            this.txtNif = new System.Windows.Forms.TextBox();
            this.lblColegiado = new System.Windows.Forms.Label();
            this.txtColegiado = new System.Windows.Forms.TextBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.lblTelf = new System.Windows.Forms.Label();
            this.txtTelf = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEspe = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblDatosPer = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.grdPacientes = new System.Windows.Forms.DataGridView();
            this.lblTituloGrd = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPacientes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(11, 28);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(59, 16);
            this.lblNombre.TabIndex = 5;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(81, 25);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(132, 22);
            this.txtNombre.TabIndex = 6;
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(408, 28);
            this.lblEdad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(43, 16);
            this.lblEdad.TabIndex = 9;
            this.lblEdad.Text = "Edad:";
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(463, 25);
            this.txtEdad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(132, 22);
            this.txtEdad.TabIndex = 10;
            // 
            // rbHombre
            // 
            this.rbHombre.AutoSize = true;
            this.rbHombre.Location = new System.Drawing.Point(17, 15);
            this.rbHombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbHombre.Name = "rbHombre";
            this.rbHombre.Size = new System.Drawing.Size(77, 20);
            this.rbHombre.TabIndex = 17;
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
            this.rbMujer.TabIndex = 18;
            this.rbMujer.TabStop = true;
            this.rbMujer.Text = "Mujer";
            this.rbMujer.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.rbHombre);
            this.panel1.Controls.Add(this.rbMujer);
            this.panel1.Location = new System.Drawing.Point(643, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(198, 77);
            this.panel1.TabIndex = 16;
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(652, 2);
            this.lblSexo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(41, 16);
            this.lblSexo.TabIndex = 15;
            this.lblSexo.Text = "Sexo:";
            // 
            // lblNif
            // 
            this.lblNif.AutoSize = true;
            this.lblNif.Location = new System.Drawing.Point(223, 28);
            this.lblNif.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNif.Name = "lblNif";
            this.lblNif.Size = new System.Drawing.Size(31, 16);
            this.lblNif.TabIndex = 7;
            this.lblNif.Text = "NIF:";
            // 
            // txtNif
            // 
            this.txtNif.Location = new System.Drawing.Point(267, 25);
            this.txtNif.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNif.Name = "txtNif";
            this.txtNif.Size = new System.Drawing.Size(132, 22);
            this.txtNif.TabIndex = 8;
            // 
            // lblColegiado
            // 
            this.lblColegiado.AutoSize = true;
            this.lblColegiado.Location = new System.Drawing.Point(16, 22);
            this.lblColegiado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblColegiado.Name = "lblColegiado";
            this.lblColegiado.Size = new System.Drawing.Size(107, 16);
            this.lblColegiado.TabIndex = 0;
            this.lblColegiado.Text = "Num. Colegiado:";
            // 
            // txtColegiado
            // 
            this.txtColegiado.Location = new System.Drawing.Point(137, 18);
            this.txtColegiado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtColegiado.Name = "txtColegiado";
            this.txtColegiado.Size = new System.Drawing.Size(132, 22);
            this.txtColegiado.TabIndex = 1;
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(223, 60);
            this.lblMail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(44, 16);
            this.lblMail.TabIndex = 13;
            this.lblMail.Text = "Email:";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(267, 57);
            this.txtMail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(132, 22);
            this.txtMail.TabIndex = 14;
            // 
            // lblTelf
            // 
            this.lblTelf.AutoSize = true;
            this.lblTelf.Location = new System.Drawing.Point(4, 60);
            this.lblTelf.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelf.Name = "lblTelf";
            this.lblTelf.Size = new System.Drawing.Size(64, 16);
            this.lblTelf.TabIndex = 11;
            this.lblTelf.Text = "Teléfono:";
            // 
            // txtTelf
            // 
            this.txtTelf.Location = new System.Drawing.Point(81, 57);
            this.txtTelf.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTelf.Name = "txtTelf";
            this.txtTelf.Size = new System.Drawing.Size(132, 22);
            this.txtTelf.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(279, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Especialización:";
            // 
            // txtEspe
            // 
            this.txtEspe.Location = new System.Drawing.Point(397, 18);
            this.txtEspe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEspe.Name = "txtEspe";
            this.txtEspe.Size = new System.Drawing.Size(132, 22);
            this.txtEspe.TabIndex = 3;
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
            this.panel2.Location = new System.Drawing.Point(20, 69);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(882, 107);
            this.panel2.TabIndex = 18;
            // 
            // lblDatosPer
            // 
            this.lblDatosPer.AutoSize = true;
            this.lblDatosPer.Location = new System.Drawing.Point(32, 59);
            this.lblDatosPer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDatosPer.Name = "lblDatosPer";
            this.lblDatosPer.Size = new System.Drawing.Size(115, 16);
            this.lblDatosPer.TabIndex = 4;
            this.lblDatosPer.Text = "Datos Personales";
            // 
            // btnAceptar
            // 
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAceptar.Location = new System.Drawing.Point(724, 628);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(87, 34);
            this.btnAceptar.TabIndex = 21;
            this.btnAceptar.TabStop = false;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCancelar.Location = new System.Drawing.Point(816, 628);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(87, 34);
            this.btnCancelar.TabIndex = 20;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.grdPacientes);
            this.panel3.Location = new System.Drawing.Point(20, 204);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(882, 419);
            this.panel3.TabIndex = 22;
            // 
            // grdPacientes
            // 
            this.grdPacientes.AllowUserToAddRows = false;
            this.grdPacientes.AllowUserToDeleteRows = false;
            this.grdPacientes.AllowUserToOrderColumns = true;
            this.grdPacientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.grdPacientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.grdPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPacientes.Location = new System.Drawing.Point(18, 17);
            this.grdPacientes.Margin = new System.Windows.Forms.Padding(4);
            this.grdPacientes.Name = "grdPacientes";
            this.grdPacientes.ReadOnly = true;
            this.grdPacientes.RowHeadersWidth = 51;
            this.grdPacientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdPacientes.Size = new System.Drawing.Size(842, 386);
            this.grdPacientes.TabIndex = 20;
            this.grdPacientes.TabStop = false;
            // 
            // lblTituloGrd
            // 
            this.lblTituloGrd.AutoSize = true;
            this.lblTituloGrd.Location = new System.Drawing.Point(32, 193);
            this.lblTituloGrd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTituloGrd.Name = "lblTituloGrd";
            this.lblTituloGrd.Size = new System.Drawing.Size(134, 16);
            this.lblTituloGrd.TabIndex = 21;
            this.lblTituloGrd.Text = "Pacientes asignados";
            // 
            // FormMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 673);
            this.Controls.Add(this.lblTituloGrd);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblDatosPer);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtEspe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtColegiado);
            this.Controls.Add(this.lblColegiado);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormMedico";
            this.Text = "Médico";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdPacientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.RadioButton rbHombre;
        private System.Windows.Forms.RadioButton rbMujer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblNif;
        private System.Windows.Forms.TextBox txtNif;
        private System.Windows.Forms.Label lblColegiado;
        private System.Windows.Forms.TextBox txtColegiado;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label lblTelf;
        private System.Windows.Forms.TextBox txtTelf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEspe;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblDatosPer;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView grdPacientes;
        private System.Windows.Forms.Label lblTituloGrd;
    }
}