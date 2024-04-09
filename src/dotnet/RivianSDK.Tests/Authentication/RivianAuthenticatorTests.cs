using System.Security;
using GraphQL.SystemTextJson;
using GraphQL.NewtonsoftJson;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GraphQL.Client.Serializer.SystemTextJson;
using Microsoft.Extensions.Configuration;
using GraphQL.Client.Http;
using Microsoft.Extensions.Configuration.EnvironmentVariables;

namespace RivianSDK.Tests;

[TestClass]
public class RivianAuthenticatorTests
{
    private IConfiguration _configuration;
    private Uri _authenticationUri;
    private string _email;
    private string _password;

    public RivianAuthenticatorTests()
    {
        var builder = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json")
            .AddUserSecrets<RivianAuthenticatorTests>()
            .AddEnvironmentVariables(); //Needed to load in Github actions secrets for integration test
        _configuration = builder.Build();

        _authenticationUri = new Uri(_configuration["Uris:Authentication"]);
        _email = _configuration["EMAIL"];
        _password = _configuration["PASSWORD"];

    }

    [TestMethod]
    public async Task RivianAuthenticator_CreateCsrfToken_Success(){
        RivianAuthenticator target = new RivianAuthenticator(_authenticationUri, new SystemTextJsonSerializer());
     
        var actual = await target.CreateCSRFTokenAsync();
        Assert.IsNotNull(actual.CsrfToken);
        Assert.IsNotNull(actual.AppSessionToken);
    }

    [TestMethod]
    public async Task RivianAuthenticator_Login_Success(){
        RivianAuthenticator target = new RivianAuthenticator(_authenticationUri, new SystemTextJsonSerializer());
        var csrfToken = await target.CreateCSRFTokenAsync();
        
        var actual = await target.RequestAccessTokenAsync(_email, _password, csrfToken);
        Assert.IsNotNull(actual.AccessToken);
        Assert.IsNotNull(actual.RefreshToken);
        Assert.IsNotNull(actual.UserSessionToken);
        Assert.IsNotNull(actual.__TypeName);
    }
}
