namespace OwnWebsite.Profiles.Models;

public sealed class SocialLink
{
    public required string Platform { get; init; }
    public required string Url { get; init; }
    public string? IconClass { get; init; }
}
