using System.Runtime.InteropServices.Marshalling;
using System.Security;
using GraphQL.Client.Http;
using GraphQL.Client.Serializer.Newtonsoft;
using GraphQL.NewtonsoftJson;

namespace RivianSDK;

public class RivianClient : IDisposable
{
    private string email;
    private SecureString password;
    private GraphQLHttpClient graphqlClient;

    public RivianClient(string email, SecureString password)
    {
        this.email = email;
        this.password = password;
        this.graphqlClient = new GraphQLHttpClient("notImplementedEndpoint", new NewtonsoftJsonSerializer());
    }

    public void Dispose()
    {
        graphqlClient.Dispose();
    }
}
