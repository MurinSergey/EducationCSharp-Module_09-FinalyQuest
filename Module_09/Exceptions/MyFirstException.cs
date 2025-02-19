namespace Module_09.Exceptions;

public class MyFirstException : Exception
{
    //Сообщение по умолчанию
    private const string DEFAULT_MESSAGE = "Моё собственное исключение";

    /// <summary>
    /// Конструктор по умолчанию
    /// </summary>
    public MyFirstException() : base(DEFAULT_MESSAGE) {

    }

    /// <summary>
    /// Конструктор с переопределением сообщения
    /// </summary>
    /// <param name="message">Новое сообщение исключения</param>
    public MyFirstException(string message) : base(message){

    }

    /// <summary>
    /// Конструктор с переопределением сообщения и пробросом цепочки исключения
    /// </summary>
    /// <param name="message">Новое сообщение</param>
    /// <param name="innerException">Внутреннее исключение</param>
    public MyFirstException(string message, Exception innerException) : base(message, innerException) {

    }

}
