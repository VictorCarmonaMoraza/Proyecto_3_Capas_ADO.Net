using CapaEntidad;
using System.Collections.Generic;

namespace CapaDatos
{
    public class TipoMedicamentoDAL
    {
        public List<TipoMedicamentoCLS> listarMedicamentos()
        {
            List<TipoMedicamentoCLS> lista = new List<TipoMedicamentoCLS>();
            lista.Add(new TipoMedicamentoCLS()
            {
                idtipomedicamento = 1,
                nombre = "Analgesicos",
                descripcion = "Des 1"
            });
            lista.Add(new TipoMedicamentoCLS()
            {
                idtipomedicamento = 2,
                nombre = "Antialegrivco",
                descripcion = "Des 2"
            });
            return lista;
        }
    }
}
