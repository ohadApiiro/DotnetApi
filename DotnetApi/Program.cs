using Microsoft.AspNetCore.Authorization;

namespace DotnetApi;

public class Program
{
    public static void Main(string[] args)
    {
        using IHost host = Host.CreateDefaultBuilder(args)
            .ConfigureServices(services =>
            {
                services.AddSingleton<IAuthorizationPolicyProvider, JwtPolicyProvider>();
                services.AddSingleton<IAuthorizationPolicyProvider, JwtPolicyProvider2>();
            }).Build();
    }
}