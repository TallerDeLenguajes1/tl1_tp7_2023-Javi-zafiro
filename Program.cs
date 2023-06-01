using EspacioCalculadora;
double x;

Calculadora cal= new Calculadora();
double.TryParse(Console.ReadLine(), out x);

cal.Suma(x);
cal.Resta(3);
Console.WriteLine(cal.Resultado);
cal.Limpiar();
Console.WriteLine(cal.Resultado);