namespace RivianSDK;

public interface IRivianClient
{
    Task<CurrentUserResponseContent> GetCurrentUser(string csrfToken, string userSessionToken, CancellationToken cancellationToken);
    Task<CsrfTokenContent> CreateCSRFTokenAsync(CancellationToken cancellationToken = default);
    Task<LoginResponseContent> RequestAccessTokenAsync(string email, string password, CsrfTokenContent csrfToken, CancellationToken cancellationToken = default);
    Task<LoginResponseContent> RequestAccessTokenMFAAsync(string email, string password, CsrfTokenContent csrfToken, CancellationToken cancellationToken = default);
}
