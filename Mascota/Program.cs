using System;

class Mascota
{

    public string Nombre;
    public string Especie;
    public int Edad;

    public Mascota(string nombre, string especie, int edad)
    {
        this.Nombre = nombre;
        this.Especie = especie;
        this.Edad = edad;
    }

    public Mascota()
    {
        this.Nombre = "Sin nombre";
        this.Especie = "Desconocida";
        this.Edad = 0;
    }

    public void Presentarse()
    {
        Console.WriteLine("Hola, soy " + Nombre + ", soy " + Especie + " y tengo " + Edad + " años.");
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Nombre de la mascota: ");
        string nombre = Console.ReadLine();

        Console.Write("Especie: ");
        string especie = Console.ReadLine();

        Console.Write("Edad: ");
        int edad = Convert.ToInt32(Console.ReadLine());

        Mascota mascota1 = new Mascota(nombre, especie, edad);

        mascota1.Presentarse();

        Console.WriteLine();
        Console.Write("Nombre de la segunda mascota: ");
        string nombre2 = Console.ReadLine();

        Console.Write("Especie: ");
        string especie2 = Console.ReadLine();

        Console.Write("Edad: ");
        int edad2 = Convert.ToInt32(Console.ReadLine());

        Mascota mascota2 = new Mascota(nombre2, especie2, edad2);

        mascota2.Presentarse();

        Mascota mascota3 = new Mascota();

        mascota3.Presentarse();

        Console.ReadKey(); 
    }
}