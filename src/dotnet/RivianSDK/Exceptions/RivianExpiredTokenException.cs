namespace RivianSDK;

public class RivianExpiredTokenException : RivianApiException
{
    public RivianExpiredTokenException() : base("Access token expired.")
    {
        
    }
}
