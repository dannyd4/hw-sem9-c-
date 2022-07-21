
//sem9 c# test 64 Задайте значение N. Напишите программу, которая найдет кол-во цифр в числе N рекурсивным методом.

/*
int NumbOfDigRecur(int a) 
{
    if (a >= 10) 
    {
        return 1 + NumbOfDigRecur(a / 10);
    }
    else return 1;
}

Console.Write("Введите челое число от 0 до 999999999 N = ");
int x = Convert.ToInt32(Console.ReadLine());

Console.Write(NumbOfDigRecur(x));
*/


//sem9 c# test 66 Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. 

/*
int ShowNums (int m, int n)
{
    if(n >= m ) return n + ShowNums(m, n-1);
    else return 0;

}

Console.Write("Введите челое число M(начало отрезка) = ");
int M = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите челое число N(конец отрезка) = ");
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(ShowNums(M,N));
*/

