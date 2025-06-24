using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DulceFácil.Dominio.Modelos.Abstracciones;
using DulceFácil.Infraestructura.AccesoDatos;
using DulceFácil.Infraestructura.AccesoDatos.Repositorio;

namespace DulceFácil.Aplicacion.ServicosImpl
{
    internal class ClientesServiciosImpl
    {
        private IClientesRepositorio clientesRepositorio;

        public ClientesServiciosImpl(DulceFacilDBContext _dulcefacilDBContext)
        {
            this.clientesRepositorio = new ClientesRepositorioImpl(_dulcefacilDBContext);
        }

        public async Task AddClienteAsync(Clientes nuevoCliente)
        {
            await clientesRepositorio.AddAsync(nuevoCliente);
        }

        public async Task DeleteClienteAsync(int id)
        {
            await clientesRepositorio.DeleteAsync(id);
        }

        public async Task<IEnumerable<Clientes>> GetAllClienteAsync()
        {
            return await clientesRepositorio.GetAllAsync();
        }

        public async Task<Clientes> GetByIdClienteAsync(int id)
        {
            return await clientesRepositorio.GetByIdAsync(id);
        }

        public async Task UpdateClienteAsync(Clientes Entity)
        {
            await clientesRepositorio.UpdateAsync(Entity);
        }
    }
}
