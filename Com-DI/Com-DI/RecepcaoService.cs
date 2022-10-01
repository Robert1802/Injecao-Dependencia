using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com_DI
{
    internal class RecepcaoService : IRecepcaoService
    {
        public string Saudacao(string nome) => $"Ola, {nome}";
    }
}
