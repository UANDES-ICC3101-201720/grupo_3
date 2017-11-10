using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrega3
{
    public class Tiendas
    {
        public int area;
        public int nropiso;
        public string nombre;
        public int nroempleados;
        public int preciomax;
        public int preciomin;
        public List<Empleados> empleados;
        public string categoria;
        public int gananciasayer = 0;
        public int gananciastotales = 0;
        public int clientesayer = 0;
        public int clientestotales = 0;


        public Tiendas(string nombre)
        {
            this.nombre = nombre;
            empleados = new List<Empleados>();
        }

        public Tiendas(int area, string nombre, int nropiso)
        {
            this.nropiso = nropiso;
            this.area = area;
            this.nombre = nombre;
            empleados = new List<Empleados>();
        }

        public Tiendas(int area, string nombre, int nroempleados, int preciomax, int preciomin, string categoria)
        {
            this.area = area;
            this.nombre = nombre;
            this.nroempleados = nroempleados;
            this.preciomax = preciomax;
            this.preciomin = preciomin;
            this.categoria = categoria;
            empleados = new List<Empleados>();
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
    }
}
