namespace Module_09.Second_Quest.Utils;

public enum SortDirection
{
    forward,
    reverse
}

public static class SortDirectionExtensions{
    public static string ToRussianString(this SortDirection direction){
        return direction switch {
            SortDirection.forward => "Сортировка от А до Я",
            SortDirection.reverse => "Сортировка от Я до А",
            _=>"Незапланированная сортировка"
        };
    }
}
