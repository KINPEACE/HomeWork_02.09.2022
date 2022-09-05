// Задайте значения M и N. Напишите программу,
// которая найдет сумму натуральных элементов в промежутке от M до N.

int M = Create("Введите M: ");
int N = Create("Введите N: ");
int tmp = M;

if(M > N)
{
    M = N;
    N = tmp;
}

Summa(M, N, tmp = 0);

void Summa(int M, int N, int sum)
{
    sum = sum + N;
    if(N <= M)
    {
        Console.Write($"Сумма элементов = {sum} ");
        return;
    }
    Summa(M, N - 1, sum);
}

int Create(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}
