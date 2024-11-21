try
{
    Console.Write("Введите первое число: ");
    string st1 = Console.ReadLine();
    double num1 = Convert.ToDouble(st1);

    Console.Write("Введите второе число: ");
    string st2 = Console.ReadLine();
    double num2 = Convert.ToDouble(st2);

    double result = (num1 / num2);
    Console.WriteLine($"Результат деления {num1} на {num2} равен: {result}");
}
catch (DivideByZeroException)
{
    Console.WriteLine("На ноль делить нельзя!");
}
catch (FormatException)
{
    Console.WriteLine("Вы ввели неверные данные, введите числа");
}
catch (Exception ex)
{
    Console.WriteLine($"Ошибка: {ex.Message}");
}
finally
{
    Console.WriteLine("Спасибо, что делили здесь (надеюсь без ошибок)");
}

