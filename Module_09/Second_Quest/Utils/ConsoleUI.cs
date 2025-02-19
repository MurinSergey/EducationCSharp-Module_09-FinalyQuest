
namespace Module_09.Second_Quest.Utils;

public static class ConsoleUI
{

    /// <summary>
    /// Событие срабатывает после выбора направления сортировки
    /// </summary>
    internal static event Action<bool>? OnSortParametrEntered;

    /// <summary>
    /// Запуск выбора параметра сортировки
    /// </summary>
    /// <param name="stop_string">Команда остановки</param>
    internal static void StartEnterSortParametr(string stop_string)
    {
        while (true)
        {
            Console.WriteLine("Пожалуйста выберите направление сортировки:");

            var sortDirections = Enum.GetValues<SortDirection>();

            foreach (var direction in sortDirections)
            {
                Console.WriteLine($"{(int)direction + 1}. {direction.ToRussianString()}");
            }

            string answer;
            if ((answer = Console.ReadLine() ?? "").Equals(stop_string.ToLower()))
            {
                break;
            }

            try
            {
                try
                {
                    var num = Convert.ToInt32(answer);

                    if (num != 1 && num != 2) throw new WrongSortParametrException();

                    SortParametrEntered(num);
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
    /// <param name="sortBy">Параметр сортировки</param>
    private static void SortParametrEntered(int sortBy)
    {
        switch (sortBy) {
            case 1:
                OnSortParametrEntered?.Invoke(false);
                break;
            case 2:
                OnSortParametrEntered?.Invoke(true);
                break;
        }
    }
}

