using Calculadora.Services;

CalculadoraImp c = new CalculadoraImp("08/11/2024");

        c.Somar(1, 2);
        c.Somar(7, 5);
        c.Somar(5, 10);
        c.Somar(8, 12);
         var listaHistorico = c.Historico();
         
foreach(var numero in listaHistorico)
{
    Console.WriteLine(numero);
}
