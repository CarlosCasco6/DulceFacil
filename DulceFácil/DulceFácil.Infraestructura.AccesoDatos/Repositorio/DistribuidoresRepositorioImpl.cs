using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DulceFácil.Dominio.Modelos.Abstracciones;

namespace DulceFácil.Infraestructura.AccesoDatos.Repositorio
{
    public class DistribuidoresRepositorioImpl : RepositorioImpl<Distribuidores>, IDistribuidoresRepositorio
    {
        public DistribuidoresRepositorioImpl(DulceFacilDBContext dBContext) : base(dBContext)
        {
        }
    }
   
    
}
