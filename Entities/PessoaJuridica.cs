namespace Exercise_H_P.Entities
{
    class PessoaJuridica : Contribuente
    {
        public int Funcionarios { get; set; }

        public PessoaJuridica(string nome, double rendaanual, int funcionarios) : base(nome, rendaanual)
        {
            Funcionarios = funcionarios;
        }
        
        public override double Imposto()
        {
            if(Funcionarios > 10){
                return RendaAnual * 0.14;
            }else{
                return RendaAnual * 0.16;
            }
        }

    }
}
