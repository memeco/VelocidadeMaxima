using System;

public class Veiculo
{
    public virtual void MostrarVelocidadeMaxima()
    {
        Console.WriteLine("Velocidade máxima não definida.");
    }
}

public class Bicicleta : Veiculo
{
    public override void MostrarVelocidadeMaxima()
    {
        Console.WriteLine("Velocidade máxima: 20 km/h");
    }
}

public class Onibus : Veiculo
{
    public override void MostrarVelocidadeMaxima()
    {
        Console.WriteLine("Velocidade máxima: 80 km/h");
    }
}

public class Caminhao : Veiculo
{
    public override void MostrarVelocidadeMaxima()
    {
        Console.WriteLine("Velocidade máxima: 100 km/h");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // Criação de objetos das classes derivadas
        Bicicleta bicicleta = new Bicicleta();
        Onibus onibus = new Onibus();
        Caminhao caminhao = new Caminhao();

        // Chamada dos métodos MostrarVelocidadeMaxima()
        bicicleta.MostrarVelocidadeMaxima();
        onibus.MostrarVelocidadeMaxima();
        caminhao.MostrarVelocidadeMaxima();
    }
}
