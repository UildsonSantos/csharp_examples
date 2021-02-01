

namespace three___Classes.Heranca
{
    public class Ponto3D : Ponto
    {
        public int z;
        public Ponto3D(int x, int y, int z) : base(x, y)
        {
            this.z = z;
            CalcularDistancia();
        }

        public static void Calcular()
        {
            //Faz alguma coisa...para a classe Ponto3D, não a instancia de Ponto3D
        }
        public override void CalcularDistancia3()
        {
            //Faz outra coisa ...ou a mesma coisa, se usar o atributo "base"
            base.CalcularDistancia3();
        }
    }
}