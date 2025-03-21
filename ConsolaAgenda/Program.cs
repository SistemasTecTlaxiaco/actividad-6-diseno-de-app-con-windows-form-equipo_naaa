using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaAgenda;

namespace ConsolaAgenda
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine(" AGENDA DE TAREAS ");
                Console.WriteLine("1. Agregar Tarea");
                Console.WriteLine("2. Mostrar Tareas Pendientes");
                Console.WriteLine("3. Marcar Tarea Como Completada");
                Console.WriteLine("4. Salir");
                Console.Write("Selecciona una opción: ");

                string opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        Agenda.AgregarTarea();
                        break;
                    case "2":
                        Agenda.MostrarTareasPendientes();
                        break;
                    case "3":
                        Agenda.MarcarTareaComoCompletada();
                        break;
                    case "4":
                        Console.WriteLine(" ¡Hasta luego!");
                        return;
                    default:
                        Console.WriteLine(" Opción no válida, intenta de nuevo.");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}
