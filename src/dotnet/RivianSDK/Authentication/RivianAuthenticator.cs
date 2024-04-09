using System.Security;
using GraphQL;
using GraphQL.Client.Abstractions;
using GraphQL.Client.Abstractions.Websocket;
using GraphQL.Client.Http;

namespace RivianSDK;

public class RivianAuthenticator : IRivianAuthenticator
{
    private Uri csrfUri;
    private GraphQLHttpClient client;

    public RivianAuthenticator(Uri csrfUri, IGraphQLWebsocketJsonSerializer serializer)
    {
        this.csrfUri = csrfUri;
        this.client = new GraphQLHttpClient(csrfUri.ToString(), serializer);

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

        var response = await client.SendQueryAsync<LoginResponse>(request, cancellationToken);
        return response.Data.Login;
    }

    public async Task<CsrfTokenContent> CreateCSRFTokenAsync(CancellationToken cancellationToken = default)
    {
        string query = "mutation CreateCSRFToken { createCsrfToken { __typename csrfToken appSessionToken } }";
        string operationName = "CreateCSRFToken";

        var request = new GraphQLRequest(query, null, operationName);
        var response = await client.SendQueryAsync<CreateCsrfTokenResponse>(request, cancellationToken);
        return response.Data.CreateCsrfToken;
    }
}
