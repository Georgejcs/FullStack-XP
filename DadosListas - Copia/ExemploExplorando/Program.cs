using System.Globalization;
using ExemploExplorando.Models;

int numero = 20;
bool ehPar = false;

// IF Ternário
ehPar = numero % 2 == 0;
Console.WriteLine($"O número {numero} é " + (ehPar ? "par" : "ímpar"));

// if (numero % 2 == 0)
// {
//     Console.WriteLine($"O número {numero} é par");
// }
// else
// {
//     Console.WriteLine($"O número {numero} é ímpar");
// }

// Pessoa p1 = new Pessoa("George", "José");

// (string nome, string sobrenome) = p1;

// Console.WriteLine($"{nome} {sobrenome}");

// LeituraArquivo arquivo = new LeituraArquivo();

// var (sucesso, linhasArquivo, _) = arquivo.LerArquivo("Arquivos/arquivoLeitura.txt");

// if (sucesso)
// {
//     // Console.WriteLine("Quantidade linhas do arquivo: " + quantidadeLinhas);
//     foreach(string linha in linhasArquivo)
//         Console.WriteLine(linha);
// }
// else
// {
//     Console.WriteLine("Não foi possível ler o arquivo");
// }

// (int Id, string Nome, string Sobrenome, decimal Altura) tupla = (1, "George", "José", 1.65M);

// // ValueTuple<int, string, string, decimal> outroExemplo = (1, "George", "José", 1.80M);
// // var outroExemploTuplaCreate = Tuple.Create(1, "Leonardo", "Buta", 1.65M);

// Console.WriteLine($"Id: {tupla.Id}");
// Console.WriteLine($"Nome: {tupla.Nome}");
// Console.WriteLine($"Sobrenome: {tupla.Sobrenome}");
// Console.WriteLine($"Altura: {tupla.Altura}");

// Dictionary<string, string> estados = new Dictionary<string, string>();

// estados.Add("SP", "São Paulo");
// estados.Add("BA", "Bahia");
// estados.Add("MG", "Minas Gerais");   

// Console.WriteLine(estados["MG"]);

// foreach(var KeyValuePair<string, string> item in estados)
// {
//     Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// }

// estados.Remove("BA");
// estados["SP"] = "São Paulo - valor alterado";

// foreach(var item in estados)
// {
//     Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// }

// string chave = "BA";
// Console.WriteLine($"Verificando o elemento: {chave}");

// if(estados.ContainsKey(chave))
// {
//     Console.WriteLine($"Valor existente: {chave}");
// }
// else
// {
//     Console.WriteLine($"Valor não existe. É seguro adicionar a chave: {chave}");
// }

// Stack<int> pilha = new Stack<int>();

// pilha.Push(4);
// pilha.Push(6);
// pilha.Push(8);
// pilha.Push(10);

// foreach(int item in pilha)
// {
//     Console.WriteLine(item);
// }

// Console.WriteLine($"Removendo o elemento do topo: {pilha.Pop()}");
// pilha.Push(20);

// foreach(int item in pilha)
// {
//     Console.WriteLine(item);
// }

// Queue<int> fila = new Queue<int>();

// fila.Enqueue(2);
// fila.Enqueue(4);
// fila.Enqueue(6);
// fila.Enqueue(8);

// foreach(int item in fila)
// {
//     Console.WriteLine(item);
// }

// Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}");
// fila.Enqueue(10);

// foreach(int item in fila)
// {
//     Console.WriteLine(item);
// }
//new ExemploExcecao().Metodo1();

// try
// {
//     string[] linhas = File.ReadAllLines("Arquivos/arquivo_Leitura.txt");

//     foreach (string linha in linhas)
//     {
//         Console.WriteLine(linha);
//     }
// }
// catch(FileNotFoundException ex)
// {
//     Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Arquivo não encontrado. {ex.Message}");
// }
// catch(DirectoryNotFoundException ex)
// {
//     Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Caminho da pasta não encontrado. " + ex.Message);
// }
// catch (Exception ex)
// {
//     Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}");
// }
// finally
// {
//     Console.WriteLine("Chegou até aqui");
// }

// Console.WriteLine("Chegou até aqui");

// DateTime data = DateTime.Now;
// Console.WriteLine(data.ToShortDateString());
// Console.WriteLine(data.ToShortTimeString());

// string dataString = "2022-13-17 18:00";
// bool sucesso = DateTime.TryParseExact(dataString,
//                       "yyyy-MM-dd HH:mm",
//                       CultureInfo.InvariantCulture,
//                       DateTimeStyles.None, out DateTime data);
// if(sucesso)
// {
//     Console.WriteLine($"Conversão com sucesso! Data: {data}");
// }
// else
// {
//     Console.WriteLine($"{dataString} não é uma data válida");
// }


// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");

// decimal valorMonetario = 1582.40M;
// Console.WriteLine(${valorMonetario:C}");
// Console.WriteLine(valorMonetario.ToString("C"));

// double porcentagem = .3421;
// Console.WriteLine(porcentagem.ToString("P"));

// int numero = 123456;
// Console.WriteLine(numero.ToString("##-##-##"));

// Pessoa p1 = new Pessoa( nome: "George", sobrenome: "José");

// Pessoa p2 = new Pessoa(nome: "Eduardo", sobrenome: "Neves");

// Curso cursoDeIngles = new Curso();
// cursoDeIngles.Nome = "Ingles";
// cursoDeIngles.Alunos = new List<Pessoa>();

// cursoDeIngles.AdicionarAluno(p1);
// cursoDeIngles.AdicionarAluno(p2);
// cursoDeIngles.ListarAlunos();
// p1.Idade = 20;
// p1.Apresentar(); 