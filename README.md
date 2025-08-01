Desafio de Projeto da Dio, referência API mínima, aplicar os conhecimentos obtidos nas aulas criando um aplicativo.

Frota de Carros: Funcionamento

A frota de carros é um sistema que gerencia uma coleção de veículos, permitindo que sejam atribuídos a motoristas para realizar viagens. Aqui está uma visão geral de como funciona:

Componentes

1. Carros: São os veículos que fazem parte da frota. Cada carro tem características como placa, modelo, marca, ano e cor.
2. Motoristas: São as pessoas que irão conduzir os carros. Cada motorista tem características como nome e número da CNH (Carteira Nacional de Habilitação).
3. Viagens: São as atribuições de carros a motoristas para realizar uma viagem específica. Cada viagem tem características como data de saída, destino e carro atribuído.

Funcionamento

1. Cadastro de Carros: Os carros são cadastrados no sistema com suas características.
2. Cadastro de Motoristas: Os motoristas são cadastrados no sistema com suas características.
3. Atribuição de Viagens: Os carros são atribuídos a motoristas para realizar viagens específicas.
4. Gerenciamento de Viagens: O sistema gerencia as viagens, permitindo que sejam visualizadas, editadas ou canceladas.

Benefícios

1. Controle de Frota: O sistema permite que a frota seja controlada de forma eficiente, reduzindo custos e melhorando a produtividade.
2. Atribuição de Carros: O sistema permite que os carros sejam atribuídos a motoristas de forma segura e eficiente.
3. Gerenciamento de Viagens: O sistema permite que as viagens sejam gerenciadas de forma eficiente, reduzindo erros e melhorando a satisfação dos clientes.

Aplicação

A frota de carros pode ser aplicada em diversas situações, como:

1. Empresas de Transporte: Empresas que oferecem serviços de transporte de passageiros ou cargas podem utilizar o sistema para gerenciar sua frota de carros.
2. Locadoras de Veículos: Locadoras de veículos podem utilizar o sistema para gerenciar sua frota de carros e atribuir veículos a clientes.
3. Empresas com Frota Própria: Empresas que possuem uma frota de carros própria podem utilizar o sistema para gerenciar seus veículos e motoristas.

Esse código define as classes Carro, Motorista, Viagem e Frota, que representam os elementos da frota de carros. A classe Frota contém métodos para adicionar carros e motoristas, registrar viagens e finalizar viagens. O programa principal cria uma instância da classe Frota e adiciona carros e motoristas, registra uma viagem e imprime informações sobre a frota.

Essa é apenas uma implementação básica e pode ser melhorada e expandida.


Criando um Aplicativo com Json e Docker


Aplicativo com Json e Docker baseado no código C# fornecido anteriormente

Pré-requisitos

- Instalar o Docker no seu sistema operacional
- Instalar o .NET Core SDK no seu sistema operacional
- Instalar o Json.NET NuGet package

Criando o Aplicativo

Crie um novo projeto .NET Core Web API no Visual Studio ou usando o comando dotnet new webapi no terminal.

Adicione o código C#  fornecido anteriormente ao projeto.

Adicionando o Json.NET NuGet package

Adicione o Json.NET NuGet package ao projeto usando o comando dotnet add package Json no terminal.

Configurando o Docker

Crie um arquivo Dockerfile no diretório raiz do projeto com o seguinte conteúdo:
FROM mcr.microsoft.com/dotnet/core/sdk:3.1
WORKDIR /app
COPY *.csproj ./
RUN dotnet restore
COPY . .
RUN dotnet build -c Release -o /app
EXPOSE 5000
CMD ["dotnet", "run"]

Esse arquivo Dockerfile instrui o Docker a:

1. Utilizar a imagem do .NET Core SDK 3.1
2. Criar um diretório /app e copiar o arquivo .csproj para lá
3. Restaurar as dependências do projeto
4. Copiar o restante do código para o diretório /app
5. Compilar o projeto em modo de lançamento
6. Expor a porta 5000
7. Executar o comando dotnet run para iniciar o aplicativo

Construindo a Imagem Docker

Execute o comando docker build -t frota-de-carros no terminal para construir a imagem Docker.

Executando o Aplicativo

Execute o comando docker run -p 5000:5000 frota-de-carros no terminal para executar o aplicativo.

Agora você pode acessar o aplicativo em http://localhost:5000.

Usando o Json

Para utilizar o Json, você precisará criar um modelo de dados que corresponda ao formato JSON que você deseja trabalhar. 

Por exemplo:

public class Carro
{
    public string Placa { get; set; }
    public string Modelo { get; set; }
    public string Marca { get; set; }
    public int Ano { get; set; }
    public string Cor { get; set; }
}

Em seguida, você pode utilizar o Json para serializar e desserializar objetos:

var carro = new Carro { Placa = "ABC123", Modelo = "Gol", Marca = "Volkswagen", Ano = 2015, Cor = "Prata" };
var json = JsonConvert.SerializeObject(carro);

E vice-versa:

var json = "{\"Placa\":\"ABC123\",\"Modelo\":\"Gol\",\"Marca\":\"Volkswagen\",\"Ano\":2015,\"Cor\":\"Prata\"}";
var carro = JsonConvert.DeserializeObject<Carro>(json);



