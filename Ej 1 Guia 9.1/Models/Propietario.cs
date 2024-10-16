using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_1_Guia_9._1.Models
{
    internal class Propietario
    {
        public int DNI { get; set; }
        public string ApellidosNombres { get; set; }    
        public string Email { get; set; }   
        public Propietario(int dNI, string apellidosNombres, string email )
        {
            DNI = dNI;
            ApellidosNombres = apellidosNombres;
            Email = email;
        }
        public override string ToString()
        {
            return $"DNI: {DNI} \r\nNombre: {ApellidosNombres} \r\nEmail: {Email}";
        }
    }
}
