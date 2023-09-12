namespace Classes.Triangulo
{
    internal class Triangulo
    {
        public double A;
        public double B;
        public double C;

        // metodo para calcular a area do triangulo
        public double Area()
        {
            double p = (A + B + C) / 2.0;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
    }
}
