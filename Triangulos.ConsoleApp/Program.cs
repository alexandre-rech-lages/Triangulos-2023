namespace Triangulos.ConsoleApp
{
    class TesteTriangulo
    {
        static void Main(string[] args)
        {
            Triangulo triangulo1 = new Triangulo(10, 10, 10);                         

            string tipoTriangulo1 = triangulo1.ObterTipo();

            Console.WriteLine(tipoTriangulo1); //Eqüilátero

            Triangulo triangulo2 = new Triangulo(12, 10, 10);

            string tipoTriangulo2 = triangulo2.ObterTipo();

            Console.WriteLine(tipoTriangulo2); //Isósceles

            Triangulo triangulo3 = new Triangulo(12, 14, 16);

            string tipoTriangulo3 = triangulo3.ObterTipo();

            Console.WriteLine(tipoTriangulo3); //Escaleno

            Console.WriteLine("O numero de triangulos criados foram: " /*+ Triangulo.quantidadeTriangulos*/);

            Console.ReadLine();
        }
    }
}