namespace Lesson_11_12_Exception_Abstact.Helpers;

static class Dangerous
{
    public static void DangerousMethod()
    {
        int number = 5;

        Console.WriteLine(number / 0);
    }
}
