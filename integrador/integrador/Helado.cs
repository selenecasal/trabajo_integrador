using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace integrador
{
    public abstract class Helado
    {
        protected string nombre;
        protected string descripcion;
        protected int precio;
        Helado(string nom, string descrip, int prec)
        {
            nombre = nom;
            descripcion = descrip;
            precio = prec;
        } 
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
        /*public abstract void CalcularPrecio();*/
    }
}

