using System;

class Celular
{
    // Propriedades
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public string Cor { get; set; }
    public double TamanhoTela { get; set; }
    public bool Ligado { get; private set; }

    // Construtor
    public Celular(string marca, string modelo, string cor, double tamanhoTela)
    {
        Marca = marca;
        Modelo = modelo;
        Cor = cor;
        TamanhoTela = tamanhoTela;
        Ligado = false;
    }

    // Métodos
    public void Ligar()
    {
        if (!Ligado)
        {
            Console.WriteLine($"O celular {Marca} {Modelo} foi ligado.");
            Ligado = true;
        }
        else
        {
            Console.WriteLine($"O celular {Marca} {Modelo} já está ligado.");
        }
    }

    public void Desligar()
    {
        if (Ligado)
        {
            Console.WriteLine($"O celular {Marca} {Modelo} foi desligado.");
            Ligado = false;
        }
        else
        {
            Console.WriteLine($"O celular {Marca} {Modelo} já está desligado.");
        }
    }

    public void EnviarMensagem(string numero, string mensagem)
    {
        if (Ligado)
        {
            Console.WriteLine($"Enviando mensagem para {numero}: {mensagem}");
        }
        else
        {
            Console.WriteLine("O celular está desligado. Ligue antes de enviar mensagens.");
        }
    }
}

class Program
{
    static void Main()
    {
        Celular celular = new Celular("Samsung", "Galaxy S20", "Preto", 6.1);

        celular.Ligar();
        celular.EnviarMensagem("123456789", "Olá, como vai?");
        celular.Desligar();
    }
}
