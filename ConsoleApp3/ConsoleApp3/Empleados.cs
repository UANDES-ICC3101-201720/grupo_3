﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Empleados
    {
        int rut;
        string nombre;
        string apellido;
        int nacimiento;
        int sueldo;
        string cargo;

        public Empleados(int rut,string nombre,string apellido, int nacimiento,int sueldo, string cargo)
        {
            this.rut = rut;
            this.nombre = nombre;
            this.apellido = apellido;
            this.nacimiento = nacimiento;
            this.sueldo = sueldo;
            this.cargo = cargo;
        }
        
    }
}
