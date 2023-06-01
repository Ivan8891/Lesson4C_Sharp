int RaiseToPower(int a, int b) // Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
{
    int result = a;
    for( int i = 1; i < b; i++ )
    {
        result *= a;
    }
    return result;
}
