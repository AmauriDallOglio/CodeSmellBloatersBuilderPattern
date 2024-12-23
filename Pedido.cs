namespace CodeSmellBloatersBuilderPattern
{
    public class Pedido
    {
        public string Codido { get; set; } = string.Empty;
        public string ClienteCodigo { get; set; } = string.Empty;
        public string ClienteNome { get; set; } = string.Empty;
        public List<string> Itens { get; set; }
        public string EnderecoEntrega { get; set; }
        public decimal Valor { get; set; }
        public decimal Desconto { get; set; }
        public decimal ValorTotal { get; set; }
        public DateTime DataEntrega { get; set; }

        //Aqui, o construtor da classe Pedido tem um grande número de parâmetros, o que resulta em um código que pode ser difícil de ler, entender e manter. Esse é um exemplo típico de um code smell chamado Long Parameter List.
        public Pedido(string clienteCodigo, string clienteNome, List<string> itens, string enderecoEntrega, decimal valor,  decimal desconto, DateTime dataEntrega)
        {
            ClienteCodigo = clienteCodigo;
            ClienteNome = clienteNome;
            Itens = itens;
            EnderecoEntrega = enderecoEntrega;
            Valor = valor;
            Desconto = desconto;
            ValorTotal = Valor - Desconto;
            DataEntrega = dataEntrega;
        }

        public void ExibirPedido()
        {
            Console.WriteLine($"Cliente código: {ClienteCodigo}");
            Console.WriteLine($"Cliente nome: {ClienteNome}");
            Console.WriteLine($"Itens: {string.Join(", ", Itens)}");
            Console.WriteLine($"Endereço de Entrega: {EnderecoEntrega}");
            Console.WriteLine($"Desconto: {Valor}");
            Console.WriteLine($"Desconto: {Desconto}");
            Console.WriteLine($"Data de Entrega: {DataEntrega.ToShortDateString()}");
            Console.WriteLine($"Valor total: {CalcularValorTotal(Valor, Desconto):C}");
        }

        public static decimal CalcularValorTotal(decimal valor, decimal desconto)
        {
            return valor - desconto; 
        }

 
  
    }
}
