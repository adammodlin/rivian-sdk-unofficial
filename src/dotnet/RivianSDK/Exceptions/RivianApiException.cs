namespace RivianSDK;

public class RivianApiException : ApplicationException
{
    public RivianApiException(string message, string code) : base($"Unknown Rivian API exception. {code}: {message}")
    {
        
    }

    public RivianApiException(string message) : base(message)
    {
    }
}
