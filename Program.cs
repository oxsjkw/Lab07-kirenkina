//Шаг 1.
// string[] days = {"Пн", "Вт", "Ср", "Чт", "Пт"};
// for (int i = 0; i < days.Length; i++) {
//     Console.WriteLine($"{i}: {days[i]}");
// }

//Задание 1.1.
// string[] days = {"Пн", "Вт", "Ср", "Чт", "Пт", "Сб", "Вс"};
// for (int i = days.Length - 1; i >= 0; i--) {
//     Console.WriteLine($"{i + 1}: {days[i]}");
// }

//Задание 1.2.
// double[] temps = { -2, 7, 5, 20, -9, 4, 30 };
// foreach (double t in temps)
// {
//     Console.Write(t + " ");
// }

//Шаг 2.
// int[] marks = { 5, 4, 3, 5, 4 };
// int sum = 0;
// foreach (int mark in marks) {
//     sum += mark;
// }
// double average = (double)sum / marks.Length;
// Console.WriteLine($"Сумма: {sum}, среднее: {average}");

//Задание 2.
// int[] prices = { 120, 45, 300, 80, 15, 210 };
// int sum = 0;
// int count_expensive_100 = 0;
// foreach (int p in prices)
// {
//     sum += p;
//     if (p > 100)
//     {
//         count_expensive_100++;
//     }
// }
// Console.WriteLine($"Общая сумма цен: {sum}, Средняя цена: {(double)sum / prices.Length}, Количество товаров дороже 100: {count_expensive_100}");

//Шаг 3.
// int[] numbers = { 7, -2, 15, 4, 9 };
// int max = numbers[0];
// for (int i = 1; i < numbers.Length; i++) {
//     if (numbers[i] > max) {
//         max = numbers[i];
//     }
// }
// Console.WriteLine($"Максимум: {max}");

//Задание 3.
// int[] prices = { 120, 45, 300, 80, 15, 210 };
// int min = prices[0];
// int max_ind = 0;
// for (int p = 0; p < prices.Length; p++)
// {
//     if (prices[p] > prices[max_ind])
//     {
//         max_ind = p;
//     }
//     else if (prices[p] < min)
//     {
//         min = prices[p];
//     }
// }
// Console.WriteLine($"Минимальная цена: {min}, Индекс самого дорогого товара: {max_ind}");

//Шаг 4.
// int[] numbers = { 1, 2, 3, 4, 5 };
// for (int i = 0; i < numbers.Length; i++) {
//     numbers[i] = numbers[i] * 2;
// }
// foreach (int n in numbers) {
//     Console.Write(n + " ");
// }

//Задание 4. 
// int[] balance = { 100, -50, 20, -5, 0, 75 };
// for (int i = 0; i < balance.Length; i++)
// {
//     if (balance[i] < 0)
//     {
//         balance[i] = 0;
//     }
// }
// foreach (int i in balance)
// {
//     Console.Write(i + " ");
// }

//Задание 5.
// Console.WriteLine("Введите 5 чисел: ");
// int[] numbers = new int[5];
// int count = 0;
// for (int i = 0; i < numbers.Length; i++)
// {
//     numbers[i] = int.Parse(Console.ReadLine());
//     if (numbers[i] % 2 == 0)
//     {
//         count++;
//     }
// }
// Console.WriteLine($"Чётных среди введённых: {count}");
// for (int i = numbers.Length - 1; i >= 0; i--)
// {
//     Console.Write(numbers[i] + " ");
// }

//Задание 6.
// Console.Write("Введите имя для поиска: ");
// string[] names = { "Анна", "Игорь", "Мария", "Олег", "Ольга" };
// string name = Console.ReadLine();
// bool YES_or_NO = false;
// for (int n = 0; n < names.Length; n++)
// {
//     if (names[n] == name)
//     {
//         Console.WriteLine($"Имя {name} на позиции: {n + 1}");
//         YES_or_NO = true;
//         break;
//     }
// }
// if (!YES_or_NO)
// {
//     Console.WriteLine("Не найдено");
// }

//Итоговая задача. «Журнал оценок»
int[] grades = {2, 4, 2, 3, 5, 5, 4, 4};
int count_2 = 0;
int count_5 = 0;
int sum = 0;
int max = grades[0];
int min = grades[0];
for (int g = 0; g < grades.Length; g++)
{
    Console.Write(grades[g] + " ");
    sum += grades[g];
    if (grades[g] > max)
    {
        max = grades[g];
    }
    else if (grades[g] < min)
    {
        min = grades[g];
    }
    switch (grades[g]) {
        case 2:
            count_2++; 
            break;
        case 5:
            count_5++; 
            break;
    }
}
Console.WriteLine();
double mid_grade = (double)sum / grades.Length;
Console.WriteLine($"Средняя оценка: {mid_grade}");
Console.WriteLine($"Наибольшая оценка: {max}, наименьшая оценка: {min}");
Console.WriteLine($"Двоек: {count_2}, пятёрок: {count_5}");
switch(mid_grade)
{
    case >= 4.5:
        Console.WriteLine("Отличник");
        break;
    case >= 3.5:
        Console.WriteLine("Хорошист");
        break;
    default:
        Console.WriteLine("Есть над чем поработать");
        break;
}

//Console.WriteLine("");