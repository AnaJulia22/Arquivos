using System.IO;
using System.Collections.Generic;
namespace exemplopoo.Helper
{
    public class Filehelper
    {
        public void ListarDireitorio(string caminho)
        {
           var retornoCaminho = Directory.GetDirectories(caminho, "*", SearchOption.AllDirectories);
           foreach(var retorno in retornoCaminho)
           {
               System.Console.WriteLine(retorno);
           }
        }
         public void ListarArquivoDireitorio(string caminho)
        {
           var retornoArquivo = Directory.GetFiles(caminho, "*", SearchOption.AllDirectories);
           foreach(var retorno in retornoArquivo)
           {
               System.Console.WriteLine(retorno);
           }
        }
        public void CriarDiretorio(string caminho)
        {
            var retorno = Directory.CreateDirectory(caminho);
            System.Console.WriteLine(retorno.FullName);
        }

        public void ApagarDiretorio(string caminho, bool ApagarArquivo)
        {
            Directory.Delete(caminho, ApagarArquivo);
        }
        public void CriarArquivoTexto(string caminho, string conteudo)
        {   
            if (!File.Exists(caminho))
            {
              File.WriteAllText(caminho, conteudo);
            }
        }
         public void CriarArquivoTextooStream(string caminho, List<string> conteudo)
        {   
         using (var stream = File.CreateText(caminho))
            {
              foreach (var linha in conteudo)
              {
                 stream.WriteLine(linha);
              }
            }
        }
        public void AdicionarTexto(string caminho, string conteudo)
        {
            File.AppendAllText( caminho, conteudo);
        }
    }
}