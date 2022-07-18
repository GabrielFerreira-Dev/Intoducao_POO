namespace Maior_Idade.Entities
{
    public class Pessoa
    {
        private string _nome;
        private int _idade;       
        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }        
        
        public int Idade
        {
            get { return _idade; }
            set { _idade = value; }
        }
        public Pessoa()
        {
            
        }
        public Pessoa(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }
        
        public string exibirDados()
        {
            return "Nome: "
            + Nome
            + ", idade: "
            + Idade;
        }
        
    }
}