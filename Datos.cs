namespace EspacioEmpleados;

public class Empleados
{
    private string nombre;
    private string apellido;
    private DateTime fechaDeNacimiento;
    private char estadoCivil;
    private char genero;
    private DateTime fechaDeIngreso;
    private double sueldoBasico;

    public string Nombre { get => nombre; set => nombre = value; }
    public string Apellido { get => apellido; set => apellido = value; }
    public DateTime FechaDeNacimiento { get => fechaDeNacimiento; set => fechaDeNacimiento = value; }
    public char EstadoCivil { get => estadoCivil; set => estadoCivil = value; }
    public char Genero { get => genero; set => genero = value; }
    public DateTime FechaDeIngreso { get => fechaDeIngreso; set => fechaDeIngreso = value; }
    public double SueldoBasico { get => sueldoBasico; set => sueldoBasico = value; }


    public enum Cargos{
        Auxiliar,
        Administrativo,
        Ingeniero,
        Especialista,
        Investigador
    }

    public Cargos cargo;
}