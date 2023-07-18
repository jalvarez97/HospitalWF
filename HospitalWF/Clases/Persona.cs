using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalWF.Clases
{
    public class Persona
    {
        public Persona() { }

        public Persona(string nombre, int edad, bool genero, string docIdentidad, int numTelefono, string ocupacion)
        {
            Nombre = nombre;
            Edad = edad;
            Genero = genero;
            DocIdentidad = docIdentidad;
            Email = nombre + "@gmail.com";
            NumTelefono = numTelefono;
            Ocupacion = ocupacion;
            if (Genero)
                Sexo = "Hombre";
            else
                Sexo = "Mujer";
        }
        public Persona(string nombre, int edad, bool genero, string docIdentidad, string email, int numTelefono, string ocupacion)
        {
            Nombre = nombre;
            Edad = edad;
            Genero = genero;
            DocIdentidad = docIdentidad;
            Email = email;
            NumTelefono = numTelefono;
            Ocupacion = ocupacion;
            if (Genero)
                Sexo = "Hombre";
            else
                Sexo = "Mujer";
        }

        //propiedades
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Sexo { get; set; }
        public bool Genero { get; set; }
        public string DocIdentidad { get; set; }
        public string Email { get; set; }
        public int NumTelefono { get; set; }
        public string Ocupacion { get; set; }
        
    }
}
