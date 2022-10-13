using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using pg5_semana5_capaDatos.Clases;
using pg5_semana5_capaLogica.Clases;

namespace pg5_semana4 {
    public partial class Incluir_Empleado : System.Web.UI.Page {

        MetodosLogica logic = new MetodosLogica();
        EntidadEmpleado entEmp = new EntidadEmpleado();

        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void handleSave(object sender, EventArgs e) {

            if (txtNombre.Text == "" | txtCodigo.Text == "" | txtLabora.Text == "" | txtHora.Text == "") {
                Response.Write("<script>alert('Debe llenar todos los campos')</script>");
            } else {
                entEmp.codigo_empleado = Convert.ToInt32(txtCodigo.Text);
                entEmp.Nombre = txtNombre.Text;
                entEmp.Horas_laboradas = Convert.ToInt32(txtLabora.Text);
                entEmp.Salario_Hora = Convert.ToInt32(txtHora.Text);
                entEmp.Salario_Bruto = Convert.ToInt32(txtLabora.Text) * Convert.ToInt32(txtHora.Text);

                logic.Guardar(entEmp);
                Response.Write("<script>alert('Empleado guardado con exito')</script>");

            }
        }
    }
}