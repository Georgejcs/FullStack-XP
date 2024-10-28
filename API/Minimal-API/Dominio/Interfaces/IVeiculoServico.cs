using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Minimal_API.Dominio.Entidades;
using MinimalApi.DTOs;

namespace Minimal_API.Dominio.Interfaces
{
    public interface IVeiculoServico
    {
        List<Veiculo> Todos(int? pagina, string? nome = null, string? marca = null);

        Veiculo? BuscaPorId(int id);

        void Incluir(Veiculo veiculo);

        void Atualizar(Veiculo veiculo);
        
        void Apagar(Veiculo veiculo);
    }
}