using System;
using System.Collections.Generic;

class Estacionamento
{
    private List<Carro> carrosEstacionados;

    public Estacionamento()
    {
        carrosEstacionados = new List<Carro>();
    }

    public void CadastrarCarro()
    {
        Console.Write("Digite a placa do carro: ");
        string placa = Console.ReadLine();

        Console.Write("Digite o modelo do carro: ");
        string modelo = Console.ReadLine();

        Carro novoCarro = new Carro { Placa = placa, Modelo = modelo };
        carrosEstacionados.Add(novoCarro);

        Console.WriteLine($"Carro cadastrado: {modelo} ({placa})");
    }

    public void RemoverCarro()
    {
        Console.Write("Digite a placa do carro a ser removido: ");
        string placa = Console.ReadLine();

        Carro carroRemover = carrosEstacionados.Find(c => c.Placa == placa);

        if (carroRemover != null)
        {
            carrosEstacionados.Remove(carroRemover);
            Console.WriteLine($"Carro removido: {carroRemover.Modelo} ({carroRemover.Placa})");
        }
        else
        {
            Console.WriteLine($"Carro com placa {placa} não encontrado.");
        }
    }

    public void ListarCarros()
    {
        Console.WriteLine("Carros estacionados:");
        foreach (Carro carro in carrosEstacionados)
        {
            Console.WriteLine($"{carro.Modelo} ({carro.Placa})");
        }
    }

    public void EncerrarEstacionamento()
    {
        carrosEstacionados.Clear();
        Console.WriteLine("Estacionamento encerrado. Todos os carros foram removidos.");
    }
}
