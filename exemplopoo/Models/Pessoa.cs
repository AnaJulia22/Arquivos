namespace exemplopoo.Models
{
    public class Pessoa
    {
        public string Nome { get; set; }  
        public int Idade { get; set; }
        public virtual void Apresentar() //virtual permite sobrescrever (override)
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos");
        }
    }
}