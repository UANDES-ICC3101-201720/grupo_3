using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Simulacion
    {
        private int horas;
        private int dineroinicial;
        public Mall mall;

        public Simulacion(int horas, int dineroinicial, Mall mall)
        {
            this.horas = horas;
            this.dineroinicial = dineroinicial;
            mall = new Mall();
        }


    }
}
