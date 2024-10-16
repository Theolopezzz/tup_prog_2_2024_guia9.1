using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_1_Guia_9._1.Models
{
    internal abstract class Evaluacion
    {
        string nombre;
        string descripcion;
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public string Descripcion { get { return descripcion; } set { descripcion = value; } }
        public Evaluacion(string nombre,string descripcion) 
        {
            this.descripcion = descripcion;
            this.nombre = nombre;   
        }
        public abstract TipoAprobacion Evaluar();
        public override string ToString()
        {
            return $"Nombre: {nombre}\r\nDescripción: {descripcion}";
        }
    }
}
