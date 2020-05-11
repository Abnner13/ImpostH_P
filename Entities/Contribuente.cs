namespace Exercise_H_P.Entities
{
    abstract class Contribuente
    {
        public string Nome { get; set; }
        public double RendaAnual { get; set; }

        public Contribuente()
        {
            
        }
        public Contribuente(string nome, double rendaanual)
        {
            Nome = nome;
            RendaAnual = rendaanual;
        }

        public abstract double Imposto();
    }
}
