namespace Lesson_11_12_Exception_Abstact.Exceptions;

public class CustomException : ApplicationException
{
    public int StatusCode { get; set; }

    public CustomException(string message) : base(message) { }

    public CustomException(int statusCode, string message)
        :base(message)
    {
        StatusCode = statusCode;
    }


}
