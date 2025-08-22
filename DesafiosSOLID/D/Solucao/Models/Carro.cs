namespace DesafiosSOLID.D.Solucao.Models
{
    public class Carro
    {
        private Roda roda;

        public Carro(Roda rodaEscolhida)
        {
            roda = rodaEscolhida; // Dependência invertida: carro não escolhe a roda
        }

        public void Dirigir()
        {
            roda.Girar(); // O carro depende de Roda genérica
        }
    }
}