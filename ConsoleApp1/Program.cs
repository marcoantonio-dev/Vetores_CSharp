using System;

class Program
{
    static void Main()
    {
        // Definindo o tamanho do vetor
        int tamanhoVetor = 10;

        // Criando o vetor
        int[] vetor = new int[tamanhoVetor];

        // Preenchendo o vetor com valores informados pelo usuário
        for (int i = 0; i < tamanhoVetor; i++)
        {
            Console.Write($"Digite o valor {i + 1}: ");
            if (!int.TryParse(Console.ReadLine(), out vetor[i]))
            {
                Console.WriteLine("Valor inválido. Tente novamente.");
                i--; // Permite ao usuário tentar novamente para a posição atual
            }
        }

        // Somando os elementos do vetor
        // int soma = 0;
        /*foreach (int num in vetor)
        {
            soma += num;
        }

        // Exibindo o resultado
        Console.WriteLine($"A soma dos elementos do vetor é: {soma}");
        */

        int auxiliar;
        for(int i=0; i <vetor.Length; i++)
        {
            for(int j = i; j < vetor.Length; j++)
            {
                if (vetor[i] < vetor[j])
                {
                     auxiliar = vetor[i];
                     vetor[i] = vetor[j];
                     vetor[j] = auxiliar;
                }
            }
        }

        //imprimir o vetor ordenado
        Console.WriteLine("Imprimindo os valores do vetor ordenado");
        for (int i = 0; i < tamanhoVetor; i++)
        {
            Console.Write(vetor[i] + ", ");
        }

        Console.WriteLine("Vetor ordenado");

    }
}