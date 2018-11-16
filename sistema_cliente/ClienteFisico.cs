using System;
namespace sistema_cliente
{
    public class ClienteFisico : Cliente 
    {
        public string cpf { set; get; }


        public override void dizQuemSouMesmo()
        {
            Console.WriteLine("EU SOU CLIENTE FISICO E ACABOU-SE");
        }

        public ClienteFisico(string nome, string endereco, Bairro bairro, string cpf)
        {
            this.nome = nome;
            this.endereco = endereco;
            this.bairro = bairro;
            this.cpf = cpf;
        }

        public ClienteFisico()
        {
        }
    }
}
