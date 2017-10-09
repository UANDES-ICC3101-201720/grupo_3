using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Pisos
    {
        public int nropiso;
        public int area;
        public int nrotiendas;
        public List<Tiendas> tiendas;

        public Pisos(int nropiso,int area, int nrotiendas)
        {
            this.nrotiendas = nrotiendas;
            this.nropiso = nropiso;
            this.area = area;
            tiendas = new List<Tiendas>();
        }
        public void AgregarTienda(Tiendas tienda)
        {
            tiendas.Add(tienda);
        }


    }
}
