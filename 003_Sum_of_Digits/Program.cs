Console.WriteLine("Введите целое число А");
int A = int.Parse( Console.ReadLine() ?? "0");
int x = A;
int sum = 0;
int digit = 0;

while (x > 0) 
{
    digit = x % 10;
    sum += digit;
    x = x / 10;
}

Console.WriteLine($"Сумма цифр в числе равна {sum}");