using System;
namespace sistema_cliente
{
    public class ClienteJuridico:Cliente 
    {
        public string cnpj { set; get; }

        public override void dizQuemSouMesmo()
        {
            Console.WriteLine("EU SOU CLIENTE JURIDICO E ACABOU-SE");
        }

        public ClienteJuridico(string nome, string endereco, Bairro bairro, string cnpj)
        {
            this.nome = nome;
            this.endereco = endereco;
            this.bairro = bairro;
            this.cnpj = cnpj;
        }

        public ClienteJuridico()
        {
        }
    }
}
