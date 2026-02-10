//1. Entrada, Processamento e Saída
// Leia o nome de uma pessoa e exiba uma mensagem de boas-vindas personalizada.
// Leia a idade de uma pessoa e informe quantos anos ela terá daqui a 10 anos.
// Peça ao usuário dois números e mostre a soma, subtração, multiplicação e divisão entre eles.
// Leia um número e mostre o seu dobro e o seu triplo.

// using _09._02;

//Atividadeum Atividade = new Atividadeum();

// Console.WriteLine("entre com seu nome");
// Atividade.Nome = Console.ReadLine();

// Console.WriteLine("entre com sua idade");
// Atividade.Idade = double.Parse(Console.ReadLine());

// Console.WriteLine("entre com o primeiro número para as 4 operações");
// Atividade.NumeroUm = double.Parse(Console.ReadLine());

// Console.WriteLine("entre com o segundo número para as 4 operações");
// Atividade.NumeroDois = double.Parse(Console.ReadLine());

// Console.WriteLine("entre com o número para saber seu dobro e triplo");
// Atividade.Dobro = double.Parse(Console.ReadLine());

// Atividade.Apresentar();


// 2. Estruturas Condicionais (if / else)
// Leia um número e informe se ele é par ou ímpar.
// Leia dois números e mostre qual é o maior ou informe se são iguais.
// Leia a nota de um aluno e informe se ele está aprovado, em recuperação ou reprovado.
// Leia a idade de uma pessoa e informe se ela é menor de idade, adulta ou idosa.
// Leia um número e informe se ele é positivo, negativo ou zero

// using _09._02;

// AtividadeDois Atividade = new AtividadeDois();

// Console.WriteLine("entre com o numero para saber se é impar ou par");
// Atividade.ParImpar = double.Parse(Console.ReadLine());
// Atividade.Impar();

// Console.WriteLine("entre com o primeiro numero para saber se é maior menor ou igual");
// Atividade.NumeroUm = double.Parse(Console.ReadLine());
// Atividade.Maior();

// Console.WriteLine("entre com o segundo numero para saber se é maior menor ou igual");
// Atividade.NumeroDois = double.Parse(Console.ReadLine());


// Console.WriteLine("entre com a nota para saber se esta aprovado");
// Atividade.Nota = double.Parse(Console.ReadLine());
// Atividade.Situacao();

// Console.WriteLine("entre com a idade para saber a situação");
// Atividade.Idade = double.Parse(Console.ReadLine());
// Atividade.Velha();

// Console.WriteLine("entre com o numero para saber se positivo ou negativo");
// Atividade.Real = double.Parse(Console.ReadLine());
// Atividade.positivo();

// 3. Estruturas de Repetição (for / while)
// Mostre os números de 1 a 10 usando um laço.
// Mostre os números pares de 1 a 50.
// Leia um número e mostre a tabuada dele.
// Leia vários números até que o usuário digite 0 e mostre a soma de todos.
// Leia 5 números e informe quantos são positivos.

// using _09._02;

// AtividadeTres atividade = new AtividadeTres();
// Console.WriteLine("Mostre os números de 1 a 10 usando um laço.");
// atividade.Mostrar();
// Console.WriteLine("Mostre os números pares de 1 a 50");
// atividade.Par();
// Console.WriteLine("diga o número para saber a tabuada dele");
// atividade.Numero = int.Parse(Console.ReadLine());
// atividade.Tabuada();
// atividade.LerNumeros();
// atividade.MostrarResultado();
// Console.WriteLine("diga o número para saber se é positivo");
// atividade.Real = int.Parse(Console.ReadLine());
// atividade.positivo();
// Console.WriteLine("diga o número para saber se é positivo");
// atividade.Real = int.Parse(Console.ReadLine());
// atividade.positivo();
// Console.WriteLine("diga o número para saber se é positivo");
// atividade.Real = int.Parse(Console.ReadLine());
// atividade.positivo();
// Console.WriteLine("diga o número para saber se é positivo");
// atividade.Real = int.Parse(Console.ReadLine());
// atividade.positivo();
// Console.WriteLine("diga o número para saber se é positivo");
// atividade.Real = int.Parse(Console.ReadLine());
// atividade.positivo();


// 4. Estrutura de Decisão Múltipla (switch / case)
// Crie um menu com as opções:
// 1 – Somar
// 2 – Subtrair
// 3 – Multiplicar
// 4 – Dividir
// O usuário escolhe a opção e informa dois números.
// Leia um número de 1 a 7 e informe o dia da semana correspondente.
// Leia um código de produto e informe a categoria (ex: 1–Alimento, 2–Bebida, 3–Limpeza).
Console.WriteLine("Digite o primeiro número: ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o segundo número: ");
int b = int.Parse(Console.ReadLine());

Console.WriteLine("escolha uma opção: ");
Console.WriteLine("1 - Somar");
Console.WriteLine("2 - Subtrair");
Console.WriteLine("3 - Multiplicar");
Console.WriteLine("4 - dividir");

Console.Write("Escolha uma opção: ");
int opcao = int.Parse(Console.ReadLine());

switch (opcao)
{
    case 1:
        Console.WriteLine($"o resultado é :{a + b}");
        break;

    case 2:
        Console.WriteLine($"o resultado é :{a - b}");
        break;

    case 3:
        Console.WriteLine($"o resultado é :{a * b}");
        break;
    case 4:
        Console.WriteLine($"o resultado é :{a / b}");
        break;

    default:
        Console.WriteLine("Opção inválida!");
        break;
}

Console.WriteLine("escolha uma opção: ");

Console.WriteLine("1 ");
Console.WriteLine("2 ");
Console.WriteLine("3 ");
Console.WriteLine("4 ");
Console.WriteLine("5");
Console.WriteLine("6");
Console.WriteLine("7");
int Escolha = int.Parse(Console.ReadLine());
switch (Escolha)
{
    case 1:
        Console.WriteLine("segunda-feira");
        break;

    case 2:
        Console.WriteLine("terça-feira");
        break;

    case 3:
         Console.WriteLine("quarta-feira");
        break;
    case 4:
         Console.WriteLine("quinta-feira");
        break;

    case 5:
        Console.WriteLine("sexta-feira");
        break;

    case 6:
         Console.WriteLine("sabado");
        break;

    case 7:
        Console.WriteLine("domingo");
        break;

    default:
        Console.WriteLine("Opção inválida!");
        break;
}


Console.WriteLine("escolha uma opção de codigo: ");

Console.WriteLine("1 ");
Console.WriteLine("2 ");
Console.WriteLine("3 ");
Console.WriteLine("4 ");
Console.WriteLine("5");
Console.WriteLine("6");
Console.WriteLine("7");
int EscolhaDois = int.Parse(Console.ReadLine());
switch (EscolhaDois)
{
    case 1:
        Console.WriteLine("alimento");
        break;

    case 2:
        Console.WriteLine("bebida");
        break;

    case 3:
         Console.WriteLine("limpeza");
        break;
    case 4:
         Console.WriteLine("fruta");
        break;

    case 5:
        Console.WriteLine("verdura");
        break;

    case 6:
         Console.WriteLine("açougue");
        break;

    case 7:
        Console.WriteLine("padaria");
        break;

    default:
        Console.WriteLine("Opção inválida!");
        break;
}
