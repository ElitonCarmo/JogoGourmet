using System;
using System.Windows.Forms;
using JogoGourmet.Model;

namespace JogoGourmet.Controller
{
    public class PratosController
    {
        public static ListaPratos<PratosAdivinhacao> listaPratos;

        public static void Inicializa()
        {
            listaPratos = new ListaPratos<PratosAdivinhacao>();
            listaPratos.GetPratosComCaracteristicaInicial().Add(new Prato("Lasanha", "")); 
            listaPratos.GetPratosSemCaracteristicaInicial().Add(new Prato("Bolo de chocolate", "")); 
        }

        public static int AdivinharPratos()
        {
            int Posicao = 0;

            for (int i = 0; i < JogoController.listaPratosAdivinhacao.Count; i++)
            {
                if (i == JogoController.listaPratosAdivinhacao.Count - 1)
                {
                    JogoController.resposta = AdivinharPrato(JogoController.listaPratosAdivinhacao[i]);
                }
                else
                {
                    JogoController.resposta = CaracteristicaController.AdivinharCaracteristica(JogoController.listaPratosAdivinhacao[i]);

                    if (JogoController.resposta == DialogResult.Yes)
                    {
                        JogoController.resposta = AdivinharPrato(JogoController.listaPratosAdivinhacao[i]);
                        break;
                    }
                }
                Posicao = i;
            }

            if (JogoController.resposta == DialogResult.Yes)
            {
                MessageBox.Show("Acertei de novo!", "", MessageBoxButtons.OK);
                Posicao = - 1;
            }
            return Posicao;
        }

        private static DialogResult AdivinharPrato(PratosAdivinhacao prato)
        {
            return MessageBox.Show("O Prato que você pensou é " + prato.GetNome() + "?", "", MessageBoxButtons.YesNo);
        }
    }
}
