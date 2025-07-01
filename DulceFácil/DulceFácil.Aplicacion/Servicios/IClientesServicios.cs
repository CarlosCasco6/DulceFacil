using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using DulceFácil.Infraestructura.AccesoDatos;

namespace DulceFácil.Aplicacion.Servicios
{
    [ServiceContract]

    public interface IClientesServicios
    {
        [OperationContract]
        Task AddClienteAsync(Clientes nuevoCliente);

        [OperationContract]
        Task UpdateClienteAsync(Clientes Entity);//actualizar
        [OperationContract]
        Task DeleteClienteAsync(int id);//eliminar por ID
        [OperationContract]
        Task<IEnumerable<Clientes>> GetAllClienteAsync();//listar todo
        [OperationContract]
        Task<Clientes> GetByIdClienteAsync(int id);//buscar por ID
    }
}

