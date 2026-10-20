namespace OwnWebsite.Profiles.Models;

public sealed class PortfolioProject
{
    public required string Title { get; init; }
    public string? Description { get; init; }
    public string? ImageUrl { get; init; }
    public string? ProjectUrl { get; init; }
    public string? Category { get; init; }
}
