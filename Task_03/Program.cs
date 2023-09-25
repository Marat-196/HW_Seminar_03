// Внутри класса Answer напишите метод ShowCube, 
// который принимает на вход число (N) и выводит 
// таблицу кубов чисел от 1 до N (включительно) каждое на новой строке.

void ShowCube(int n)
{
    int count = 1;
    while(count <= n)
    {
        Console.WriteLine($"{Math.Pow(count, 3)}");
        count += 1;
    }
}

Console.Write("Введите число N: ");
int num = Convert.ToInt32(Console.ReadLine());
ShowCube(num);