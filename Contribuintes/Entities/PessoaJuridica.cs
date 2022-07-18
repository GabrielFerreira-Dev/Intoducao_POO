namespace Contribuintes.Entities
{
    class PessoaJuridica : Contribuintes
    {
        private int _quantiaDeFuncionarios;
        public int QuantiaDeFuncionarios
        {
            get { return _quantiaDeFuncionarios; }
            set { _quantiaDeFuncionarios = value; }
        }
        public PessoaJuridica(string nome, double rendaAnual, int quantiaDeFuncionarios) : base(nome,rendaAnual)
        {
            QuantiaDeFuncionarios = quantiaDeFuncionarios;
        }
        public double Impostos()
        {
            if (QuantiaDeFuncionarios <= 10)
            {
                return RendaAnual * 0.16;
            }
            else
            {
                return RendaAnual * 0.14;
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