namespace Module_09.Exceptions;

public class WrongSortParametrException : Exception
{

    //Сообщение по умолчанию
    private const string DEFAULT_MESSAGE = "Выбран неверный параметр сортировки: нужно выбрать 1 или 2";

    /// <summary>
    /// Конструктор по умолчанию
    /// </summary>
    public WrongSortParametrException() : base(DEFAULT_MESSAGE){

    }

    /// <summary>
    /// Конструктор с переопределением сообщения
    /// </summary>
    /// <param name="message">Новое сообщение исключения</param>
    public WrongSortParametrException(string message) : base(message){

    }

    /// <summary>
    /// Конструктор с переопределением сообщения и пробросом цепочки исключения
    /// </summary>
    /// <param name="message">Новое сообщение</param>
    /// <param name="innerException">Внутреннее исключение</param>
    public WrongSortParametrException (string message, Exception innerException) : base(message, innerException) {

    }

    /// <summary>
    /// Конструктор c пробросом цепочки исключения
    /// </summary>
    /// <param name="innerException">Внутреннее исключение</param>
    public WrongSortParametrException (Exception innerException) : base(DEFAULT_MESSAGE, innerException) {

    }
}
