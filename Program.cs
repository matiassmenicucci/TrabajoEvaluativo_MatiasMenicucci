using System;
using System.Collections.Generic;

namespace ProyectoArticulos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> ArticulosLocal1 = new List<string>();

            // Ejemplo de uso de las funciones
            bool resultadoAgregar = Funciones.Agregar_Producto(ArticulosLocal1, "Lapicera");
            bool resultadoBorrar = Funciones.Borrar_Producto(ArticulosLocal1, "Lapicera");
            Funciones.Mostrar_todos_Productos(ArticulosLocal1);
            bool resultadoModificar = Funciones.Modificar_Producto(ArticulosLocal1, "Lapiz", "Fibron");
            int posicion = Funciones.Buscar_Producto(ArticulosLocal1, "Fibron");

            Console.WriteLine("Resultado agregar: " + resultadoAgregar);
            Console.WriteLine("Resultado borrar: " + resultadoBorrar);
            Console.WriteLine("Resultado modificar: " + resultadoModificar);
            Console.WriteLine("Posición: " + posicion);
        }
    }
}