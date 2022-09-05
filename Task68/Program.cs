// Напишите програму вычесления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.

int m = Create("Введите m: ");
int n = Create("Введите n: ");

int Akkerman = A(m, n);

Console.Write($"Функция Аккермана = {Akkerman} ");

int A(int m, int n)
{
    if(m == 0) return n + 1;
    else if(n == 0) return A(m - 1, 1);
    else return A(m - 1, A(m, n - 1));
}

int Create(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}
