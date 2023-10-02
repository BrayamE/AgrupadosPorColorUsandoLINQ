using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class Program
{
    public static void Main(string[] args)
    {
        List<Animal> animales = new List<Animal>();
        animales.Add(new Animal() { Nombre = "Hormiga", Color = "Rojo" });
        animales.Add(new Animal() { Nombre = "Lobo", Color = "Gris" });
        animales.Add(new Animal() { Nombre = "Elefante", Color = "Gris" });
        animales.Add(new Animal() { Nombre = "Pantegra", Color = "Negro" });
        animales.Add(new Animal() { Nombre = "Gato", Color = "Negro" });
        animales.Add(new Animal() { Nombre = "Iguana", Color = "Verde" });
        animales.Add(new Animal() { Nombre = "Sapo", Color = "Verde" });
        animales.Add(new Animal() { Nombre = "Camaleon", Color = "Verde" });
        animales.Add(new Animal() { Nombre = "Gallina", Color = "Blanco" });
        // Retorna los datos de la colleción Animales agrupada por color
        Console.WriteLine("=========================");
        Console.WriteLine("BRAYAM EDWIN QUISPE APAZA");
        Console.WriteLine("=========================");
        var animalesAgrupadosPorColor = animales.GroupBy(a => a.Color);

        foreach (var grupo in animalesAgrupadosPorColor)
        {
            Console.WriteLine($"Color: {grupo.Key}");
            foreach (var animal in grupo)
            {
                Console.WriteLine($"Nombre: {animal.Nombre}");
            }
            Console.WriteLine();
        }
    }
    public class Animal
    {
        public string Nombre { get; set; }
        public string Color { get; set; }
    }
}
