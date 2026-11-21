# Sistema Sencillo de Gestión de Empleados (C#)

Aplicación de consola desarrollada en **C#** con el objetivo de poner en práctica las relaciones fundamentales entre clases dentro de la Programación Orientada a Objetos (POO). El proyecto modela un escenario básico de recursos humanos donde existen distintos tipos de trabajadores organizados dentro de un departamento.

---

## Objetivo del proyecto

Demostrar de forma clara y funcional cómo combinar:

1. **Herencia (`Empleado` → `Desarrollador`):** Permite extender una clase base reutilizando sus atributos y lógica de inicialización mediante la palabra clave `base`.
2. **Composición / Agregación (`Departamento` → `List<Empleado>`):** Permite que una clase contenga y administre una colección de instancias de otra clase sin necesidad de crear una relación de herencia incorrecta.

---

## Requerimientos implementados

- **Clase `Empleado`:** Define las propiedades básicas `Id` (`int`), `Nombre` (`string`) y `SalarioBase` (`decimal`), junto con su constructor para inicializar los datos.
- **Clase `Desarrollador`:** Hereda de `Empleado` e incorpora la propiedad adicional `LenguajePrincipal` (`string`).
- **Uso de `base`:** El constructor de `Desarrollador` invoca al constructor de `Empleado` mediante `: base(id, nombre, salarioBase)` para delegar la inicialización de los atributos heredados.
- **Clase `Departamento`:** Administra el nombre del área y mantiene una colección `List<Empleado>` inicializada para almacenar tanto empleados generales como desarrolladores.
- **Método `ListarEmpleados()`:** Recorre la colección de empleados del departamento e imprime sus datos en consola, diferenciando si el registro corresponde a un `Desarrollador` para mostrar también su lenguaje principal.
- **Demostración funcional:** En `Program.cs` se instancian al menos tres objetos, se registran dentro de un departamento y se muestran en pantalla.

---

## Cómo ejecutar el proyecto

### Requisitos previos
- Tener instalado **.NET SDK** (versión 6.0, 7.0, 8.0 o superior).
- Un editor o entorno de desarrollo como **Visual Studio**, **Visual Studio Code** o **JetBrains Rider**.

### Pasos desde la terminal
1. Clona este repositorio en tu equipo:
   ```bash
   git clone [https://github.com/tu-usuario/tu-repositorio.git](https://github.com/tu-usuario/tu-repositorio.git)