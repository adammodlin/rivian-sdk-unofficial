namespace RivianSDK;

public class RivianApiRateLimitException : RivianApiException
{
    public RivianApiRateLimitException() : base("API is being rated limited.")
    {
        
    }
}