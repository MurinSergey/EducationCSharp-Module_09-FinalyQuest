
using System.Collections.Generic;
using System.Globalization;

namespace Module_09.Second_Quest.Utils;

public static class ConsoleUI
{

    /// <summary>
    /// Событие срабатывает после выбора типа сортировки
    /// </summary>
    internal static event Action<List<string>, SortType>? OnSortParametrEntered;

    /// <summary>
    /// Событие срабатывает после ввода команды остановки процесса
    /// </summary>
    internal static event Action<string>? OnSortParametrCommand;

    /// <summary>
    /// Запуск выбора параметра сортировки
    /// </summary>
    /// <param name="stop_string">Команда остановки</param>
    internal static void StartEnterSortParametr(List<string> people, string stop_string = "stop")
    {
        PrintStringList(people);

        while (true)
        {
            Console.WriteLine();
            Console.WriteLine($"Пожалуйста выберите направление сортировки или напишете \"{stop_string}\":");

            var sortDirections = Enum.GetValues<SortType>();

            foreach (var direction in sortDirections)
            {
                Console.WriteLine($"{(int)direction + 1}. {direction.ToRussianString()}");
            }

            string answer;
            if ((answer = Console.ReadLine() ?? "").ToLower().Equals(stop_string.ToLower()))
            {
                OnSortParametrCommand?.Invoke(stop_string);
                break;
            }

            try
            {
                try
                {
                    var num = Convert.ToInt32(answer);

                    if (num < 1 || num > sortDirections.Length) throw new WrongSortParametrException();

                    SortParametrEntered(people, (SortType)num - 1);
                }
                catch (Exception ex) when (ex is FormatException || ex is OverflowException)
                {
                    throw new WrongSortParametrException(ex);
                }
            }
            catch (WrongSortParametrException ex)
            {
                Console.WriteLine(ex.Message);
                if (ex.InnerException != null)
                {
                    Console.WriteLine(ex.InnerException.Message);
                }
            }
        }
    }

    /// <summary>
    /// Вызывает событие сортировки в выбранным параметром
    /// </summary>
    /// <param name="people">Сортируемый список</param>
    /// <param name="sortBy">Параметр сортировки</param>
    private static void SortParametrEntered(List<string> people, SortType sortBy)
    {
        OnSortParametrCommand?.Invoke(sortBy.ToRussianString());
        OnSortParametrEntered?.Invoke(people, sortBy);
    }

    /// <summary>
    /// Метод выводит список строк в консоль
    /// </summary>
    /// <param name="stringList">Список строк</param>
    internal static void PrintStringList(List<string> stringList)
    {
        Console.WriteLine();
        Console.WriteLine("Содержимое списка: ");
        foreach (var item in stringList)
        {
            Console.WriteLine(item);
        }
    }
}

