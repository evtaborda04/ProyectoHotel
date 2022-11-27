using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.ICRUD
{
    public interface ICRUDCLIENTE<C>
    {
        string Insertar(C cli);
        string Eliminar(C cli);
        string Actualizar(C cli);
        C BuscarID(string id);
        List<C> ConsultarTodos(string cli);
    }
}
