using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Minimal_API.Dominio.ModelViews
{
    public struct Home
    {
        public string Mensagem { get => "Bem vindo a API de veículos - Minimal API"; }
        public string Doc { get => "/swagger"; }
    }
}