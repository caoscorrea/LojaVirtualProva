using System;
using System.Collections.Generic;
using LojaVirtual.Models;

class Program
{
    static void Main()
    {
        var produtos = new List<Produto>();

        try
        {
            produtos.Add(new Produto(1, "Notebook", 3500, "Eletrônicos"));
            produtos.Add(new Produto(2, "Camisa", 120, "Vestuário"));
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Erro ao cadastrar produto: {ex.Message}");
        }

        Console.WriteLine("Produtos cadastrados:");
        foreach (var produto in produtos)
        {
            Console.WriteLine(produto);
        }
    }
}
