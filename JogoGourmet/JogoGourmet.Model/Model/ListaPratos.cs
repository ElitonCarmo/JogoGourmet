using System;
using System.Collections.Generic;

namespace JogoGourmet.Model
{
    public class ListaPratos<T> : IListaPratosAdivinhacao<T> where T : PratosAdivinhacao
    {
        private List<PratosAdivinhacao> pratosComCaracteristicaInicial = new List<PratosAdivinhacao>();
        private List<PratosAdivinhacao> pratosSemCaracteristicaInicial = new List<PratosAdivinhacao>();

        public List<PratosAdivinhacao> GetPratosComCaracteristicaInicial()
        {
            return pratosComCaracteristicaInicial;
        }
        public List<PratosAdivinhacao> GetPratosSemCaracteristicaInicial()
        {
            return pratosSemCaracteristicaInicial;
        }
    }
}
