namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        int lista=0;// Var usado no bloco quanto erra a placa.

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            // Implementado!!!!!
            
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = Console.ReadLine(); // ler o que o Usuário digito
            veiculos.Add(placa);//adicionar na lista "veiculos"
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");
            lista++;
            // Implementado!!!!!
            string placa = Console.ReadLine(); // ler o que o Usuário digito

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                // Implementado!!!!!
                int horas = int.Parse(Console.ReadLine());

                // Implementado!!!!!
                decimal valorTotal = precoInicial + precoPorHora * horas; 

                // Implementado!!!!!
                veiculos.Remove (placa);

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            // Implementado!!!!! Incremetei um IF quando erra a placa depois de uma certa quantidade de vezez ele 
            // mostra a lista de placa cadastras.
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente/n");

                if (lista>=2)
                {
                    ListarVeiculos();// imprime a lista
                    RemoverVeiculo();//vai retona o método RemoverVeiculo do 0
                }
                else
                {
                RemoverVeiculo(); //vai retona o método RemoverVeiculo do 0
                }
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                // Implementado!!!!!
                foreach (var item in veiculos)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
