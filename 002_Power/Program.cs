Console.WriteLine("Введите целое основание А");
int A = int.Parse( Console.ReadLine() ?? "0");

Console.WriteLine("Введите целый показатель степени B");
int B = int.Parse( Console.ReadLine() ?? "0");

int x = A;
if (B == 0 ) Console.WriteLine($"Ответ: 1");
else if (B > 0)
{
    for (int i = 1; i < B; i += 1) A = A * x;
    Console.WriteLine($"Ответ: {A}");
}
else if (B < 0)
{
    for (int j = 1; j < (-1)*B; j += 1) A = A * x;
    Console.WriteLine($"Ответ: 1/{(A)}");
}