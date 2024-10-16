using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_1_Guia_9._1.Models
{
    internal class VTV:IComparable
    {
        List<Evaluacion> verificciones = new List<Evaluacion>();
        string patente;
        DateTime fecha;
        int cantidadVerificaciones;
        TipoAprobacion aprobacion;
        Propietario propietario;
        public Evaluacion this[int idx] 
        { get 
            { if (idx < 0 && idx < cantidadVerificaciones)
                    return verificciones[idx];
            return null;
            } 
        }
        public VTV (string patente,Propietario prop)
        {
            this.patente = patente;
            propietario = prop;
        }
    }
}
