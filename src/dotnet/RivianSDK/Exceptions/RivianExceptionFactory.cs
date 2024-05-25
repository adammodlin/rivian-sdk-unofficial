using GraphQL;
using GraphQL.Client.Http;
using System.Collections.Generic;
using System.Linq;

namespace RivianSDK;

public class RivianExceptionFactory
{
    public static Exception CreateExceptionFromResponse<T>(GraphQLHttpResponse<T> response){
        Exception e;

        if (response.Errors.Length == 1){
            e = CreateExceptionFromGraphQLError(response.Errors.Single());
        } else {
            e = new AggregateException(response.Errors.Select(CreateExceptionFromGraphQLError));
        }
        return e;
    }

    public static RivianApiException CreateExceptionFromGraphQLError(GraphQLError error){
        switch (error.Extensions["code"]){
            case "UNAUTHENTICATED":
                return new RivianUnauthenticatedException();
            default:
                return new RivianApiException(error.Message, error.Extensions["code"].ToString());
        }
    }
}
