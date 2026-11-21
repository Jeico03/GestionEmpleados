namespace GestionEmpleados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Departamento Informatica = new Departamento("Informatica");

            Desarrollador desarrolladorJunior = new Desarrollador(1, "Juan Perez", 30000m, "C#");
            Desarrollador desarrolladorMidSenior = new Desarrollador(2, "Maria Lopez", 60000m, "Java");
            Desarrollador desarrolladorSenior = new Desarrollador(3, "Carlos Alcantara", 90000m, "Python");

            Informatica.AgregarEmpleado(desarrolladorJunior);
            Informatica.AgregarEmpleado(desarrolladorMidSenior);
            Informatica.AgregarEmpleado(desarrolladorSenior);

            Informatica.ListarEmpleados();
        }
    }
}
