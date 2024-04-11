namespace RivianSDK;

public interface IRivianClient
{
    public Task Authenticate();
    Task<CsrfTokenContent> CreateCSRFTokenAsync(CancellationToken cancellationToken = default);
    Task<LoginResponseContent> RequestAccessTokenAsync(string email, string password, CsrfTokenContent csrfToken, CancellationToken cancellationToken = default);
    Task<LoginResponseContent> RequestAccessTokenMFAAsync(string email, string password, CsrfTokenContent csrfToken, CancellationToken cancellationToken = default);
}
