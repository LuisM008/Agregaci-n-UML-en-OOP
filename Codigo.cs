using System;
public class Departamento
{
    public string Nombre{get;set;}
    public void MostrarProfesor(Profesor p)
    {
        Console.WriteLine("Profesor:"+ p.Nombre);
        Console.WriteLine("Departamento:"+Nombre);
    }
}
public class Profesor
{
    public string Nombre {get;set;}
}
public class Program
{
    static void Main()
    {
        //La creacion del objeto profesor
        Profesor profe=new Profesor();
        profe.Nombre="Vera";
        //La creacion del objeto departamento
        Departamento poo=new Departamento();
        poo.Nombre="Programacion Orientada a Objetos";
        //Llamar a los metodos 
        poo.MostrarProfesor(profe);
    }
}
