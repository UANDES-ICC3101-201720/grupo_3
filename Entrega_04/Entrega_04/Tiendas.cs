using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        


        
        public Tiendas(int area, string nombre, int nropiso)
        {
            this.nropiso = nropiso;
            this.area = area;
            this.nombre = nombre;
            empleados = new List<Empleados>();
        }

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
        public int ClientesRecepcionados(int clientesayer)
        {
            int numero;
            int cmax = clientesayer + (area / 10) * Math.Max((100 - (preciomax + preciomin) / 2), 0) * nroempleados / 100;
            Random rnd = new Random();
            numero = rnd.Next(0, cmax);
            clientesayer = numero;
            clientestotales += clientesayer;
            return (numero);
        }
        public void RandomPrecios()
        {
            int num1;
            int num2;
            Random rnd = new Random();
            num1 = rnd.Next(0, 100);
            num2 = rnd.Next(0, 100);
            if (num1 <= num2)
            {
                preciomin = num1;
                preciomax = num2;
            }
            else
            {
                preciomin = num2;
                preciomax = num1;
            }
        }

        public void RandomnNumeroEmpleados()
        {
            int numero;
            Random rnd = new Random();
            numero = rnd.Next(1, 2);
            nroempleados = (area) * numero - area + 1;
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
    }
}
