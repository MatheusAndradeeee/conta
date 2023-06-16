using System.Drawing;
using System.Runtime.CompilerServices;

public class Conta
{//atributos(caracteristicas)
    public string nome;
    public string tipoConta;
    public double saldo;

     
      
    public void Deposito(double deposito)
    {
        if (deposito > 0)
        {
            saldo += deposito;
        }
        else { Console.WriteLine("Valor inválido."); }
       
    }

    public void Sacar(double saque) 
    {
         if (saque <= saldo)
        {
            saldo -= saque;
        }
        else { Console.WriteLine("Valor inválido."); }

    }
}