using FastEndpoints;

namespace NDI.Api.Api.Endpoints.Users;

public class TestRequest
{
    public string Name { get; set; }
    public string Age { get; set; }
}

public class TestEndpoint : Endpoint<TestRequest,TestResponse>
{
    public TestEndpoint()
    {
    }
    
    public override void Configure()
    {
        Post("/test");
        AllowAnonymous();
    }

    public override async Task HandleAsync(TestRequest req, CancellationToken ct)
    {
        var response = new TestResponse
        {
            NameAge = $"{req.Name} {req.Age}"
        };

        await SendAsync(response, cancellation: ct);
    }

    
}

public class TestResponse
{
    public string NameAge { get; set; }
}

