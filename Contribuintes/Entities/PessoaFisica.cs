namespace Contribuintes.Entities
{
    class PessoaFisica : Contribuintes
    {
        private double _gastosSaude;
        public double GastosSaude
        {
            get { return _gastosSaude; }
            set { _gastosSaude = value; }
        }
        public PessoaFisica(string nome, double rendaAnual, double gastosSaude) : base(nome, rendaAnual)
        {
            GastosSaude = gastosSaude;
        }
        public double Impostos()
        {
            if (RendaAnual <= 2000)
            {
                return ((RendaAnual * 0.15) - (GastosSaude * 0.5)); 
            }
            else
            {
                return ((RendaAnual * 0.25) - (GastosSaude * 0.5));
            }
        }
        public override string ToString()
        {
            return Nome
            + "; Impostos a serem pagos:  "
            + Impostos().ToString("F2")
            + " de uma renda de R$"
            + RendaAnual.ToString("F2");
        }
    }
}