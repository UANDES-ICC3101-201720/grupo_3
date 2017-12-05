using System;
using System.Collections.Generic;
using System.Linq;

namespace Entrega_04
{
    [Serializable]
    public class Mall
    {
        public int nropisos;
        public int dineroincial;
        public string nombre;
        public int nrohoras;
        public int arriendo;
        public List<Pisos> pisos;

        public Mall(int nropisos, int nrohoras,int dinero, string nombre, int arriendo)
        {
            this.nropisos = nropisos;
            this.nrohoras = nrohoras;
            this.dineroincial = dinero;
            this.nombre = nombre;
            this.arriendo = arriendo;
            this.pisos = new List<Pisos>();
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

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public int Horas
        {
            get { return nrohoras; }
            set { nrohoras = value; }
        }
        public int Pisos
        {
            get { return nropisos; }
            set { nropisos = value; }
        }

        public int Dinero
        {
            get { return dineroincial; }
            set { dineroincial = value; }
        }

        public List<Pisos> TomarPisos
        { 
            get { return pisos; }
            set { pisos = value; }
        }
        public int Arriendo
        {
            get { return arriendo; }
            set { arriendo = value; }
        }
    }
}