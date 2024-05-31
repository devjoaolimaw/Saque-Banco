using System;

class Program
{
    static void Main(string[] args)
    {
        int saldoTotal = 1500;
        Console.WriteLine($"Você possui R${saldoTotal},00");
        
        Console.WriteLine();

        Console.WriteLine("Quanto deseja diretirar?");
        int valorSaque = int.Parse(Console.ReadLine());
        
        int saldo = saldoTotal - valorSaque;
        
        Console.WriteLine("Por fovor aguarde...");
        Thread.Sleep(2000);

        if (valorSaque <= saldoTotal)
        {
          Console.WriteLine($"Saque realizado com sucesso! Novo saldo: {saldo}");
        }
        else
        {
          Console.WriteLine("Saldo insuficiente. Saque nao realizado!");
        }
    }
}