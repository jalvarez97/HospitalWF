using HospitalWF.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace HospitalWF
{
    public partial class FormMedico : Form
    {        
        Medico oMedicoForm = new Medico();
        List<Paciente> lstPacientes = new List<Paciente>(); 

        public FormMedico()
        {
            InitializeComponent();
        }

        public FormMedico(Medico oMedicoFormPadre, List<Paciente> Pacientes)
        {
            InitializeComponent();
            txtColegiado.Enabled = false;
            oMedicoForm = oMedicoFormPadre;
            lstPacientes = Pacientes;
            txtNombre.Text = oMedicoForm.Nombre;
            txtEdad.Text = oMedicoForm.Edad.ToString();
            txtNif.Text = oMedicoForm.DocIdentidad;
            txtMail.Text = oMedicoForm.Email;
            txtTelf.Text = oMedicoForm.NumTelefono.ToString();
            txtColegiado.Text = oMedicoForm.NumColegiado.ToString();
            txtEspe.Text = oMedicoForm.Especialidad;
            ObtenerGenero(oMedicoForm);
            BuscarPacientesAsignados();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Persona oPersona = new Persona(txtNombre.Text, Convert.ToInt32(txtEdad.Text), rbHombre.Checked, txtNif.Text
                                        , txtMail.Text, Convert.ToInt32(txtTelf.Text), "Medico");

            Medico oMedico = new Medico(oPersona, Convert.ToInt32(txtColegiado.Text), txtEspe.Text);            

            FormMenu oFormMenu = Owner as FormMenu;            

            if (oFormMenu.lstMedicos.Contains(oMedicoForm))
            {
                oFormMenu.lstMedicos.Remove(oMedicoForm);
                oFormMenu.lstPersonas.Remove(oMedicoForm);
            }

            oFormMenu.lstPersonas.Insert(0, oMedico);
            oFormMenu.lstMedicos.Insert(0,oMedico);
            oFormMenu.BuscarMedicos();
            this.Close();
        }   

        private void ObtenerGenero(Medico oMedico)
        {
            if (oMedico.Genero)
                rbHombre.Checked = true;
            else
                rbMujer.Checked = true;
        }
        
        public void BuscarPacientesAsignados()
        {
            List<Paciente> lstAuxiliar = new List<Paciente>();
            var compareInfo = CultureInfo.InvariantCulture.CompareInfo;

            lstAuxiliar.AddRange(lstPacientes.Where(p => p.MedicoAsignado.ToString() == oMedicoForm.NumColegiado.ToString()));
             
            var bindingList = new BindingList<Paciente>(lstAuxiliar);
            var source = new BindingSource(bindingList, null);

            grdPacientes.DataSource = source;

            if (source.Count > 0)
            {
                grdPacientes.Columns["Ocupacion"].Visible = false;
                grdPacientes.Columns["Genero"].Visible = false;
                grdPacientes.Columns["MedicoAsignado"].Visible = false;

                grdPacientes.Columns["Enfermedad"].DisplayIndex = 9;
                grdPacientes.Columns["Tratamiento"].DisplayIndex = 9;

                grdPacientes.ReadOnly = true;
                grdPacientes.AllowUserToAddRows = false;

                //grdPacientes.CurrentCell = grdPacientes.Rows[0].Cells[2];
            }
        }
    }
}
