/*
# Atividade 02 — Sistema de tabuada personalizada
## Situação-problema
Um professor deseja criar um programa para ajudar alunos do ensino fundamental a estudar tabuada.
O sistema deve permitir que o usuário escolha um número e exibir a tabuada de 1 até 10.
## Regras de negócio
- O usuário deve informar o número da tabuada.
- O sistema deve exibir a multiplicação de 1 até 10.
- Após exibir a tabuada, o programa deve perguntar se o usuário deseja consultar outra.
*/

// static int LerNumeroTabuada()
// {
//     Console.Write("Digite um número para a tabuada");
//     int numero = int.Parse(Console.ReadLine()!);
//     return numero;
// }
// static void ExibirTabuada(int numero)
// {
//     Console.WriteLine();
//     int contador = 1;
//     while (contador <= 10)
//     {
//         Console.WriteLine($"{numero} x {contador} = {numero * contador}");
//         contador++;
//     }
//     Console.WriteLine();
// }

// static string LerContinuacao()
// {
//     Console.WriteLine("Deseja continuar outra tabuada? s/n: ");
//     string resposta = Console.ReadLine()!;
//     return resposta;
// }
// static bool DesejaContinuar(string resposta)
// {
//     if (resposta == "s" || resposta == "S")
//     {
//         return true;
//     }
//     else
//     {
//         return false;
//     }
// }
// static void ExecutarTabuada()
// {
//     Console.Clear();
//     int numero = LerNumeroTabuada();
//     ExibirTabuada(numero);
//     string resposta = LerContinuacao();
//     if (DesejaContinuar(resposta))
//     {
//         ExecutarTabuada();
//     }
//     else
//     {
//         Console.WriteLine();
//         Console.WriteLine("Programa encerrado.");
//     }
// }
// ExecutarTabuada();