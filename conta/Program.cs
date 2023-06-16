using System.ComponentModel;

public class Programa
{
    static void Main(string[] args)
    {

        Conta c = new Conta();
        Console.WriteLine("Dígite seu nome: ");
        c.nome = Console.ReadLine();

        Console.WriteLine("Dígite o tipo da conta(Corrente ou Poupança):");
        c.tipoConta = Console.ReadLine();


        c.saldo = 0;

        Console.WriteLine($"{c.nome}, dígite o valor para ser depositado:");
        double valor = Convert.ToDouble(Console.ReadLine());
       
            c.Deposito(valor);
        
        Console.WriteLine($"{c.nome}, sua conta {c.tipoConta} tem {c.saldo.ToString("c2")}");

        Console.WriteLine("Dígite um valor para sacar!");
        double valorSaque = Convert.ToDouble(Console.ReadLine());
        c.Sacar(valorSaque);
        Console.WriteLine($"{c.nome}, sua conta {c.tipoConta} tem {c.saldo.ToString("c2")}");
        Console.ReadKey();
    }
}