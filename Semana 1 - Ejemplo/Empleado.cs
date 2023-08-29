using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_1___Ejemplo
{
    internal class Empleado
    {
        public Empleado() { }
        public Empleado(string nombre, string categoria, int minutosTardanza, int lLamadasAtencion)
        {
            Nombre = nombre;
            Categoria = categoria;
            MinutosTardanza = minutosTardanza;
            LLamadasAtencion = lLamadasAtencion;
        }

        public String Nombre { get; set; }

        public String Categoria { get; set; }

        public int MinutosTardanza { get; set; }

        public int LLamadasAtencion { get; set; }

        public double Pago { get; set; }
    }
}
