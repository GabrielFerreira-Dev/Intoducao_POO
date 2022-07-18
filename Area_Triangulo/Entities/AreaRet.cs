namespace Area_Triangulo.Entities
{
    public class AreaRet
    {
        private double _altura;
        private double _base;
        public double Base
        {
            get { return _base; }
            set { _base = value; }
        }
        
        public double Altura
        {
            get { return _altura; }
            set { _altura = value; }
        }
        public AreaRet()
        {
            
        }
        public AreaRet(double _altura, double _base)
        {
            Base = _base;
            Altura = _altura;
        }
        public double CalculaArea()
        {
            return Altura * Base;
        }
        
    }
}