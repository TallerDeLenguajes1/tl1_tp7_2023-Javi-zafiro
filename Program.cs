using EspacioCalculadora;
string? menu;
double num;
int repetir;
bool aux=false;
Calculadora cal=new Calculadora();
do
{
    Console.WriteLine("ingrese el numero, la inicial o la operacion que desea realizar");
    Console.WriteLine("1. suma");
    Console.WriteLine("2. resta");
    Console.WriteLine("3. multiplicacion");
    Console.WriteLine("4. division");
    menu=Console.ReadLine();
    Console.WriteLine("ingrese un numero");
    double.TryParse(Console.ReadLine(), out num);
    cal.Suma(num);
    switch (menu)
    {
        case "1":
        case "s":
        case "suma":
            Console.WriteLine("ingrese otro numero");
            double.TryParse(Console.ReadLine(), out num);
            cal.Suma(num);
            Console.WriteLine("el resultado de la suma es: "+cal.Resultado);
            break;
        case "2":
        case "r":
        case "resta":
            Console.WriteLine("ingrese otro numero");
            double.TryParse(Console.ReadLine(), out num);
            cal.Resta(num);
            Console.WriteLine("el resultado de la suma es: "+cal.Resultado);
            break;
        case "3":
        case "m":
        case "multiplicacion":
            Console.WriteLine("ingrese otro numero");
            double.TryParse(Console.ReadLine(), out num);
            cal.Multiplicacion(num);
            Console.WriteLine("el resultado de la suma es: "+cal.Resultado);
            break;
        case "4":
        case "d":
        case "division":
            Console.WriteLine("ingrese otro numero");
            double.TryParse(Console.ReadLine(), out num);
            cal.Division(num);
            Console.WriteLine("el resultado de la suma es: "+cal.Resultado);
            break;
        default:
            Console.WriteLine("no se reconoce la palabra ingresada");
            break;
    }
    Console.WriteLine("si desea realizar otra operacion ingrese 1");
    Console.WriteLine("si desea salir precione 0");
    int.TryParse(Console.ReadLine(), out repetir);
    if (repetir==1)
    {
        aux=true;
    }else
    {
        aux=false;
    }
    cal.Limpiar();
} while (aux);
