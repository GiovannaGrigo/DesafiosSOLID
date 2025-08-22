using DesafiosSOLID.L.Violacao.Models;

namespace DesafiosSOLID.L.Violacao.Models
{
    public class Pinguim : Ave
    {
        public override void Voar()
        {
            // Pinguins não voam! Isso quebra a lógica.
        }
    }
}