using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

class GestorBD
{
	private MySqlConnection conexion;

	// 3.1 - Constructor con cadena de conexión
	public GestorBD()
	{
		MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
		builder.Server = "localhost";
		builder.UserID = "root";
		builder.Password = "";
		builder.Database = "videotech";

		conexion = new MySqlConnection(builder.ConnectionString);
	}

	// 3.2 Insertar
	public void Insertar(Pelicula l)
	{
		conexion.Open();

		MySqlCommand cmd = new MySqlCommand("INSERT INTO peliculas (titulo, director, anyo, disponible) VALUES (@titulo, @autor, @anyo, @disponible)", conexion);
		cmd.Parameters.AddWithValue("@titulo", l.getTitulo());
		cmd.Parameters.AddWithValue("@director", l.getDirector());
		cmd.Parameters.AddWithValue("@anyo", l.getAnyo());
		cmd.Parameters.AddWithValue("@disponible", l.isDisponible());

		cmd.ExecuteNonQuery();

		conexion.Close();
	}
	// 3.3 - Leer todos
	public List<Pelicula> ObtenerTodos()
	{
		List<Pelicula> lista = new List<Pelicula>();

		conexion.Open();

		MySqlCommand cmd = new MySqlCommand("SELECT * FROM libros", conexion);
		MySqlDataReader dr = cmd.ExecuteReader();

		while (dr.Read())
		{
			Pelicula l = new Pelicula(
				dr["titulo"].ToString(),
				dr["director"].ToString(),
				int.Parse(dr["anyo"].ToString()),
				bool.Parse(dr["disponible"].ToString())
			);
			lista.Add(l);
		}

		dr.Close();
		conexion.Close();

		return lista;
	}

}

