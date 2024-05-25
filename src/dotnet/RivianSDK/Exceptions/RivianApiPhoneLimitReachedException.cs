namespace RivianSDK;

public class RivianApiPhoneLimitReachedException : RivianApiException
{
    public RivianApiPhoneLimitReachedException() : base("Phone limit has been reached.")
    {
        
    }
}