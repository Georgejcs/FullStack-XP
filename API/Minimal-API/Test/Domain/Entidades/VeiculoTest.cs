using Minimal_API.Dominio.Entidades;

namespace Test.Domain.Entidades
{
    [TestClass]
    public class VeiculoTest
    {
        [TestMethod]
        public void TestarGetSetPropriedadesVeiculo()
        {
            // Arange
            var vet = new Veiculo();

            // Act
            vet.Id = 1;
            vet.Nome = "Fiesta";
            vet.Marca = "Ford";
            vet.Ano = 2013;

            // Assert
            Assert.AreEqual(1, vet.Id);
            Assert.AreEqual("Fiesta", vet.Nome);
            Assert.AreEqual("Ford", vet.Marca);
            Assert.AreEqual(2013, vet.Ano);
        }
    }
}