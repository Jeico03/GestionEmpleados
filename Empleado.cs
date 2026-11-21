using System;
using System.Collections.Generic;
using System.Text;

namespace GestionEmpleados
{
    internal class Empleado
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public decimal SalarioBase { get; set; }

        public Empleado(int id, string nombre, decimal salarioBase)
        {
            Id = id;
            Nombre = nombre;
            SalarioBase = salarioBase;
        }
    }
}
