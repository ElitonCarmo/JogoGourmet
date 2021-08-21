using System;
using System.Collections.Generic;

namespace JogoGourmet.Model
{
    public interface IListaPratosAdivinhacao<T> where T : PratosAdivinhacao
    {
        List<PratosAdivinhacao> GetPratosComCaracteristicaInicial();

        List<PratosAdivinhacao> GetPratosSemCaracteristicaInicial(); 
    }
}
