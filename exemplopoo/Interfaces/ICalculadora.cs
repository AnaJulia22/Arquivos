namespace exemplopoo.Interfaces
{
    public interface ICalculadora
    {
         int Somar(int num1, int num2);
         int Subtrair(int num1, int num2);
         int Multiplicar(int num1, int num2);
         int Dividir(int num1, int num2) //implementação padrão, assim posso excluir
         // a implementação da divisão sem dar erro em Calculadora
         {
             return num1 / num2; 
         }
    }
}