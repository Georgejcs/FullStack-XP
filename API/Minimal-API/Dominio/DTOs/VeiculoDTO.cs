using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Minimal_API.Dominio.DTOs
{
    public record veiculoDTO
    {
        public string Nome { get; set; } = default!;
        public string Marca { get; set; } = default!;
        public int Ano { get; set; } = default!;
    }
}