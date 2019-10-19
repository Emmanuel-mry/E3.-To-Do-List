using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeTareas
{
  public  class Tarea 
    {
        public int Id { get; set; }
        public string NombreUsuario { get; set; }
        public string tarea { get; set; }
        public string Hora { get; set; }
        public string Fecha { get; set; } //La hice en string porque soy tonto y no supe manejar el datatime
        public string Estatus { get; set; }
    }
}
