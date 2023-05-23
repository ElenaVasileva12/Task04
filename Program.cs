
int number1=Convert.ToInt32(Console.ReadLine());
int number2=Convert.ToInt32(Console.ReadLine());
int number3=Convert.ToInt32(Console.ReadLine());

int max=number1;

if (number2>max)
{
    Console.WriteLine($"max = {number2}");
}
else if (number3>max)
{
    Console.WriteLine($"max = {number3}");
}
else
{
    Console.WriteLine($"max ={number1}");
}