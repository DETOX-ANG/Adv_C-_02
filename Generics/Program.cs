using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Generics.Modelo;

namespace Generics {
    class Program {
        static void Main(string[] args) {

            Carro carro = new Carro() {Modelo = "Fiat", Placa = " KGB-123" };
            Casa casa = new Casa() {Cidade = "Rio de Janeiro", Endereco = "Rua X 024" };
            Usuario usuario = new Usuario() {Cpf = "142.565.699-44", Nome = "Ralph", Snome = "Rocha"};

            //Serializadora.Serializar(carro);
            //Serializadora.Serializar(casa);
            //Serializadora.Serializar(usuario);

            Carro carro2 = Serializadora.Deserializar<Carro>();
            Casa casa2 = Serializadora.Deserializar<Casa>();
            Usuario usuario2 = Serializadora.Deserializar<Usuario>();

            Console.WriteLine($"{carro2.Modelo}, {carro2.Placa}");
            Console.WriteLine($"{casa2.Cidade}, {casa2.Endereco}");
            Console.WriteLine($"{usuario2.Cpf}, {usuario2.Nome}, {usuario2.Snome}");
            Console.ReadKey();

        }
    }
}
