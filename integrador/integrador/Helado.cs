using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;

namespace integrador
{
    public class Helado
    {
        protected int id;
        protected string nombre;
        protected string descripcion;
        protected int precio;
        public Helado(int idHelado,string nom, string descrip, int prec)
        {
            id = idHelado;
            nombre = nom;
            descripcion = descrip;
            precio = prec;
        }
        public Helado( string nom, string descrip, int prec)
        {
            nombre = nom;
            descripcion = descrip;
            precio = prec;
        }
        public int Id
        {
            get { return id; }
            private set {}
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        public int Precio
        {
            get { return precio; }
            set { precio = value; }
        }
        

        public void AgregarABaseDeDatos(SqliteConnection conexion)
        {
            conexion.Open();
            string consulta = $"INSERT INTO sabores (nombre, descripcion, precio) VALUES ('{nombre}', '{descripcion}', '{precio}')";
            SqliteCommand comando = new SqliteCommand(consulta, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
        }
        public void EditarSabor(SqliteConnection conexion)
        {
            conexion.Open();
            string consulta = $"UPDATE sabores SET nombre='{nombre}' , descripcion='{descripcion}', precio='{precio}' where id_sabores='{id}'";
            SqliteCommand comando = new SqliteCommand(consulta, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
        }
        
    }
}

