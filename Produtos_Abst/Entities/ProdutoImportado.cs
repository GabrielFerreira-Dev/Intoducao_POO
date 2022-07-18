namespace Produtos_Abst.Entities
{
    public class ProdutoImportado : Produto
    {
        private double _customFee;
        public double CustomFee
        {
            get { return _customFee; }
            set { _customFee = value; }
        }
        public ProdutoImportado(string nome, double preco, double custoAdicional) : base(nome, preco)
        {
            CustomFee = custoAdicional;
        }
        public double totalPrice()
        {
            return Price += CustomFee;
        }

        public override string PriceTag()
        {
            return Name
            + " $"
            + totalPrice().ToString("F2")
            + " (Custom Fee: $ " 
            + CustomFee.ToString("F2") 
            +")";
        }
        
        
    }
}