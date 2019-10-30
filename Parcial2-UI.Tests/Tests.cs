using BLL;
using Entidades;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Parcial2_UI.Tests
{
    [TestClass]
    public class Tests
    {
        [TestMethod()]
        public void GuardarCliente()
        {
            Clientes cliente = new Clientes();
            cliente.ClienteId = 1;
            cliente.Nombres = "Juan Perez";
            cliente.Balance = 1000;

            RepositorioBase<Clientes> r = new RepositorioBase<Clientes>();
            bool paso = false;
            paso = r.Guardar(cliente);
            Assert.AreEqual(true, paso);
        }
        [TestMethod()]
        public void ModificarCliente()
        {
            RepositorioBase<Clientes> repositoriobase = new RepositorioBase<Clientes>();
            bool paso = false;
            Clientes cliente = repositoriobase.Buscar(1);
            cliente.Nombres = "Juan Elias";
            paso = repositoriobase.Modificar(cliente);
            Assert.AreEqual(true, paso);
        }
        [TestMethod()]
        public void EliminarCliente()
        {
            RepositorioBase<Clientes> repositoriobase = new RepositorioBase<Clientes>();
            bool paso = false;
            paso = repositoriobase.Eliminar(1);
            Assert.AreEqual(true, paso);
        }
    }
}
