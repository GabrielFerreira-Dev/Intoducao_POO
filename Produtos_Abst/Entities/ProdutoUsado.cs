namespace Produtos_Abst.Entities
{
    public class ProdutoUsado : Produto
    {
        private string _dateManufacture;
        public string DataManufatura
        {
            get { return _dateManufacture; }
            set { _dateManufacture = value; }
        }
        public ProdutoUsado(string nome, double preco, string _dateManufacture) : base(nome, preco)
        {
            DataManufatura = _dateManufacture;
        }

        public override string PriceTag()
        {
            return Name
            + "(USADO) $"
            + Price.ToString("F2")
            + ", (DATA DE MANUFATURA: "
            + DataManufatura
            + ")";
        }
        
    }
}