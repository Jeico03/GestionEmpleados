namespace GestionEmpleados
{
    internal class Departamento
    {
        public string Nombre { get; set; }

        public List<Empleado> Empleados { get; set; }

        public Departamento(string nombre)
        {
            Nombre = nombre;
            Empleados = new List<Empleado>();
        }

        public void AgregarEmpleado(Empleado empleado)
        {
            Empleados.Add(empleado);
        }

        public void ListarEmpleados()
        {
            foreach (Empleado empleado in Empleados)
            {
                Console.WriteLine($"ID: {empleado.Id}, Nombre: {empleado.Nombre}, Salario Base: {empleado.SalarioBase}");
            }
        }
    }
}
