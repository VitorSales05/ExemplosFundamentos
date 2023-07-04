using ExemploFundamentos.Models;


// Pessoa pessoa = new Pessoa();
// pessoa.Cadastro("Vitor", 27);

//////////////////// LISTA ///////////////////////////////////
// Lista lista = new Lista();
// lista.ArrayNumeros();

//////////////////// CONTADOR ////////////////////////////////
// Contador contador = new Contador();
// contador.Multiplicador();
//////////////////// SOMA EM LOOPING //////////////////////////
// contador.LoopingDeSoma();

///////////////////  CALCULADORA //////////////////////////////
Calculadora calculadora = new Calculadora();
Console.WriteLine("Calculadora C#");
Console.WriteLine("1-Somar | 2-Subtrair | 3-Dividir | 4-Multiplicar | 5-Potência | 6-Seno | 7-Coseno | 8-Tangente | 9-Raiz Quadrada");
Console.WriteLine("Selecione uma operação");
int operacaoRealizada = Convert.ToInt32(Console.ReadLine());
switch(operacaoRealizada)
{
    case 1:
        calculadora.Somar();
        break;
    case 2:
        calculadora.Subtrair();
        break;
    case 3:
        calculadora.Dividir();
        break;
    case 4:
        calculadora.Multiplicar();
        break;
    case 5:
        calculadora.Potencia();
        break;
    case 6:
        calculadora.Seno();
        break;
    case 7:
        calculadora.Coseno();
        break;
    case 8:
        calculadora.Tangente();
        break;
    case 9:
        calculadora.RaizQuadrada();
        break;
    default:
        Console.WriteLine("*** Opção inválida. ***");
        break;
}
