namespace DUA.Infrastructure.Security;

public sealed class SecretsManagerClientPlaceholder
{
    public Task<string> GetSecretAsync(string secretName, CancellationToken cancellationToken)
    {
        return Task.FromResult(string.Empty);
    }
}
