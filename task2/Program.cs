// Напишите программу, которая найдет точку пересечения двух прямых, заданных уравнениями
// y = k1 * x + b1, y = k2 *x + b2, значения b1, k1, b2 и k2 задаются пользователем

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите X первой прямой: ");
double b1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите Y первой прямой: ");
double k1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите X второй прямой: ");
double b2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите Y первой прямой: ");
double k2 = Convert.ToInt32(Console.ReadLine());

double num1 = ((b2 - b1) / (k1 - k2));
double num2 = ((k1 * b2) - (b1 * k2)) / (k1 - k2);

Console.Write($"Точка пересечения двух прямых: ({num1}; {num2})");

 
