using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Tiendas
    {
        int area;
        int nrotienda;
        string nombre;
        public List<Empleados> empleados;

        public Tiendas(int area, string nombre)
        {
            this.area = area;
            this.nombre = nombre;
            empleados = new List<Empleados>();
        }

    }
}
