namespace OwnWebsite.Profiles.Models;

public sealed class ServiceItem
{
    public required string Title { get; init; }
    public string? Description { get; init; }
    public string? IconClass { get; init; }
}
