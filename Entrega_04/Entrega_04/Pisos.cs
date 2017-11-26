using System;
using System.Collections.Generic;

namespace Entrega_04
{
    [Serializable]
    public class Pisos
    {
        public int nropiso;
        public int area;
        public int nrotiendas;
        public List<Tiendas> tiendas;

        public Pisos(int nropiso, int area, int nro_tiendas)
        {
            this.nropiso = nropiso;
            this.area = area;
            this.nrotiendas = nro_tiendas;
            this.tiendas = new List<Tiendas>();
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

        public List<Tiendas> TomarTiendas
        {
            get { return tiendas; }
            set { tiendas = value; }
        }
    }
}
