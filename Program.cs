//1. Entrada, Processamento e Saída
// Leia o nome de uma pessoa e exiba uma mensagem de boas-vindas personalizada.
// Leia a idade de uma pessoa e informe quantos anos ela terá daqui a 10 anos.
// Peça ao usuário dois números e mostre a soma, subtração, multiplicação e divisão entre eles.
// Leia um número e mostre o seu dobro e o seu triplo.

// using _09._02;

// Atividadeum Atividade = new Atividadeum();

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

using _09._02;

AtividadeDois Atividade = new AtividadeDois();

Console.WriteLine("entre com o numero para saber se é impar ou par");
Atividade.ParImpar = double.Parse(Console.ReadLine());
Atividade.Impar();

Console.WriteLine("entre com o primeiro numero para saber se é maior menor ou igual");
Atividade.NumeroUm = double.Parse(Console.ReadLine());
Atividade.Maior();

Console.WriteLine("entre com o segundo numero para saber se é maior menor ou igual");
Atividade.NumeroDois = double.Parse(Console.ReadLine());


Console.WriteLine("entre com a nota para saber se esta aprovado");
Atividade.Nota = double.Parse(Console.ReadLine());
Atividade.Situacao();

Console.WriteLine("entre com a idade para saber a situação");
Atividade.Idade = double.Parse(Console.ReadLine());
Atividade.Velha();

Console.WriteLine("entre com o numero para saber se positivo ou negativo");
Atividade.Real = double.Parse(Console.ReadLine());
Atividade.positivo();