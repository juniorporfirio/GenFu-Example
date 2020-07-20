using System;
using System.Collections.Generic;
using FluentAssertions;
using GenFu;
using Xunit;

namespace BrincandoGenFu.Testes
{
    public class ReuniaoTeste
    {
        const int vinte = 20;
        public ReuniaoTeste()
        {
            A.Reset();
            ConfigurarUsuario();
            ConfigurarReuniao();
        }
        private void ConfigurarUsuario()
        {
            A.Configure<Usuario>()
            .Fill(x => x.Nome).AsFirstName()
            .Fill(x => x.Email).AsEmailAddress()
            .Fill(x => x.Telefone).AsPhoneNumber()
            .Fill(x => x.Twitter).AsTwitterHandle();
        }

        private void ConfigurarReuniao()
        {
            var usuarios = A.ListOf<Usuario>(vinte);

            A.Configure<Reuniao>()
            .Fill(x => x.Data).AsFutureDate()
            .Fill(x => x.Descricao).AsMusicGenreDescription()
            .Fill(x => x.Participantes, usuarios);
            A.Default().FillerManager.RegisterFiller(new WebsiteFiller());

        }

        [Fact]
        public void DeveTerVinteInstanciasDeReunioesComDadosGenFu()
        {
            var reunioes = A.ListOf<Reuniao>(vinte);
            reunioes.Should().HaveCount(vinte);
        }

        [Fact]
        public void DeveRetornarUmaInstanciaDeReuniaoGenFu()
        {
            var reuniao = A.New<Reuniao>();
            reuniao.Participantes.Should().HaveCount(20);
        }
    }
}
