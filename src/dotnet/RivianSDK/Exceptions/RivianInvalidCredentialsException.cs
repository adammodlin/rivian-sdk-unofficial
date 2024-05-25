namespace RivianSDK;

public class RivianInvalidCredentialsException : RivianApiException
{
    public RivianInvalidCredentialsException() : base("User credentials invalid.")
    {
        
    }
}
