namespace CodeSmellBloatersBuilderPattern.BuilderPattern
{
    public class PedidoBuilder
    {
        private string _clienteCodigo = string.Empty;
        private string _clienteNome = string.Empty;
        private List<string> _itens = [];
        private string _enderecoEntrega = string.Empty;
        private decimal _valor;
        private decimal _desconto;
        private DateTime _dataEntrega;

        public PedidoBuilder InformarCliente(string clienteCodigo, string clienteNome)
        {
            _clienteCodigo = clienteCodigo;
            _clienteNome = clienteNome;
            return this;
        }

        public PedidoBuilder InformarItens(List<string> itens)
        {
            _itens = itens;
            return this;
        }

        public PedidoBuilder InformarEnderecoEntrega(string enderecoEntrega)
        {
            _enderecoEntrega = enderecoEntrega;
            return this;
        }

        public PedidoBuilder InformarValor(decimal desconto)
        {
            _valor = desconto;
            return this;
        }

        public PedidoBuilder InformarDesconto(decimal desconto)
        {
            _desconto = desconto;
            return this;
        }

        public PedidoBuilder InformarDataEntrega(DateTime dataEntrega)
        {
            _dataEntrega = dataEntrega;
            return this;
        }

        public Pedido Build()
        {
            return new Pedido(_clienteCodigo, _clienteNome, _itens, _enderecoEntrega, _valor, _desconto, _dataEntrega);
        }
    }
}
