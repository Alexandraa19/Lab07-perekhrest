// int[] marks = { 5, 4, 3, 5, 4 };

// Console.WriteLine(marks[0]);
// Console.WriteLine(marks[4]);

// marks[2] = 4;
// for (int i = 0; i < marks.Length; i++)
// {
//     Console.WriteLine($"marks[{i}] = {marks[i]}");
// }

// foreach (int mark in marks) { Console.WriteLine(mark); }
// //задание 1.1 
// string[] days = { "Пн", "Вт", "Ср", "Чт", "Пт", "Сб", "Вс" };

// for (int i = days.Length - 1; i >= 0; i--)
// {
//     Console.WriteLine($"{i} = {days[i]}");
// }

// //задание 1.2
// double[] temps = { 11.3, -3.0, 25.0, 21.2, -7.6, 1.4, 9.2 };
// foreach (double t in temps)
// {
//     Console.WriteLine(t + " ");
// }
// Console.WriteLine();
// Console.WriteLine();

//задание 2
// int[] prices = { 120, 45, 300, 80, 15, 210 };
// int obsum = 0;

// foreach (int p in prices) { obsum += p; }
// double srpr = (double)obsum / prices.Length;
// int expen = 0;
// foreach (int p in prices) { if (p > 100) expen++; }
// Console.WriteLine($"сумма цен: {obsum}");
// Console.WriteLine($"средняя цена:{srpr}");
// Console.WriteLine($"товары дороже 100:{expen}");
// Console.WriteLine();

// //задание 3
// int minpr = prices[0];
// int maxi = 0;
// for (int i = 1; i < prices.Length; i++)
// {
//     if (prices[i] < minpr) minpr = prices[i];
//     if (prices[i] > prices[maxi]) maxi = i;
// }
// Console.WriteLine($"мин. цена: {minpr}");
// Console.WriteLine($"индекс самог дорого товара:{maxi}");
// Console.WriteLine();

//задание 4
int[] balance = { 100, -50, 20, -5, 0, 75 };
for (int i = 0; i < balance.Length; i++)
{
    if (balance[i] < 0) balance[i] = 0;
}
Console.WriteLine("массив после замены:");
foreach (int b in balance)
{
    Console.Write(b + " ");
}
Console.WriteLine();
Console.WriteLine();

// задание 5
int[] numbers = new int[5];
for (int i = 0; i < numbers.Length; i++)
{
    Console.Write($"введите число {i + 1}: ");
    numbers[i] = int.Parse(Console.ReadLine()!);
}

Console.WriteLine("массив в обратном порядке:");
for (int i = numbers.Length - 1; i >= 0; i--)
{
    Console.Write(numbers[i] + " ");
}
Console.WriteLine();

int ec = 0;
foreach (int n in numbers)
{
    if (n % 2 == 0) ec++;
}
Console.WriteLine($"чётных чисел: {ec}");
Console.WriteLine();

//задание 6
string[] names = { "Анна", "Игорь", "Мария", "Олег", "Ольга" };
Console.Write("введите имя : ");
string sname = Console.ReadLine()!;

int fin = -1;
for (int i = 0; i < names.Length; i++)
{
    if (names[i] == sname)
    {
        fin = i;
        break;
    }
}

if (fin >= 0)
    Console.WriteLine($"имя найдено на позиции {fin}");
else
    Console.WriteLine("не найдено");
Console.WriteLine();

//итоговая задача:
int[] grades = new int[8];
Console.WriteLine("введите 8 оценок (от 2 до 5):");
for (int i = 0; i < grades.Length; i++)
{
    Console.Write($"оценка {i + 1}: ");
    grades[i] = int.Parse(Console.ReadLine()!);
}

Console.Write("все оценки: ");
foreach (int g in grades) Console.Write(g + " ");
Console.WriteLine();

int sumgrades = 0;
foreach (int g in grades) sumgrades += g;
double avggrade = (double)sumgrades / grades.Length;

int maxgrade = grades[0];
int mingrade = grades[0];
int twos = 0;
int fives = 0;

foreach (int g in grades)
{
    if (g > maxgrade) maxgrade = g;
    if (g < mingrade) mingrade = g;
    if (g == 2) twos++;
    if (g == 5) fives++;
}

Console.WriteLine($"средняя оценка: {avggrade:F2}");
Console.WriteLine($"максимальная оценка: {maxgrade}");
Console.WriteLine($"минимальная оценка: {mingrade}");
Console.WriteLine($"количество двоек: {twos}");
Console.WriteLine($"количество пятёрок: {fives}");

if (avggrade >= 4.5)
    Console.WriteLine("отличник");
else if (avggrade >= 3.5)
    Console.WriteLine("хорошист");
else
    Console.WriteLine("есть над чем поработать");
Console.WriteLine();

// доп.задания
int[] arr = { 1, 2, 3, 4, 5, 6 };
for (int i = 0; i < arr.Length / 2; i++)
{
    int temp = arr[i];
    arr[i] = arr[arr.Length - 1 - i];
    arr[arr.Length - 1 - i] = temp;
}
Console.Write("развёрнутый массив: ");
foreach (int x in arr) Console.Write(x + " ");
Console.WriteLine();