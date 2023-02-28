// Рекурсия


// double Factorial (double n)
// {
//     // 1! == 1
//     if(n == 1) return 1;
//     else return n * Factorial(n-1);
// }
// for (double i = 1; i < 40; i++)
// {
// Console.WriteLine($"{i} = {Factorial(i)}");
// }
// отрицательные значение появляются из-за переполнения типа 17! не вмещается в типа данных int
// поэтому можно int заменить на double
// 1,1240007277776077E+21 - E+21 это 10 в 21 степени

// Фибоначчи

// f(1) = 1
// f(2) = 1
// f(n) = f(n-1) + f(n-2)

double Fibonacci(int n)
{
    if (n == 1 || n == 2) return 1;
    else return Fibonacci(n - 1) + Fibonacci(n - 2);
}

for (int i = 1; i < 50; i++)
{
    Console.WriteLine($"f({i}) = {Fibonacci(i)}");
}