using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Threading.Tasks;

namespace Sistema_Estacionamento.Models
{
    public class Estacionamento
    {
        private decimal PrecoInicial = 0;
        private decimal PrecoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal PrecoInicial, decimal PrecoPorHora)
        {
            this.PrecoInicial = PrecoInicial;
            this.PrecoPorHora = PrecoPorHora;
        }

        public void AdicionarVeiculo ()
        {
            Console.WriteLine("Insira a placa do veículo: ");
            string placa = Console.ReadLine();

            veiculos.Add(placa);

            Console.WriteLine($"Veículo {placa} adicionado!");
            Thread.Sleep(2000);
            Console.Clear();
        }

        public void RemoverVeiculo ()
        {          
            if(veiculos.Count() == 0)
            {
                Console.WriteLine("Não há veículos estacionados");
            }
            else
            {
            
                Console.WriteLine("Informe a placa do veículo que deseja remover: ");
                string placa = Console.ReadLine();
                int Hora = 0;
                
                if(!veiculos.Contains(placa))
                {
                    Console.WriteLine($"Não possui veículo com placa {placa} no estacionamento");
                }
                else
                {
                    bool erro = true;
                    do{
                        Console.WriteLine("Horas que veículo ficou estacionado: ");
                        Hora = int.Parse(Console.ReadLine());
                        
                        if(Hora < 0)
                        {
                            Console.WriteLine("Insira uma hora válida!");
                        }
                        else
                        {
                            erro = false;
                        }
                    }while(erro);

                    if(Hora == 0)
                    {
                        Console.WriteLine($"Valor a ser pago= {PrecoInicial}");
                    }
                    else
                    {
                        PrecoPorHora = PrecoPorHora * Hora;
                        Console.WriteLine($"Valor a ser pago= {PrecoInicial + PrecoPorHora}");
                    }
                    
                    veiculos.Remove(placa);

                    Console.WriteLine($"Veículo {placa} removido!");
                }
            }
            Thread.Sleep(5000);
            Console.Clear();
        }

        public void ListarVeiculos () 
        {
            if(veiculos.Count() == 0)
            {
                Console.WriteLine("Não há veículos estacionados");
                Thread.Sleep(2000);
                Console.Clear();
            }
            else
            {
                Console.WriteLine("--Veículos no Estacionamento--");
                foreach(string carros in veiculos)
                {
                    Console.WriteLine($"{carros}");
                }
                Thread.Sleep(2000);
            }
            
        }
    }
}