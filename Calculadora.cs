namespace EspacioCalculadora;
public class Calculadora{
    private double dato;
    public Calculadora(){
        dato=0;
    }
    public double Resultado { get => dato;}
    public void Suma(double termino){
        dato+=termino;
    }
    public void Resta(double termino){
        dato-=termino;
    }
    public void Multiplicacion(double termino){
        dato*=termino;
    }
    public void Division(double termino){
        dato/=termino;
    }
    public void Limpiar(){
        dato=0;
    }
}