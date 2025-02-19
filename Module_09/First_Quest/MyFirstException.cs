using System;

namespace Module_09.First_Quest;

public class MyFirstException : Exception
{
    //Сообщение по умолчанию
    private const string DEFAULT_MESSAGE = "Моё собственное исключение";

    //Пустой конструктор
    public MyFirstException() : base(DEFAULT_MESSAGE) {

    }

    //Конструктор для переопределения сообщения
    public MyFirstException(string message) : base(message){

    }

    //Конструктор для переопределения сообщения и проброса цепочки исключений
    public MyFirstException(string message, Exception innerException) : base(message, innerException) {

    }

}
