using System;

class Program
{
    static void Main()
    {
        Estacionamento estacionamento = new Estacionamento();

        bool continuar = true;

        while (continuar)
        {
            Console.WriteLine("\nEscolha uma opção:");
            Console.WriteLine("1 - Cadastrar Carro");
            Console.WriteLine("2 - Remover Carro");
            Console.WriteLine("3 - Listar Carros");
            Console.WriteLine("4 - Encerrar Estacionamento");
            Console.WriteLine("5 - Sair");

            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    estacionamento.CadastrarCarro();
                    break;
                case "2":
                    estacionamento.RemoverCarro();
                    break;
                case "3":
                    estacionamento.ListarCarros();
                    break;
                case "4":
                    estacionamento.EncerrarEstacionamento();
                    break;
                case "5":
                    continuar = false;
                    break;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }
}
