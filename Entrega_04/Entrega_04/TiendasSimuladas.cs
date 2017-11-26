using System;

namespace Entrega_04
{
    [Serializable] 
    public class TiendasSimuladas
    {
        string nombre;
        int nroempleados;
        string categoria;
        int piso;
        int area;
        int preciomin;
        int preciomax;
        int arriendo;
        int sueldo;
        int ventas;
        int gananciasdia;
        int gananciasacumuladas;
        int clientesPasados;
        int dia;
        int arriendo_M2;

        public TiendasSimuladas(string nombre, int nroempleados,string categoria,int piso, int area, int preciomin, int preciomax, int sueldo,int ventas, int gananciasdia,int gananciasacumuladas, int arriendo_M2)
        {
            
            this.nombre = nombre;
            this.nroempleados = nroempleados;
            this.categoria = categoria;
            this.piso = piso;
            this.area = area;
            this.preciomin = preciomin;
            this.preciomax = preciomax;
            this.arriendo = area*arriendo_M2;
            this.sueldo = sueldo;
            this.ventas = ventas;
            this.gananciasdia = gananciasdia;
            this.gananciasacumuladas = gananciasacumuladas;
            this.clientesPasados = 0;
            this.dia = 0;
            this.arriendo_M2 = arriendo_M2;
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
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
        public int Piso
        {
            get { return piso; }
            set { piso = value; }
        }
        public int Area
        {
            get { return area; }
            set { area = value; }
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
        public int Arriendo
        {
            get { return arriendo; }
            set { arriendo = value; }
        }
        public int Sueldos
        {
            get { return sueldo; }
            set { sueldo = value; }
        }
        public int Ventas
        {
            get { return ventas; }
            set { ventas = value; }
        }
        public int Gananciasdia
        {
            get { return gananciasdia; }
            set { gananciasdia = value; }
        }
        public int Gananciasacumuladas
        {
            get { return gananciasacumuladas; }
            set { gananciasacumuladas = value; }
        }
        public int Clientespasados
        {
            get { return clientesPasados; }
            set { clientesPasados = value; }
        }
        public int Dia
        {
            get { return dia; }
            set { dia = value; }
        }
        public int Arriendo_M2
        {
            get { return arriendo_M2; }
            set { arriendo_M2 = value; }
        }
    }
}
