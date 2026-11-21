using System;
using System.Collections.Generic;
using System.Text;

namespace GestionEmpleados
{
    internal class Desarrollador : Empleado
    {
        public string LenguajePrincipal { get; set; }

        public Desarrollador(int id, string nombre, int salarioBase, string lenguajePrincipal) : base(id, nombre, salarioBase)
        {
            LenguajePrincipal = lenguajePrincipal;
        }
    }
}
