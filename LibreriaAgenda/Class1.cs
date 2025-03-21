using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LibreriaAgenda
{
    public class Tarea
    {
        public string Descripcion { get; set; }
        public DateTime FechaVencimiento { get; set; }

        public Tarea(string descripcion, DateTime fechaVencimiento)
        {
            Descripcion = descripcion;
            FechaVencimiento = fechaVencimiento;
        }
    }

    public static class Agenda
    {
        static List<Tarea> listaTareas = new List<Tarea>();

        // Método para agregar una tarea
        public static void AgregarTarea()
        {
            Console.Write("📝 Ingresa la descripción de la tarea: ");
            string descripcion = Console.ReadLine();

            Console.Write("📅 Ingresa la fecha de vencimiento (yyyy-MM-dd): ");
            if (DateTime.TryParse(Console.ReadLine(), out DateTime fechaVencimiento))
            {
                listaTareas.Add(new Tarea(descripcion, fechaVencimiento));
                Console.WriteLine("✅ Tarea agregada correctamente.");
            }
            else
            {
                Console.WriteLine("❌ Fecha inválida, intenta de nuevo.");
            }

            Console.ReadKey();
        }

        // Método para marcar una tarea como completada
        public static void MarcarTareaComoCompletada()
        {
            MostrarTareasPendientes();
            Console.Write("\n🔢 Ingresa el número de la tarea completada: ");

            if (int.TryParse(Console.ReadLine(), out int indice) && indice > 0 && indice <= listaTareas.Count)
            {
                listaTareas.RemoveAt(indice - 1);
                Console.WriteLine("✅ Tarea eliminada con éxito.");
            }
            else
            {
                Console.WriteLine("❌ Número inválido, intenta de nuevo.");
            }

            Console.ReadKey();
        }

        // Método para mostrar tareas pendientes
        public static void MostrarTareasPendientes()
        {
            Console.Clear();
            Console.WriteLine("📋 TAREAS PENDIENTES 📋\n");

            if (listaTareas.Count == 0)
            {
                Console.WriteLine("🎉 No hay tareas pendientes.");
            }
            else
            {
                for (int i = 0; i < listaTareas.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {listaTareas[i].Descripcion} - 📆 {listaTareas[i].FechaVencimiento.ToShortDateString()}");
                }
            }

            Console.ReadKey();
        }
    }
}