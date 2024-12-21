namespace OOP_architecture.Extansion;

public static class ExtensionTask
{
    public static bool IsEvenNumber(this int number)
    {
        var check = false;
        if (number % 2 == 0)
        {
            return true;
        }
        return check;
    }

    public static bool IsPrimeNumber(this int number)
    {
        var counterDivide = 0;
        var checkPrime = false;
        for (var i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                counterDivide++;
            }
        }
        if (counterDivide == 2)
        {
            checkPrime = true;
        }
        return checkPrime;
    }

    public static int Valuable(this int number, int value)
    {
        var sum = number + value;
        return sum;
    }

    public static int UpperLatterCounter(this string text)
    {
        var count = 0;
        foreach(char latter in text)
        {
            if (char.IsUpper(latter))
            {
                count++;
            }
        }
        return count;
    }

    public static List<Person> OlderThan(this List<Person> peaple)
    {
        var list = new List<Person>();
        var humanSecond = 
        foreach(var human in peaple)
        {
            if (human.Age > peaple)
            {

            }
        }
    }

}
