namespace RivianSDK;

public class RivianUnauthenticatedException : RivianApiException
{
    public RivianUnauthenticatedException() : base("User token invalid.")
    {
        
    }
}