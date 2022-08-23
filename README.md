# Bem Vindo a este repositório

Repositório criado para treinar conceitos básicos em C#

# Pastas e conteúdos

- Console: 
    - imprimindo dados
    - concatenando variáveis no texto

- dataType:
    - tipos de dados
    - quebrando linha
    - acessando métodos
    - tipos de números

- userInput:
    - fazendo interação com o usuário

- debugging code:
    - passo a passo para usar o debug

- calculator:
    - convertendo tipos de dados

- madLib:
    - imprimindo string com join
    - criando nova string com classe

- convertData:
    - testando conversões

- controlStructure:
    - verificando condição antes de converter
    - função com if/else e switch/case

- iterationStructure:
    - forEach/for/while/doWhile
    - StringWriter/StringReader

## Comandos mais usados

- dotnet run
- dotnet test
- dotnet build

- dotnet new console -o console1
    console será o tipo de arquivo criado. console1 será o nome da pasta

- dotnet new xUnit -o console1.Test
- dotnet add package FluentAssertions --version 6.5.1
    comando para adicionar a fluência nos testes - processar o comando dentro da pasta de testes
- dotnet add reference ../pastaOrigem/pastaComAsFunçõesASeremTestadas.csproj
    referencia os testes em relação as funções

### Iniciando um projeto simples
- criar pasta (demais comandos processar dentro da pasta)
- dotnet new sln (irá criar um arquivo NomeDaPasta.sln)
- dotnet new classlib -o nomeDaPastaQueConteráALógica
- dotnet sln NomeDaPasta.sln add nomeDaPastaQueConteráALógica/nomeDaPastaQueConteráALógica.csproj

- dotnet new xUnit -n nomeDaPastaQueConteráALógica.Test
- dotnet sln NomeDaPasta.sln add nomeDaPastaQueConteráALógica.Test/nomeDaPastaQueConteráALógica.Test.csproj
- cd nomeDaPastaQueConteráALógica.Test
- dotnet add reference ../NomeDaPasta/nomeDaPastaQueConteráALógica.csproj
- dotnet add package FluentAssertions --version 6.5.1

Para processar e testar:
 - dotnet build
 - dotnet test

PS. os arquivos que possuem a lógica desenvolvida podem ser renomeados conforme a classe do arquivo. NomeDaClasse.cs
Da mesma forma para os arquivos de testes, usando o formato NomeDaClasse.Test.cs
