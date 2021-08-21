using System;
using System.Windows.Forms;
using JogoGourmet.Controller;
using JogoGourmet.Model;
using Microsoft.VisualBasic;

namespace JogoGourmet.View
{
    public partial class View : Form
    {
        public View()
        {
            InitializeComponent();
            PratosController.Inicializa();
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            int Posicao = JogoController.IniciarJogo();
            if (Posicao >= 0) {
                AdicionarNovoPrato(Posicao);
            }
        }

        private void AdicionarNovoPrato(int Posicao)
        {
            string nomePrato = Interaction.InputBox("Qual prato você pensou?", "Desisto", string.Empty, 200, 200);
            string caracteristicaPrato = Interaction.InputBox(nomePrato + " é _____ mas " + JogoController.listaPratosAdivinhacao[Posicao].GetNome() + " não.", "Complete", string.Empty, 200, 200);

            if (string.IsNullOrWhiteSpace(nomePrato.Trim()) || string.IsNullOrWhiteSpace(caracteristicaPrato.Trim()))
                MessageBox.Show("Não consegui identificar o novo prato, que pena!", "", MessageBoxButtons.OK);
            else
                JogoController.listaPratosAdivinhacao.Insert(Posicao, new Prato(nomePrato, caracteristicaPrato));
        }
    }
}
