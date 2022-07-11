namespace Ex_03
{
    public class Aluno
    {
        public string Nome;
        public double Nota1, Nota2, Nota3;

        public double NotaFinal(){
            return Nota1 + Nota2 + Nota3;
        }

        public bool Aprovacao()
        {
            if(NotaFinal() >= 60)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public double Restante()
        {
            if(NotaFinal() >= 60)
            {
                return 0;
            }
            else
            {
                return 60 - NotaFinal();
            }
        }

      
    }
}