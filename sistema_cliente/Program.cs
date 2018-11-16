using System;

namespace sistema_cliente
{
    class Program
    {
        static void Main(string[] args)
        {           
            Bairro bairro = new Bairro();

            Console.WriteLine("Informe a opcao: ");
            Console.Write("1 - PF | 2 - PJ :");


            int tipo = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Informe o nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Informe o endereco: ");
            string endereco = Console.ReadLine();

            Console.WriteLine("Informe o nome do bairro: ");
            bairro.nome = Console.ReadLine();

            switch(tipo){
                case 1:
                    Console.WriteLine("Informe o CPF: ");
                    string cpf = Console.ReadLine();
                    ClienteFisico clienteFisico = new ClienteFisico(nome, endereco, bairro, cpf);
                    Console.Clear();
                    Console.WriteLine("Nome: " +     clienteFisico.nome);
                    Console.WriteLine("CPF: " +      clienteFisico.cpf);
                    Console.WriteLine("Endereco: " + clienteFisico.endereco);
                    Console.WriteLine("Bairro: " +   clienteFisico.bairro.nome );

                    clienteFisico.dizQuemSouMesmo();

                    break;
                case 2:
                    Console.WriteLine("Informe o CNPJ: ");
                    string cnpj = Console.ReadLine();
                    ClienteJuridico clienteJuridico = new ClienteJuridico(nome, endereco, bairro,cnpj);
                    Console.Clear();
                    Console.WriteLine("Nome: " +     clienteJuridico.nome);
                    Console.WriteLine("CNPJ: " +      clienteJuridico.cnpj);
                    Console.WriteLine("Endereco: " + clienteJuridico.endereco);
                    Console.WriteLine("Bairro: " +   clienteJuridico.bairro.nome);

                    clienteJuridico.dizQuemSouMesmo();

                    break;
                default : 
                    // do_something;
                    break;
            }


        }

       
    }
}
