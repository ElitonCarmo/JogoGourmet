using System;

namespace JogoGourmet.Model
{
    public class Prato: PratosAdivinhacao
    {
        public string Nome { get; set; }
        public string Caracteristica { get; set; }

        public Prato(string nome, string caracteristica)
        {
            Nome = nome;
            Caracteristica = caracteristica;
        }

        public string GetNome()
        {
            return Nome;
        }

        public string GetCaracteristica()
        {
            return Caracteristica;
        }
    }
}
