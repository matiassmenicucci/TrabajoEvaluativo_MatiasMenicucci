using System;
using System.Collections.Generic;

namespace ProyectoArticulos
{
    public class Funciones
    {
        public static bool Agregar_Producto(List<string> lista, string nuevo)
        {
            if (!lista.Contains(nuevo))
            {
                lista.Add(nuevo);
                return true;
            }
            return false;
        }

        public static bool Borrar_Producto(List<string> lista, string producto)
        {
            return lista.Remove(producto);
        }

        public static void Mostrar_todos_Productos(List<string> lista)
        {
            foreach (string producto in lista)
            {
                Console.WriteLine(producto);
            }
        }

        public static bool Modificar_Producto(List<string> lista, string viejo, string nuevo)
        {
            int pos = Buscar_Producto(lista, viejo);
            if (pos != -1)
            {
                lista[pos] = nuevo;
                return true;
            }
            return false;
        }

        public static int Buscar_Producto(List<string> lista, string producto)
        {
            return lista.IndexOf(producto);
        }
    }
}