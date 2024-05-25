namespace RivianSDK;

public class RivianInvalidOTPException : RivianApiException
{
    public RivianInvalidOTPException() : base("User OTP invalid.")
    {
        
    }
}