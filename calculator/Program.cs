// Вводим первое число
Console.WriteLine("Введите первое число ");
string? first = Console.ReadLine();
// Превращаем строку first в число num1. если не получилось появляется ошибка 
if (!double.TryParse(first, out double num1)) { Console.WriteLine("Ошибка! Введите число"); return; }

// Вводим символ (+, -, *, /)
Console.WriteLine("Выберите операцию: ");
string? op = Console.ReadLine();

// Вводим второе число
Console.WriteLine("Введите второе число: ");
string? second = Console.ReadLine();


// Превращаем строку second в число num2. если не получилось появляется ошибка
if (!double.TryParse(second, out double num2)) { Console.WriteLine("Ошибка! Введите число"); return; }

// Арифметические операции. тут программа понимает какой именно знак был введен
if (op == "+") { Console.WriteLine($"Результат: {num1 + num2}"); }
else if (op == "-") { Console.WriteLine($"Результат: {num1 - num2}"); }
else if (op == "*") { Console.WriteLine($"Результат: {num1 * num2}"); }
// Если выбрана операция деления загляни внутрь: если второе число равно нулю — напиши "Infinity", а во всех остальных случаях просто раздели первое число на второе и выведи ответ
else if (op == "/")
{
    double result = num1 / num2;
    if (double.IsNaN(result)) Console.WriteLine("Не число (0/0)");
    else if (double.IsInfinity(result)) Console.WriteLine("Деление на ноль невозможно");
    else Console.WriteLine($"Результат: {result}");
}

else
    Console.WriteLine("Неизвестная Операция!");