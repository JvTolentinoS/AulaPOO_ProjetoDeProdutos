using System;

namespace AulaPOO_ProjetoDeProdutos.Classes
{
    public class Usuario
    {
        public Usuario(){ //***Ok
            Cadastrar();
        }
        public Usuario(int _codigo, string _nome, string _email, string _senha){
            Codigo = _codigo;
            Nome = _nome;
            Email = _email;
            Senha = _senha;
            DataCadastro = DateTime.UtcNow;
        }

        int Codigo { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }

        DateTime DataCadastro {get; set;}
        
        public void Cadastrar(){

            Nome = "A";
            Email = "A"; 
            Senha = "A";
            DataCadastro = DateTime.UtcNow;
        }
        
        public void Deletar(int cod){

            Nome = "";
            Email = "";
            Senha = "";
            DataCadastro = DateTime.Parse("0000-00-00T00:00:00");
        }
        
        
        
    }
}