namespace PaymentsRequests.APIException;

public class ApiException : Exception
{
    public int StatusCode { get; set; }
    public string Details { get; set; }

    public ApiException(string message, int statusCode = 500, string details = null) : base(message)
    {
        StatusCode = statusCode;
        Details = details;
    }
}