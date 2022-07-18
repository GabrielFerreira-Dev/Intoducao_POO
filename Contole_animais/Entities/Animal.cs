namespace Contole_animais.Entities
{
    public class Animal
    {
        private string _tipo;
        private string _nome;
        public string Tipo
        {
            get { return _tipo; }
            set { _tipo = value; }
        }        
        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }
        public Animal(string tipo, string nome)
        {
            Tipo = tipo;
            Nome = nome;
        }

        public override string ToString()
        {
            return "Tipo: "
            + Tipo
            + ", Nome: "
            + Nome.ToString();
        }
    }
}