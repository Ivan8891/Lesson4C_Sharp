int RaiseToPower(int a, int b) // Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
{
    int result = a;
    for( int i = 1; i < b; i++ )
    {
        result *= a;
    }
    return result;
}
int SumOfNumber(int number) // Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
{
	int sum = 0;
	int num = 0;
	while(number != 0)
	{
		num = number%10;
		sum += num;
		number /= 10;
	}
	return sum;
}
