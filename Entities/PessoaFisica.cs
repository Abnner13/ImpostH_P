using System.Globalization;

namespace Exercise_H_P.Entities
{
    class PessoaFisica : Contribuente
    {
        public double Saude { get; set; }

        public PessoaFisica(string nome, double rendaanual, double saude) : base(nome, rendaanual)
        {
            Saude = saude;
        }

        public override double Imposto()
        {
            
            if(RendaAnual < 20000.00){
               return  RendaAnual * 0.15 - Saude * 0.5;
            }else{
                return  RendaAnual * 0.25 - Saude * 0.5;
            }


            throw new System.NotImplementedException();
        }

    }
}
