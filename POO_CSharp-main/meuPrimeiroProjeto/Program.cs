using System;

namespace meuPrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta_da_barbara = new ContaCorrente ("Barbara", 12345, 123, 10);
            ContaCorrente conta_da_maria = new ContaCorrente ("Maria", 12345, 789, 100);
            ContaCorrente conta_do_joao = new ContaCorrente ("Joao", 12345, 456, 1000);

            Console.WriteLine("A conta é do (a) " + conta_da_barbara.Titular + 
            ", a agência é " + conta_da_barbara.Agencia + " e o número é " 
            + conta_da_barbara.Numero + ".");

            Console.WriteLine("A conta é do (a) " + conta_da_maria.Titular + 
            ", a agência é " + conta_da_maria.Agencia + " e o número é " 
            + conta_da_maria.Numero + ".");

            Console.WriteLine("A conta é do (a) " + conta_do_joao.Titular + 
            ", a agência é " + conta_do_joao.Agencia + " e o número é " 
            + conta_do_joao.Numero + ".");

        }
    }
}
