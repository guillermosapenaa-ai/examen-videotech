using System.IO;
using System.Collections.Generic;

//Apartado 2.1 - Trabajar con la lista
//Apartado 2.1 A)
List<Pelicula> peliculas = new List<Pelicula>();

peliculas.Add(new Pelicula ("Titanic", "James Cameron", 1998, true));
peliculas.Add(new Pelicula("El club de la lucha", "David Fincher", 1999, false));
peliculas.Add(new Pelicula("Sinner", "Cristopher Nolan", 2024, false));

//Apartado 2.1 B)
Console.WriteLine(" Todas las películas ");
foreach (Pelicula l in peliculas)
{
	Console.WriteLine(l.ToString());
}
//Apartado 2.1 C)
Console.WriteLine("Películas de Nolan");
foreach (Pelicula l in peliculas)
{
	if (l.getDirector().Contains("Nolan"))
	{
		Console.WriteLine(l.ToString());
	}
}

// Apartado 2.2 - Fecha de registro
Console.WriteLine("Fecha de registro");
Console.WriteLine(DateTime.Now.ToShortDateString());

// Apartado 2.3 - Guardar en fichero

StreamWriter writer = File.CreateText("Peliculas.txt");

foreach (Pelicula l in peliculas)
{
	writer.WriteLine(l.getTitulo() + ";" + l.getDirector() + ";" + l.getAnyo() + ";" + l.isDisponible());
}

writer.Close();

