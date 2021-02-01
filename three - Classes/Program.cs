using System;
using three___Classes.Heranca
{
    
}
namespace three___Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Ponto ponto = new Ponto(10,20);
            Ponto3D ponto3D = new Ponto3D(10, 20, 30);

            Ponto3D.Calcular();
        }
    }
}
