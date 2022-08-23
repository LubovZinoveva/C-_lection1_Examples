// Рекурсия - функция, которая вызвывает сама себя

double Factorial(int n)
{
    // 1! = 1
    // 0! = 1
    if(n == 1 || n == 0) return 1;
    else return n * Factorial(n - 1);
}

for(int i = 1; i < 25; i ++)
{
    Console.WriteLine($"{i}! = {Factorial(i)}");
}
// тут на 17! сбой, тк тип int мало вмещает в себя. 
//Оптимально использовать тип double в функции

