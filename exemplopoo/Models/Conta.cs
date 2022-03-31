namespace exemplopoo.Models
{
    public abstract class Conta //em todo método abstrato, sou obrigado a sobreescrevê-lo
    {
        protected double saldo;
        public abstract void Creditar (double valor);
        public void ExibirSaldo()
        {
            System.Console.WriteLine("Seu saldo é: " + saldo);
        }
    }
}