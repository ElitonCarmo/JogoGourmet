using System;
using System.Collections.Generic;
using System.Windows.Forms;
using JogoGourmet.Model;

namespace JogoGourmet.Controller
{
    public class JogoController
    {
        public static DialogResult resposta;

        public static List<PratosAdivinhacao> listaPratosAdivinhacao;

        public static int IniciarJogo()
        {
            Prato prato = new Prato("Lasanha", "massa");
            resposta = CaracteristicaController.AdivinharCaracteristica(prato);

            if (resposta == DialogResult.Yes)
                listaPratosAdivinhacao = PratosController.listaPratos.GetPratosComCaracteristicaInicial();
            else
                listaPratosAdivinhacao = PratosController.listaPratos.GetPratosSemCaracteristicaInicial();
            return PratosController.AdivinharPratos();
        }
    }
}
