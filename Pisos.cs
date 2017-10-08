using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Pisos
    {
        int nropiso;
        int area;
        public List<Tiendas> tiendas;

        public Pisos(int nropiso,int area)
        {
            this.nropiso = nropiso;
            this.area = area;
            tiendas = new List<Tiendas>();
        }

        public int Area()
        {
            return area;
        }


    }
}
