using System.Text.Json.Serialization;

namespace Mercado.Application.Response;

public class Response<T>
{
    // TODO error type
    public T? Data { get; set; }
    public string? ErrorMessage { get; set; }
    public bool HasError => !string.IsNullOrEmpty(ErrorMessage);

    public static Response<T> Success(T data)
    {
        return new Response<T> { Data = data };
    }

    public static Response<T> Fail(string errorMessage)
    {
        return new Response<T> { ErrorMessage = errorMessage };
    }
}
