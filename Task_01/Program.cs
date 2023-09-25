bool IsPalindrome(int number)
{
    if (number < 10000 || number > 99999)
    {
        Console.WriteLine("Число не пятизначное");
        return false;
        
    }
    else
    {
        int numFirstEnd = number % 10;
        int numFirstStart = number / 10000;
        int numSecondEnd = number % 100 / 10;
        int numSecondStart = number / 1000 % 10;
        if (numFirstEnd == numFirstStart && numSecondEnd == numSecondStart) return true;
        else return false;
    }
}

// Console.WriteLine("Введите число: ");
// int val = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(IsPalindrome(val));