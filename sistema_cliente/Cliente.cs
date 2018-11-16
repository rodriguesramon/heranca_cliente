using System;
namespace sistema_cliente
{
    public class Cliente
    {
        public string nome { set; get; }
        public string endereco { set; get; }
        public Bairro bairro { set; get; }

        public virtual void dizQuemSouMesmo(){
            Console.WriteLine("No fim de tudo, sou apenas CLIENTE!");
        }

        public Cliente()
        {

        }
    }
}
