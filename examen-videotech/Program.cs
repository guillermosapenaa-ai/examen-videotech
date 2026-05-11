using System.IO;
using System.Collections.Generic;


List<Pelicula> peliculas = new List<Pelicula>();

peliculas.Add(new Pelicula ("Titanic", "James Cameron", 1998, true));
peliculas.Add(new Pelicula("El club de la lucha", "David Fincher", 1999, false));
peliculas.Add(new Pelicula("Sinner", "Cristopher Nolan", 2024, false));

Console.WriteLine(" Todas las películas ");
foreach (Pelicula l in peliculas)
{
	Console.WriteLine(l.ToString());
}

Console.WriteLine("Películas de Nolan");
foreach (Pelicula l in peliculas)
{
	if (l.getDirector().Contains("Nolan"))
	{
		Console.WriteLine(l.ToString());
	}
}
Console.WriteLine("Fecha de registro");
Console.WriteLine(DateTime.Now.ToShortDateString());

StreamWriter writer = File.CreateText("Peliculas.txt");

foreach (Pelicula l in peliculas)
{
	writer.WriteLine(l.getTitulo() + ";" + l.getDirector() + ";" + l.getAnyo() + ";" + l.isDisponible());
}

writer.Close();

