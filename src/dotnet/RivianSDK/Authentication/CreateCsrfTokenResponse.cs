using System.Text.Json.Serialization;

namespace RivianSDK;

public class CreateCsrfTokenResponse
{
    public CsrfTokenContent CreateCsrfToken {get;set;}
}
