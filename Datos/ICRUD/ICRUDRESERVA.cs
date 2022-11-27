using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.ICRUD
{
    public interface ICRUDRESERVA<R>
    {
        string Insertar(R res);
        string Eliminar(R res);
        string Actualizar(R res);
        R BuscarReserva(string id);
        List<R> ConsultarTodos(string hab);
    }
}
