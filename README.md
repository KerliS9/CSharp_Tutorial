# Bem Vindo a este repositório

Repositório criado para treinar conceitos básicos em C#

# Pastas e conteúdos

- arrayStructure:
    - array único []
    - array multidimensional [,]
    - array jagged [][]
    - array com mais de uma dimensão  não pode ser testado de forma direta, precisa ser transformado em array único primeiro

- calculator:
    - convertendo tipos de dados

- console: 
    - imprimindo dados
    - concatenando variáveis no texto

- controlStructure:
    - verificando condição antes de converter
    - função com if/else e switch/case

- convertData:
    - testando conversões

- dataType:
    - tipos de dados
    - quebrando linha
    - acessando métodos
    - tipos de números

- debugging code:
    - passo a passo para usar o debug

- exception:
    - try/catch/finally

- guessingGame:
    - adivinhando a palavra
    - while combinado com if/else

- iterationStructure:
    - forEach/for/while/doWhile
    - StringWriter/StringReader

- madLib:
    - imprimindo string com join
    - criando nova string com classe

- methods:
    - chamando funções no método Main
    - usando parâmetros

- userInput:
    - fazendo interação com o usuário

## Comandos mais usados

- dotnet run
- dotnet test
- dotnet build
- dotnet test --logger "console;verbosity=detailed"

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

### Principais tipos de dados

- char - usado para identificar um caractere, por exemplo: 'A'
- int - usado para identificar números inteiros, por exemplo: 12
- decimal - usado para identificar números com casas decimas, é necessário usar o sufixo m, por exemplo: 12.30m (Sem sufixo o número será tratado como double)
- bool - usado para identificar valor verdadeiro ou falso, por exemplo: true
- string - usado para apresentação ou referência, por exemplo: "Hello World!"

### Lendo erros no console - pontos de atenção:

 - A primeira parte (1,1) indica a "linha e a coluna" em que o erro ocorreu.
 - O C# é uma linguagem que diferencia maiúsculas de minúsculas.
 - Aspas precisam ser duplas. Aspas simples somente são usadas para identificar o tipo de dado CHAR.

### Atalhos

- cw + tab : para criar a linha System.Console.WriteLine
- ctrl + x : remover linhas
- t (try) + tab : cria um bloco try/catch
- ctrl + / : comentar a linha

### Adicionais

- Console.WriteLine - imprime uma linha abaixo da outra
- Console.Write - encadeia a resposta numa linha
- Aspas duplas ""- cadeia de caracteres literal
- Parênteses () - operador de invocação de método
- Classe - métodos residem dentro de classes
- Ponto . - entre a classe e o método - é como se navega entre a classe e seus métodos
- Ponto e vírgula - final do operador de instrução
- Array multidimensional [,] - número da linha x número da coluna
- Try/catch/finally - finally sempre será executado, podendo ser usada para parar de consumir a conexão que foi iniciada no try

### Sobre C#
 
 - linguagem tipada
 - compilada
 - de código gerenciado - depende de um gerenciador, conhecido como Runtime. No C# este Runtime se chama CLR ou CLR Runtime.

 - IL - Intermediate Language - todas as linguagens da Microsoft são compiladas para este nível
 - CLR - Common Language Runtime - depois o CLR compila para código de máquina, executa e gerencia
 - JIT - Just In Time

  - namespace: usado para relacionar os arquivos. Arquivos com o mesmo namespace ficam dentro do mesmo diretório.