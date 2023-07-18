using HospitalWF.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalWF
{
    public partial class Menu : Form
    {

        Automatizacion oAutomatiza = new Automatizacion();
        List<Medico> lstMedicos = new List<Medico>();

        public Menu()
        {
            InitializeComponent();
            InicializarForm();
        }

        public void InicializarForm()
        {
            lstMedicos = oAutomatiza.GenerarMedicosConPacientesRandom(100);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {         

        
            var bindingList = new BindingList<Medico>(lstMedicos);
            var source = new BindingSource(bindingList, null);
            grdMedicos.DataSource = source;

            BuscarMedico oMe = new BuscarMedico();
            oMe.Show();


        }
    }
}
