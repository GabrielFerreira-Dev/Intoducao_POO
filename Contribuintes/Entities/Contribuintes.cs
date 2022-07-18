namespace Contribuintes
{
    abstract class Contribuintes
    {
        private string _nome;
        private double _rendaAnual;
        public double RendaAnual
        {
            get { return _rendaAnual; }
            set { _rendaAnual = value; }
        }
        
        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }
        public Contribuintes()
        {

        }
        public Contribuintes(string nome, double rendaAnual)
        {
            Nome = nome;
            RendaAnual = rendaAnual;
        }
        
        public virtual string ToString()
        {
            return Nome
            + ": "
            + RendaAnual.ToString("F2");
        }
    }
}