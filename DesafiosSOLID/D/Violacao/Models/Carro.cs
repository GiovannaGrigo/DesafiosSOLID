using DesafiosSOLID.D.Violacao.Models;

namespace DesafiosSOLID.D.Violacao.Models
{
    public class Carro
    {
        private RodaEspecifica roda;

        public Carro()
        {
            roda = new RodaEspecifica(); // Dependência direta
        }

        public void Dirigir()
        {
            roda.Girar(); // O carro depende de um tipo concreto
        }
    }
}