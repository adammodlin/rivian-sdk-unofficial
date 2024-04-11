using System.ComponentModel;
using System.Runtime.InteropServices.Marshalling;
using System.Security;
using GraphQL;
using GraphQL.Client.Abstractions.Websocket;
using GraphQL.Client.Http;
using GraphQL.Client.Serializer.Newtonsoft;
using GraphQL.NewtonsoftJson;

namespace RivianSDK;

public class RivianClient : IDisposable
{
    private string _email;
    private string _password;
    private Uri _csrfUri;
    private GraphQLHttpClient _client;

    public RivianClient(string email, string password, Uri csrfUri, IGraphQLWebsocketJsonSerializer serializer)
    {
        this._email = email;
        this._password = password;
        this._csrfUri = csrfUri;
        this._client = new GraphQLHttpClient(csrfUri.ToString(), serializer);
    }

    public async Task<LoginResponseContent> RequestAccessTokenMFAAsync(string email, string password, CsrfTokenContent csrfToken, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public async Task<LoginResponseContent> RequestAccessTokenAsync(string email, string password, CsrfTokenContent csrfToken, CancellationToken cancellationToken = default)
    {
        var query = "mutation Login($email: String!, $password: String!) {\n  login(email: $email, password: $password) {\n    __typename\n    ... on MobileLoginResponse {\n      __typename\n      accessToken\n      refreshToken\n      userSessionToken\n    }\n    ... on MobileMFALoginResponse {\n      __typename\n      otpToken\n    }\n  }\n}";
        var operationName = "Login";
        var variables = new { email, password};
        var headers = new Dictionary<string, string>
            {
                { "A-Sess", $"{csrfToken.AppSessionToken}" },
                { "Csrf-Token", $"{csrfToken.CsrfToken}" },
                { "Apollographql-Client-Name", "com.rivian.ios.consumer-apollo-ios" },
                { "User-Agent", "RivianApp/707 CFNetwork/1237 Darwin/20.4.0"},
                { "Dc-Cid", $"m-ios-{{{Guid.NewGuid()}}}"},
                { "Accept", "application/json"}
            };
       
        var request = new GraphQLHttpRequestWithHeadersSupport {Headers = headers, Query = query, Variables = variables, OperationName = operationName };

        var response = await _client.SendQueryAsync<LoginResponse>(request, cancellationToken);
        return response.Data.Login;
    }

    public async Task<CsrfTokenContent> CreateCSRFTokenAsync(CancellationToken cancellationToken = default)
    {
        string query = "mutation CreateCSRFToken { createCsrfToken { __typename csrfToken appSessionToken } }";
        string operationName = "CreateCSRFToken";

        var request = new GraphQLRequest(query, null, operationName);
        var response = await _client.SendQueryAsync<CreateCsrfTokenResponse>(request, cancellationToken);
        return response.Data.CreateCsrfToken;
    }

    public async Task<bool> Authenticate()
    {
        var csrfToken = await CreateCSRFTokenAsync();
        var loginResponse = await RequestAccessTokenAsync(_email, _password, csrfToken);

        return true;
    }

    public void Dispose()
    {
        _client.Dispose();
    }
}
