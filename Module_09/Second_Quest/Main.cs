using Module_09.Second_Quest.Utils;
using System.Globalization;

namespace Module_09.Second_Quest;

public class Main
{
    internal static void Run()
    {
        Console.WriteLine("====Выполняем программу второго задания====");

        List<string> list = [
            "Булатов",
            "Демьянов",
            "Антонов",
            "Якорь",
            "Юла"
        ];

        Utils.ConsoleUI.OnSortParametrEntered += SortedPeopleList;
        Utils.ConsoleUI.OnSortParametrCommand += PrintSortedProcessCommand;
        Utils.ConsoleUI.StartEnterSortParametr(list, "Стоп");
    }

    /// <summary>
    /// Метод выполняет сортировку переданного массива
    /// </summary>
    /// <param name="people">Список фамилий</param>
    /// <param name="direction">Направление сортировки</param>
    internal static void SortedPeopleList(List<string> people, SortType sortBy)
    {
        /*
         *  При сортировке строк необходимо учитывать на каком языке написаны строки.
         *  Если не учитывать язык, то сравнение через метод sort() будет выполняться по юникоду, что не всегда корректно.
         */
        CultureInfo culture = new("ru-RU");
        switch (sortBy)
        {
            case SortType.forward:
            default:
                people.Sort((a, b) => culture.CompareInfo.Compare(a, b));
                break;
            case SortType.reverse:
                people.Sort((a, b) => culture.CompareInfo.Compare(b, a));
                break;
        }
        Utils.ConsoleUI.PrintStringList(people);
    }

    /// <summary>
    /// Выводит имя команды
    /// </summary>
    /// <param name="command">Выпоненная команда</param>
    internal static void PrintSortedProcessCommand(string command)
    {
        Console.WriteLine($"Процесс выполнил команду: {command}");
    }
}
