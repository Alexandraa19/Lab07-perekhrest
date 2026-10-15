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
