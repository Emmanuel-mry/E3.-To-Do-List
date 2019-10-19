using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeTareas
{
   public class RepoTarea:Tarea
    {
        int c; //declarando globalmente un contador
        List<Tarea> TR = new List<Tarea>(); //Declarando globalmente la lista
        public void Menu() //Aqui se abre el menu de opciones
        {
            Console.WriteLine("-----BIENVENIDO-----");
            Console.WriteLine();
            Console.WriteLine("Seleccione la opcion que desea realizar");
            Console.WriteLine();
            Console.WriteLine("1) Crear una tarea ");
            Console.WriteLine("2) Mostrar lista de tareas");
            Console.WriteLine("3) Mostrar detalle de tarea");
            Console.WriteLine("4) Estatus de tareas");
            Console.WriteLine("5) Cambiar estatus de tareas");
            Console.WriteLine("6) SALIR");
            Console.WriteLine();
            


            switch (Console.ReadLine()) //La respuesta se puso directo en el switch
            {
                case "1":
                    AgregarTareas();

                    Menu();


                    break;
                case "2":
                    MostrarLista();

                    break;
                case "3":
                    DetalleTarea();

                    break;
                case "4":
                    EstatusTarea();
                    break;
                case "5":

                    break;
                case "6":

                default:
                    break;
            }

        }
        public void AgregarTareas() //En este metodo es donde se van a crear las listas de tareas
        {
            do //Utilice un do while para crear cuantas listas quiera el usuario
            {
                c++; //Utilice un contador como id de las tareas
                Console.Clear();

                TR.Add(new Tarea { Id = c });
                Console.WriteLine("TAREA "+c+"#");
                Console.WriteLine();
                Console.WriteLine("Ingrese su nombre: ");
                TR.Add(new Tarea { NombreUsuario = Console.ReadLine() });
                Console.WriteLine();
                Console.WriteLine("Ingrese la tarea a realizar: ");
                TR.Add(new Tarea { tarea = Console.ReadLine() });
                Console.WriteLine();
                Console.WriteLine("Ingrese hora: ");
                TR.Add(new Tarea { Hora = Console.ReadLine() });
                Console.WriteLine();
                Console.WriteLine("Ingrese la fecha: ");
                TR.Add(new Tarea { Fecha = Console.ReadLine() });
                Console.WriteLine();
                Console.WriteLine("Ingrese el estatus de la tarea: ");
                Console.WriteLine("pendiente - en proceso - finalizada (capturar en miniscula)");
                Console.WriteLine();
                TR.Add(new Tarea { Estatus = Console.ReadLine() });
                Console.WriteLine();
                Console.WriteLine("Desea crear otra tarea?");



            } while (Console.ReadLine() == "si"); //Si el usuario escribe si se crea otra lista
            Console.Clear();
            Menu();

        }

        public void MostrarLista() //En este metodo se muestran todas las listas que se capturan
        {
            Console.Clear();
            foreach (Tarea item in TR)
            {
                Console.WriteLine("{0}-{1}{2}{3}{4}{5}", item.Id, item.tarea, item.Estatus, item.NombreUsuario, item.Hora, item.Fecha);

            }


            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
            Menu();

        }
        public void DetalleTarea() //En este metodo se muestra el detalle de cada tarea

        {
            Console.WriteLine("Ingrese nombre de la tarea que desea revisar");
            string nomtarea = Console.ReadLine();
            
            foreach (Tarea item in TR)
            {
                if (nomtarea==item.tarea)
                {
                    Console.WriteLine(item.tarea);
                    Console.WriteLine(item.NombreUsuario);
                    Console.WriteLine(item.Hora);
                    Console.WriteLine(item.Fecha);
                    Console.WriteLine(item.Estatus);
                }

                
            }

            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
            Menu();

        }
        public void EstatusTarea()
        {
            Console.WriteLine("Seleccione la opcion que desea");
            Console.WriteLine("1) PENDIENTES");
            Console.WriteLine("2) EN PROCESO");
            Console.WriteLine("3) FINALIZADA");
      var  c = Console.ReadLine();

           


        }

        public void CambiarEstatus()
        {

        }
    }
}
