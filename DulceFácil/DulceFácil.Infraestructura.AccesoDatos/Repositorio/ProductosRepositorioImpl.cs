using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DulceFácil.Dominio.Modelos.Abstracciones;

namespace DulceFácil.Infraestructura.AccesoDatos.Repositorio
{
    public class ProductosRepositorioImpl: RepositorioImpl<Productos>, IProductosRepositorio
    {
        public ProductosRepositorioImpl(DulceFacilDBContext dBContext) : base(dBContext)
        {
        }
    }
    
    
}
