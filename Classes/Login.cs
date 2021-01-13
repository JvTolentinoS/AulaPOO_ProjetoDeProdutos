using System;

namespace AulaPOO_ProjetoDeProdutos.Classes
{
    public class Login
    {
        public Login(bool logado) 
        {
            this.Logado = logado;
               
        }
                public bool Logado {get; set;}

        public Login(){
            Usuario user = new Usuario();
            Logar(user);
            if(Logado){
                GerarMenu();
            }

        }
        
        public void GerarMenu(){

            Produto produto = new Produto();
            Marca marca = new Marca();

            int opcao;

            do{
                Console.WriteLine($"Escolha uma opção");
                Console.WriteLine($"1 - Cadastrar Produto");
                Console.WriteLine($"2 - Listar Produto");
                Console.WriteLine($"3 - Deletar Produto");
                Console.WriteLine($"4 - Cadastrar Marca");
                Console.WriteLine($"5 - Listar Marca");
                Console.WriteLine($"6 - Sair da aplicação");
                
                opcao = int.Parse(Console.ReadLine());
                
                switch (opcao)
                {
                    case 1:
                        produto.Cadastrar();
                        break;

                    case 2:
                        produto.Listar();
                        break;
                    case 3:
                        Console.WriteLine($"Digite um código para excluir");
                        int cod = 0;
                        produto.Deletar(cod);
                        break;
                    case 4:
                        marca.CadastrarMarcas();
                        break;
                    case 5:
                        marca.Listar();
                        break;
                    case 6:
                        Console.WriteLine($"Digite o código de uma Marca para deletar");
                        cod = 0;
                        marca.Deletar(cod);
                        break;
                    case 0:
                        Deslogar();
                        break;
                    default:
                        break;
                }
                

            }while(opcao != 0); //***Como estar na tela de Login após desconectar?
        }

        public void Logar(Usuario usuario){
            
            Console.WriteLine($"Digite seu email:");
            string emailLogin = Console.ReadLine();
            
            Console.WriteLine($"Digite sua senha:");
            string senhaLogin = Console.ReadLine();
            
            if(emailLogin == usuario.Email && senhaLogin == usuario.Senha){
                Logado = true;
                Console.WriteLine($"Usuário Verificado.");
            }else{
                Console.WriteLine($"Falha na Verificação");
                
            }
            

        }

        public void Deslogar(){
            Logado = false;
        }
    }
}