namespace Module_09.Second_Quest;

public class Main
{
    internal static void Run(){
        Console.WriteLine("Выполняем программу второго задания");

        List<string> list = [
            "Иванов",
            "Петров",
            "Сидоров",
            "Ульянов",
            "Булатов"
        ];
        Utils.ConsoleUI.OnSortParametrEntered += SortedPeopleList;
        Utils.ConsoleUI.StartEnterSortParametr("Stop");
    }

    internal static void SortedPeopleList(bool direction){
        
    }
}
