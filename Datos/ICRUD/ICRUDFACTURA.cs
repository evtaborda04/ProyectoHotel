using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.ICRUD
{
    public interface ICRUDFACTURA<R>
    {
        string Insertar(R rent);
        string Eliminar(R ren);
        string Actualizar(R rent);
        R BuscarFactura(string id);
        List<R> ConsultarTodos(string rent);
    }
}
    