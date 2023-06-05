using EspacioEmpleados;
DateTime hoy=DateTime.Now;
double años;

Empleados prueba = new Empleados();

prueba.Nombre="javier";
prueba.Apellido="cortez";
prueba.FechaDeNacimiento= new DateTime(1999, 3, 26);
prueba.EstadoCivil='S';
prueba.Genero='M';
prueba.FechaDeIngreso= new DateTime(2019, 5, 7);
prueba.SueldoBasico=26000;
prueba.cargo=Empleados.Cargos.Investigador;

años=hoy.Year-prueba.FechaDeIngreso.Year;

Console.WriteLine(prueba.Nombre);
Console.WriteLine(prueba.Apellido);
Console.WriteLine(prueba.FechaDeNacimiento);
Console.WriteLine(prueba.EstadoCivil);
Console.WriteLine(prueba.Genero);
Console.WriteLine(prueba.FechaDeIngreso);
Console.WriteLine(prueba.SueldoBasico);
Console.WriteLine(prueba.cargo);
Console.WriteLine(años);