using System.Collections.Concurrent;

void expressoes()
{ 
    int a = 10, b = 3; 
    double c = 20.5, d = 4;
    Console.WriteLine(a + b * d);
    Console.WriteLine(d / b - a);
    Console.WriteLine(c + a % b);
    Console.WriteLine(d * (a + b) / d);
    Console.WriteLine(c - a % b / d);
}

void condicaoExpressao()
{ 
    int a = 20, b = 15;
    Console.WriteLine($"a = {a} | b = {b}");
    bool resp;
    resp = a > b;
    Console.WriteLine($"> {resp}");
    resp = a < b;
    Console.WriteLine($"< {resp}");
    resp = a >= b;
    Console.WriteLine($">= {resp}");
    resp = a <= b;
    Console.WriteLine($"<= {resp}");
    resp = a == b;
    Console.WriteLine($"== {resp}");
    resp = a != b;
    Console.WriteLine($"!= {resp}");

    a = 10;
    b = 10;
    Console.WriteLine($"\na = {a} | b = {b}");

    resp = a > b;
    Console.WriteLine($"> {resp}");
    resp = a < b;
    Console.WriteLine($"< {resp}");
    resp = a >= b;
    Console.WriteLine($">= {resp}");
    resp = a <= b;
    Console.WriteLine($"<= {resp}");
    resp = a == b;
    Console.WriteLine($"== {resp}");
    resp = a != b;
    Console.WriteLine($"!= {resp}");
}

// Exercício: dado um numero pelo usuário, calcular o seu módulo matematico:
// numero: 67   67
// numero: -45  45

void exercicioModulo()
{
    // -------------- ALGORITMO
    int num;
    // ler um numero
    Console.Write("Digite um numero: ");
    num = Convert.ToInt16(Console.ReadLine()); // 67

    // verificar se o numero é negativo
    if (num < 0)
    {
        // Bloco verdade
        // se for transformar em positivo
        num = num * -1;
    }

    // exibir o numero
    Console.WriteLine($"Numero = {num}");
}

void desvioComposto()
{
    /* venda até 500 -> 6%
     * venda acima 500 -> 12%
     * exibir o valor com desconto
     */
    double venda;
    Console.Write("Venda R$ ");
    venda = Convert.ToDouble(Console.ReadLine());

    if (venda > 500)
    {
        venda = venda * 0.88;
    }
    else
    {
        venda = venda * 0.94;
    }
    Console.WriteLine($"Novo valor: R$ {venda}");
}

void encadeado() { 
    // Dado um numero pelo usuário, verificar se o numero é "positivo", "negativo" ou "nulo"
    // num  67      positivo
    // num  0       nulo
    // num  -4      negativo
    int num;
    Console.Write("Numero: ");
    num = Convert.ToInt16(Console.ReadLine()); // 77
    // --------------------------------------
    if (num > 0)
    { 
        Console.WriteLine("Positivo");
        Console.WriteLine("dasdsadasdas");
    }
    else if (num < 0)
    {
        Console.WriteLine("Negativo");
    }
    else
    {
        Console.WriteLine("nulo");
    }
    // --------------------------------------

    if (num > 0)
    { 
        Console.WriteLine("Positivo");
    }
    else if (num < 0)
    { 
        Console.WriteLine("Negativo");
        if (num != 0)
        { 
            Console.WriteLine("dsfsadf");
        }
    }
    else
    { 
        Console.WriteLine("nulo");
    }
}

void switch1()
{ 
    // Exibir por extenso o dia da semana a partir de um numero
    int dia = 8; // ao comparar numero, coloque somente o numero
    char letra = 'A'; // ao comparar char (um caractere) coloque entre apóstrofo ' '
    string palavra = "Edson"; // ao comparar string, coloque entre aspas ""

    switch(dia)
    {
        case 1:
            Console.WriteLine("Domingo"); break;
        case 2:
            Console.WriteLine("Segunda"); break;
        case 3:
            Console.WriteLine("terca"); break;
        case 4:
            Console.WriteLine("quarta"); break;
        case 5:
            Console.WriteLine("quinta"); break;
        case 6:
            Console.WriteLine("sexta"); break;
        case 7:
            Console.WriteLine("sábado"); break;
        default:
            Console.WriteLine("Dia inexistente"); break;
    }
}


int a, b;
a = Convert.ToInt32(Console.ReadLine());
b = Convert.ToInt32(Console.ReadLine());

switch ((a, b))
{
    case ( > 0, > 0) when a == b:
        Console.WriteLine($"Os valores são positivos, mas iguais: {a}");
        break;
    case ( > 0, > 0):
        Console.WriteLine($"Positivos mas diferentes a = {a} e b = {b}");
        break;
    default:
        Console.WriteLine($"um ou os dois são negativos  a = {a} e b = {b}");
        break;
}














