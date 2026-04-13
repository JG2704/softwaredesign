namespace DUA.Domain.Entities;

public sealed class DuaTemplate
{
    public Guid Id { get; init; }
    public string Name { get; init; } = string.Empty;
    public string Version { get; init; } = "v1";
    public bool IsActive { get; set; }
}
