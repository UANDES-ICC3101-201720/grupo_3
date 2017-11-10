using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrega3
{
    public class Pisos
    {
        public int nropiso;
        public int area;
        public int nrotiendas;
        public List<Tiendas> tiendas;

        public Pisos(int nropiso, int area)
        {
            this.nropiso = nropiso;
            this.area = area;
            tiendas = new List<Tiendas>();
        }

       
        public void AgregarTienda(Tiendas tienda)
        {
            tiendas.Add(tienda);
        }

        public int Nropiso
        {
            get { return nropiso; }
            set { nropiso = value; }
        }
        public int Area
        {
            get { return area; }
            set { area = value; }
        }
        public int Nrotiendas
        {
            get { return nrotiendas; }
            set { nrotiendas = value; }
        }

    }
}
