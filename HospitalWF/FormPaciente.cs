using HospitalWF.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Windows.Forms;

namespace HospitalWF
{
    public partial class FormPaciente : Form
    {
        Paciente oPacienteForm = new Paciente();
        List<Medico> lstMedicos = new List<Medico>();

        public FormPaciente(List<Medico> Medicos)
        {
            InitializeComponent();
            lstMedicos = Medicos;
            BuscarMedicos();
        }

        public FormPaciente(Paciente oPacienteFormPadre, List<Medico> Medicos)
        {
            InitializeComponent();
            oPacienteForm = oPacienteFormPadre;
            lstMedicos = Medicos;
            txtNombre.Text = oPacienteForm.Nombre;
            txtEdad.Text = oPacienteForm.Edad.ToString();
            txtNif.Text = oPacienteForm.DocIdentidad;
            txtMail.Text = oPacienteForm.Email;
            txtTelf.Text = oPacienteForm.NumTelefono.ToString();
            txtEnfermedad.Text = oPacienteForm.Enfermedad;
            txtTratamiento.Text = oPacienteForm.Tratamiento;
            lblNumCol.Text = oPacienteForm.MedicoAsignado.ToString();
            ObtenerGenero(oPacienteForm);
            BuscarMedicos();
        }

        private void ObtenerGenero(Paciente oPaciente)
        {
            if (oPaciente.Genero)
                rbHombre.Checked = true;
            else
                rbMujer.Checked = true;
        }

        public void BuscarMedicos()
        {
            List<Medico> lstAuxiliar = new List<Medico>();
            var compareInfo = CultureInfo.InvariantCulture.CompareInfo;

            lstAuxiliar.AddRange(lstMedicos);

            var bindingList = new BindingList<Medico>(lstAuxiliar);
            var source = new BindingSource(bindingList, null);

            grdMedicos.DataSource = source;

            if (source.Count > 0)
            {
                grdMedicos.Columns["Ocupacion"].Visible = false;
                grdMedicos.Columns["Genero"].Visible = false;

                grdMedicos.Columns["NumColegiado"].DisplayIndex = 0;
                grdMedicos.Columns["Especialidad"].DisplayIndex = 8;

                grdMedicos.CurrentCell = grdMedicos.Rows[0].Cells[2];
            }
        }

        private void grdMedicos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblNumCol.Text = lstMedicos[grdMedicos.CurrentRow.Index].NumColegiado.ToString();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Persona oPersona = new Persona(txtNombre.Text, Convert.ToInt32(txtEdad.Text), rbHombre.Checked, txtNif.Text
                                      , txtMail.Text, Convert.ToInt32(txtTelf.Text), "Medico");

            Paciente oPaciente = new Paciente(oPersona, txtEnfermedad.Text, txtTratamiento.Text);

            oPaciente.MedicoAsignado = Convert.ToInt32(lblNumCol.Text);

            FormMenu oFormMenu = Owner as FormMenu;

            if (oFormMenu.lstPacientes.Contains(oPacienteForm))
            {
                oFormMenu.lstPacientes.Remove(oPacienteForm);
                oFormMenu.lstPersonas.Remove(oPacienteForm);
            }

            oFormMenu.lstPersonas.Insert(0, oPaciente);
            oFormMenu.lstPacientes.Insert(0, oPaciente);
            oFormMenu.BuscarPacientes();
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
