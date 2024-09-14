using Sintaxe_Basica.Common.Models;

List<string> listaString = new List<string>();

listaString.Add("SP");
listaString.Add("BA");
listaString.Add("MG");

Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

listaString.Add("SC");

Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

listaString.Remove("MG");

Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");






// for(int i = 0; i < listaString.Count; i++)
// {
//     Console.WriteLine($"Posição Nº {i} - {listaString[i]}");
// }

// int contadorForeach = 0;
// foreach(string item in listaString)
// {
//     Console.WriteLine($"Posição Nº {contadorForeach} - {item}");
//     contadorForeach++;
// }

// int[] arrayInteiros = new int[3];

// arrayInteiros[0] = 72;
// arrayInteiros[1] = 64;
// arrayInteiros[2] = 50;

// int[] arrayInteirosDobrado = new int[arrayInteiros.Length * 2];
// Array.Copy(arrayInteiros, arrayInteirosDobrado, arrayInteiros.Length);


// Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);

// Percorrendo o Array com o FOR
// for(int i = 0; i < arrayInteiros.Length; i++)
// {
//     Console.WriteLine($"Posição N° {i} - {arrayInteiros[i]}");
// }

// Percorrendo o Array com o FOREACH
// int contadorForeach = 0;
// foreach(int valor in arrayInteiros)
// {
//     Console.WriteLine($"Posição N° {contadorForeach} - {valor}");
// }

// Repeticao rep = new Repeticao();

// rep.Menu();
// // rep.Durante(10);
// // rep.Enquanto(10);
// rep.FacaEnquanto();

// Calculadora calc = new Calculadora();

// calc.Somar(10, 5);
// calc.Subtrair(10, 5);
// calc.Multiplicar(10, 5);
// calc.Dividir(10, 5);
// calc.Potencia(10, 5);
// calc.Seno(30);
// calc.Coseno(30);
// calc.Tangente(30);
//calc.RaizQuadrada(16);

// int numero = 10;

// Console.WriteLine(numero);

// Console.WriteLine("Incrementando o 10");
// numero++;
// //numero--;

// Console.WriteLine(numero);

// bool choveu = false;
// bool estaTarde = true;

// if(!choveu && !estaTarde)
// {
//     Console.WriteLine("Vou pedalar");
// }
// else
// {
//     Console.WriteLine("Vou pedalar outro dia");
// }

// bool possuiPresencaMinima = true;
// double media = 8.5;

// if (possuiPresencaMinima && media >= 7)
// {
//     Console.WriteLine("Aprovado");
// }
// else 
// {
//     Console.WriteLine("Reprovado");
// }

// bool ehMaiorDeIdade = true;
// bool possuiAutorizacaoDoResponsavel = false;

// if(ehMaiorDeIdade || possuiAutorizacaoDoResponsavel)
// {
//     Console.WriteLine("Entrada liberada!");
// }
// else
// {
//     Console.WriteLine("Entrada não liberada");
// }

// Console.WriteLine("Digite uma letra: ");
// string letra = Console.ReadLine();

// switch (letra)
// {
//     case "a":
//     case "e":
//     case "i":
//     case "o":
//     case "u":
//         Console.WriteLine("Vogal");
//     break;
//     default:
//         Console.WriteLine("Vogal");
//     break;
// }

// if(letra == "a")
// {
//     Console.WriteLine("Vogal");
// }
// else if(letra == "e")
// {
//     Console.WriteLine("Vogal");
// }
// else if(letra == "i")
// {
//     Console.WriteLine("Vogal");
// }
// else if(letra == "o")
// {
//     Console.WriteLine("Vogal");
// }
// else if(letra == "u")
// {
//     Console.WriteLine("Vogal");
// }
// else
// {
//     Console.WriteLine("Não é um vogal");
// }

// int quantidadeEmEstoque = 10;
// int quantidadeCompra = 4;
// bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;

// Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
// Console.WriteLine($"Quantidade de compras realizadas: {quantidadeCompra}");
// Console.WriteLine($"É possível realizar a venda? {possivelVenda}");

// if(quantidadeCompra  == 0)
// {
//     Console.WriteLine("Venda inválida");

// }
// else if(quantidadeEmEstoque >= quantidadeCompra)
// {
//     Console.WriteLine("Venda realizada");
// }
// else 
// {
//     Console.WriteLine("Desculpe. Não temos a quantidade desejada em estoque.");
// }

//string a = "15";

//int b = 0;
//int.TryParse(a, out b);
// OU
// int.TryParse(a, out  int b);

// Console.WriteLine(b);
// Console.WriteLine("Conversão realizada com sucesso");


// double a = 4 / (2 + 2);

// Console.WriteLine(a);

// int a = 5;
// double b = a;

// int a = 5;
// long b = a;

// long a = long.MaxValue;
// int b = Convert.ToInt32(a);

// Console.WriteLine(b);

// int inteiro = 5;
// string a = inteiro.ToString();

// Console.WriteLine(a);

// Cast - Casting
// int a = Convert.ToInt32(null);
//  int a = int.Parse("5");
// Console.WriteLine(a);

// int a = 10;
// int b = 20;

// int c = a + b;

// c = a + b;

//c += 5;
//c -= 5;
//c *= 5;

//Console.WriteLine(c);