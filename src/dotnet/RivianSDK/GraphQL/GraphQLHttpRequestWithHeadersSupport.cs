using System.Net.Http.Headers;
using System.Net.Mime;
using GraphQL.Client.Abstractions;
using GraphQL.Client.Http;

namespace RivianSDK;

public class GraphQLHttpRequestWithHeadersSupport : GraphQLHttpRequest
{
    public Dictionary<string,string> Headers {get;set;}

    public override HttpRequestMessage ToHttpRequestMessage(GraphQLHttpClientOptions options, IGraphQLJsonSerializer serializer)
  {
    var r = base.ToHttpRequestMessage(options, serializer);
    foreach (var header in Headers){
      r.Headers.Add(header.Key, header.Value);
    }

    return r;
  }
}