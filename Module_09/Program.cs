//Запускаем программу через шаблонный делегат.
Action startProgram = First_Quest.Run;
startProgram += Second_Quest.Run;
startProgram?.Invoke();
Console.ReadKey();