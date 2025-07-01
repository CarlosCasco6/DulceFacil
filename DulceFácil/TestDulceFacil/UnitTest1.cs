using DulceFácil.Aplicacion.Servicios;
using DulceFácil.Aplicacion.ServicosImpl;
using DulceFácil.Infraestructura.AccesoDatos;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace TestDulceFacil
{
    public class Tests : TestsBase
    {
        private IClientesServicios _clientesServicio;
        private DulceFacilDBContext _dulceFacilDBContext;

        [SetUp]
        public void Setup()
        {
            var option = new DbContextOptionsBuilder<DulceFacilDBContext>()
                .UseSqlServer("Data Source=DESKTOP-P9QMUGG;Initial Catalog=DulceFacil;Integrated Security=True; TrustServerCertificate=True;")
                .Options;
            _dulceFacilDBContext = new DulceFacilDBContext(option);
            _clientesServicio = new ClientesServiciosImpl(_dulceFacilDBContext);
        }

       

        [Test]
        public async Task Test1()
        {
            var nuevoCliente = new Clientes
            {
                cedula = "1004896468",
                nombre = "Alexandra Perugachi",
                direccion = "AV. 6 de Diciembre, pasaje N45C, Casa E8-36",
                correo = "alexandraperugachi07@gimal.com",
                telefono = "0981503984"
            };
            await _clientesServicio.AddClienteAsync(nuevoCliente);
            await _clientesServicio.GetAllClienteAsync();
            Assert.Pass();
        }

        [TearDown]
        public void TearDown()
        {
            _dulceFacilDBContext?.Dispose();
        }
    }
}