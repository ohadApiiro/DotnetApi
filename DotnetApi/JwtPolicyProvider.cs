using Microsoft.AspNetCore.Authorization;

namespace DotnetApi;

public class JwtPolicyProvider : IAuthorizationPolicyProvider
{
    public Task<AuthorizationPolicy?> GetPolicyAsync(string policyName)
    {
        throw new NotImplementedException();
    }

    public Task<AuthorizationPolicy> GetDefaultPolicyAsync()
    {
        throw new NotImplementedException();
    }

    public Task<AuthorizationPolicy?> GetFallbackPolicyAsync()
    {
        throw new NotImplementedException();
    }
}