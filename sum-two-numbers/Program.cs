// Спрашиваем первое число. Console.ReadLine всегда возвращает строку.
Console.Write("Первое число: ");
string? first = Console.ReadLine();

// Спрашиваем второе число.
Console.Write("Второе число: ");
string? second = Console.ReadLine();

// TryParse пытается превратить строку в число.
// Если не получилось — возвращает false, и программа не падает.
// && значит: блок сработает только если ОБА числа разобрались успешно.
if (int.TryParse(first, out int x) && int.TryParse(second, out int y))
    Console.WriteLine(x + y);
else
    Console.WriteLine("Это не числа");

// int.Parse(first) сделал бы то же самое, но на слове "кот" уронил бы программу
// с FormatException. Поэтому здесь используется TryParse, а не Parse.

// Console.WriteLine(first + second);  // вывело бы "55": склеивает строки, а не числа
