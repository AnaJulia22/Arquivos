using System;
using exemplopoo.Helper;
using exemplopoo.Interfaces;
using exemplopoo.Models;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)

    {   
        var caminho = "C:/Users/anaju/DIO/Workingwithfiles";
        var caminhoPathCombine = Path.Combine(caminho,"test1");
        var caminhoArquivo = Path.Combine(caminho, "arquivo-teste-stream.txt");
        var listaString = new List<string> {"linha 1", "linha 2", "linha 3" };

        Filehelper helper = new Filehelper();
        helper.CriarArquivoTextoStream (caminhoArquivo, listaString);

        //helper.ListarDireitorio(caminho);
        //helper.ListarArquivoDireitorio(caminho);
        //helper.CriarDiretorio(caminhoPathCombine);
        //helper.ApagarDiretorio(caminhoPathCombine,true);
        //helper.CriarArquivoTexto(caminhoArquivo, "Olá! Teste de escrita de arquivo");

        // ICalculadora calc = new Calculadora();
        // System.Console.WriteLine(calc.Somar(10, 10));

        // Computador comp = new Computador();
        
        // System.Console.WriteLine(comp.ToString());

        // // Classes abstratas 
        // Corrente c = new Corrente();
        // c.Creditar(200);
        // c.ExibirSaldo();

        // // Polimorfismo tempo de compilação
        // Calculadora calc = new Calculadora();
        // System.Console.WriteLine("Resultado da primeira soma é: " + calc.somar(30, 500));
        // System.Console.WriteLine("Resultado da segunda soma é: " + calc.somar(30, 500,1000));

        // // Polimorfismo em tempo de execução
        // Aluno p1 = new Aluno();
        // p1.Nome = "Bob";
        // p1.Idade = 20;
        // p1.Nota = 10;    
        // p1.Apresentar();

        // Professor p2 = new Professor();
        // p2.Nome = "Bob";
        // p2.Idade = 20;
        // p2.Salário = 3000;    
        // p2.Apresentar();


        //  // Herança
        // Professor p1 = new Professor();
        // p1.Nome = "Bob";
        // p1.Idade = 20;
        // p1.Salário = 2000;
            
        // p1.Apresentar();


        // // Encapsulamento
        // Retângulo r = new Retângulo();
        // r.DefinirMedidas(30, 30);
        // System.Console.WriteLine($"Área: {r.ObterArea()}");

        // // Abstração
        // Pessoa p1 = new Pessoa();
        // p1.Nome = "Bob";
        // p1.Idade = 20;
        // p1.Apresentar();
    }
}
