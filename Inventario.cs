using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_de_Inventario
{
    class Inventario
    {
        Producto inicio;
        Producto temp;


        public Inventario()
        {
            inicio = null;
        }

        public void Agregar(Producto producto)
        {
            bool ban = true;
            if (inicio == null)
            {
                inicio = producto;
            }
            else
            {
                temp = inicio;
                while (temp.siguiente != null)
                {
                    if (temp.codigo == producto.codigo)
                    {
                        ban = false;
                    }
                    temp = temp.siguiente;
                }
                if (temp.codigo != producto.codigo && ban)
                {
                    temp = inicio;
                    if (producto.codigo < temp.codigo)
                    {
                        producto.siguiente = temp;
                        inicio = producto;
                    }
                    else
                    {
                        ban = true;
                        while (temp.siguiente != null)
                        {
                            if (producto.codigo < temp.siguiente.codigo)
                            {
                                producto.siguiente = temp.siguiente;
                                temp.siguiente = producto;
                                ban = false;
                                break;
                            }
                            temp = temp.siguiente;
                        }
                        if (ban)
                        {
                            temp.siguiente = producto;
                        }
                    }
                }
            }

        }

        public void Eliminar(int codigo)
        {
            temp = inicio;
            if (temp.codigo == codigo)
            {
                inicio = temp.siguiente;
            }
            else
            {
                while (temp.siguiente != null)
                {
                    if (temp.siguiente.codigo == codigo)
                    {
                        if (temp.siguiente.siguiente == null)
                        {
                            temp.siguiente = null;
                        }
                        else
                        {
                            temp.siguiente = temp.siguiente.siguiente;
                        }
                    }
                    if (temp.siguiente != null)
                    {
                        temp = temp.siguiente;
                    }
                }
            }
        }


        public Producto Buscar(int codigo)
        {
            temp = inicio;
            Producto producto = null;
            while (temp != null)
            {
                if (temp.codigo == codigo)
                {
                    producto = temp;
                }
                temp = temp.siguiente;
            }
            return producto;
        }

        public string Reporte()
        {
            String datos = "";
            temp = inicio;
            while (temp != null)
            {
                datos += temp.ToString() + Environment.NewLine;
                temp = temp.siguiente;
            }
            return datos;
        }

    }
}
