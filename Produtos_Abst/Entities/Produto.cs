namespace Produtos_Abst.Entities
{
    public class Produto
    {
        private string _name;
        private double _price;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }        
        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }
        public Produto()
        {
            
        }
        public Produto(string nome, double preco)
        {
            Name = nome;
            Price = preco;
        }

        public virtual string PriceTag()
        {
            return Name
            + " $"
            + Price.ToString("F2");
        }
        
    }
}