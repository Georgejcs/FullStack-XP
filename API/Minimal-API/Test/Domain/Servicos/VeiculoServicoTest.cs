using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Minimal_API.Dominio.Entidades;
using Minimal_API.Dominio.Servicos;
using Minimal_API.Infraestrutura.Db;

namespace Test.Domain.Servicos
{
    [TestClass]
    public class VeiculoServicoTest
    {
       private DbContexto CriarContextoDeTeste()
    {
        var assemblyPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        var path = Path.GetFullPath(Path.Combine(assemblyPath ?? "", "..", "..", ".."));

        var builder = new ConfigurationBuilder()
            .SetBasePath(path ?? Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .AddEnvironmentVariables();

        var configuration = builder.Build();

        return new DbContexto(configuration);
    }


    [TestMethod]
    public void TestandoSalvarVeiculo()
    {
        // Arrange
        var context = CriarContextoDeTeste();
        context.Database.ExecuteSqlRaw("TRUNCATE TABLE Veiculos");

        var vet = new Veiculo();
        vet.Nome = "Dodge Challenger SRT Demon";
        vet.Marca = "Dodge";
        vet.Ano = 2018;

        var veiculoServico = new VeiculoServico(context);

        // Act
        veiculoServico.Incluir(vet);

        // Assert
        Assert.AreEqual(1, veiculoServico.Todos(1).Count());
    }

    [TestMethod]
    public void TestandoBuscaPorId()
    {
        // Arrange
        var context = CriarContextoDeTeste();
        context.Database.ExecuteSqlRaw("TRUNCATE TABLE Veiculos");

        var vet = new Veiculo();
        vet.Nome = "Dodge Challenger SRT Demon";
        vet.Marca = "Dodge";
        vet.Ano = 2018;

        var veiculoServico = new VeiculoServico(context);

        // Act
        veiculoServico.Incluir(vet);
        var vetDoBanco = veiculoServico.BuscaPorId(vet.Id);

        // Assert
        Assert.AreEqual(1, vetDoBanco?.Id);
    }
}
}