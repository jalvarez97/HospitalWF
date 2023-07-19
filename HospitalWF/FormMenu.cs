using AxWMPLib;
using HospitalWF.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace HospitalWF
{
    public partial class FormMenu : Form
    {
        Automatizacion oAutomatiza = new Automatizacion();
        
        public List<Persona> lstPersonas = new List<Persona>();
        public List<Medico> lstMedicos = new List<Medico>();
        public List<Paciente> lstPacientes = new List<Paciente>();

        public FormMenu()
        {
            InitializeComponent();
            InicializarForm();
        }

        private void InicializarForm()
        {
            lstMedicos.AddRange(oAutomatiza.GenerarMedicos(100));
            lstPacientes.AddRange(oAutomatiza.GenerarPacientes(1000, lstMedicos));
            lstPersonas.AddRange(lstMedicos);
            lstPersonas.AddRange(lstPacientes);

            cboFiltro.SelectedIndex = 0;
            cboBuscarPorCampo.SelectedIndex = 0;
        }      

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            switch (cboFiltro.SelectedIndex)
            {
                case 0:
                    BuscarPersonas();
                    break;
                case 1:
                    BuscarMedicos();
                    break;
                case 2:
                    BuscarPacientes();
                    break;
            }                 
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            switch (cboFiltro.SelectedIndex)
            {
                case 1:
                    FormMedico oFormM = new FormMedico();
                    AddOwnedForm(oFormM);
                    oFormM.Show();
                    break;
                case 2:
                    FormPaciente oFormP = new FormPaciente(lstMedicos);
                    AddOwnedForm(oFormP);
                    oFormP.Show();
                    break;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (grdPersonal.Rows.Count > 0)
            {
                switch (cboFiltro.SelectedIndex)
                {
                    case 1:
                        DataGridViewRow selectedRowMedico = grdPersonal.Rows[grdPersonal.CurrentRow.Index];
                        string sNifMedico = selectedRowMedico.Cells[6].Value.ToString();

                        List<Medico> lstMedicoAux = new List<Medico>();
                        lstMedicoAux.AddRange(lstMedicos.Where(p => p.DocIdentidad.ToString() == sNifMedico));

                        FormMedico oForm = new FormMedico(lstMedicoAux[0], lstPacientes);
                        AddOwnedForm(oForm);
                        oForm.Show();
                        break;
                    case 2:
                        DataGridViewRow selectedRowPaciente = grdPersonal.Rows[grdPersonal.CurrentRow.Index];
                        string sNifPaciente = selectedRowPaciente.Cells[7].Value.ToString();

                        List<Paciente> lstPacienteAux = new List<Paciente>();
                        lstPacienteAux.AddRange(lstPacientes.Where(p => p.DocIdentidad.ToString() == sNifPaciente));

                        FormPaciente oFormP = new FormPaciente(lstPacienteAux[0], lstMedicos);
                        AddOwnedForm(oFormP);
                        oFormP.Show();
                        break;
                }
            }           
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (grdPersonal.Rows.Count > 0)
            {
                switch (cboFiltro.SelectedIndex)
                {
                    case 1:
                        DataGridViewRow selectedRowMedico = grdPersonal.Rows[grdPersonal.CurrentRow.Index];
                        string sNifMedico = selectedRowMedico.Cells[6].Value.ToString();

                        List<Medico> lstMedicoAux = new List<Medico>();
                        lstMedicoAux.AddRange(lstMedicos.Where(p => p.DocIdentidad.ToString() == sNifMedico));

                        List<Persona> lstPersonaMAux = new List<Persona>();
                        lstPersonaMAux.AddRange(lstPersonas.Where(p => p.DocIdentidad.ToString() == sNifMedico));

                        lstPersonas.Remove(lstPersonaMAux[0]);
                        lstMedicos.Remove(lstMedicoAux[0]);
                        BuscarMedicos();
                        break;
                    case 2:
                        DataGridViewRow selectedRowPaciente = grdPersonal.Rows[grdPersonal.CurrentRow.Index];
                        string sNifPaciente = selectedRowPaciente.Cells[7].Value.ToString();

                        List<Paciente> lstPacienteAux = new List<Paciente>();
                        lstPacienteAux.AddRange(lstPacientes.Where(p => p.DocIdentidad.ToString() == sNifPaciente));

                        List<Persona> lstPersonaPAux = new List<Persona>();
                        lstPersonaPAux.AddRange(lstPersonas.Where(p => p.DocIdentidad.ToString() == sNifPaciente));

                        lstPersonas.Remove(lstPersonaPAux[0]);
                        lstPacientes.Remove(lstPacienteAux[0]);
                        BuscarPacientes();
                        break;
                }
            }                
        }
               
        private void cboFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboFiltro.SelectedIndex)
            {
                case 0:
                    BorrarElementosCombo();
                    cboBuscarPorCampo.Items.AddRange(new object[] {
                                                     "Ocupacion"});     
                    btnEliminar.Enabled = false;
                    btnInsertar.Enabled = false; 
                    btnModificar.Enabled = false;
                    lblTituloGrd.Text = "Lista de personas";

                    BuscarPersonas();                    
                    break;
                case 1:
                    BorrarElementosCombo();
                    cboBuscarPorCampo.Items.AddRange(new object[] {
                                                     "NumColegiado",
                                                     "Especialidad"});
                    btnEliminar.Enabled = true;
                    btnInsertar.Enabled = true;
                    btnModificar.Enabled = true;
                    lblTituloGrd.Text = "Lista de Médicos";
                    BuscarMedicos();
                    break;
                case 2:
                    BorrarElementosCombo();
                    cboBuscarPorCampo.Items.AddRange(new object[] {
                                                     "Enfermedad",
                                                     "Tratamiento",
                                                     "Médico asignado"});
                    btnEliminar.Enabled = true;
                    btnInsertar.Enabled = true;
                    btnModificar.Enabled = true;
                    lblTituloGrd.Text = "Lista de Pacientes";
                    BuscarPacientes();
                    break;
            }
        }

        private void cboBuscarPorCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtBuscar.Text = null;
            txtBuscar.Focus();
        }    
       
        private void BorrarElementosCombo()
        {
            cboBuscarPorCampo.SelectedIndex = 0;
            txtBuscar.Text = null;

            if (cboBuscarPorCampo.Items.Contains("Ocupacion"))
            {
                cboBuscarPorCampo.Items.Remove("Ocupacion");
            }

            if (cboBuscarPorCampo.Items.Contains("NumColegiado"))
            {
                cboBuscarPorCampo.Items.Remove("NumColegiado");
                cboBuscarPorCampo.Items.Remove("Especialidad");
            }

            if (cboBuscarPorCampo.Items.Contains("Enfermedad"))
            {
                cboBuscarPorCampo.Items.Remove("Enfermedad");
                cboBuscarPorCampo.Items.Remove("Tratamiento");
                cboBuscarPorCampo.Items.Remove("Médico asignado");
            }
        }

        private void BuscarPersonas()
        {
            List<Persona> lstAuxiliar = new List<Persona>();
            var compareInfo = CultureInfo.InvariantCulture.CompareInfo;
            
            switch (cboBuscarPorCampo.SelectedIndex)
            {
                case 0:
                    lstAuxiliar.AddRange(lstPersonas.Where(p => compareInfo.IndexOf(p.Nombre, txtBuscar.Text, CompareOptions.IgnoreCase) > -1));
                    break;
                case 1:
                    lstAuxiliar.AddRange(lstPersonas.Where(p => compareInfo.IndexOf(p.Edad.ToString(), txtBuscar.Text, CompareOptions.IgnoreCase) > -1));
                    break;
                case 2:
                    lstAuxiliar.AddRange(lstPersonas.Where(p => compareInfo.IndexOf(p.Sexo.ToString(), txtBuscar.Text, CompareOptions.IgnoreCase) > -1));
                    break;
                case 3:
                    lstAuxiliar.AddRange(lstPersonas.Where(p => compareInfo.IndexOf(p.DocIdentidad, txtBuscar.Text, CompareOptions.IgnoreCase) > -1));
                    break;
                case 4:
                    lstAuxiliar.AddRange(lstPersonas.Where(p => compareInfo.IndexOf(p.Email, txtBuscar.Text, CompareOptions.IgnoreCase) > -1));
                    break;
                case 5:
                    lstAuxiliar.AddRange(lstPersonas.Where(p => compareInfo.IndexOf(p.NumTelefono.ToString(), txtBuscar.Text, CompareOptions.IgnoreCase) > -1));
                    break;
                case 6:
                    lstAuxiliar.AddRange(lstPersonas.Where(p => compareInfo.IndexOf(p.Ocupacion, txtBuscar.Text, CompareOptions.IgnoreCase) > -1));
                    break;
            }
            
            var bindingList = new BindingList<Persona>(lstAuxiliar);
            var source = new BindingSource(bindingList, null);

            grdPersonal.DataSource = source;

            if (source.Count > 0)
            {
                grdPersonal.Columns["Ocupacion"].Visible = true;
                grdPersonal.Columns["Genero"].Visible = false;

                grdPersonal.CurrentCell = grdPersonal.Rows[0].Cells[0];
                txtBuscar.Focus();
            }
        }

        public void BuscarMedicos()
        {
            List<Medico> lstAuxiliar = new List<Medico>();
            var compareInfo = CultureInfo.InvariantCulture.CompareInfo;

            switch (cboBuscarPorCampo.SelectedIndex)
            {
                case 0:
                    lstAuxiliar.AddRange(lstMedicos.Where(p => compareInfo.IndexOf(p.Nombre, txtBuscar.Text, CompareOptions.IgnoreCase) > -1));
                    break;
                case 1:
                    lstAuxiliar.AddRange(lstMedicos.Where(p => compareInfo.IndexOf(p.Edad.ToString(), txtBuscar.Text, CompareOptions.IgnoreCase) > -1));
                    break;
                case 2:
                    lstAuxiliar.AddRange(lstMedicos.Where(p => compareInfo.IndexOf(p.Sexo.ToString(), txtBuscar.Text, CompareOptions.IgnoreCase) > -1));
                    break;
                case 3:
                    lstAuxiliar.AddRange(lstMedicos.Where(p => compareInfo.IndexOf(p.DocIdentidad, txtBuscar.Text, CompareOptions.IgnoreCase) > -1));
                    break;
                case 4:
                    lstAuxiliar.AddRange(lstMedicos.Where(p => compareInfo.IndexOf(p.Email, txtBuscar.Text, CompareOptions.IgnoreCase) > -1));
                    break;
                case 5:
                    lstAuxiliar.AddRange(lstMedicos.Where(p => compareInfo.IndexOf(p.NumTelefono.ToString(), txtBuscar.Text, CompareOptions.IgnoreCase) > -1));
                    break;
                case 6:
                    lstAuxiliar.AddRange(lstMedicos.Where(p => compareInfo.IndexOf(p.NumColegiado.ToString(), txtBuscar.Text, CompareOptions.IgnoreCase) > -1));
                    break;
                case 7:
                    lstAuxiliar.AddRange(lstMedicos.Where(p => compareInfo.IndexOf(p.Especialidad, txtBuscar.Text, CompareOptions.IgnoreCase) > -1));
                    break;
            }
            
            var bindingList = new BindingList<Medico>(lstAuxiliar);
            var source = new BindingSource(bindingList, null);

            grdPersonal.DataSource = source;

            if (source.Count > 0)
            {
                grdPersonal.Columns["Ocupacion"].Visible = false;
                grdPersonal.Columns["Genero"].Visible = false;

                grdPersonal.Columns["NumColegiado"].DisplayIndex = 0;
                grdPersonal.Columns["Especialidad"].DisplayIndex = 8;

                grdPersonal.CurrentCell = grdPersonal.Rows[0].Cells[2];
                txtBuscar.Focus();
            }
        }

        public void BuscarPacientes()
        {
            List<Paciente> lstAuxiliar = new List<Paciente>();
            var compareInfo = CultureInfo.InvariantCulture.CompareInfo;
                            
            switch (cboBuscarPorCampo.SelectedIndex)
            {
                case 0:
                    lstAuxiliar.AddRange(lstPacientes.Where(p => compareInfo.IndexOf(p.Nombre, txtBuscar.Text, CompareOptions.IgnoreCase) > -1));
                    break;
                case 1:
                    lstAuxiliar.AddRange(lstPacientes.Where(p => compareInfo.IndexOf(p.Edad.ToString(), txtBuscar.Text, CompareOptions.IgnoreCase) > -1));
                    break;
                case 2:
                    lstAuxiliar.AddRange(lstPacientes.Where(p => compareInfo.IndexOf(p.Sexo.ToString(), txtBuscar.Text, CompareOptions.IgnoreCase) > -1));
                    break;
                case 3:
                    lstAuxiliar.AddRange(lstPacientes.Where(p => compareInfo.IndexOf(p.DocIdentidad, txtBuscar.Text, CompareOptions.IgnoreCase) > -1));
                    break;
                case 4:
                    lstAuxiliar.AddRange(lstPacientes.Where(p => compareInfo.IndexOf(p.Email, txtBuscar.Text, CompareOptions.IgnoreCase) > -1));
                    break;
                case 5:
                    lstAuxiliar.AddRange(lstPacientes.Where(p => compareInfo.IndexOf(p.NumTelefono.ToString(), txtBuscar.Text, CompareOptions.IgnoreCase) > -1));
                    break;
                case 6:
                    lstAuxiliar.AddRange(lstPacientes.Where(p => compareInfo.IndexOf(p.Enfermedad, txtBuscar.Text, CompareOptions.IgnoreCase) > -1));
                    break;
                case 7:
                    lstAuxiliar.AddRange(lstPacientes.Where(p => compareInfo.IndexOf(p.Tratamiento, txtBuscar.Text, CompareOptions.IgnoreCase) > -1));
                    break;
                case 8:
                    lstAuxiliar.AddRange(lstPacientes.Where(p => compareInfo.IndexOf(p.MedicoAsignado.ToString(), txtBuscar.Text, CompareOptions.IgnoreCase) > -1));
                    break;
            }            

            var bindingList = new BindingList<Paciente>(lstAuxiliar);
            var source = new BindingSource(bindingList, null);

            grdPersonal.DataSource = source;

            if (source.Count > 0)
            {
                grdPersonal.Columns["Ocupacion"].Visible = false;
                grdPersonal.Columns["Genero"].Visible = false;

                grdPersonal.Columns["MedicoAsignado"].DisplayIndex = 0;
                grdPersonal.Columns["Enfermedad"].DisplayIndex = 8;

                grdPersonal.CurrentCell = grdPersonal.Rows[0].Cells[2];
                txtBuscar.Focus();
            }
        }   
    }
}
