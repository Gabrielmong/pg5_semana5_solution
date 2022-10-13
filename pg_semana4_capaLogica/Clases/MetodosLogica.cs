using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pg5_semana5_capaDatos.Clases;
using pg5_semana5_capaDatos.Model;

namespace pg_semana4_capaLogica
{
    public class MetodosLogica
    {
        MetodosEmpleado met = new MetodosEmpleado();

        public bool Guardar(EntidadEmpleado ent) {
            empleado tblEmp = new empleado();
            tblEmp.codigo_empleado = ent.codigo_empleado;
            tblEmp.Nombre = ent.Nombre;
            tblEmp.Horas_laboradas = ent.Horas_laboradas;
            tblEmp.Salario_Hora = ent.Salario_Hora;
            tblEmp.Salario_Bruto = ent.Salario_Bruto;

            return met.Guardar(tblEmp);

        }

    }
}
