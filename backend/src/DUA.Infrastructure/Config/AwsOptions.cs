namespace DUA.Infrastructure.Config;

public sealed class AwsOptions
{
    public const string SectionName = "AWS";

    public string Region { get; init; } = "us-east-1";
    public string S3BucketName { get; init; } = "dua-streamliner-placeholder";
    public string QueueUrl { get; init; } = string.Empty;
}
