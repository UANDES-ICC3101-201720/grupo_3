using System;
using System.Collections.Generic;

namespace Entrega_04
{
    [Serializable]
    public class Tiendas
    {
        public int area;
        public int nropiso;
        public string nombre;
        public int nroempleados;
        public int preciomax;
        public int preciomin;
        public int sueldo;
        public List<Empleados> empleados;
        public string categoria;
        public int gananciasayer = 0;
        public int gananciastotales = 0;
        public int clientesayer = 0;
        public int clientestotales = 0;

        public Tiendas(int area, string nombre, int nropiso, int nroempleados, int preciomax, int preciomin, string categoria,int sueldo)
        {
            this.area = area;
            this.nombre = nombre;
            this.nropiso = nropiso;
            this.nroempleados = nroempleados;
            this.preciomax = preciomax;
            this.preciomin = preciomin;
            this.categoria = categoria;
            empleados = new List<Empleados>();
            this.sueldo = sueldo;
        }

        public int Area
        {
            get { return area; }
            set { area = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int Nropiso
        {
            get { return nropiso; }
            set { nropiso = value; }
        }

        public int Nroempleados
        {
            get { return nroempleados; }
            set { nroempleados = value; }
        }

        public string Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }

        public int Preciomin
        {
            get { return preciomin; }
            set { preciomin = value; }
        }

        public int Preciomax 
        {
            get { return preciomax; }
            set { preciomax = value; }
        }

        public int Sueldo   
        {
            get { return sueldo; }
            set { sueldo = value; }
        }
    }
}
