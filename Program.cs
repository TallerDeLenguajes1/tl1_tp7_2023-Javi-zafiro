using EspacioEmpleados;
double montoTotalSalarios = 0.0;
Empleados empleadoMasProximoJubilarse=null;
int aniosProximoJubilacion = int.MaxValue;

Empleados empleado1 = new Empleados();
empleado1.Nombre = "Juan";
empleado1.Apellido = "Perez";
empleado1.FechaDeNacimiento = new DateTime(1985, 10, 15);
empleado1.EstadoCivil = 'S';
empleado1.Genero = 'M';
empleado1.FechaDeIngreso = new DateTime(2010, 5, 1);
empleado1.SueldoBasico = 65000;
empleado1.Cargo = Empleados.Cargos.Ingeniero;

Empleados empleado2 = new Empleados();
empleado2.Nombre = "María";
empleado2.Apellido = "Lopez";
empleado2.FechaDeNacimiento = new DateTime(1990, 6, 20);
empleado2.EstadoCivil = 'C';
empleado2.Genero = 'F';
empleado2.FechaDeIngreso = new DateTime(2015, 3, 10);
empleado2.SueldoBasico = 50000;
empleado2.Cargo = Empleados.Cargos.Administrativo;

Empleados empleado3 = new Empleados();
empleado3.Nombre = "Pedro";
empleado3.Apellido = "González";
empleado3.FechaDeNacimiento = new DateTime(1980, 8, 5);
empleado3.EstadoCivil = 'C';
empleado3.Genero = 'M';
empleado3.FechaDeIngreso = new DateTime(2005, 9, 15);
empleado3.SueldoBasico = 80000;
empleado3.Cargo = Empleados.Cargos.Especialista;

Empleados[] empleados={empleado1, empleado2, empleado3};
foreach (Empleados empleado in empleados)
{
    montoTotalSalarios= montoTotalSalarios + empleado.Salario();

    if (empleado.AniosParaJubilarse() < aniosProximoJubilacion)
    {
        empleadoMasProximoJubilarse = empleado;
        aniosProximoJubilacion = empleado.AniosParaJubilarse();
    }
}

Console.WriteLine("Monto Total de Salarios: " + montoTotalSalarios.ToString("C"));
Console.WriteLine("Empleado más próximo a jubilarse:");
Console.WriteLine("Nombre: " + empleadoMasProximoJubilarse.Nombre);
Console.WriteLine("Apellido: " + empleadoMasProximoJubilarse.Apellido);
Console.WriteLine("Antigüedad: " + empleadoMasProximoJubilarse.Antiguedad());
Console.WriteLine("Edad: " + empleadoMasProximoJubilarse.Edad());
Console.WriteLine("Salario: " + empleadoMasProximoJubilarse.Salario().ToString("C"));