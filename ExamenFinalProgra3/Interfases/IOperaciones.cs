using ExamenFinalProgra3.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinalProgra3.Interfases
{
    public interface IOperaciones
    {
        void BuscarMaterial(int id);
        ClaseMateriales ObtenerProveedor(int id);
        List<ClaseMateriales> ObtenerProveedor();
        List<ClaseMateriales> ObtenerProveedor(string Proveedor);

        
    }
}
