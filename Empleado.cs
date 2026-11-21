using System;
using System.Collections.Generic;
using System.Text;

namespace GestionEmpleados
{
    internal class Empleado
    {
        private int Id { get; }

        private string Nombre { get; }

        private int SalarioBase { get; }

        public Empleado(int id, string nombre, int salarioBase)
        {
            Id = id;
            Nombre = nombre;
            SalarioBase = salarioBase;
        }
    }
}
