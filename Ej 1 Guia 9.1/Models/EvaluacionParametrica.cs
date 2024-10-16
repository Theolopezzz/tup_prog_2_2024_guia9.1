using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_1_Guia_9._1.Models
{
    internal class EvaluacionParametrica:Evaluacion
    {
        double valorMinimo;
        double valorMaximo;
        string unidad;
        double valorTolerado;
        public double ValorMinimo { get { return valorMinimo; } set { valorMinimo = value; } } 
        public double ValorMaximo { get { return valorMaximo; } set { valorMaximo = value; } }  
        public double ValorTolerado { get {  return valorTolerado; } set { valorTolerado = value; } }
        public string Unidad { get {  return unidad; } set {  unidad = value; } }
        public double ValorMedio { get; set; }
        public EvaluacionParametrica(string nombre,string descripcion,double minimo, double maximo,string unidad, double tolerado): base(nombre, descripcion) { }
        public override TipoAprobacion Evaluar()
        {
            
        }
        public override string ToString()
        {
            return base.ToString() + $"Valor minimo: {valorMinimo}  Valor maximo: {valorMaximo}";
        }
    }
}
