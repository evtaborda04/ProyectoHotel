using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.ICRUD
{
    public interface ICRUDHABITACION<H>
    {
        string Insertar(H hab);
        string Eliminar(H hab);
        string Actualizar(H hab);
        H BuscarHabitacion(string id);
        List<H> ConsultarTodos(string hab);
    }
}
