using ExemploFundamentos.Models;


// Pessoa pessoa = new Pessoa();
// pessoa.Cadastro("Vitor", 27);

//////////////////// LISTA ///////////////////////////////////
// PercorrendoArray lista = new PercorrendoArray();
// lista.ArrayNumeros();

//////////////////// CONTADOR ////////////////////////////////
// Contador contador = new Contador();
// contador.Multiplicador();
//////////////////// SOMA EM LOOPING //////////////////////////
// contador.LoopingDeSoma();

///////////////////  CALCULADORA //////////////////////////////
// Calculadora calculadora = new Calculadora();
// Console.WriteLine("Calculadora C#");
// Console.WriteLine("1-Somar | 2-Subtrair | 3-Dividir | 4-Multiplicar | 5-Potência | 6-Seno | 7-Coseno | 8-Tangente | 9-Raiz Quadrada");
// Console.WriteLine("Selecione uma operação");
// int operacaoRealizada = Convert.ToInt32(Console.ReadLine());
// switch(operacaoRealizada)
// {
//     case 1:
//         calculadora.Somar();
//         break;
//     case 2:
//         calculadora.Subtrair();
//         break;
//     case 3:
//         calculadora.Dividir();
//         break;
//     case 4:
//         calculadora.Multiplicar();
//         break;
//     case 5:
//         calculadora.Potencia();
//         break;
//     case 6:
//         calculadora.Seno();
//         break;
//     case 7:
//         calculadora.Coseno();
//         break;
//     case 8:
//         calculadora.Tangente();
//         break;
//     case 9:
//         calculadora.RaizQuadrada();
//         break;
//     default:
//         Console.WriteLine("*** Opção inválida. ***");
//         break;
// }


//////////////////// LISTA e ARRAY ////////////////////////////
// Tem como principal diferença a capacidade de redimencionamento conforme é necessário, por isso o uso da LISTA é mais indicado.

//////////////// LISTA ////////////////
List<string> listaString = new List<string>();

listaString.Add("TO");
listaString.Add("SP");
listaString.Add("MA");
listaString.Add("GO");

Console.WriteLine("LISTA TESTE");
int contadorLista = 0;
foreach(string lista in listaString)
{
    Console.WriteLine($"Elemento lista N° {contadorLista} - {lista}");
    contadorLista++;
}
Console.WriteLine($"Quantidade de elementos na Lista: {listaString.Count} - Capacidade da lista: {listaString.Capacity}");

// Redimencionamento automatico conforme o necessário
// Obs.: As Listas tem como base no seu código fonte os Arrays, porém possuem "atalhos" para execução de determinadas tarefas.
Console.WriteLine("Adição do elemento: BA");
listaString.Add("BA");

Console.WriteLine($"Quantidade de elementos na Lista: {listaString.Count} - Capacidade da lista: {listaString.Capacity}");


//////////////// ARRAY ////////////////
string[] arrayString = new string[4];

arrayString[0] = "RJ";
arrayString[1] = "PA";
arrayString[2] = "DF";
arrayString[3] = "AM";

Console.WriteLine("ARRAY TESTE");
int contadorArray = 0;
foreach(string array in arrayString)
{
    Console.WriteLine($"Elemento array N° {contadorArray} - {array}");
    contadorArray++;
}

Console.WriteLine($"Quantidade de elementos no Array: {contadorArray} - Capacidade do Array: {arrayString.Length}");

// Para a adição de mais itens é necessário o seu redimencionamento. 
// Obs.: O Array não é redimencionado, mas sim copiado para outro Array de maior capacidade.
Console.WriteLine($"Redimencionamento do Array - Array.Resize<>");
Array.Resize<string>(ref arrayString, arrayString.Length * 2);

Console.WriteLine($"Quantidade de elementos no Array: {contadorArray} - Capacidade do Array: {arrayString.Length}");