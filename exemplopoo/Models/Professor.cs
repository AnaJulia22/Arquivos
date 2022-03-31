namespace exemplopoo.Models
{
    public class Professor : Pessoa
    {
        public double Salário { get; set; }
         public override void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, sou um professor e ganho {Salário}");
        }
    }
}