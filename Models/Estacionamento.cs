// Projeto da DIO 
namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        // Método para adicionar um veículo
        public void AdicionarVeiculo()
        {
        
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = Console.ReadLine();
            if (!string.IsNullorEmpty(placa))
            {
                veiculos.Add(placa.ToUpper()); //Adiciona a placa em letras maiúsculas para padronizar
                Console.WriteLine($"Veículo com placa {placa} estacionado com sucesso.");
            }
            else
            {
                Console.WriteLine("Placa inválida, tente novamente.");
            }
        }

        // Método para remover um veículo
        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");
            string placa = Console.ReadLine();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                int horas;
                if (int.TryParse(Console.ReadLine(), out horas))
                {
                    // Calcula o valor total a ser pago
                    decimal valorTotal = precoInicial + precoPorHora * horas;

                    // Remove o veículo da lista
                    veiculos.Remove(placa.ToUpper());
                    Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
                }
                else
                {
                    Console.WriteLine("Número de horas inválido. Tente novamente.");
                }
            }

            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        // Método para listar veículos estacionados
        public void ListarVeiculos()
        {

            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                foreach (var veiculo in veiculos)
                {
                    Console.WriteLine(veiculo);
                }
                }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
