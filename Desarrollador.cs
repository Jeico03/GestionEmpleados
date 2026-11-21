using System;
using System.Collections.Generic;
using System.Text;

namespace GestionEmpleados
{
    internal class Desarrollador : Empleado
    {
        private string LenguajePrincipal { get; }

        public Desarrollador(int id, string nombre, int salarioBase, string lenguajePrincipal) : base(id, nombre, salarioBase)
        {
            LenguajePrincipal = lenguajePrincipal;
        }
    }
}
