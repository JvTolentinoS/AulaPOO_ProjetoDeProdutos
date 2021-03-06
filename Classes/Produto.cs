using System;
using System.Collections.Generic;

namespace AulaPOO_ProjetoDeProdutos.Classes
{
    public class Produto
    {
        public int Codigo { get; set; }

        public string NomeProduto { get; set; }
        
        public float Preco { get; set; }
        
        public DateTime DataCadastro { get; set; }

        public Marca Marca { get; set; }

        public Usuario CadastradoPor { get; set; }
        
        public List<Produto> ListaDeProdutos { get; set; }
        
        public void Cadastrar(){

            Produto novoProduto = new Produto(); /// ****Erro no Produto

            Console.WriteLine($"Digite o código do Produto:");
            novoProduto.Codigo = int.Parse(Console.ReadLine());

            Console.WriteLine($"Digite o nome do Produto: ");
            novoProduto.NomeProduto = Console.ReadLine();
            
            Console.WriteLine($"Digite o preço do produto: ");
            novoProduto.Preco = float.Parse(Console.ReadLine());
            
            novoProduto.DataCadastro = DateTime.UtcNow;
            
            novoProduto.Marca = Marca.CadastrarMarcas();

            Usuario generico = new Usuario();
            
        }
        
        public void Listar(){

            Console.ForegroundColor = ConsoleColor.Green;
            foreach (var item in ListaDeProdutos)
            {
                Console.WriteLine($"Código {item.Codigo}");
                Console.WriteLine($"Produto {item.NomeProduto}");
                Console.WriteLine($"Preco R$ {item.Preco}");
                Console.WriteLine($"Data de Cadastro{item.DataCadastro}");
                Console.WriteLine($"Marca {item.Marca.NomeMarca}");
                Console.WriteLine($"Cadastrado por {item.CadastradoPor.Nome}");
                
            }
            Console.ResetColor();
            
        }
                
        public void Deletar(int cod){
            cod = int.Parse(Console.ReadLine());
            Produto prodDelete = ListaDeProdutos.Find(p => p.Codigo == cod);
            ListaDeProdutos.Remove(prodDelete);
        }
        
        
    }
}