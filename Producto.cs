using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_de_Inventario
{
    class Producto
    {
        private int _codigo;
        private String _nombre;
        private int _cantidad;
        private int _precio;

        public Producto siguiente;

        public int codigo
        {
            get { return _codigo; }
        }

        public string nombre
        {
            get { return _nombre; }

        }

        public int cantidad
        {
            get { return _cantidad; }
        }

        public int precio
        {
            get { return _precio; }
        }

        
        public Producto(int codigo, string nombre, int cantidad, int precio)
        {
            _codigo = codigo;
            _nombre = nombre;
            _cantidad = cantidad;
            _precio = precio;
        }

       
        public override string ToString()
        {
            return codigo + " " + nombre + " " + cantidad + " $" + precio;
        }
    }
}

