namespace Module_09.Second_Quest.Utils;

public enum SortType
{
    forward,
    reverse
}


/// <summary>
/// Метод возвращает описание на русском языке
/// </summary>
public static class SortDirectionExtensions{
    public static string ToRussianString(this SortType direction){
        return direction switch {
            SortType.forward => "Сортировка от А до Я",
            SortType.reverse => "Сортировка от Я до А",
            _=>"Незапланированная сортировка"
        };
    }
}
