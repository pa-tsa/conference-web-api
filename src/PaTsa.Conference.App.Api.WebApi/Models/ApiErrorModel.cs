namespace PaTsa.Conference.App.Api.WebApi.Models;

public class ApiErrorModel
{
    public int ErrorCode { get; set; }

    public string? Message { get; set; }

    public static ApiErrorModel Unauthorized => new()
    {
        ErrorCode = (int)ErrorCodes.Unauthorized,
        Message = "Client is unauthorized"
    };
}

public enum ErrorCodes
{
    Unauthorized = 1000
}
