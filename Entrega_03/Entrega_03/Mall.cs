using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrega_03
{
    public class Mall
    {
        public int nropisos;
        public int dineroincial;
        public string nombre;
        public int nrohoras;
        public List<Pisos> pisos;

        public Mall(int nropisos, int nrohoras, string nombre)
        {
            this.nropisos = nropisos;
            this.nrohoras = nrohoras;
            pisos = new List<Pisos>();
        }
        public Mall(string nombre)
        {
            this.nombre = nombre;
            pisos = new List<Pisos>();
        }
        public Mall()
        {
            nropisos = 0;
            nrohoras = 0;
            pisos = new List<Pisos>();
        }
        public void AgregarPiso(Pisos piso)
        {
            if (ComprobarPiso(piso)) pisos.Add(piso);
            else Console.WriteLine("Error no se puede agregar este piso");
        }

        public bool ComprobarPiso(Pisos piso)
        {
            if (pisos.Count() != 0 && (pisos.Count()) <= nropisos)
            {
                if (piso.area <= pisos[pisos.Count() - 1].area) return true;
                else return false;

            }
            else if (pisos.Count() == 0 && piso.area > 0) return true;
            else
            {
                return false;
            }

        }
    }
}
