using System;
using System.Collections.Generic;
using System.Text;

namespace GestionEmpleados
{
    internal class Empleado
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public int SalarioBase { get; set; }

        public Empleado(int id, string nombre, int salarioBase)
        {
            Id = id;
            Nombre = nombre;
            SalarioBase = salarioBase;
        }
    }
}
