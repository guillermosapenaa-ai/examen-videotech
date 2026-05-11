using System;
using System.Collections.Generic;
using System.Text;

public class Pelicula
{
	// Atributos privados
	private string titulo;
	private string director;
	private int anyo;
	private bool disponible;
	
	
	// Constructor
	public Pelicula(string titulo, string director, int anyo, bool disponible)
	{
		this.titulo = titulo;
		this.director = director;
		this.anyo = anyo;
		this.disponible = disponible;
	}
	// Métodos get
	public string getTitulo() { return titulo; }
	public string getDirector() { return director; }
	public int getAnyo() { return anyo; }
	public bool isDisponible() { return disponible; }

	// ToString
	public override string ToString()
	{
		return $"{titulo} - {director} ({anyo})";
	}
}

