namespace RivianSDK;

public class RivianTemporarilyLockedException : RivianApiException
{
    public RivianTemporarilyLockedException() : base("User temporarily locked.")
    {
        
    }
}