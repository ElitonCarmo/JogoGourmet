using JogoGourmet.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace JogoGourmet.Controller
{
    public class CaracteristicaController
    {
        public static DialogResult AdivinharCaracteristica(PratosAdivinhacao prato)
        {
            return MessageBox.Show("O Prato que você pensou é " + prato.GetCaracteristica() + "?", "", MessageBoxButtons.YesNo);
        }
    }
}
