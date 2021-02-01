
namespace three___Classes.Heranca
{
    public class Ponto
    {
        public int x, y;
        private int distancia;
        
        public Ponto(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        protected void CalcularDistancia()
        {
            //Faz alguma coisa...para instancia da classe Ponto e de Classes extendidas (filhas)
            CalcularDistancia2();
        }

        private void CalcularDistancia2()
        {
            //Faz alguma coisa...apenas para indtancias da classe ponto
        }

        public virtual void CalcularDistancia3()
        {
            //Faz alguma coisa...para instancia da classe Ponto e de Classes extendidas (filhas) permitindo sobre escrita
        }
    }
}