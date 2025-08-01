using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace FrotaDeCarros
{
    public class Carro
    {
        public string Placa { get; set; }
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public int Ano { get; set; }
        public string Cor { get; set; }
    }

    public class Motorista
    {
        public string Nome { get; set; }
        public string CNH { get; set; }
    }

    public class Viagem
    {
        public Carro Carro { get; set; }
        public Motorista Motorista { get; set; }
        public DateTime DataSaida { get; set; }
        public DateTime DataRetorno { get; set; }
        public string Destino { get; set; }
    }

    class Program
    {
        static void Main()
        {
            var frota = new Frota();

            var carro1 = new Carro { Placa = "ABC123", Modelo = "Gol", Marca = "Volkswagen", Ano = 2015, Cor = "Prata" };
            var carro2 = new Carro { Placa = "DEF456", Modelo = "Jetta", Marca = "Volkswagen", Ano = 2018, Cor = "Preto" };

            var motorista1 = new Motorista { Nome = "João", CNH = "123456789" };
            var motorista2 = new Motorista { Nome = "Maria", CNH = "987654321" };

            frota.Carros.Add(carro1);
            frota.Carros.Add(carro2);
            frota.Motoristas.Add(motorista1);
            frota.Motoristas.Add(motorista2);

            var viagem1 = new Viagem { Carro = carro1, Motorista = motorista1, DataSaida = DateTime.Now, Destino = "São Paulo" };
            frota.Viagens.Add(viagem1);

            var json = JsonSerializer.Serialize(frota);
            Console.WriteLine(json);
        }
    }

    public class Frota
    {
        public List<Carro> Carros { get; set; }
        public List<Motorista> Motoristas { get; set; }
        public List<Viagem> Viagens { get; set; }

        public Frota()
        {
            Carros = new List<Carro>();
            Motoristas = new List<Motorista>();
            Viagens = new List<Viagem>();
        }
    }
}
