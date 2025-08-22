using DesafiosSOLID.O.Solucao.Models;

namespace DesafiosSOLID.O.Solucao.Models
{
    public class Desenhista
    {
        public void DesenharFormas(List<Forma> formas)
        {
            foreach (var forma in formas)
            {
                forma.Desenhar();
            }
        }
    }
}