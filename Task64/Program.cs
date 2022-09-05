// Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N.

int M = Create("Введите M: ");
int N = Create("Введите N: ");
Show(M, N);

void Show(int M, int N)
{
    if(N > M) return;
    Show(M, N + 1);
    Console.Write(N + ". ");
}

int Create(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}
