namespace DesafiosSOLID.S.Violacao.Models
{
    public class Passaro
    {
        public string Nome { get; set; }

        public void Voar()
        {
            // Aqui o pássaro deve voar
        }

        public void Bicar()
        {
            // Aqui o pássaro deve bicar
        }

        public void Latir()
        {
            // Aqui o pássaro está latindo (comportamento errado, isso pertence a um cachorro)
        }
    }
}
