using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Mall
    {
        public int nropisos;
        public int nrohoras;
        public List<Pisos> pisos;

        public Mall(int nropisos, int nrohoras)
        {
            this.nropisos = nropisos;
            this.nrohoras = nrohoras;
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
            if(ComprobarPiso(piso)) pisos.Add(piso);
            else Console.WriteLine("Error no se puede agregar este piso");
        }

        public bool ComprobarPiso(Pisos piso)
        {
            if ((pisos.Count()) <= nropisos)
            {
                return true;
                //FALTA COMPROBAR EL AREA <= al piso anterior
            }
            else return false;
            
        }

    }
}
