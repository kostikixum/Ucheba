//В задаче вводиться любое число и разряд который надо получить. 
Console.WriteLine("Введитt целое число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите желаемый разряд");
int num0 = Convert.ToInt32(Console.ReadLine());
int num2, num3, num4 = 0, num5, num6, num7 = 0, num8, num9;
num6 = num1;
do
{
    num2 = num1 / 10;
    num3 = num1 - (num2 * 10);
    num4 = num4 + 1;
    num1 = num2;
} while (num2 > 0);
num5 = num4 - num0;
if (num5 < num0)
{
    Console.WriteLine("короткое число");
}
else
{
    do
    {
        num8 = num6 / 10;
        num9 = num6 - (num8 * 10);
        num7 = num7 + 1;
        num6 = num8;
    } while (num7 < num5);
    Console.WriteLine(num9);
};