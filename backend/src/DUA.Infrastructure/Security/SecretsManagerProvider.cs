namespace DUA.Infrastructure.Security;

public sealed class SecretsManagerProvider
{
    public Task<string> GetSecretAsync(string secretName, CancellationToken cancellationToken)
        => Task.FromResult(string.Empty);
}
