using pg5_semana5_capaDatos.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pg5_semana5_capaDatos.Clases {
    public class MetodosEmpleado {

        PG5_PRACTICA2Entities db = new PG5_PRACTICA2Entities();
        
        public bool Guardar(empleado emp) {
            db.empleado.Add(emp);
            db.SaveChanges();
            return true;
        }
    }
}
