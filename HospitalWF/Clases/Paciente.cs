﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalWF.Clases
{
    public class Paciente : Persona
    {
        public Paciente() { }
        
        public Paciente(Persona p, string enfermedad
                      , string tratamiento) : base(p.Nombre, p.Edad, p.Genero
                                                  , p.DocIdentidad, p.NumTelefono, "Paciente")
        {
            Enfermedad = enfermedad;
            Tratamiento = tratamiento;
        }

        //propiedades
        public string Enfermedad { get; set; }
        public string Tratamiento { get; set; }
        public int MedicoAsignado { get; set; }

    }
}
