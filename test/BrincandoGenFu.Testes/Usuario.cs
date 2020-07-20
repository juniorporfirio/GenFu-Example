using System;
using System.Collections.Generic;
using System.Linq;

namespace BrincandoGenFu.Testes
{
    public class Usuario
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Twitter { get; set; }
    }

    public class Reuniao
    {
        public DateTime Data { get; set; }
        public string Descricao { get; set; }
        public List<Usuario> Participantes { get; set; }
        public string Url { get; set; }
    }
}