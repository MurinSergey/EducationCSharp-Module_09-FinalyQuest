using System;

namespace Module_09.First_Quest;

public class Main
{
    internal static void Run()
    {
        //Массив из пяти исключений
        Exception[] exceptions = [
            new NotImplementedException(),
            new FormatException(),
            new MyFirstException(),
            new ArgumentNullException(),
            new ArgumentOutOfRangeException()
        ];

        foreach (Exception ex in exceptions)
        {
            try
            {
                Console.WriteLine("=============================");
                throw ex;
            }
            catch (Exception exception)
            {
                Console.WriteLine($"Сработало исключение {exception.GetType().Name}: {exception.Message}");
            }
            finally
            {
                Console.WriteLine("=============================");
            }
        }

    }
}
