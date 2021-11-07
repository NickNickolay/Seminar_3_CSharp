// 0. Вывести квадрат числа 
//int a=3;
//Console.WriteLine(a*a);

//  1. По двум введённым числам проверять является ли первое квадратом второго
// int a = 3;
// int b = 45;
// if (a * a == b)
//     Console.WriteLine("yes");
// else Console.WriteLine("no");


//  2. Даны два числа. Показать большее и меньшее число
// int a = 6;
// int b = 38;
// int max = 0;
// int min = 0;
// if (a > b)
// {
//     max = a;
//     min = b;
// }
// if (b > a)
// {
//     max = b;
//     min = a;
// }
// Console.WriteLine($"max = {max}, min = {min}");

//  3. По введенному номеру дня недели вывести его название
// Console.WriteLine("Введите номер деня недели: ");
// int a = Convert.ToInt32(Console.ReadLine());
//     if (a == 1)
//     {
//         Console.WriteLine("Monday");
//     }
//     if (a == 2)
//     {
//         Console.WriteLine("Tuesday");
//     }
//     if (a == 3)
//     {
//         Console.WriteLine("Wednesday");
//     }
//     if (a == 4)
//     {
//         Console.WriteLine("Thursday");
//     }
//     if (a == 5)
//     {
//         Console.WriteLine("Friday");
//     }
//     if (a == 6)
//     {
//         Console.WriteLine("Saturday");
//     }
//     if (a == 7)
//     {
//         Console.WriteLine("Sunday");
//     }



//  4. Найти максимальное из трех чисел
// int a = 344;
// int b =1357;
// int c = 34;
// int max = a;
// if(b>max) max = b;
// if(c>max) max = c;
// Console.WriteLine(max);

//  5. Написать программу вычисления значения функции y=f(a) / y=2*a+b/c.
// int F(int a, int b, int c)
// {
// return 2*a + b/c; 
// }
// Console.WriteLine(F(2, 6, 5));

//  6. Выяснить является ли число чётным
/*int a = 22;
if(a%2==0)
{
    Console.WriteLine($"Четное: {a}");
}
if(a%2!=0)
{
    Console.WriteLine($"Нечетное: {a}");
}

Console.WriteLine();
*/

//  7. Показать числа от -N до N
/*int n = 10;
for (int i = -n; i <= n; i++)
{
    Console.Write($"{i} ");
}
*/

//  8. Показать четные числа от 1 до N
/*int n = 10;
for (int i = 1; i <= n; i++)
{
    if (i % 2 == 0)
    Console.Write($"{i} ");
    
}
*/

//  9. Показать последнюю цифру трёхзначного числа
/*int x = new Random().Next(100,1000);
int z = x % 10;
Console.WriteLine(x);
Console.WriteLine(z);
*/

// 10. Показать вторую цифру трёхзначного числа
int x = new Random().Next(100,1000);
int z = x % 100;
int a = z/10;
Console.WriteLine($"{x}, {a}");
