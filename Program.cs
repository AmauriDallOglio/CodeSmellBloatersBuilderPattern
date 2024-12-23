using CodeSmellBloatersBuilderPattern.BuilderPattern;

namespace CodeSmellBloatersBuilderPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Capítulo 1 / 1.2.1 Code smells - Bloaters");
            Console.WriteLine("-----------------------------------");

            Console.WriteLine("Exemplo de Code Smell: Bloaters: Primeiramente, a classe Pedido com um construtor sobrecarregado, o que resultaria em um código com muitos parâmetros.");
            Console.WriteLine("Aqui, o construtor da classe Pedido tem um grande número de parâmetros, o que resulta em um código que pode ser difícil de ler, entender e manter. Esse é um exemplo típico de um code smell chamado Long Parameter List.");
            var pedido = new Pedido(
            "1",
            "Amauri Dall'Oglio",
            [ "Notebook", "Mouse", "Teclado" ],
            "Rua A, 123, Santa catarina",
            10,
            2,
                DateTime.Now.AddDays(7)
            );
            pedido.ExibirPedido();

            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Capítulo 3 / 3.2 (Builder Pattern)");
            Console.WriteLine("-----------------------------------");

            Console.WriteLine("Solução com o Builder Pattern: Em seguida, vamos refatorar o código utilizando o padrão Builder para organizar a construção do Pedido.");
            var pedidoBuilder = new PedidoBuilder()
                .InformarCliente("1", "Amauri DallOglio")
                .InformarItens(["Notebook", "Mouse", "Teclado" ])
                .InformarEnderecoEntrega("Rua A, 123, São Paulo")
                .InformarValor(10)
                .InformarDesconto(2)
                .InformarDataEntrega(DateTime.Now.AddDays(7))
                .Build();

            pedidoBuilder.ExibirPedido();



            Console.WriteLine("Fim");
        }
    }
}
