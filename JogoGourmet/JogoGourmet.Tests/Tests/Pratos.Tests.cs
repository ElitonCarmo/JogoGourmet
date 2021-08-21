using Microsoft.VisualStudio.TestTools.UnitTesting;
using JogoGourmet.Model;
using JogoGourmet.Controller;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace JogoGourmet.Tests.Tests
{
    [TestClass]
    public class Pratos
    {
        public static DialogResult resposta;

        [TestMethod]
        public void ValidarPrato()
        {
            string Nome = "testeNome";
            string Caracteristica = "testeCaracteristica";

            Prato testePrato = new Prato(Nome, Caracteristica);

            Assert.IsNotNull(testePrato);
            Assert.IsTrue(testePrato.GetNome() == Nome);
            Assert.IsTrue(testePrato.GetCaracteristica() == Caracteristica);
        }

        [TestMethod]
        public void ValidarSelecaoPrato()
        {
            PratosController.Inicializa();
            int Posicao = JogoController.IniciarJogo();
            Assert.IsTrue(Posicao >= 0 || Posicao == -1);
        }

        [TestMethod]
        public void ValidarAdicionarPrato()
        {
            PratosController.Inicializa();
            string UltimoNome = "", UltimaCaracteristica = "";
            string nomePrato = "Sorvete";
            string caracteristicaPrato = "Gelado";
            int Posicao = JogoController.IniciarJogo();
            if (Posicao >= 0)
            {
                if (!string.IsNullOrWhiteSpace(nomePrato.Trim()) || !string.IsNullOrWhiteSpace(caracteristicaPrato.Trim()))
                {
                    JogoController.listaPratosAdivinhacao.Insert(Posicao, new Prato(nomePrato, caracteristicaPrato));
                    UltimoNome = JogoController.listaPratosAdivinhacao.First().GetNome();
                    UltimaCaracteristica = JogoController.listaPratosAdivinhacao.First().GetCaracteristica();
                }
            }
            Assert.IsTrue(UltimoNome == nomePrato);
            Assert.IsTrue(UltimaCaracteristica == caracteristicaPrato);
        }
    }
}
