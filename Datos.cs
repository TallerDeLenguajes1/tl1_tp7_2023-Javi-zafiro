namespace EspacioEmpleados;

public class Empleados
{
     public enum Cargos{
        Auxiliar,
        Administrativo,
        Ingeniero,
        Especialista,
        Investigador
    }
    private string? nombre;
    private string? apellido;
    private DateTime fechaDeNacimiento;
    private char estadoCivil;
    private char genero;
    private DateTime fechaDeIngreso;
    private double sueldoBasico;
    private Cargos cargo;

    public string? Nombre { get => nombre; set => nombre = value; }
    public string? Apellido { get => apellido; set => apellido = value; }
    public DateTime FechaDeNacimiento { get => fechaDeNacimiento; set => fechaDeNacimiento = value; }
    public char EstadoCivil { get => estadoCivil; set => estadoCivil = value; }
    public char Genero { get => genero; set => genero = value; }
    public DateTime FechaDeIngreso { get => fechaDeIngreso; set => fechaDeIngreso = value; }
    public double SueldoBasico { get => sueldoBasico; set => sueldoBasico = value; }
    public Cargos Cargo { get => cargo; set => cargo = value; }

    public int Antiguedad(){
        DateTime hoy= DateTime.Now;
        int antiguedad=hoy.Year-FechaDeIngreso.Year;
        if (hoy.Month < FechaDeIngreso.Month || (hoy.Month == FechaDeIngreso.Month && hoy.Day < FechaDeIngreso.Day))
                {
                    antiguedad--;
                }
        return antiguedad;
    }
    public int Edad(){
        DateTime hoy= DateTime.Now;
        int edad=hoy.Year-FechaDeNacimiento.Year;
        if (hoy.Month < FechaDeNacimiento.Month || (hoy.Month == FechaDeNacimiento.Month && hoy.Day < FechaDeNacimiento.Day))
                {
                    edad--;
                }
        return edad;
    }

    public int AniosParaJubilarse(){
        int jubilacion;
        int anios;
        if (Genero=='M')
        {
            jubilacion=65;
        }else
        {
            jubilacion=60;
        }
        anios=jubilacion-Edad();
        return anios;
    }
    public double Salario()
    {
        
        double adicional = CalcularAdicional();
        return SueldoBasico + adicional;
        
    }

    private double CalcularAdicional()
    {
        int antiguedad = Antiguedad();
        double adicional = 0.0;

        if (antiguedad <= 20)
        {
            adicional = SueldoBasico * (antiguedad * 0.01);
        }
        else
        {
            adicional = SueldoBasico * 0.25;
        }

        if (Cargo == Cargos.Ingeniero || Cargo == Cargos.Especialista)
        {
            adicional *= 1.5;
        }

        if (EstadoCivil == 'C')
        {
            adicional += 15000;
        }

        return adicional;
    }
}

