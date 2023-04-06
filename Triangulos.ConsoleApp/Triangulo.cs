namespace Triangulos.ConsoleApp
{
    public class Triangulo
    {
        private int ladoX;
        private int ladoY;
        private int ladoZ;

        public string Tipo;

        private static int quantidadeTriangulos = 0;

        public Triangulo(int ladoX, int ladoY, int ladoZ) //método constructor EXPLÍCITO
        {
            //todo triangulo que for criado deve ser escaleno
            this.ladoX = ladoX;
            this.ladoY = ladoY;
            this.ladoZ = ladoZ;

            quantidadeTriangulos++;
        }

        public string ObterTipo()
        {            
            string tipo;

            //padrão null guard
            if (LadoXInvalido() || LadoYInvalido() || LadoZInvalido())
                tipo = "Invalido";

            else if (ladoX == ladoY && ladoY == ladoZ)
                tipo = "Eqüilátero";

            else if (ladoX != ladoY && ladoY != ladoZ && ladoZ != ladoX)
                tipo = "Escaleno";

            else
                tipo = "Isósceles";

            return tipo;
        }      

        private bool LadoZInvalido()
        {
            bool ladoZInvalido = ladoZ > ladoX + ladoY;

            return ladoZInvalido;
        }

        private bool LadoYInvalido()
        {

            bool ladoXInvalido = ladoX > ladoZ + ladoY;

            return ladoXInvalido;
        }

        private bool LadoXInvalido()
        {

            bool ladoYInvalido = ladoY > ladoZ + ladoX;

            return ladoYInvalido;
        }
    }
}
