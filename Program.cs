using System;
using System.Collections.Generic;
using LojaVirtual.Models;

var notebook = new Produto(1, "Notebook", 3000, "Eletrônicos");
var livro = new Produto(2, "Livro", 100, "Livros");

var cliente = new Cliente(1, "Carlos", "carlos@email.com", "12345678900");

var itens = new List<ItemPedido>
{
    new ItemPedido(notebook, 1),
    new ItemPedido(livro, 3)
};

var descontos = new List<IDescontoStrategy>
{
    new DescontoCategoria(),
    new DescontoQuantidade()
};

var pedido = PedidoFactory.Criar(1, cliente, itens, descontos);

Console.WriteLine($"Pedido #{pedido.Id} - Cliente: {pedido.Cliente.Nome}");
Console.WriteLine($"Data: {pedido.Data}");
foreach (var item in pedido.Itens)
{
    Console.WriteLine($"- {item.Produto.Nome} x{item.Quantidade} = R$ {item.Subtotal():F2}");
}
Console.WriteLine($"Total com descontos: R$ {pedido.Total:F2}");
